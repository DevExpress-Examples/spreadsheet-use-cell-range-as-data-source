using DevExpress.Spreadsheet;
using DevExpress.Utils;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace RangeDataSource {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        object rangeDS;

        public Form1() {
            InitializeComponent();
            spreadsheetControl1.LoadDocument("temperature.xlsx");
            ribbonControl1.SelectedPage = dataRibbonPage1;
        }
        private void barBtnSheetToGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
            if (spreadsheetControl1.ActiveWorksheet.Selection.Count() > 1)
                UseRangeAsDataSource();
            else
                UseTableAsDataSource();

            xtraTabControl1.SelectedTabPage = tbGauge;
        }

        private void UseRangeAsDataSource() {
            #region #RangeAsDataSource
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            CellRange dataRange = sheet.Selection;
            if (dataRange.Equals(sheet.Tables[0].Range))
                options.UseFirstRowAsHeader = true;
            else {
                options.UseFirstRowAsHeader = false;
                options.DataSourceColumnTypeDetector = new MyColumnDetector();
            }
            options.SkipHiddenColumns = true;
            rangeDS = dataRange.GetDataSource(options);
            sheet.DataBindings.Error += DataBindings_Error;
            #endregion #RangeAsDataSource
            BindControlsToDataSource();
        }

        private void UseTableAsDataSource() {
            #region #TableAsDataSource
            RangeDataSourceOptions options = new RangeDataSourceOptions();
            Worksheet sheet = spreadsheetControl1.ActiveWorksheet;
            Table sheetDataTable = sheet.Tables[0];
            if (sheetDataTable.ShowHeaders)
                options.UseFirstRowAsHeader = true;
            else {
                options.UseFirstRowAsHeader = false;
            }
            options.EditingOptions = DataSourceEditingOptions.ReadOnly;
            options.SkipHiddenColumns = false;
            rangeDS = sheetDataTable.GetDataSource(options);
            sheet.DataBindings.Error += DataBindings_Error;
            #endregion #TableAsDataSource
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
            gridControl1.DataSource = rangeDS;
            dataNavigator1.DataSource = rangeDS;
            linearScaleComponent1.DataBindings.Clear();
            if (DataSourceHelper.IsFieldExists(rangeDS, "Temperature", typeof(double)))
                linearScaleComponent1.DataBindings.Add(new System.Windows.Forms.Binding("Value", rangeDS, "Temperature"));
        }

        #region TabControl Switching
        private void xtraTabControl1_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e) {
            if (e.Page == tbSheet) {
                dataRibbonPage1.Visible = true;
                sheetPageCategory.Visible = true;
                ribbonControl1.Minimized = false;
                ribbonControl1.SelectedPage = dataRibbonPage1;
            }
            if (e.Page == tbGauge) {
                sheetPageCategory.Visible = false;
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
