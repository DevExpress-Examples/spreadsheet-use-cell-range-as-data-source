using DevExpress.Spreadsheet;
using DevExpress.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RangeDataSourceForSnap {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        object rangeDS;

        public Form1() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument("temperature.xlsx");
            snapControl1.LoadDocument("report.snx");
            ribbonControl1.SelectedPage = dataRibbonPage1;
            ribbonControl1.Minimized = true;
        }
        private void barBtnSheetToSnap_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            #region #RangeAsDataSource
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            Range dataRange = sheet.Selection;
            if (dataRange.Equals(sheet.Tables[0].Range))
                options.UseFirstRowAsHeader = true;
            else {
                options.UseFirstRowAsHeader = false;
                options.DataSourceColumnTypeDetector = new MyColumnDetector();
            }
            // Uncomment the following line to use the range data source in read-only mode.
            //options.EditingOptions = DataSourceEditingOptions.ReadOnly;
            options.SkipHiddenColumns = true;
            rangeDS = dataRange.GetDataSource(options);
            sheet.DataBindings.Error += DataBindings_Error;
            #endregion #RangeAsDataSource
            BindControlsToDataSource();
        }
        #region #DataBindings_Error
        private void DataBindings_Error(object sender, DataBindingErrorEventArgs e) {
            string msg = String.Format("The error {0} occurs in attempt to {1} in row with index= {2}",
                e.ErrorType.ToString(), e.BindingDirection.ToString(), e.RowIndex);
            MessageBox.Show(msg, "Binding Error");
        }
        #endregion #DataBindings_Error
        private void BindControlsToDataSource() {
            snapControl1.DataSource = rangeDS;
            gridControl1.DataSource = rangeDS;
            dataNavigator1.DataSource = rangeDS;
            linearScaleComponent1.DataBindings.Clear();
            if (DataSourceHelper.IsFieldExists(rangeDS, "Temperature", typeof(double)))
                linearScaleComponent1.DataBindings.Add(new System.Windows.Forms.Binding("Value", rangeDS, "Temperature"));
        }

        #region TabControl Switching
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if (e.Page == tbSheet) {
                snapPageCategory.Visible = false;
                dataToolsRibbonPageCategory1.Visible = false;
                sheetPageCategory.Visible = true;
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                ribbonControl1.Minimized = true;

            }
            if (e.Page == tbGauge) {
                snapPageCategory.Visible = false;
                dataToolsRibbonPageCategory1.Visible = false;
                sheetPageCategory.Visible = false;
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden;
                ribbonControl1.Minimized = true;
            }
            if (e.Page == tbSnap) {
                snapPageCategory.Visible = true;
                dataToolsRibbonPageCategory1.Visible = true;
                sheetPageCategory.Visible = false;
                snapControl1.Document.Fields.Update();
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible;
                ribbonControl1.Minimized = true;
            }
        }
        #endregion TabControl Switching
        #region Gauge Interactive
        private void gaugeControl1_MouseMove(object sender, System.Windows.Forms.MouseEventArgs e) {
            GaugeHelper.CheckCursor(gaugeControl1 as DevExpress.XtraGauges.Base.IGaugeContainer, e);
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                GaugeHelper.CalculateMouseValue(gaugeControl1 as DevExpress.XtraGauges.Base.IGaugeContainer, linearScaleComponent1, e);
        }
        #endregion Gauge Interactive

        private void spreadsheetControl1_SelectionChanged(object sender, EventArgs e) {
            ribbonControl1.Minimized = false;
            ribbonControl1.SelectedPage = dataRibbonPage1;
        }
    }
}