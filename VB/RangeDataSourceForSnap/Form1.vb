Imports DevExpress.Spreadsheet
Imports DevExpress.Utils
Imports System
Imports System.ComponentModel
Imports System.Linq
Imports System.Windows.Forms

Namespace RangeDataSourceForSnap
    Partial Public Class Form1
        Inherits DevExpress.XtraBars.Ribbon.RibbonForm

        Private rangeDS As Object

        Public Sub New()
            InitializeComponent()
            spreadsheetControl1.LoadDocument("temperature.xlsx")
            snapControl1.LoadDocument("report.snx")
            ribbonControl1.SelectedPage = dataRibbonPage1
        End Sub
        Private Sub barBtnSheetToSnap_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barBtnSheetToSnap.ItemClick
            If spreadsheetControl1.ActiveWorksheet.Selection.Count() > 1 Then
                UseRangeAsDataSource()
            Else
                UseTableAsDataSource()
            End If

            xtraTabControl1.SelectedTabPage = tbSnap
        End Sub

        Private Sub UseRangeAsDataSource()
'            #Region "#RangeAsDataSource"
            Dim options As New RangeDataSourceOptions()
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            Dim dataRange As Range = sheet.Selection
            If dataRange.Equals(sheet.Tables(0).Range) Then
                options.UseFirstRowAsHeader = True
            Else
                options.UseFirstRowAsHeader = False
                options.DataSourceColumnTypeDetector = New MyColumnDetector()
            End If
            options.SkipHiddenColumns = True
            rangeDS = dataRange.GetDataSource(options)
            AddHandler sheet.DataBindings.Error, AddressOf DataBindings_Error
'            #End Region ' #RangeAsDataSource
            BindControlsToDataSource()
        End Sub

        Private Sub UseTableAsDataSource()
'            #Region "#TableAsDataSource"
            Dim options As New RangeDataSourceOptions()
            Dim sheet As Worksheet = spreadsheetControl1.ActiveWorksheet
            Dim sheetDataTable As Table = sheet.Tables(0)
            If sheetDataTable.ShowHeaders Then
                options.UseFirstRowAsHeader = True
            Else
                options.UseFirstRowAsHeader = False
            End If
            options.EditingOptions = DataSourceEditingOptions.ReadOnly
            options.SkipHiddenColumns = False
            rangeDS = sheetDataTable.GetDataSource(options)
            AddHandler sheet.DataBindings.Error, AddressOf DataBindings_Error
'            #End Region ' #TableAsDataSource
            BindControlsToDataSource()
        End Sub

        #Region "#DataBindings_Error"
        Private Sub DataBindings_Error(ByVal sender As Object, ByVal e As DataBindingErrorEventArgs)
            Dim msg As String = String.Format("The error {0} occurs in attempt to {1} in row with index= {2}", e.ErrorType.ToString(), e.BindingDirection.ToString(), e.RowIndex)
            MessageBox.Show(msg, "Binding Error")
        End Sub
        #End Region ' #DataBindings_Error
        Private Sub BindControlsToDataSource()
            snapControl1.DataSource = rangeDS
            gridControl1.DataSource = rangeDS
            dataNavigator1.DataSource = rangeDS
            linearScaleComponent1.DataBindings.Clear()
            If DataSourceHelper.IsFieldExists(rangeDS, "Temperature", GetType(Double)) Then
                linearScaleComponent1.DataBindings.Add(New System.Windows.Forms.Binding("Value", rangeDS, "Temperature"))
            End If
        End Sub

        #Region "TabControl Switching"
        Private Sub xtraTabControl1_SelectedPageChanged(ByVal sender As Object, ByVal e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles xtraTabControl1.SelectedPageChanged
            If e.Page Is tbSheet Then
                dataRibbonPage1.Visible = True
                snapPageCategory.Visible = False
                dataToolsRibbonPageCategory1.Visible = False
                sheetPageCategory.Visible = True
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                ribbonControl1.Minimized = False
                ribbonControl1.SelectedPage = dataRibbonPage1
            End If
            If e.Page Is tbGauge Then
                snapPageCategory.Visible = False
                dataToolsRibbonPageCategory1.Visible = False
                sheetPageCategory.Visible = False
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
                ribbonControl1.Minimized = True
            End If
            If e.Page Is tbSnap Then
                snapPageCategory.Visible = True
                dataToolsRibbonPageCategory1.Visible = True
                sheetPageCategory.Visible = False
                snapControl1.Document.Fields.Update()
                reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Visible
                ribbonControl1.Minimized = True
            End If
        End Sub
        #End Region ' TabControl Switching
        #Region "Gauge Interactive"
        Private Sub gaugeControl1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles gaugeControl1.MouseMove
            GaugeHelper.CheckCursor(TryCast(gaugeControl1, DevExpress.XtraGauges.Base.IGaugeContainer), e)
            If e.Button = System.Windows.Forms.MouseButtons.Left Then
                GaugeHelper.CalculateMouseValue(TryCast(gaugeControl1, DevExpress.XtraGauges.Base.IGaugeContainer), linearScaleComponent1, e)
            End If
        End Sub
        #End Region ' Gauge Interactive

        Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            ribbonControl1.Minimized = False
            ribbonControl1.SelectedPage = dataRibbonPage1
        End Sub
    End Class
End Namespace
