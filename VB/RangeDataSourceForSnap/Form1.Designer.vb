Namespace RangeDataSourceForSnap
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Dim galleryItemGroup1 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim spreadsheetCommandGalleryItemGroup1 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem1 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem2 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem3 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem4 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem5 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem6 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup2 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem7 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem8 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem9 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem10 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem11 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem12 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim galleryItemGroup2 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim galleryItemGroup3 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim chartControlCommandGalleryItemGroup2DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DColumn()
            Dim createBarChartItem1 As New DevExpress.XtraCharts.UI.CreateBarChartItem()
            Dim createFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBarChartItem()
            Dim createSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBarChartItem()
            Dim createSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBarChartItem()
            Dim createStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup3DColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DColumn()
            Dim createBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateBar3DChartItem()
            Dim createFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedBar3DChartItem()
            Dim createManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateManhattanBarChartItem()
            Dim createSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideFullStackedBar3DChartItem()
            Dim createSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideStackedBar3DChartItem()
            Dim createStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupCylinderColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupCylinderColumn()
            Dim createCylinderBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderBar3DChartItem()
            Dim createCylinderFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderFullStackedBar3DChartItem()
            Dim createCylinderManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderManhattanBarChartItem()
            Dim createCylinderSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideFullStackedBar3DChartItem()
            Dim createCylinderSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderSideBySideStackedBar3DChartItem()
            Dim createCylinderStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateCylinderStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupConeColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupConeColumn()
            Dim createConeBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeBar3DChartItem()
            Dim createConeFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeFullStackedBar3DChartItem()
            Dim createConeManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreateConeManhattanBarChartItem()
            Dim createConeSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideFullStackedBar3DChartItem()
            Dim createConeSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeSideBySideStackedBar3DChartItem()
            Dim createConeStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreateConeStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroupPyramidColumn1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPyramidColumn()
            Dim createPyramidBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidBar3DChartItem()
            Dim createPyramidFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidFullStackedBar3DChartItem()
            Dim createPyramidManhattanBarChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidManhattanBarChartItem()
            Dim createPyramidSideBySideFullStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideFullStackedBar3DChartItem()
            Dim createPyramidSideBySideStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidSideBySideStackedBar3DChartItem()
            Dim createPyramidStackedBar3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePyramidStackedBar3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DLine()
            Dim createLineChartItem1 As New DevExpress.XtraCharts.UI.CreateLineChartItem()
            Dim createFullStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLineChartItem()
            Dim createScatterLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterLineChartItem()
            Dim createSplineChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineChartItem()
            Dim createStackedLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLineChartItem()
            Dim createStepLineChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLineChartItem()
            Dim chartControlCommandGalleryItemGroup3DLine1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DLine()
            Dim createLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateLine3DChartItem()
            Dim createFullStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedLine3DChartItem()
            Dim createSpline3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSpline3DChartItem()
            Dim createStackedLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedLine3DChartItem()
            Dim createStepLine3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepLine3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DPie()
            Dim createPieChartItem1 As New DevExpress.XtraCharts.UI.CreatePieChartItem()
            Dim createDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnutChartItem()
            Dim createNestedDoughnutChartItem1 As New DevExpress.XtraCharts.UI.CreateNestedDoughnutChartItem()
            Dim chartControlCommandGalleryItemGroup3DPie1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DPie()
            Dim createPie3DChartItem1 As New DevExpress.XtraCharts.UI.CreatePie3DChartItem()
            Dim createDoughnut3DChartItem1 As New DevExpress.XtraCharts.UI.CreateDoughnut3DChartItem()
            Dim chartControlCommandGalleryItemGroup2DBar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DBar()
            Dim createRotatedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedBarChartItem()
            Dim createRotatedFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedFullStackedBarChartItem()
            Dim createRotatedSideBySideFullStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideFullStackedBarChartItem()
            Dim createRotatedSideBySideStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedSideBySideStackedBarChartItem()
            Dim createRotatedStackedBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRotatedStackedBarChartItem()
            Dim chartControlCommandGalleryItemGroup2DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup2DArea()
            Dim createAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateAreaChartItem()
            Dim createFullStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedAreaChartItem()
            Dim createFullStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineAreaChartItem()
            Dim createFullStackedStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedStepAreaChartItem()
            Dim createSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineAreaChartItem()
            Dim createStackedAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedAreaChartItem()
            Dim createStackedStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedStepAreaChartItem()
            Dim createStackedSplineAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineAreaChartItem()
            Dim createStepAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateStepAreaChartItem()
            Dim chartControlCommandGalleryItemGroup3DArea1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroup3DArea()
            Dim createArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateArea3DChartItem()
            Dim createFullStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedArea3DChartItem()
            Dim createFullStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFullStackedSplineArea3DChartItem()
            Dim createSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateSplineArea3DChartItem()
            Dim createStackedArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedArea3DChartItem()
            Dim createStackedSplineArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStackedSplineArea3DChartItem()
            Dim createStepArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateStepArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupPoint1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPoint()
            Dim createPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePointChartItem()
            Dim createBubbleChartItem1 As New DevExpress.XtraCharts.UI.CreateBubbleChartItem()
            Dim chartControlCommandGalleryItemGroupFunnel1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFunnel()
            Dim createFunnelChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnelChartItem()
            Dim createFunnel3DChartItem1 As New DevExpress.XtraCharts.UI.CreateFunnel3DChartItem()
            Dim chartControlCommandGalleryItemGroupFinancial1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupFinancial()
            Dim createStockChartItem1 As New DevExpress.XtraCharts.UI.CreateStockChartItem()
            Dim createCandleStickChartItem1 As New DevExpress.XtraCharts.UI.CreateCandleStickChartItem()
            Dim chartControlCommandGalleryItemGroupRadar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRadar()
            Dim createRadarPointChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarPointChartItem()
            Dim createRadarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarLineChartItem()
            Dim createRadarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarAreaChartItem()
            Dim createRadarRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRadarRangeAreaChartItem()
            Dim createScatterRadarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterRadarLineChartItem()
            Dim chartControlCommandGalleryItemGroupPolar1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupPolar()
            Dim createPolarPointChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarPointChartItem()
            Dim createPolarLineChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarLineChartItem()
            Dim createPolarAreaChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarAreaChartItem()
            Dim createPolarRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreatePolarRangeAreaChartItem()
            Dim createScatterPolarLineChartItem1 As New DevExpress.XtraCharts.UI.CreateScatterPolarLineChartItem()
            Dim chartControlCommandGalleryItemGroupRange1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupRange()
            Dim createRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeBarChartItem()
            Dim createSideBySideRangeBarChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideRangeBarChartItem()
            Dim createRangeAreaChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeAreaChartItem()
            Dim createRangeArea3DChartItem1 As New DevExpress.XtraCharts.UI.CreateRangeArea3DChartItem()
            Dim chartControlCommandGalleryItemGroupGantt1 As New DevExpress.XtraCharts.UI.ChartControlCommandGalleryItemGroupGantt()
            Dim createGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateGanttChartItem()
            Dim createSideBySideGanttChartItem1 As New DevExpress.XtraCharts.UI.CreateSideBySideGanttChartItem()
            Dim skinPaddingEdges1 As New DevExpress.Skins.SkinPaddingEdges()
            Dim skinPaddingEdges2 As New DevExpress.Skins.SkinPaddingEdges()
            Dim editorButtonImageOptions1 As New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim editorButtonImageOptions2 As New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim editorButtonImageOptions3 As New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim editorButtonImageOptions4 As New DevExpress.XtraEditors.Controls.EditorButtonImageOptions()
            Dim galleryItemGroup4 As New DevExpress.XtraBars.Ribbon.GalleryItemGroup()
            Dim spreadsheetCommandGalleryItem13 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem14 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem15 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem16 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem17 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem18 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem19 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem20 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem21 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem22 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem23 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup3 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem24 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem25 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem26 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem27 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem28 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem29 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem30 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem31 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem32 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem33 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem34 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem35 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup4 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem36 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem37 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem38 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem39 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem40 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem41 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem42 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup5 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem43 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem44 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem45 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem46 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem47 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup6 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem48 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem49 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem50 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItemGroup7 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItemGroup()
            Dim spreadsheetCommandGalleryItem51 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem52 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem53 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem54 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim spreadsheetCommandGalleryItem55 As New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandGalleryItem()
            Dim reduceOperation1 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim reduceOperation2 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim reduceOperation3 As New DevExpress.XtraBars.Ribbon.ReduceOperation()
            Dim linearScaleRange1 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange2 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Dim linearScaleRange3 As New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
            Me.stylesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup()
            Me.galleryChangeStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem()
            Me.themesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup()
            Me.themesGalleryBarItem1 = New DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem()
            Me.stylesRibbonPageGroup2 = New DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup()
            Me.spreadsheetCommandBarSubItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarSubItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem59 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem60 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem61 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem62 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem63 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem64 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem65 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem66 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem67 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem68 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem69 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem70 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem71 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown9 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.ribbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
            Me.spreadsheetCommandBarButtonItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.undoItem1 = New DevExpress.XtraRichEdit.UI.UndoItem()
            Me.redoItem1 = New DevExpress.XtraRichEdit.UI.RedoItem()
            Me.fileNewItem1 = New DevExpress.XtraRichEdit.UI.FileNewItem()
            Me.fileOpenItem1 = New DevExpress.XtraRichEdit.UI.FileOpenItem()
            Me.fileSaveItem1 = New DevExpress.XtraRichEdit.UI.FileSaveItem()
            Me.fileSaveAsItem1 = New DevExpress.XtraRichEdit.UI.FileSaveAsItem()
            Me.commandBarItem1 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.quickPrintItem1 = New DevExpress.XtraRichEdit.UI.QuickPrintItem()
            Me.printItem1 = New DevExpress.XtraRichEdit.UI.PrintItem()
            Me.printPreviewItem1 = New DevExpress.XtraRichEdit.UI.PrintPreviewItem()
            Me.showDocumentPropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem()
            Me.commandBarItem2 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.spreadsheetCommandBarButtonItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem20 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem21 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem22 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem23 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem24 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem25 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.pasteItem1 = New DevExpress.XtraRichEdit.UI.PasteItem()
            Me.cutItem1 = New DevExpress.XtraRichEdit.UI.CutItem()
            Me.copyItem1 = New DevExpress.XtraRichEdit.UI.CopyItem()
            Me.pasteSpecialItem1 = New DevExpress.XtraRichEdit.UI.PasteSpecialItem()
            Me.barButtonGroup1 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontSizeItem()
            Me.repositoryItemRichEditFontSizeEdit1 = New DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit()
            Me.snapControl1 = New DevExpress.Snap.SnapControl()
            Me.fontSizeIncreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem()
            Me.fontSizeDecreaseItem1 = New DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem()
            Me.barButtonGroup2 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleFontBoldItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontBoldItem()
            Me.toggleFontItalicItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontItalicItem()
            Me.toggleFontUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem()
            Me.toggleFontDoubleUnderlineItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem()
            Me.toggleFontStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem()
            Me.toggleFontDoubleStrikeoutItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem()
            Me.toggleFontSuperscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem()
            Me.toggleFontSubscriptItem1 = New DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem()
            Me.barButtonGroup3 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontColorItem()
            Me.changeFontHighlightColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem()
            Me.changeTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ChangeTextCaseItem()
            Me.makeTextUpperCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem()
            Me.makeTextLowerCaseItem1 = New DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem()
            Me.capitalizeEachWordCaseItem1 = New DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem()
            Me.toggleTextCaseItem1 = New DevExpress.XtraRichEdit.UI.ToggleTextCaseItem()
            Me.clearFormattingItem1 = New DevExpress.XtraRichEdit.UI.ClearFormattingItem()
            Me.barButtonGroup4 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleBulletedListItem1 = New DevExpress.XtraRichEdit.UI.ToggleBulletedListItem()
            Me.toggleNumberingListItem1 = New DevExpress.XtraRichEdit.UI.ToggleNumberingListItem()
            Me.toggleMultiLevelListItem1 = New DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem()
            Me.barButtonGroup5 = New DevExpress.XtraBars.BarButtonGroup()
            Me.decreaseIndentItem1 = New DevExpress.XtraRichEdit.UI.DecreaseIndentItem()
            Me.increaseIndentItem1 = New DevExpress.XtraRichEdit.UI.IncreaseIndentItem()
            Me.toggleShowWhitespaceItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem()
            Me.barButtonGroup6 = New DevExpress.XtraBars.BarButtonGroup()
            Me.toggleParagraphAlignmentLeftItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem()
            Me.toggleParagraphAlignmentCenterItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem()
            Me.toggleParagraphAlignmentRightItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem()
            Me.toggleParagraphAlignmentJustifyItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem()
            Me.barButtonGroup7 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeParagraphLineSpacingItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem()
            Me.setSingleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem()
            Me.setSesquialteralParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem()
            Me.setDoubleParagraphSpacingItem1 = New DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem()
            Me.showLineSpacingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem()
            Me.addSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem()
            Me.removeSpacingBeforeParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem()
            Me.addSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem()
            Me.removeSpacingAfterParagraphItem1 = New DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem()
            Me.changeParagraphBackColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem()
            Me.findItem1 = New DevExpress.XtraRichEdit.UI.FindItem()
            Me.replaceItem1 = New DevExpress.XtraRichEdit.UI.ReplaceItem()
            Me.insertPageBreakItem21 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem2()
            Me.insertTableItem1 = New DevExpress.XtraRichEdit.UI.InsertTableItem()
            Me.insertPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertPictureItem()
            Me.insertFloatingPictureItem1 = New DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem()
            Me.commandBarItem3 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem4 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem5 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem6 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem7 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.insertBookmarkItem1 = New DevExpress.XtraRichEdit.UI.InsertBookmarkItem()
            Me.insertHyperlinkItem1 = New DevExpress.XtraRichEdit.UI.InsertHyperlinkItem()
            Me.editPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.EditPageHeaderItem()
            Me.editPageFooterItem1 = New DevExpress.XtraRichEdit.UI.EditPageFooterItem()
            Me.insertPageNumberItem1 = New DevExpress.XtraRichEdit.UI.InsertPageNumberItem()
            Me.insertPageCountItem1 = New DevExpress.XtraRichEdit.UI.InsertPageCountItem()
            Me.insertTextBoxItem1 = New DevExpress.XtraRichEdit.UI.InsertTextBoxItem()
            Me.insertSymbolItem1 = New DevExpress.XtraRichEdit.UI.InsertSymbolItem()
            Me.changeSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem()
            Me.setNormalSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem()
            Me.setNarrowSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem()
            Me.setModerateSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem()
            Me.setWideSectionPageMarginsItem1 = New DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem()
            Me.showPageMarginsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem()
            Me.changeSectionPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem()
            Me.setPortraitPageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem()
            Me.setLandscapePageOrientationItem1 = New DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem()
            Me.changeSectionPaperKindItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem()
            Me.changeSectionColumnsItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem()
            Me.setSectionOneColumnItem1 = New DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem()
            Me.setSectionTwoColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem()
            Me.setSectionThreeColumnsItem1 = New DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem()
            Me.showColumnsSetupFormItem1 = New DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem()
            Me.insertBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertBreakItem()
            Me.insertPageBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertPageBreakItem()
            Me.insertColumnBreakItem1 = New DevExpress.XtraRichEdit.UI.InsertColumnBreakItem()
            Me.insertSectionBreakNextPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem()
            Me.insertSectionBreakEvenPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem()
            Me.insertSectionBreakOddPageItem1 = New DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem()
            Me.changeSectionLineNumberingItem1 = New DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem()
            Me.setSectionLineNumberingNoneItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem()
            Me.setSectionLineNumberingContinuousItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem()
            Me.setSectionLineNumberingRestartNewPageItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem()
            Me.setSectionLineNumberingRestartNewSectionItem1 = New DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem()
            Me.toggleParagraphSuppressLineNumbersItem1 = New DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem()
            Me.showLineNumberingFormItem1 = New DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem()
            Me.changePageColorItem1 = New DevExpress.XtraRichEdit.UI.ChangePageColorItem()
            Me.switchToSimpleViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem()
            Me.switchToDraftViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem()
            Me.switchToPrintLayoutViewItem1 = New DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem()
            Me.toggleShowHorizontalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem()
            Me.toggleShowVerticalRulerItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem()
            Me.zoomOutItem1 = New DevExpress.XtraRichEdit.UI.ZoomOutItem()
            Me.zoomInItem1 = New DevExpress.XtraRichEdit.UI.ZoomInItem()
            Me.snapBarToolbarsListItem1 = New DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem()
            Me.commandBarCheckItem1 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.showAllFieldCodesItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem()
            Me.showAllFieldResultsItem1 = New DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem()
            Me.toggleFieldHighlightingItem1 = New DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem()
            Me.goToPageHeaderItem1 = New DevExpress.XtraRichEdit.UI.GoToPageHeaderItem()
            Me.goToPageFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPageFooterItem()
            Me.goToNextHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem()
            Me.goToPreviousHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem()
            Me.toggleLinkToPreviousItem1 = New DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem()
            Me.toggleDifferentFirstPageItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem()
            Me.toggleDifferentOddAndEvenPagesItem1 = New DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem()
            Me.closePageHeaderFooterItem1 = New DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem()
            Me.toggleFirstRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstRowItem()
            Me.toggleLastRowItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastRowItem()
            Me.toggleBandedRowsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem()
            Me.toggleFirstColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem()
            Me.toggleLastColumnItem1 = New DevExpress.XtraRichEdit.UI.ToggleLastColumnItem()
            Me.toggleBandedColumnsItem1 = New DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem()
            Me.galleryChangeTableStyleItem1 = New DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem()
            Me.galleryChangeTableCellStyleItem1 = New DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem()
            Me.changeTableBorderLineStyleItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem()
            Me.repositoryItemBorderLineStyle1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle()
            Me.changeTableBorderLineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem()
            Me.repositoryItemBorderLineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight()
            Me.changeTableBorderColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem()
            Me.changeTableBordersItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableBordersItem()
            Me.toggleTableCellsBottomBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem()
            Me.toggleTableCellsTopBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem()
            Me.toggleTableCellsLeftBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem()
            Me.toggleTableCellsRightBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem()
            Me.resetTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem()
            Me.toggleTableCellsAllBordersItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem()
            Me.toggleTableCellsOutsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem()
            Me.toggleTableCellsInsideBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem()
            Me.toggleTableCellsInsideHorizontalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem()
            Me.toggleTableCellsInsideVerticalBorderItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem()
            Me.toggleShowTableGridLinesItem1 = New DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem()
            Me.changeTableCellsShadingItem1 = New DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem()
            Me.selectTableElementsItem1 = New DevExpress.XtraRichEdit.UI.SelectTableElementsItem()
            Me.selectTableCellItem1 = New DevExpress.XtraRichEdit.UI.SelectTableCellItem()
            Me.selectTableColumnItem1 = New DevExpress.XtraRichEdit.UI.SelectTableColumnItem()
            Me.selectTableRowItem1 = New DevExpress.XtraRichEdit.UI.SelectTableRowItem()
            Me.selectTableItem1 = New DevExpress.XtraRichEdit.UI.SelectTableItem()
            Me.showTablePropertiesFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem()
            Me.deleteTableElementsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableElementsItem()
            Me.showDeleteTableCellsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem()
            Me.deleteTableColumnsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem()
            Me.deleteTableRowsItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableRowsItem()
            Me.deleteTableItem1 = New DevExpress.XtraRichEdit.UI.DeleteTableItem()
            Me.insertTableRowAboveItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem()
            Me.insertTableRowBelowItem1 = New DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem()
            Me.insertTableColumnToLeftItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem()
            Me.insertTableColumnToRightItem1 = New DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem()
            Me.mergeTableCellsItem1 = New DevExpress.XtraRichEdit.UI.MergeTableCellsItem()
            Me.showSplitTableCellsForm1 = New DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm()
            Me.splitTableItem1 = New DevExpress.XtraRichEdit.UI.SplitTableItem()
            Me.toggleTableAutoFitItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem()
            Me.toggleTableAutoFitContentsItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem()
            Me.toggleTableAutoFitWindowItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem()
            Me.toggleTableFixedColumnWidthItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem()
            Me.toggleTableCellsTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem()
            Me.toggleTableCellsMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem()
            Me.toggleTableCellsBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem()
            Me.toggleTableCellsTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem()
            Me.toggleTableCellsMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem()
            Me.toggleTableCellsBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem()
            Me.toggleTableCellsTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem()
            Me.toggleTableCellsMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem()
            Me.toggleTableCellsBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem()
            Me.showTableOptionsFormItem1 = New DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem()
            Me.checkSpellingItem1 = New DevExpress.XtraRichEdit.UI.CheckSpellingItem()
            Me.insertTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem()
            Me.updateTableOfContentsItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem()
            Me.addParagraphsToTableOfContentItem1 = New DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem()
            Me.setParagraphHeadingLevelItem1 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem2 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem3 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem4 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem5 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem6 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem7 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem8 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem9 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.setParagraphHeadingLevelItem10 = New DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem()
            Me.insertCaptionPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem()
            Me.insertFiguresCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems()
            Me.insertTablesCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems()
            Me.insertEquationsCaptionItems1 = New DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems()
            Me.insertTableOfFiguresPlaceholderItem1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem()
            Me.insertTableOfFiguresItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems()
            Me.insertTableOfTablesItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems()
            Me.insertTableOfEquationsItems1 = New DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems()
            Me.updateTableOfFiguresItem1 = New DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem()
            Me.changeFloatingObjectFillColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem()
            Me.changeFloatingObjectOutlineColorItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem()
            Me.changeFloatingObjectOutlineWeightItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem()
            Me.repositoryItemFloatingObjectOutlineWeight1 = New DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight()
            Me.changeFloatingObjectTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem()
            Me.setFloatingObjectSquareTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem()
            Me.setFloatingObjectTightTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem()
            Me.setFloatingObjectThroughTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem()
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem()
            Me.setFloatingObjectBehindTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem()
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem()
            Me.changeFloatingObjectAlignmentItem1 = New DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem()
            Me.setFloatingObjectTopLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem()
            Me.setFloatingObjectTopCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem()
            Me.setFloatingObjectTopRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem()
            Me.setFloatingObjectMiddleLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem()
            Me.setFloatingObjectMiddleCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem()
            Me.setFloatingObjectMiddleRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem()
            Me.setFloatingObjectBottomLeftAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem()
            Me.setFloatingObjectBottomCenterAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem()
            Me.setFloatingObjectBottomRightAlignmentItem1 = New DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem()
            Me.floatingObjectBringForwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem()
            Me.floatingObjectBringForwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem()
            Me.floatingObjectBringToFrontItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem()
            Me.floatingObjectBringInFrontOfTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem()
            Me.floatingObjectSendBackwardSubItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem()
            Me.floatingObjectSendBackwardItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem()
            Me.floatingObjectSendToBackItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem()
            Me.floatingObjectSendBehindTextItem1 = New DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem()
            Me.commandBarCheckItem2 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem3 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem4 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem1 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem5 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem6 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem7 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem8 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem9 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.filterPopupButtonItem1 = New DevExpress.Snap.Extensions.UI.FilterPopupButtonItem()
            Me.propertiesBarButtonItem1 = New DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem()
            Me.commandBarSubItem2 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem10 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem11 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem3 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem12 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem13 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarItem8 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem9 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarSubItem4 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem14 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem15 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem16 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem17 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem18 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem19 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem20 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem5 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem21 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem22 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem6 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem23 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem24 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarSubItem7 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarCheckItem25 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem26 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem27 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem28 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem29 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem30 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem31 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarItem10 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem11 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem12 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.barButtonGroup8 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeEditorRowLimitItem1 = New DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem()
            Me.repositoryItemEditorRowLimitEdit1 = New DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit()
            Me.createBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateBarBaseItem()
            Me.commandBarGalleryDropDown1 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createLineBaseItem1 = New DevExpress.XtraCharts.UI.CreateLineBaseItem()
            Me.commandBarGalleryDropDown2 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createPieBaseItem1 = New DevExpress.XtraCharts.UI.CreatePieBaseItem()
            Me.commandBarGalleryDropDown3 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createRotatedBarBaseItem1 = New DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem()
            Me.commandBarGalleryDropDown4 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createAreaBaseItem1 = New DevExpress.XtraCharts.UI.CreateAreaBaseItem()
            Me.commandBarGalleryDropDown5 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.createOtherSeriesTypesBaseItem1 = New DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem()
            Me.commandBarGalleryDropDown6 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.changePaletteGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem()
            Me.commandBarGalleryDropDown7 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.changeAppearanceGalleryBaseItem1 = New DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem()
            Me.runDesignerChartItem1 = New DevExpress.XtraCharts.UI.RunDesignerChartItem()
            Me.mailMergeDataSourceItem1 = New DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem()
            Me.commandBarCheckItem32 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.commandBarCheckItem33 = New DevExpress.Snap.Extensions.UI.CommandBarCheckItem()
            Me.mailMergeCurrentRecordItem1 = New DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem()
            Me.repositoryItemMailMergeCurrentRecordEdit1 = New DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit()
            Me.commandBarSubItem8 = New DevExpress.Snap.Extensions.UI.CommandBarSubItem()
            Me.commandBarItem13 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem14 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.commandBarItem15 = New DevExpress.Snap.Extensions.UI.CommandBarItem()
            Me.barBtnSheetToSnap = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonGroup9 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem26 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem27 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem28 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem29 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup10 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeFontNameItem2 = New DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem()
            Me.repositoryItemFontEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemFontEdit()
            Me.changeFontSizeItem2 = New DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem()
            Me.repositoryItemSpreadsheetFontSizeEdit1 = New DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit()
            Me.spreadsheetControl1 = New DevExpress.XtraSpreadsheet.SpreadsheetControl()
            Me.spreadsheetCommandBarButtonItem30 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem31 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup11 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup12 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem4 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem32 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem33 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem34 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem35 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem36 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem37 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem38 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem39 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem40 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem41 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem42 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem43 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem44 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeBorderLineColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem()
            Me.changeBorderLineStyleItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem()
            Me.commandBarGalleryDropDown8 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.barButtonGroup13 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeCellFillColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem()
            Me.changeFontColorItem2 = New DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem()
            Me.barButtonGroup14 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem7 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem8 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup15 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarCheckItem9 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarCheckItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.barButtonGroup16 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem45 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem46 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarSubItem5 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarCheckItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem47 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem48 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem49 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup17 = New DevExpress.XtraBars.BarButtonGroup()
            Me.changeNumberFormatItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem()
            Me.repositoryItemPopupGalleryEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit()
            Me.barButtonGroup18 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarSubItem6 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem50 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem51 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem52 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem53 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem54 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem55 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem56 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.barButtonGroup19 = New DevExpress.XtraBars.BarButtonGroup()
            Me.spreadsheetCommandBarButtonItem57 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem58 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown10 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem()
            Me.commandBarGalleryDropDown11 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.spreadsheetCommandBarButtonItem72 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem73 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem74 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem10 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.galleryFormatAsTableItem1 = New DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem()
            Me.commandBarGalleryDropDown12 = New DevExpress.XtraBars.Commands.CommandBarGalleryDropDown(Me.components)
            Me.galleryChangeStyleItem2 = New DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem()
            Me.spreadsheetCommandBarSubItem11 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem75 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem76 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem77 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem12 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem78 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem79 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem80 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem13 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem81 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem82 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem83 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem84 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem85 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem86 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem87 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem88 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem89 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem90 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem91 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem92 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem93 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.changeSheetTabColorItem1 = New DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem()
            Me.spreadsheetCommandBarButtonItem94 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem14 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem95 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem96 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem97 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem98 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem99 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem100 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem16 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem101 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem102 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem103 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem104 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem17 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem105 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem106 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem107 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem108 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem109 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem110 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarSubItem18 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarSubItem19 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem()
            Me.spreadsheetCommandBarButtonItem115 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem116 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem117 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem118 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem119 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem120 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem121 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.sheetPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.fileRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.FileRibbonPage()
            Me.commonRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup()
            Me.homeRibbonPage2 = New DevExpress.XtraSpreadsheet.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup2 = New DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup2 = New DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup()
            Me.alignmentRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup()
            Me.numberRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup()
            Me.cellsRibbonPageGroup1 = New DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup()
            Me.editingRibbonPageGroup2 = New DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup()
            Me.dataRibbonPage1 = New DevExpress.XtraSpreadsheet.UI.DataRibbonPage()
            Me.ribbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
            Me.snapPageCategory = New DevExpress.XtraBars.Ribbon.RibbonPageCategory()
            Me.fileRibbonPage2 = New DevExpress.XtraRichEdit.UI.FileRibbonPage()
            Me.commonRibbonPageGroup2 = New DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup()
            Me.infoRibbonPageGroup2 = New DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup()
            Me.dataRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataRibbonPageGroup()
            Me.homeRibbonPage1 = New DevExpress.XtraRichEdit.UI.HomeRibbonPage()
            Me.clipboardRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup()
            Me.fontRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.FontRibbonPageGroup()
            Me.paragraphRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup()
            Me.editingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup()
            Me.insertRibbonPage1 = New DevExpress.XtraRichEdit.UI.InsertRibbonPage()
            Me.pagesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup()
            Me.tablesRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup()
            Me.illustrationsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup()
            Me.toolboxRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup()
            Me.linksRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup()
            Me.headerFooterRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup()
            Me.textRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TextRibbonPageGroup()
            Me.symbolsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup()
            Me.pageLayoutRibbonPage1 = New DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage()
            Me.pageSetupRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup()
            Me.pageBackgroundRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup()
            Me.viewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ViewRibbonPage()
            Me.documentViewsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup()
            Me.showRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup()
            Me.zoomRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup()
            Me.viewRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup()
            Me.viewFieldsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup()
            Me.reviewRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReviewRibbonPage()
            Me.documentProofingRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup()
            Me.referencesRibbonPage1 = New DevExpress.XtraRichEdit.UI.ReferencesRibbonPage()
            Me.tableOfContentsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup()
            Me.captionsRibbonPageGroup1 = New DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup()
            Me.dataToolsRibbonPageCategory1 = New DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory()
            Me.snMergeFieldToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage()
            Me.dataShapingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup()
            Me.snMergeFieldPropertiesRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup()
            Me.groupToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage()
            Me.groupingRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup()
            Me.listToolsRibbonPage1 = New DevExpress.Snap.Extensions.UI.ListToolsRibbonPage()
            Me.listHeaderAndFooterRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup()
            Me.listCommandsRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup()
            Me.listEditorRowLimitRibbonPageGroup1 = New DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup()
            Me.appearanceRibbonPage1 = New DevExpress.Snap.Extensions.UI.AppearanceRibbonPage()
            Me.xtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
            Me.tbSheet = New DevExpress.XtraTab.XtraTabPage()
            Me.tbSnap = New DevExpress.XtraTab.XtraTabPage()
            Me.tbGauge = New DevExpress.XtraTab.XtraTabPage()
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.textBox1 = New System.Windows.Forms.TextBox()
            Me.dataNavigator1 = New DevExpress.XtraEditors.DataNavigator()
            Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
            Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
            Me.linearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
            Me.linearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
            Me.linearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
            Me.spreadsheetBarController1 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController()
            Me.spreadsheetCommandBarButtonItem111 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem112 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarCheckItem15 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem()
            Me.spreadsheetCommandBarButtonItem113 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.spreadsheetCommandBarButtonItem114 = New DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem()
            Me.snapBarController1 = New DevExpress.Snap.Extensions.SnapBarController()
            Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.snapDockManager1 = New DevExpress.Snap.Extensions.SnapDockManager(Me.components)
            Me.fieldListDockPanel1 = New DevExpress.Snap.Extensions.UI.FieldListDockPanel()
            Me.fieldListDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.reportExplorerDockPanel1 = New DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel()
            Me.reportExplorerDockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
            Me.snapDocumentManager1 = New DevExpress.Snap.Extensions.SnapDocumentManager(Me.components)
            Me.noDocumentsView1 = New DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView(Me.components)
            DirectCast(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.xtraTabControl1.SuspendLayout()
            Me.tbSheet.SuspendLayout()
            Me.tbSnap.SuspendLayout()
            Me.tbGauge.SuspendLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.fieldListDockPanel1.SuspendLayout()
            Me.reportExplorerDockPanel1.SuspendLayout()
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' stylesRibbonPageGroup1
            ' 
            Me.stylesRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("stylesRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.stylesRibbonPageGroup1.ItemLinks.Add(Me.galleryChangeStyleItem1)
            Me.stylesRibbonPageGroup1.Name = "stylesRibbonPageGroup1"
            ' 
            ' galleryChangeStyleItem1
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem1.Gallery.ColumnCount = 10
            Me.galleryChangeStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup1})
            Me.galleryChangeStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem1.Id = 93
            Me.galleryChangeStyleItem1.Name = "galleryChangeStyleItem1"
            ' 
            ' themesRibbonPageGroup1
            ' 
            Me.themesRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("themesRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.themesRibbonPageGroup1.ItemLinks.Add(Me.themesGalleryBarItem1)
            Me.themesRibbonPageGroup1.Name = "themesRibbonPageGroup1"
            ' 
            ' themesGalleryBarItem1
            ' 
            ' 
            ' 
            ' 
            Me.themesGalleryBarItem1.Gallery.ColumnCount = 7
            Me.themesGalleryBarItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.themesGalleryBarItem1.Gallery.ItemCheckMode = DevExpress.XtraBars.Ribbon.Gallery.ItemCheckMode.SingleCheck
            Me.themesGalleryBarItem1.Gallery.RowCount = 1
            Me.themesGalleryBarItem1.Id = 269
            Me.themesGalleryBarItem1.Name = "themesGalleryBarItem1"
            ' 
            ' stylesRibbonPageGroup2
            ' 
            Me.stylesRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem7)
            Me.stylesRibbonPageGroup2.ItemLinks.Add(Me.galleryFormatAsTableItem1)
            Me.stylesRibbonPageGroup2.ItemLinks.Add(Me.galleryChangeStyleItem2)
            Me.stylesRibbonPageGroup2.Name = "stylesRibbonPageGroup2"
            ' 
            ' spreadsheetCommandBarSubItem7
            ' 
            Me.spreadsheetCommandBarSubItem7.CommandName = "ConditionalFormattingCommandGroup"
            Me.spreadsheetCommandBarSubItem7.Id = 400
            Me.spreadsheetCommandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem9), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonGalleryDropDownItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem72), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem10) _
            })
            Me.spreadsheetCommandBarSubItem7.Name = "spreadsheetCommandBarSubItem7"
            ' 
            ' spreadsheetCommandBarSubItem8
            ' 
            Me.spreadsheetCommandBarSubItem8.CommandName = "ConditionalFormattingHighlightCellsRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem8.Id = 408
            Me.spreadsheetCommandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem59), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem60), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem61), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem62), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem63), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem64), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem65) _
            })
            Me.spreadsheetCommandBarSubItem8.Name = "spreadsheetCommandBarSubItem8"
            ' 
            ' spreadsheetCommandBarButtonItem59
            ' 
            Me.spreadsheetCommandBarButtonItem59.CommandName = "ConditionalFormattingGreaterThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem59.Id = 401
            Me.spreadsheetCommandBarButtonItem59.Name = "spreadsheetCommandBarButtonItem59"
            Me.spreadsheetCommandBarButtonItem59.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem60
            ' 
            Me.spreadsheetCommandBarButtonItem60.CommandName = "ConditionalFormattingLessThanRuleCommand"
            Me.spreadsheetCommandBarButtonItem60.Id = 402
            Me.spreadsheetCommandBarButtonItem60.Name = "spreadsheetCommandBarButtonItem60"
            Me.spreadsheetCommandBarButtonItem60.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem61
            ' 
            Me.spreadsheetCommandBarButtonItem61.CommandName = "ConditionalFormattingBetweenRuleCommand"
            Me.spreadsheetCommandBarButtonItem61.Id = 403
            Me.spreadsheetCommandBarButtonItem61.Name = "spreadsheetCommandBarButtonItem61"
            Me.spreadsheetCommandBarButtonItem61.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem62
            ' 
            Me.spreadsheetCommandBarButtonItem62.CommandName = "ConditionalFormattingEqualToRuleCommand"
            Me.spreadsheetCommandBarButtonItem62.Id = 404
            Me.spreadsheetCommandBarButtonItem62.Name = "spreadsheetCommandBarButtonItem62"
            Me.spreadsheetCommandBarButtonItem62.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem63
            ' 
            Me.spreadsheetCommandBarButtonItem63.CommandName = "ConditionalFormattingTextContainsRuleCommand"
            Me.spreadsheetCommandBarButtonItem63.Id = 405
            Me.spreadsheetCommandBarButtonItem63.Name = "spreadsheetCommandBarButtonItem63"
            Me.spreadsheetCommandBarButtonItem63.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem64
            ' 
            Me.spreadsheetCommandBarButtonItem64.CommandName = "ConditionalFormattingDateOccurringRuleCommand"
            Me.spreadsheetCommandBarButtonItem64.Id = 406
            Me.spreadsheetCommandBarButtonItem64.Name = "spreadsheetCommandBarButtonItem64"
            Me.spreadsheetCommandBarButtonItem64.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem65
            ' 
            Me.spreadsheetCommandBarButtonItem65.CommandName = "ConditionalFormattingDuplicateValuesRuleCommand"
            Me.spreadsheetCommandBarButtonItem65.Id = 407
            Me.spreadsheetCommandBarButtonItem65.Name = "spreadsheetCommandBarButtonItem65"
            Me.spreadsheetCommandBarButtonItem65.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarSubItem9
            ' 
            Me.spreadsheetCommandBarSubItem9.CommandName = "ConditionalFormattingTopBottomRuleCommandGroup"
            Me.spreadsheetCommandBarSubItem9.Id = 415
            Me.spreadsheetCommandBarSubItem9.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem66), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem67), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem68), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem69), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem70), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem71) _
            })
            Me.spreadsheetCommandBarSubItem9.Name = "spreadsheetCommandBarSubItem9"
            ' 
            ' spreadsheetCommandBarButtonItem66
            ' 
            Me.spreadsheetCommandBarButtonItem66.CommandName = "ConditionalFormattingTop10RuleCommand"
            Me.spreadsheetCommandBarButtonItem66.Id = 409
            Me.spreadsheetCommandBarButtonItem66.Name = "spreadsheetCommandBarButtonItem66"
            Me.spreadsheetCommandBarButtonItem66.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem67
            ' 
            Me.spreadsheetCommandBarButtonItem67.CommandName = "ConditionalFormattingTop10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem67.Id = 410
            Me.spreadsheetCommandBarButtonItem67.Name = "spreadsheetCommandBarButtonItem67"
            Me.spreadsheetCommandBarButtonItem67.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem68
            ' 
            Me.spreadsheetCommandBarButtonItem68.CommandName = "ConditionalFormattingBottom10RuleCommand"
            Me.spreadsheetCommandBarButtonItem68.Id = 411
            Me.spreadsheetCommandBarButtonItem68.Name = "spreadsheetCommandBarButtonItem68"
            Me.spreadsheetCommandBarButtonItem68.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem69
            ' 
            Me.spreadsheetCommandBarButtonItem69.CommandName = "ConditionalFormattingBottom10PercentRuleCommand"
            Me.spreadsheetCommandBarButtonItem69.Id = 412
            Me.spreadsheetCommandBarButtonItem69.Name = "spreadsheetCommandBarButtonItem69"
            Me.spreadsheetCommandBarButtonItem69.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem70
            ' 
            Me.spreadsheetCommandBarButtonItem70.CommandName = "ConditionalFormattingAboveAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem70.Id = 413
            Me.spreadsheetCommandBarButtonItem70.Name = "spreadsheetCommandBarButtonItem70"
            Me.spreadsheetCommandBarButtonItem70.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem71
            ' 
            Me.spreadsheetCommandBarButtonItem71.CommandName = "ConditionalFormattingBelowAverageRuleCommand"
            Me.spreadsheetCommandBarButtonItem71.Id = 414
            Me.spreadsheetCommandBarButtonItem71.Name = "spreadsheetCommandBarButtonItem71"
            Me.spreadsheetCommandBarButtonItem71.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem1
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.CommandName = "ConditionalFormattingDataBarsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.DropDownControl = Me.commandBarGalleryDropDown9
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Id = 416
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.Name = "spreadsheetCommandBarButtonGalleryDropDownItem1"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown9
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown9.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup1.CommandName = "ConditionalFormattingDataBarsGradientFillCommandGroup"
            spreadsheetCommandGalleryItem1.CommandName = "ConditionalFormattingDataBarGradientBlue"
            spreadsheetCommandGalleryItem2.CommandName = "ConditionalFormattingDataBarGradientGreen"
            spreadsheetCommandGalleryItem3.CommandName = "ConditionalFormattingDataBarGradientRed"
            spreadsheetCommandGalleryItem4.CommandName = "ConditionalFormattingDataBarGradientOrange"
            spreadsheetCommandGalleryItem5.CommandName = "ConditionalFormattingDataBarGradientLightBlue"
            spreadsheetCommandGalleryItem6.CommandName = "ConditionalFormattingDataBarGradientPurple"
            spreadsheetCommandGalleryItemGroup1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem1, spreadsheetCommandGalleryItem2, spreadsheetCommandGalleryItem3, spreadsheetCommandGalleryItem4, spreadsheetCommandGalleryItem5, spreadsheetCommandGalleryItem6})
            spreadsheetCommandGalleryItemGroup2.CommandName = "ConditionalFormattingDataBarsSolidFillCommandGroup"
            spreadsheetCommandGalleryItem7.CommandName = "ConditionalFormattingDataBarSolidBlue"
            spreadsheetCommandGalleryItem8.CommandName = "ConditionalFormattingDataBarSolidGreen"
            spreadsheetCommandGalleryItem9.CommandName = "ConditionalFormattingDataBarSolidRed"
            spreadsheetCommandGalleryItem10.CommandName = "ConditionalFormattingDataBarSolidOrange"
            spreadsheetCommandGalleryItem11.CommandName = "ConditionalFormattingDataBarSolidLightBlue"
            spreadsheetCommandGalleryItem12.CommandName = "ConditionalFormattingDataBarSolidPurple"
            spreadsheetCommandGalleryItemGroup2.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem7, spreadsheetCommandGalleryItem8, spreadsheetCommandGalleryItem9, spreadsheetCommandGalleryItem10, spreadsheetCommandGalleryItem11, spreadsheetCommandGalleryItem12})
            Me.commandBarGalleryDropDown9.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup1, spreadsheetCommandGalleryItemGroup2})
            Me.commandBarGalleryDropDown9.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown9.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown9.Name = "commandBarGalleryDropDown9"
            Me.commandBarGalleryDropDown9.Ribbon = Me.ribbonControl1
            ' 
            ' ribbonControl1
            ' 
            Me.ribbonControl1.ExpandCollapseItem.Id = 0
            Me.ribbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.ribbonControl1.ExpandCollapseItem, Me.spreadsheetCommandBarButtonItem1, Me.spreadsheetCommandBarButtonItem2, Me.spreadsheetCommandBarButtonItem3, Me.spreadsheetCommandBarButtonItem4, Me.spreadsheetCommandBarButtonItem5, Me.spreadsheetCommandBarButtonItem6, Me.spreadsheetCommandBarButtonItem7, Me.spreadsheetCommandBarButtonItem8, Me.spreadsheetCommandBarButtonItem9, Me.spreadsheetCommandBarButtonItem10, Me.spreadsheetCommandBarButtonItem11, Me.undoItem1, Me.redoItem1, Me.fileNewItem1, Me.fileOpenItem1, Me.fileSaveItem1, Me.fileSaveAsItem1, Me.commandBarItem1, Me.quickPrintItem1, Me.printItem1, Me.printPreviewItem1, Me.showDocumentPropertiesFormItem1, Me.commandBarItem2, Me.spreadsheetCommandBarButtonItem12, Me.spreadsheetCommandBarButtonItem13, Me.spreadsheetCommandBarCheckItem1, Me.spreadsheetCommandBarButtonItem14, Me.spreadsheetCommandBarButtonItem15, Me.spreadsheetCommandBarSubItem1, Me.spreadsheetCommandBarButtonItem16, Me.spreadsheetCommandBarButtonItem17, Me.spreadsheetCommandBarButtonItem18, Me.spreadsheetCommandBarSubItem2, Me.spreadsheetCommandBarButtonItem19, Me.spreadsheetCommandBarButtonItem20, Me.spreadsheetCommandBarSubItem3, Me.spreadsheetCommandBarButtonItem21, Me.spreadsheetCommandBarButtonItem22, Me.spreadsheetCommandBarButtonItem23, Me.spreadsheetCommandBarButtonItem24, Me.spreadsheetCommandBarButtonItem25, Me.pasteItem1, Me.cutItem1, Me.copyItem1, Me.pasteSpecialItem1, Me.barButtonGroup1, Me.changeFontNameItem1, Me.changeFontSizeItem1, Me.fontSizeIncreaseItem1, Me.fontSizeDecreaseItem1, Me.barButtonGroup2, Me.toggleFontBoldItem1, Me.toggleFontItalicItem1, Me.toggleFontUnderlineItem1, Me.toggleFontDoubleUnderlineItem1, Me.toggleFontStrikeoutItem1, Me.toggleFontDoubleStrikeoutItem1, Me.toggleFontSuperscriptItem1, Me.toggleFontSubscriptItem1, Me.barButtonGroup3, Me.changeFontColorItem1, Me.changeFontHighlightColorItem1, Me.changeTextCaseItem1, Me.makeTextUpperCaseItem1, Me.makeTextLowerCaseItem1, Me.capitalizeEachWordCaseItem1, Me.toggleTextCaseItem1, Me.clearFormattingItem1, Me.barButtonGroup4, Me.toggleBulletedListItem1, Me.toggleNumberingListItem1, Me.toggleMultiLevelListItem1, Me.barButtonGroup5, Me.decreaseIndentItem1, Me.increaseIndentItem1, Me.barButtonGroup6, Me.toggleParagraphAlignmentLeftItem1, Me.toggleParagraphAlignmentCenterItem1, Me.toggleParagraphAlignmentRightItem1, Me.toggleParagraphAlignmentJustifyItem1, Me.toggleShowWhitespaceItem1, Me.barButtonGroup7, Me.changeParagraphLineSpacingItem1, Me.setSingleParagraphSpacingItem1, Me.setSesquialteralParagraphSpacingItem1, Me.setDoubleParagraphSpacingItem1, Me.showLineSpacingFormItem1, Me.addSpacingBeforeParagraphItem1, Me.removeSpacingBeforeParagraphItem1, Me.addSpacingAfterParagraphItem1, Me.removeSpacingAfterParagraphItem1, Me.changeParagraphBackColorItem1, Me.galleryChangeStyleItem1, Me.findItem1, Me.replaceItem1, Me.insertPageBreakItem21, Me.insertTableItem1, Me.insertPictureItem1, Me.insertFloatingPictureItem1, Me.commandBarItem3, Me.commandBarItem4, Me.commandBarItem5, Me.commandBarItem6, Me.commandBarItem7, Me.insertBookmarkItem1, Me.insertHyperlinkItem1, Me.editPageHeaderItem1, Me.editPageFooterItem1, Me.insertPageNumberItem1, Me.insertPageCountItem1, Me.insertTextBoxItem1, Me.insertSymbolItem1, Me.changeSectionPageMarginsItem1, Me.setNormalSectionPageMarginsItem1, Me.setNarrowSectionPageMarginsItem1, Me.setModerateSectionPageMarginsItem1, Me.setWideSectionPageMarginsItem1, Me.showPageMarginsSetupFormItem1, Me.changeSectionPageOrientationItem1, Me.setPortraitPageOrientationItem1, Me.setLandscapePageOrientationItem1, Me.changeSectionPaperKindItem1, Me.changeSectionColumnsItem1, Me.setSectionOneColumnItem1, Me.setSectionTwoColumnsItem1, Me.setSectionThreeColumnsItem1, Me.showColumnsSetupFormItem1, Me.insertBreakItem1, Me.insertPageBreakItem1, Me.insertColumnBreakItem1, Me.insertSectionBreakNextPageItem1, Me.insertSectionBreakEvenPageItem1, Me.insertSectionBreakOddPageItem1, Me.changeSectionLineNumberingItem1, Me.setSectionLineNumberingNoneItem1, Me.setSectionLineNumberingContinuousItem1, Me.setSectionLineNumberingRestartNewPageItem1, Me.setSectionLineNumberingRestartNewSectionItem1, Me.toggleParagraphSuppressLineNumbersItem1, Me.showLineNumberingFormItem1, Me.changePageColorItem1, Me.switchToSimpleViewItem1, Me.switchToDraftViewItem1, Me.switchToPrintLayoutViewItem1, Me.toggleShowHorizontalRulerItem1, Me.toggleShowVerticalRulerItem1, Me.zoomOutItem1, Me.zoomInItem1, Me.snapBarToolbarsListItem1, Me.commandBarCheckItem1, Me.showAllFieldCodesItem1, Me.showAllFieldResultsItem1, Me.toggleFieldHighlightingItem1, Me.goToPageHeaderItem1, Me.goToPageFooterItem1, Me.goToNextHeaderFooterItem1, Me.goToPreviousHeaderFooterItem1, Me.toggleLinkToPreviousItem1, Me.toggleDifferentFirstPageItem1, Me.toggleDifferentOddAndEvenPagesItem1, Me.closePageHeaderFooterItem1, Me.toggleFirstRowItem1, Me.toggleLastRowItem1, Me.toggleBandedRowsItem1, Me.toggleFirstColumnItem1, Me.toggleLastColumnItem1, Me.toggleBandedColumnsItem1, Me.galleryChangeTableStyleItem1, Me.galleryChangeTableCellStyleItem1, Me.changeTableBorderLineStyleItem1, Me.changeTableBorderLineWeightItem1, Me.changeTableBorderColorItem1, Me.changeTableBordersItem1, Me.toggleTableCellsBottomBorderItem1, Me.toggleTableCellsTopBorderItem1, Me.toggleTableCellsLeftBorderItem1, Me.toggleTableCellsRightBorderItem1, Me.resetTableCellsAllBordersItem1, Me.toggleTableCellsAllBordersItem1, Me.toggleTableCellsOutsideBorderItem1, Me.toggleTableCellsInsideBorderItem1, Me.toggleTableCellsInsideHorizontalBorderItem1, Me.toggleTableCellsInsideVerticalBorderItem1, Me.toggleShowTableGridLinesItem1, Me.changeTableCellsShadingItem1, Me.selectTableElementsItem1, Me.selectTableCellItem1, Me.selectTableColumnItem1, Me.selectTableRowItem1, Me.selectTableItem1, Me.showTablePropertiesFormItem1, Me.deleteTableElementsItem1, Me.showDeleteTableCellsFormItem1, Me.deleteTableColumnsItem1, Me.deleteTableRowsItem1, Me.deleteTableItem1, Me.insertTableRowAboveItem1, Me.insertTableRowBelowItem1, Me.insertTableColumnToLeftItem1, Me.insertTableColumnToRightItem1, Me.mergeTableCellsItem1, Me.showSplitTableCellsForm1, Me.splitTableItem1, Me.toggleTableAutoFitItem1, Me.toggleTableAutoFitContentsItem1, Me.toggleTableAutoFitWindowItem1, Me.toggleTableFixedColumnWidthItem1, Me.toggleTableCellsTopLeftAlignmentItem1, Me.toggleTableCellsMiddleLeftAlignmentItem1, Me.toggleTableCellsBottomLeftAlignmentItem1, Me.toggleTableCellsTopCenterAlignmentItem1, Me.toggleTableCellsMiddleCenterAlignmentItem1, Me.toggleTableCellsBottomCenterAlignmentItem1, Me.toggleTableCellsTopRightAlignmentItem1, Me.toggleTableCellsMiddleRightAlignmentItem1, Me.toggleTableCellsBottomRightAlignmentItem1, Me.showTableOptionsFormItem1, Me.checkSpellingItem1, Me.insertTableOfContentsItem1, Me.updateTableOfContentsItem1, Me.addParagraphsToTableOfContentItem1, Me.setParagraphHeadingLevelItem1, Me.setParagraphHeadingLevelItem2, Me.setParagraphHeadingLevelItem3, Me.setParagraphHeadingLevelItem4, Me.setParagraphHeadingLevelItem5, Me.setParagraphHeadingLevelItem6, Me.setParagraphHeadingLevelItem7, Me.setParagraphHeadingLevelItem8, Me.setParagraphHeadingLevelItem9, Me.setParagraphHeadingLevelItem10, Me.insertCaptionPlaceholderItem1, Me.insertFiguresCaptionItems1, Me.insertTablesCaptionItems1, Me.insertEquationsCaptionItems1, Me.insertTableOfFiguresPlaceholderItem1, Me.insertTableOfFiguresItems1, Me.insertTableOfTablesItems1, Me.insertTableOfEquationsItems1, Me.updateTableOfFiguresItem1, Me.changeFloatingObjectFillColorItem1, Me.changeFloatingObjectOutlineColorItem1, Me.changeFloatingObjectOutlineWeightItem1, Me.changeFloatingObjectTextWrapTypeItem1, Me.setFloatingObjectSquareTextWrapTypeItem1, Me.setFloatingObjectTightTextWrapTypeItem1, Me.setFloatingObjectThroughTextWrapTypeItem1, Me.setFloatingObjectTopAndBottomTextWrapTypeItem1, Me.setFloatingObjectBehindTextWrapTypeItem1, Me.setFloatingObjectInFrontOfTextWrapTypeItem1, Me.changeFloatingObjectAlignmentItem1, Me.setFloatingObjectTopLeftAlignmentItem1, Me.setFloatingObjectTopCenterAlignmentItem1, Me.setFloatingObjectTopRightAlignmentItem1, Me.setFloatingObjectMiddleLeftAlignmentItem1, Me.setFloatingObjectMiddleCenterAlignmentItem1, Me.setFloatingObjectMiddleRightAlignmentItem1, Me.setFloatingObjectBottomLeftAlignmentItem1, Me.setFloatingObjectBottomCenterAlignmentItem1, Me.setFloatingObjectBottomRightAlignmentItem1, Me.floatingObjectBringForwardSubItem1, Me.floatingObjectBringForwardItem1, Me.floatingObjectBringToFrontItem1, Me.floatingObjectBringInFrontOfTextItem1, Me.floatingObjectSendBackwardSubItem1, Me.floatingObjectSendBackwardItem1, Me.floatingObjectSendToBackItem1, Me.floatingObjectSendBehindTextItem1, Me.themesGalleryBarItem1, Me.commandBarCheckItem2, Me.commandBarCheckItem3, Me.commandBarCheckItem4, Me.commandBarSubItem1, Me.commandBarCheckItem5, Me.commandBarCheckItem6, Me.commandBarCheckItem7, Me.commandBarCheckItem8, Me.commandBarCheckItem9, Me.filterPopupButtonItem1, Me.propertiesBarButtonItem1, Me.commandBarSubItem2, Me.commandBarCheckItem10, Me.commandBarCheckItem11, Me.commandBarSubItem3, Me.commandBarCheckItem12, Me.commandBarCheckItem13, Me.commandBarItem8, Me.commandBarItem9, Me.commandBarSubItem4, Me.commandBarCheckItem14, Me.commandBarCheckItem15, Me.commandBarCheckItem16, Me.commandBarCheckItem17, Me.commandBarCheckItem18, Me.commandBarCheckItem19, Me.commandBarCheckItem20, Me.commandBarSubItem5, Me.commandBarCheckItem21, Me.commandBarCheckItem22, Me.commandBarSubItem6, Me.commandBarCheckItem23, Me.commandBarCheckItem24, Me.commandBarSubItem7, Me.commandBarCheckItem25, Me.commandBarCheckItem26, Me.commandBarCheckItem27, Me.commandBarCheckItem28, Me.commandBarCheckItem29, Me.commandBarCheckItem30, Me.commandBarCheckItem31, Me.commandBarItem10, Me.commandBarItem11, Me.commandBarItem12, Me.barButtonGroup8, Me.changeEditorRowLimitItem1, Me.createBarBaseItem1, Me.createLineBaseItem1, Me.createPieBaseItem1, Me.createRotatedBarBaseItem1, Me.createAreaBaseItem1, Me.createOtherSeriesTypesBaseItem1, Me.changePaletteGalleryBaseItem1, Me.changeAppearanceGalleryBaseItem1, Me.runDesignerChartItem1, Me.mailMergeDataSourceItem1, Me.commandBarCheckItem32, Me.commandBarCheckItem33, Me.mailMergeCurrentRecordItem1, Me.commandBarSubItem8, Me.commandBarItem13, Me.commandBarItem14, Me.commandBarItem15, Me.barBtnSheetToSnap, Me.barButtonGroup9, Me.spreadsheetCommandBarButtonItem26, Me.spreadsheetCommandBarButtonItem27, Me.spreadsheetCommandBarButtonItem28, Me.spreadsheetCommandBarButtonItem29, Me.barButtonGroup10, Me.changeFontNameItem2, Me.changeFontSizeItem2, Me.spreadsheetCommandBarButtonItem30, Me.spreadsheetCommandBarButtonItem31, Me.barButtonGroup11, Me.spreadsheetCommandBarCheckItem2, Me.spreadsheetCommandBarCheckItem3, Me.spreadsheetCommandBarCheckItem4, Me.spreadsheetCommandBarCheckItem5, Me.barButtonGroup12, Me.spreadsheetCommandBarSubItem4, Me.spreadsheetCommandBarButtonItem32, Me.spreadsheetCommandBarButtonItem33, Me.spreadsheetCommandBarButtonItem34, Me.spreadsheetCommandBarButtonItem35, Me.spreadsheetCommandBarButtonItem36, Me.spreadsheetCommandBarButtonItem37, Me.spreadsheetCommandBarButtonItem38, Me.spreadsheetCommandBarButtonItem39, Me.spreadsheetCommandBarButtonItem40, Me.spreadsheetCommandBarButtonItem41, Me.spreadsheetCommandBarButtonItem42, Me.spreadsheetCommandBarButtonItem43, Me.spreadsheetCommandBarButtonItem44, Me.changeBorderLineColorItem1, Me.changeBorderLineStyleItem1, Me.barButtonGroup13, Me.changeCellFillColorItem1, Me.changeFontColorItem2, Me.barButtonGroup14, Me.spreadsheetCommandBarCheckItem6, Me.spreadsheetCommandBarCheckItem7, Me.spreadsheetCommandBarCheckItem8, Me.barButtonGroup15, Me.spreadsheetCommandBarCheckItem9, Me.spreadsheetCommandBarCheckItem10, Me.spreadsheetCommandBarCheckItem11, Me.barButtonGroup16, Me.spreadsheetCommandBarButtonItem45, Me.spreadsheetCommandBarButtonItem46, Me.spreadsheetCommandBarCheckItem12, Me.spreadsheetCommandBarSubItem5, Me.spreadsheetCommandBarCheckItem13, Me.spreadsheetCommandBarButtonItem47, Me.spreadsheetCommandBarButtonItem48, Me.spreadsheetCommandBarButtonItem49, Me.barButtonGroup17, Me.changeNumberFormatItem1, Me.barButtonGroup18, Me.spreadsheetCommandBarSubItem6, Me.spreadsheetCommandBarButtonItem50, Me.spreadsheetCommandBarButtonItem51, Me.spreadsheetCommandBarButtonItem52, Me.spreadsheetCommandBarButtonItem53, Me.spreadsheetCommandBarButtonItem54, Me.spreadsheetCommandBarButtonItem55, Me.spreadsheetCommandBarButtonItem56, Me.barButtonGroup19, Me.spreadsheetCommandBarButtonItem57, Me.spreadsheetCommandBarButtonItem58, Me.spreadsheetCommandBarSubItem7, Me.spreadsheetCommandBarButtonItem59, Me.spreadsheetCommandBarButtonItem60, Me.spreadsheetCommandBarButtonItem61, Me.spreadsheetCommandBarButtonItem62, Me.spreadsheetCommandBarButtonItem63, Me.spreadsheetCommandBarButtonItem64, Me.spreadsheetCommandBarButtonItem65, Me.spreadsheetCommandBarSubItem8, Me.spreadsheetCommandBarButtonItem66, Me.spreadsheetCommandBarButtonItem67, Me.spreadsheetCommandBarButtonItem68, Me.spreadsheetCommandBarButtonItem69, Me.spreadsheetCommandBarButtonItem70, Me.spreadsheetCommandBarButtonItem71, Me.spreadsheetCommandBarSubItem9, Me.spreadsheetCommandBarButtonGalleryDropDownItem1, Me.spreadsheetCommandBarButtonGalleryDropDownItem2, Me.spreadsheetCommandBarButtonGalleryDropDownItem3, Me.spreadsheetCommandBarButtonItem72, Me.spreadsheetCommandBarButtonItem73, Me.spreadsheetCommandBarButtonItem74, Me.spreadsheetCommandBarSubItem10, Me.galleryFormatAsTableItem1, Me.galleryChangeStyleItem2, Me.spreadsheetCommandBarSubItem11, Me.spreadsheetCommandBarButtonItem75, Me.spreadsheetCommandBarButtonItem76, Me.spreadsheetCommandBarButtonItem77, Me.spreadsheetCommandBarSubItem12, Me.spreadsheetCommandBarButtonItem78, Me.spreadsheetCommandBarButtonItem79, Me.spreadsheetCommandBarButtonItem80, Me.spreadsheetCommandBarSubItem13, Me.spreadsheetCommandBarButtonItem81, Me.spreadsheetCommandBarButtonItem82, Me.spreadsheetCommandBarButtonItem83, Me.spreadsheetCommandBarButtonItem84, Me.spreadsheetCommandBarButtonItem85, Me.spreadsheetCommandBarButtonItem86, Me.spreadsheetCommandBarButtonItem87, Me.spreadsheetCommandBarButtonItem88, Me.spreadsheetCommandBarButtonItem89, Me.spreadsheetCommandBarButtonItem90, Me.spreadsheetCommandBarButtonItem91, Me.spreadsheetCommandBarSubItem14, Me.spreadsheetCommandBarButtonItem92, Me.spreadsheetCommandBarButtonItem93, Me.changeSheetTabColorItem1, Me.spreadsheetCommandBarButtonItem94, Me.spreadsheetCommandBarCheckItem14, Me.spreadsheetCommandBarButtonItem95, Me.spreadsheetCommandBarSubItem15, Me.spreadsheetCommandBarButtonItem96, Me.spreadsheetCommandBarButtonItem97, Me.spreadsheetCommandBarButtonItem98, Me.spreadsheetCommandBarButtonItem99, Me.spreadsheetCommandBarButtonItem100, Me.spreadsheetCommandBarSubItem16, Me.spreadsheetCommandBarButtonItem101, Me.spreadsheetCommandBarButtonItem102, Me.spreadsheetCommandBarButtonItem103, Me.spreadsheetCommandBarButtonItem104, Me.spreadsheetCommandBarSubItem17, Me.spreadsheetCommandBarButtonItem105, Me.spreadsheetCommandBarButtonItem106, Me.spreadsheetCommandBarButtonItem107, Me.spreadsheetCommandBarButtonItem108, Me.spreadsheetCommandBarButtonItem109, Me.spreadsheetCommandBarButtonItem110, Me.spreadsheetCommandBarSubItem18, Me.spreadsheetCommandBarSubItem19, Me.spreadsheetCommandBarButtonItem115, Me.spreadsheetCommandBarButtonItem116, Me.spreadsheetCommandBarButtonItem117, Me.spreadsheetCommandBarButtonItem118, Me.spreadsheetCommandBarButtonItem119, Me.spreadsheetCommandBarButtonItem120, Me.spreadsheetCommandBarButtonItem121})
            Me.ribbonControl1.Location = New System.Drawing.Point(0, 0)
            Me.ribbonControl1.MaxItemId = 480
            Me.ribbonControl1.Name = "ribbonControl1"
            Me.ribbonControl1.PageCategories.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageCategory() { Me.sheetPageCategory, Me.snapPageCategory, Me.dataToolsRibbonPageCategory1})
            Me.ribbonControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemFontEdit1, Me.repositoryItemRichEditFontSizeEdit1, Me.repositoryItemBorderLineStyle1, Me.repositoryItemBorderLineWeight1, Me.repositoryItemFloatingObjectOutlineWeight1, Me.repositoryItemEditorRowLimitEdit1, Me.repositoryItemMailMergeCurrentRecordEdit1, Me.repositoryItemFontEdit2, Me.repositoryItemSpreadsheetFontSizeEdit1, Me.repositoryItemPopupGalleryEdit1})
            Me.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013
            Me.ribbonControl1.Size = New System.Drawing.Size(1111, 146)
            ' 
            ' spreadsheetCommandBarButtonItem1
            ' 
            Me.spreadsheetCommandBarButtonItem1.CommandName = "FileNew"
            Me.spreadsheetCommandBarButtonItem1.Id = 1
            Me.spreadsheetCommandBarButtonItem1.Name = "spreadsheetCommandBarButtonItem1"
            ' 
            ' spreadsheetCommandBarButtonItem2
            ' 
            Me.spreadsheetCommandBarButtonItem2.CommandName = "FileOpen"
            Me.spreadsheetCommandBarButtonItem2.Id = 2
            Me.spreadsheetCommandBarButtonItem2.Name = "spreadsheetCommandBarButtonItem2"
            ' 
            ' spreadsheetCommandBarButtonItem3
            ' 
            Me.spreadsheetCommandBarButtonItem3.CommandName = "FileSave"
            Me.spreadsheetCommandBarButtonItem3.Id = 3
            Me.spreadsheetCommandBarButtonItem3.Name = "spreadsheetCommandBarButtonItem3"
            ' 
            ' spreadsheetCommandBarButtonItem4
            ' 
            Me.spreadsheetCommandBarButtonItem4.CommandName = "FileSaveAs"
            Me.spreadsheetCommandBarButtonItem4.Id = 4
            Me.spreadsheetCommandBarButtonItem4.Name = "spreadsheetCommandBarButtonItem4"
            ' 
            ' spreadsheetCommandBarButtonItem5
            ' 
            Me.spreadsheetCommandBarButtonItem5.CommandName = "FileQuickPrint"
            Me.spreadsheetCommandBarButtonItem5.Id = 5
            Me.spreadsheetCommandBarButtonItem5.Name = "spreadsheetCommandBarButtonItem5"
            ' 
            ' spreadsheetCommandBarButtonItem6
            ' 
            Me.spreadsheetCommandBarButtonItem6.CommandName = "FilePrint"
            Me.spreadsheetCommandBarButtonItem6.Id = 6
            Me.spreadsheetCommandBarButtonItem6.Name = "spreadsheetCommandBarButtonItem6"
            ' 
            ' spreadsheetCommandBarButtonItem7
            ' 
            Me.spreadsheetCommandBarButtonItem7.CommandName = "FilePrintPreview"
            Me.spreadsheetCommandBarButtonItem7.Id = 7
            Me.spreadsheetCommandBarButtonItem7.Name = "spreadsheetCommandBarButtonItem7"
            ' 
            ' spreadsheetCommandBarButtonItem8
            ' 
            Me.spreadsheetCommandBarButtonItem8.CommandName = "FileUndo"
            Me.spreadsheetCommandBarButtonItem8.Id = 8
            Me.spreadsheetCommandBarButtonItem8.Name = "spreadsheetCommandBarButtonItem8"
            ' 
            ' spreadsheetCommandBarButtonItem9
            ' 
            Me.spreadsheetCommandBarButtonItem9.CommandName = "FileRedo"
            Me.spreadsheetCommandBarButtonItem9.Id = 9
            Me.spreadsheetCommandBarButtonItem9.Name = "spreadsheetCommandBarButtonItem9"
            ' 
            ' spreadsheetCommandBarButtonItem10
            ' 
            Me.spreadsheetCommandBarButtonItem10.CommandName = "FileEncrypt"
            Me.spreadsheetCommandBarButtonItem10.Id = 10
            Me.spreadsheetCommandBarButtonItem10.Name = "spreadsheetCommandBarButtonItem10"
            ' 
            ' spreadsheetCommandBarButtonItem11
            ' 
            Me.spreadsheetCommandBarButtonItem11.CommandName = "FileShowDocumentProperties"
            Me.spreadsheetCommandBarButtonItem11.Id = 11
            Me.spreadsheetCommandBarButtonItem11.Name = "spreadsheetCommandBarButtonItem11"
            ' 
            ' undoItem1
            ' 
            Me.undoItem1.Id = 12
            Me.undoItem1.Name = "undoItem1"
            ' 
            ' redoItem1
            ' 
            Me.redoItem1.Id = 13
            Me.redoItem1.Name = "redoItem1"
            ' 
            ' fileNewItem1
            ' 
            Me.fileNewItem1.Id = 14
            Me.fileNewItem1.Name = "fileNewItem1"
            ' 
            ' fileOpenItem1
            ' 
            Me.fileOpenItem1.Id = 15
            Me.fileOpenItem1.Name = "fileOpenItem1"
            ' 
            ' fileSaveItem1
            ' 
            Me.fileSaveItem1.Id = 16
            Me.fileSaveItem1.Name = "fileSaveItem1"
            ' 
            ' fileSaveAsItem1
            ' 
            Me.fileSaveAsItem1.Id = 17
            Me.fileSaveAsItem1.Name = "fileSaveAsItem1"
            ' 
            ' commandBarItem1
            ' 
            Me.commandBarItem1.Id = 18
            Me.commandBarItem1.Name = "commandBarItem1"
            Me.commandBarItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ExportDocument
            ' 
            ' quickPrintItem1
            ' 
            Me.quickPrintItem1.Id = 19
            Me.quickPrintItem1.Name = "quickPrintItem1"
            ' 
            ' printItem1
            ' 
            Me.printItem1.Id = 20
            Me.printItem1.Name = "printItem1"
            ' 
            ' printPreviewItem1
            ' 
            Me.printPreviewItem1.Id = 21
            Me.printPreviewItem1.Name = "printPreviewItem1"
            ' 
            ' showDocumentPropertiesFormItem1
            ' 
            Me.showDocumentPropertiesFormItem1.Id = 22
            Me.showDocumentPropertiesFormItem1.Name = "showDocumentPropertiesFormItem1"
            ' 
            ' commandBarItem2
            ' 
            Me.commandBarItem2.Id = 23
            Me.commandBarItem2.Name = "commandBarItem2"
            Me.commandBarItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.NewDataSource
            ' 
            ' spreadsheetCommandBarButtonItem12
            ' 
            Me.spreadsheetCommandBarButtonItem12.CommandName = "DataSortAscending"
            Me.spreadsheetCommandBarButtonItem12.Id = 24
            Me.spreadsheetCommandBarButtonItem12.Name = "spreadsheetCommandBarButtonItem12"
            ' 
            ' spreadsheetCommandBarButtonItem13
            ' 
            Me.spreadsheetCommandBarButtonItem13.CommandName = "DataSortDescending"
            Me.spreadsheetCommandBarButtonItem13.Id = 25
            Me.spreadsheetCommandBarButtonItem13.Name = "spreadsheetCommandBarButtonItem13"
            ' 
            ' spreadsheetCommandBarCheckItem1
            ' 
            Me.spreadsheetCommandBarCheckItem1.CommandName = "DataFilterToggle"
            Me.spreadsheetCommandBarCheckItem1.Id = 26
            Me.spreadsheetCommandBarCheckItem1.Name = "spreadsheetCommandBarCheckItem1"
            ' 
            ' spreadsheetCommandBarButtonItem14
            ' 
            Me.spreadsheetCommandBarButtonItem14.CommandName = "DataFilterClear"
            Me.spreadsheetCommandBarButtonItem14.Id = 27
            Me.spreadsheetCommandBarButtonItem14.Name = "spreadsheetCommandBarButtonItem14"
            ' 
            ' spreadsheetCommandBarButtonItem15
            ' 
            Me.spreadsheetCommandBarButtonItem15.CommandName = "DataFilterReApply"
            Me.spreadsheetCommandBarButtonItem15.Id = 28
            Me.spreadsheetCommandBarButtonItem15.Name = "spreadsheetCommandBarButtonItem15"
            ' 
            ' spreadsheetCommandBarSubItem1
            ' 
            Me.spreadsheetCommandBarSubItem1.CommandName = "DataToolsDataValidationCommandGroup"
            Me.spreadsheetCommandBarSubItem1.Id = 29
            Me.spreadsheetCommandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem16), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem17), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem18) _
            })
            Me.spreadsheetCommandBarSubItem1.Name = "spreadsheetCommandBarSubItem1"
            ' 
            ' spreadsheetCommandBarButtonItem16
            ' 
            Me.spreadsheetCommandBarButtonItem16.CommandName = "DataToolsDataValidation"
            Me.spreadsheetCommandBarButtonItem16.Id = 30
            Me.spreadsheetCommandBarButtonItem16.Name = "spreadsheetCommandBarButtonItem16"
            ' 
            ' spreadsheetCommandBarButtonItem17
            ' 
            Me.spreadsheetCommandBarButtonItem17.CommandName = "DataToolsCircleInvalidData"
            Me.spreadsheetCommandBarButtonItem17.Id = 31
            Me.spreadsheetCommandBarButtonItem17.Name = "spreadsheetCommandBarButtonItem17"
            ' 
            ' spreadsheetCommandBarButtonItem18
            ' 
            Me.spreadsheetCommandBarButtonItem18.CommandName = "DataToolsClearValidationCircles"
            Me.spreadsheetCommandBarButtonItem18.Id = 32
            Me.spreadsheetCommandBarButtonItem18.Name = "spreadsheetCommandBarButtonItem18"
            ' 
            ' spreadsheetCommandBarSubItem2
            ' 
            Me.spreadsheetCommandBarSubItem2.CommandName = "OutlineGroupCommandGroup"
            Me.spreadsheetCommandBarSubItem2.Id = 33
            Me.spreadsheetCommandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem19), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem20) _
            })
            Me.spreadsheetCommandBarSubItem2.Name = "spreadsheetCommandBarSubItem2"
            Me.spreadsheetCommandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem19
            ' 
            Me.spreadsheetCommandBarButtonItem19.CommandName = "GroupOutline"
            Me.spreadsheetCommandBarButtonItem19.Id = 34
            Me.spreadsheetCommandBarButtonItem19.Name = "spreadsheetCommandBarButtonItem19"
            ' 
            ' spreadsheetCommandBarButtonItem20
            ' 
            Me.spreadsheetCommandBarButtonItem20.CommandName = "AutoOutline"
            Me.spreadsheetCommandBarButtonItem20.Id = 35
            Me.spreadsheetCommandBarButtonItem20.Name = "spreadsheetCommandBarButtonItem20"
            ' 
            ' spreadsheetCommandBarSubItem3
            ' 
            Me.spreadsheetCommandBarSubItem3.CommandName = "OutlineUngroupCommandGroup"
            Me.spreadsheetCommandBarSubItem3.Id = 36
            Me.spreadsheetCommandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem21), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem22) _
            })
            Me.spreadsheetCommandBarSubItem3.Name = "spreadsheetCommandBarSubItem3"
            Me.spreadsheetCommandBarSubItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem21
            ' 
            Me.spreadsheetCommandBarButtonItem21.CommandName = "UngroupOutline"
            Me.spreadsheetCommandBarButtonItem21.Id = 37
            Me.spreadsheetCommandBarButtonItem21.Name = "spreadsheetCommandBarButtonItem21"
            ' 
            ' spreadsheetCommandBarButtonItem22
            ' 
            Me.spreadsheetCommandBarButtonItem22.CommandName = "ClearOutline"
            Me.spreadsheetCommandBarButtonItem22.Id = 38
            Me.spreadsheetCommandBarButtonItem22.Name = "spreadsheetCommandBarButtonItem22"
            ' 
            ' spreadsheetCommandBarButtonItem23
            ' 
            Me.spreadsheetCommandBarButtonItem23.CommandName = "Subtotal"
            Me.spreadsheetCommandBarButtonItem23.Id = 39
            Me.spreadsheetCommandBarButtonItem23.Name = "spreadsheetCommandBarButtonItem23"
            Me.spreadsheetCommandBarButtonItem23.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem24
            ' 
            Me.spreadsheetCommandBarButtonItem24.CommandName = "ShowDetail"
            Me.spreadsheetCommandBarButtonItem24.Id = 40
            Me.spreadsheetCommandBarButtonItem24.Name = "spreadsheetCommandBarButtonItem24"
            Me.spreadsheetCommandBarButtonItem24.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem25
            ' 
            Me.spreadsheetCommandBarButtonItem25.CommandName = "HideDetail"
            Me.spreadsheetCommandBarButtonItem25.Id = 41
            Me.spreadsheetCommandBarButtonItem25.Name = "spreadsheetCommandBarButtonItem25"
            Me.spreadsheetCommandBarButtonItem25.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' pasteItem1
            ' 
            Me.pasteItem1.Id = 49
            Me.pasteItem1.Name = "pasteItem1"
            ' 
            ' cutItem1
            ' 
            Me.cutItem1.Id = 50
            Me.cutItem1.Name = "cutItem1"
            ' 
            ' copyItem1
            ' 
            Me.copyItem1.Id = 51
            Me.copyItem1.Name = "copyItem1"
            ' 
            ' pasteSpecialItem1
            ' 
            Me.pasteSpecialItem1.Id = 52
            Me.pasteSpecialItem1.Name = "pasteSpecialItem1"
            ' 
            ' barButtonGroup1
            ' 
            Me.barButtonGroup1.Id = 42
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontNameItem1, "FF")
            Me.barButtonGroup1.ItemLinks.Add(Me.changeFontSizeItem1)
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeIncreaseItem1, "FG")
            Me.barButtonGroup1.ItemLinks.Add(Me.fontSizeDecreaseItem1, "FK")
            Me.barButtonGroup1.Name = "barButtonGroup1"
            Me.barButtonGroup1.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeFontNameItem1
            ' 
            Me.changeFontNameItem1.Edit = Me.repositoryItemFontEdit1
            Me.changeFontNameItem1.Id = 53
            Me.changeFontNameItem1.Name = "changeFontNameItem1"
            ' 
            ' repositoryItemFontEdit1
            ' 
            Me.repositoryItemFontEdit1.AutoHeight = False
            Me.repositoryItemFontEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit1.Name = "repositoryItemFontEdit1"
            ' 
            ' changeFontSizeItem1
            ' 
            Me.changeFontSizeItem1.Edit = Me.repositoryItemRichEditFontSizeEdit1
            Me.changeFontSizeItem1.Id = 54
            Me.changeFontSizeItem1.Name = "changeFontSizeItem1"
            ' 
            ' repositoryItemRichEditFontSizeEdit1
            ' 
            Me.repositoryItemRichEditFontSizeEdit1.AutoHeight = False
            Me.repositoryItemRichEditFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemRichEditFontSizeEdit1.Control = Me.snapControl1
            Me.repositoryItemRichEditFontSizeEdit1.Name = "repositoryItemRichEditFontSizeEdit1"
            ' 
            ' snapControl1
            ' 
            Me.snapControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.snapControl1.Location = New System.Drawing.Point(0, 0)
            Me.snapControl1.MenuManager = Me.ribbonControl1
            Me.snapControl1.Name = "snapControl1"
            Me.snapControl1.Options.Export.Rtf.ExportTheme = True
            Me.snapControl1.Options.SnapMailMergeVisualOptions.DataSourceName = Nothing
            Me.snapControl1.Size = New System.Drawing.Size(1109, 528)
            Me.snapControl1.TabIndex = 0
            Me.snapControl1.Text = "snapControl1"
            ' 
            ' fontSizeIncreaseItem1
            ' 
            Me.fontSizeIncreaseItem1.Id = 55
            Me.fontSizeIncreaseItem1.Name = "fontSizeIncreaseItem1"
            ' 
            ' fontSizeDecreaseItem1
            ' 
            Me.fontSizeDecreaseItem1.Id = 56
            Me.fontSizeDecreaseItem1.Name = "fontSizeDecreaseItem1"
            ' 
            ' barButtonGroup2
            ' 
            Me.barButtonGroup2.Id = 43
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontBoldItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontItalicItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSuperscriptItem1)
            Me.barButtonGroup2.ItemLinks.Add(Me.toggleFontSubscriptItem1)
            Me.barButtonGroup2.Name = "barButtonGroup2"
            Me.barButtonGroup2.Tag = "{433DA7F0-03E2-4650-9DB5-66DD92D16E39}"
            ' 
            ' toggleFontBoldItem1
            ' 
            Me.toggleFontBoldItem1.Id = 57
            Me.toggleFontBoldItem1.Name = "toggleFontBoldItem1"
            ' 
            ' toggleFontItalicItem1
            ' 
            Me.toggleFontItalicItem1.Id = 58
            Me.toggleFontItalicItem1.Name = "toggleFontItalicItem1"
            ' 
            ' toggleFontUnderlineItem1
            ' 
            Me.toggleFontUnderlineItem1.Id = 59
            Me.toggleFontUnderlineItem1.Name = "toggleFontUnderlineItem1"
            ' 
            ' toggleFontDoubleUnderlineItem1
            ' 
            Me.toggleFontDoubleUnderlineItem1.Id = 60
            Me.toggleFontDoubleUnderlineItem1.Name = "toggleFontDoubleUnderlineItem1"
            ' 
            ' toggleFontStrikeoutItem1
            ' 
            Me.toggleFontStrikeoutItem1.Id = 61
            Me.toggleFontStrikeoutItem1.Name = "toggleFontStrikeoutItem1"
            ' 
            ' toggleFontDoubleStrikeoutItem1
            ' 
            Me.toggleFontDoubleStrikeoutItem1.Id = 62
            Me.toggleFontDoubleStrikeoutItem1.Name = "toggleFontDoubleStrikeoutItem1"
            ' 
            ' toggleFontSuperscriptItem1
            ' 
            Me.toggleFontSuperscriptItem1.Id = 63
            Me.toggleFontSuperscriptItem1.Name = "toggleFontSuperscriptItem1"
            ' 
            ' toggleFontSubscriptItem1
            ' 
            Me.toggleFontSubscriptItem1.Id = 64
            Me.toggleFontSubscriptItem1.Name = "toggleFontSubscriptItem1"
            ' 
            ' barButtonGroup3
            ' 
            Me.barButtonGroup3.Id = 44
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontColorItem1, "FC")
            Me.barButtonGroup3.ItemLinks.Add(Me.changeFontHighlightColorItem1, "I")
            Me.barButtonGroup3.Name = "barButtonGroup3"
            Me.barButtonGroup3.Tag = "{DF8C5334-EDE3-47c9-A42C-FE9A9247E180}"
            ' 
            ' changeFontColorItem1
            ' 
            Me.changeFontColorItem1.Id = 65
            Me.changeFontColorItem1.Name = "changeFontColorItem1"
            ' 
            ' changeFontHighlightColorItem1
            ' 
            Me.changeFontHighlightColorItem1.Id = 66
            Me.changeFontHighlightColorItem1.Name = "changeFontHighlightColorItem1"
            ' 
            ' changeTextCaseItem1
            ' 
            Me.changeTextCaseItem1.Id = 67
            Me.changeTextCaseItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextUpperCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.makeTextLowerCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.capitalizeEachWordCaseItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTextCaseItem1) _
            })
            Me.changeTextCaseItem1.Name = "changeTextCaseItem1"
            ' 
            ' makeTextUpperCaseItem1
            ' 
            Me.makeTextUpperCaseItem1.Id = 68
            Me.makeTextUpperCaseItem1.Name = "makeTextUpperCaseItem1"
            ' 
            ' makeTextLowerCaseItem1
            ' 
            Me.makeTextLowerCaseItem1.Id = 69
            Me.makeTextLowerCaseItem1.Name = "makeTextLowerCaseItem1"
            ' 
            ' capitalizeEachWordCaseItem1
            ' 
            Me.capitalizeEachWordCaseItem1.Id = 70
            Me.capitalizeEachWordCaseItem1.Name = "capitalizeEachWordCaseItem1"
            ' 
            ' toggleTextCaseItem1
            ' 
            Me.toggleTextCaseItem1.Id = 71
            Me.toggleTextCaseItem1.Name = "toggleTextCaseItem1"
            ' 
            ' clearFormattingItem1
            ' 
            Me.clearFormattingItem1.Id = 72
            Me.clearFormattingItem1.Name = "clearFormattingItem1"
            ' 
            ' barButtonGroup4
            ' 
            Me.barButtonGroup4.Id = 45
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleBulletedListItem1, "U")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleNumberingListItem1, "N")
            Me.barButtonGroup4.ItemLinks.Add(Me.toggleMultiLevelListItem1, "M")
            Me.barButtonGroup4.Name = "barButtonGroup4"
            Me.barButtonGroup4.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' toggleBulletedListItem1
            ' 
            Me.toggleBulletedListItem1.Id = 73
            Me.toggleBulletedListItem1.Name = "toggleBulletedListItem1"
            ' 
            ' toggleNumberingListItem1
            ' 
            Me.toggleNumberingListItem1.Id = 74
            Me.toggleNumberingListItem1.Name = "toggleNumberingListItem1"
            ' 
            ' toggleMultiLevelListItem1
            ' 
            Me.toggleMultiLevelListItem1.Id = 75
            Me.toggleMultiLevelListItem1.Name = "toggleMultiLevelListItem1"
            ' 
            ' barButtonGroup5
            ' 
            Me.barButtonGroup5.Id = 46
            Me.barButtonGroup5.ItemLinks.Add(Me.decreaseIndentItem1, "AO")
            Me.barButtonGroup5.ItemLinks.Add(Me.increaseIndentItem1, "AI")
            Me.barButtonGroup5.ItemLinks.Add(Me.toggleShowWhitespaceItem1)
            Me.barButtonGroup5.Name = "barButtonGroup5"
            Me.barButtonGroup5.Tag = "{4747D5AB-2BEB-4ea6-9A1D-8E4FB36F1B40}"
            ' 
            ' decreaseIndentItem1
            ' 
            Me.decreaseIndentItem1.Id = 76
            Me.decreaseIndentItem1.Name = "decreaseIndentItem1"
            ' 
            ' increaseIndentItem1
            ' 
            Me.increaseIndentItem1.Id = 77
            Me.increaseIndentItem1.Name = "increaseIndentItem1"
            ' 
            ' toggleShowWhitespaceItem1
            ' 
            Me.toggleShowWhitespaceItem1.Id = 82
            Me.toggleShowWhitespaceItem1.Name = "toggleShowWhitespaceItem1"
            ' 
            ' barButtonGroup6
            ' 
            Me.barButtonGroup6.Id = 47
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentLeftItem1, "AL")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentCenterItem1, "AC")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentRightItem1, "AR")
            Me.barButtonGroup6.ItemLinks.Add(Me.toggleParagraphAlignmentJustifyItem1, "AJ")
            Me.barButtonGroup6.Name = "barButtonGroup6"
            Me.barButtonGroup6.Tag = "{8E89E775-996E-49a0-AADA-DE338E34732E}"
            ' 
            ' toggleParagraphAlignmentLeftItem1
            ' 
            Me.toggleParagraphAlignmentLeftItem1.Id = 78
            Me.toggleParagraphAlignmentLeftItem1.Name = "toggleParagraphAlignmentLeftItem1"
            ' 
            ' toggleParagraphAlignmentCenterItem1
            ' 
            Me.toggleParagraphAlignmentCenterItem1.Id = 79
            Me.toggleParagraphAlignmentCenterItem1.Name = "toggleParagraphAlignmentCenterItem1"
            ' 
            ' toggleParagraphAlignmentRightItem1
            ' 
            Me.toggleParagraphAlignmentRightItem1.Id = 80
            Me.toggleParagraphAlignmentRightItem1.Name = "toggleParagraphAlignmentRightItem1"
            ' 
            ' toggleParagraphAlignmentJustifyItem1
            ' 
            Me.toggleParagraphAlignmentJustifyItem1.Id = 81
            Me.toggleParagraphAlignmentJustifyItem1.Name = "toggleParagraphAlignmentJustifyItem1"
            ' 
            ' barButtonGroup7
            ' 
            Me.barButtonGroup7.Id = 48
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphLineSpacingItem1, "K")
            Me.barButtonGroup7.ItemLinks.Add(Me.changeParagraphBackColorItem1, "H")
            Me.barButtonGroup7.Name = "barButtonGroup7"
            Me.barButtonGroup7.Tag = "{9A8DEAD8-3890-4857-A395-EC625FD02217}"
            ' 
            ' changeParagraphLineSpacingItem1
            ' 
            Me.changeParagraphLineSpacingItem1.Id = 83
            Me.changeParagraphLineSpacingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSingleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSesquialteralParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setDoubleParagraphSpacingItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineSpacingFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.addSpacingBeforeParagraphItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingBeforeParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.addSpacingAfterParagraphItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.removeSpacingAfterParagraphItem1) _
            })
            Me.changeParagraphLineSpacingItem1.Name = "changeParagraphLineSpacingItem1"
            ' 
            ' setSingleParagraphSpacingItem1
            ' 
            Me.setSingleParagraphSpacingItem1.Id = 84
            Me.setSingleParagraphSpacingItem1.Name = "setSingleParagraphSpacingItem1"
            ' 
            ' setSesquialteralParagraphSpacingItem1
            ' 
            Me.setSesquialteralParagraphSpacingItem1.Id = 85
            Me.setSesquialteralParagraphSpacingItem1.Name = "setSesquialteralParagraphSpacingItem1"
            ' 
            ' setDoubleParagraphSpacingItem1
            ' 
            Me.setDoubleParagraphSpacingItem1.Id = 86
            Me.setDoubleParagraphSpacingItem1.Name = "setDoubleParagraphSpacingItem1"
            ' 
            ' showLineSpacingFormItem1
            ' 
            Me.showLineSpacingFormItem1.Id = 87
            Me.showLineSpacingFormItem1.Name = "showLineSpacingFormItem1"
            ' 
            ' addSpacingBeforeParagraphItem1
            ' 
            Me.addSpacingBeforeParagraphItem1.Id = 88
            Me.addSpacingBeforeParagraphItem1.Name = "addSpacingBeforeParagraphItem1"
            ' 
            ' removeSpacingBeforeParagraphItem1
            ' 
            Me.removeSpacingBeforeParagraphItem1.Id = 89
            Me.removeSpacingBeforeParagraphItem1.Name = "removeSpacingBeforeParagraphItem1"
            ' 
            ' addSpacingAfterParagraphItem1
            ' 
            Me.addSpacingAfterParagraphItem1.Id = 90
            Me.addSpacingAfterParagraphItem1.Name = "addSpacingAfterParagraphItem1"
            ' 
            ' removeSpacingAfterParagraphItem1
            ' 
            Me.removeSpacingAfterParagraphItem1.Id = 91
            Me.removeSpacingAfterParagraphItem1.Name = "removeSpacingAfterParagraphItem1"
            ' 
            ' changeParagraphBackColorItem1
            ' 
            Me.changeParagraphBackColorItem1.Id = 92
            Me.changeParagraphBackColorItem1.Name = "changeParagraphBackColorItem1"
            ' 
            ' findItem1
            ' 
            Me.findItem1.Id = 94
            Me.findItem1.Name = "findItem1"
            ' 
            ' replaceItem1
            ' 
            Me.replaceItem1.Id = 95
            Me.replaceItem1.Name = "replaceItem1"
            ' 
            ' insertPageBreakItem21
            ' 
            Me.insertPageBreakItem21.Id = 96
            Me.insertPageBreakItem21.Name = "insertPageBreakItem21"
            ' 
            ' insertTableItem1
            ' 
            Me.insertTableItem1.Id = 97
            Me.insertTableItem1.Name = "insertTableItem1"
            ' 
            ' insertPictureItem1
            ' 
            Me.insertPictureItem1.Id = 98
            Me.insertPictureItem1.Name = "insertPictureItem1"
            ' 
            ' insertFloatingPictureItem1
            ' 
            Me.insertFloatingPictureItem1.Id = 99
            Me.insertFloatingPictureItem1.Name = "insertFloatingPictureItem1"
            ' 
            ' commandBarItem3
            ' 
            Me.commandBarItem3.Id = 100
            Me.commandBarItem3.Name = "commandBarItem3"
            Me.commandBarItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertBarCode
            ' 
            ' commandBarItem4
            ' 
            Me.commandBarItem4.Id = 101
            Me.commandBarItem4.Name = "commandBarItem4"
            Me.commandBarItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertCheckBox
            ' 
            ' commandBarItem5
            ' 
            Me.commandBarItem5.Id = 102
            Me.commandBarItem5.Name = "commandBarItem5"
            Me.commandBarItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertChart
            ' 
            ' commandBarItem6
            ' 
            Me.commandBarItem6.Id = 103
            Me.commandBarItem6.Name = "commandBarItem6"
            Me.commandBarItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSparkline
            ' 
            ' commandBarItem7
            ' 
            Me.commandBarItem7.Id = 104
            Me.commandBarItem7.Name = "commandBarItem7"
            Me.commandBarItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertIndex
            ' 
            ' insertBookmarkItem1
            ' 
            Me.insertBookmarkItem1.Id = 105
            Me.insertBookmarkItem1.Name = "insertBookmarkItem1"
            ' 
            ' insertHyperlinkItem1
            ' 
            Me.insertHyperlinkItem1.Id = 106
            Me.insertHyperlinkItem1.Name = "insertHyperlinkItem1"
            ' 
            ' editPageHeaderItem1
            ' 
            Me.editPageHeaderItem1.Id = 107
            Me.editPageHeaderItem1.Name = "editPageHeaderItem1"
            ' 
            ' editPageFooterItem1
            ' 
            Me.editPageFooterItem1.Id = 108
            Me.editPageFooterItem1.Name = "editPageFooterItem1"
            ' 
            ' insertPageNumberItem1
            ' 
            Me.insertPageNumberItem1.Id = 109
            Me.insertPageNumberItem1.Name = "insertPageNumberItem1"
            ' 
            ' insertPageCountItem1
            ' 
            Me.insertPageCountItem1.Id = 110
            Me.insertPageCountItem1.Name = "insertPageCountItem1"
            ' 
            ' insertTextBoxItem1
            ' 
            Me.insertTextBoxItem1.Id = 111
            Me.insertTextBoxItem1.Name = "insertTextBoxItem1"
            ' 
            ' insertSymbolItem1
            ' 
            Me.insertSymbolItem1.Id = 112
            Me.insertSymbolItem1.Name = "insertSymbolItem1"
            ' 
            ' changeSectionPageMarginsItem1
            ' 
            Me.changeSectionPageMarginsItem1.Id = 113
            Me.changeSectionPageMarginsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNormalSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setNarrowSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setModerateSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setWideSectionPageMarginsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showPageMarginsSetupFormItem1, True) _
            })
            Me.changeSectionPageMarginsItem1.Name = "changeSectionPageMarginsItem1"
            ' 
            ' setNormalSectionPageMarginsItem1
            ' 
            Me.setNormalSectionPageMarginsItem1.Id = 114
            Me.setNormalSectionPageMarginsItem1.Name = "setNormalSectionPageMarginsItem1"
            ' 
            ' setNarrowSectionPageMarginsItem1
            ' 
            Me.setNarrowSectionPageMarginsItem1.Id = 115
            Me.setNarrowSectionPageMarginsItem1.Name = "setNarrowSectionPageMarginsItem1"
            ' 
            ' setModerateSectionPageMarginsItem1
            ' 
            Me.setModerateSectionPageMarginsItem1.Id = 116
            Me.setModerateSectionPageMarginsItem1.Name = "setModerateSectionPageMarginsItem1"
            ' 
            ' setWideSectionPageMarginsItem1
            ' 
            Me.setWideSectionPageMarginsItem1.Id = 117
            Me.setWideSectionPageMarginsItem1.Name = "setWideSectionPageMarginsItem1"
            ' 
            ' showPageMarginsSetupFormItem1
            ' 
            Me.showPageMarginsSetupFormItem1.Id = 118
            Me.showPageMarginsSetupFormItem1.Name = "showPageMarginsSetupFormItem1"
            ' 
            ' changeSectionPageOrientationItem1
            ' 
            Me.changeSectionPageOrientationItem1.Id = 119
            Me.changeSectionPageOrientationItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setPortraitPageOrientationItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setLandscapePageOrientationItem1) _
            })
            Me.changeSectionPageOrientationItem1.Name = "changeSectionPageOrientationItem1"
            ' 
            ' setPortraitPageOrientationItem1
            ' 
            Me.setPortraitPageOrientationItem1.Id = 120
            Me.setPortraitPageOrientationItem1.Name = "setPortraitPageOrientationItem1"
            ' 
            ' setLandscapePageOrientationItem1
            ' 
            Me.setLandscapePageOrientationItem1.Id = 121
            Me.setLandscapePageOrientationItem1.Name = "setLandscapePageOrientationItem1"
            ' 
            ' changeSectionPaperKindItem1
            ' 
            Me.changeSectionPaperKindItem1.Id = 122
            Me.changeSectionPaperKindItem1.Name = "changeSectionPaperKindItem1"
            ' 
            ' changeSectionColumnsItem1
            ' 
            Me.changeSectionColumnsItem1.Id = 123
            Me.changeSectionColumnsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionOneColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionTwoColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionThreeColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showColumnsSetupFormItem1, True) _
            })
            Me.changeSectionColumnsItem1.Name = "changeSectionColumnsItem1"
            ' 
            ' setSectionOneColumnItem1
            ' 
            Me.setSectionOneColumnItem1.Id = 124
            Me.setSectionOneColumnItem1.Name = "setSectionOneColumnItem1"
            ' 
            ' setSectionTwoColumnsItem1
            ' 
            Me.setSectionTwoColumnsItem1.Id = 125
            Me.setSectionTwoColumnsItem1.Name = "setSectionTwoColumnsItem1"
            ' 
            ' setSectionThreeColumnsItem1
            ' 
            Me.setSectionThreeColumnsItem1.Id = 126
            Me.setSectionThreeColumnsItem1.Name = "setSectionThreeColumnsItem1"
            ' 
            ' showColumnsSetupFormItem1
            ' 
            Me.showColumnsSetupFormItem1.Id = 127
            Me.showColumnsSetupFormItem1.Name = "showColumnsSetupFormItem1"
            ' 
            ' insertBreakItem1
            ' 
            Me.insertBreakItem1.Id = 128
            Me.insertBreakItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.insertPageBreakItem1, "", False, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "B", ""), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertColumnBreakItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakNextPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakEvenPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertSectionBreakOddPageItem1) _
            })
            Me.insertBreakItem1.Name = "insertBreakItem1"
            ' 
            ' insertPageBreakItem1
            ' 
            Me.insertPageBreakItem1.Id = 129
            Me.insertPageBreakItem1.Name = "insertPageBreakItem1"
            ' 
            ' insertColumnBreakItem1
            ' 
            Me.insertColumnBreakItem1.Id = 130
            Me.insertColumnBreakItem1.Name = "insertColumnBreakItem1"
            ' 
            ' insertSectionBreakNextPageItem1
            ' 
            Me.insertSectionBreakNextPageItem1.Id = 131
            Me.insertSectionBreakNextPageItem1.Name = "insertSectionBreakNextPageItem1"
            ' 
            ' insertSectionBreakEvenPageItem1
            ' 
            Me.insertSectionBreakEvenPageItem1.Id = 132
            Me.insertSectionBreakEvenPageItem1.Name = "insertSectionBreakEvenPageItem1"
            ' 
            ' insertSectionBreakOddPageItem1
            ' 
            Me.insertSectionBreakOddPageItem1.Id = 133
            Me.insertSectionBreakOddPageItem1.Name = "insertSectionBreakOddPageItem1"
            ' 
            ' changeSectionLineNumberingItem1
            ' 
            Me.changeSectionLineNumberingItem1.Id = 134
            Me.changeSectionLineNumberingItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingNoneItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingContinuousItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewPageItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setSectionLineNumberingRestartNewSectionItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleParagraphSuppressLineNumbersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showLineNumberingFormItem1, True) _
            })
            Me.changeSectionLineNumberingItem1.Name = "changeSectionLineNumberingItem1"
            ' 
            ' setSectionLineNumberingNoneItem1
            ' 
            Me.setSectionLineNumberingNoneItem1.Id = 135
            Me.setSectionLineNumberingNoneItem1.Name = "setSectionLineNumberingNoneItem1"
            ' 
            ' setSectionLineNumberingContinuousItem1
            ' 
            Me.setSectionLineNumberingContinuousItem1.Id = 136
            Me.setSectionLineNumberingContinuousItem1.Name = "setSectionLineNumberingContinuousItem1"
            ' 
            ' setSectionLineNumberingRestartNewPageItem1
            ' 
            Me.setSectionLineNumberingRestartNewPageItem1.Id = 137
            Me.setSectionLineNumberingRestartNewPageItem1.Name = "setSectionLineNumberingRestartNewPageItem1"
            ' 
            ' setSectionLineNumberingRestartNewSectionItem1
            ' 
            Me.setSectionLineNumberingRestartNewSectionItem1.Id = 138
            Me.setSectionLineNumberingRestartNewSectionItem1.Name = "setSectionLineNumberingRestartNewSectionItem1"
            ' 
            ' toggleParagraphSuppressLineNumbersItem1
            ' 
            Me.toggleParagraphSuppressLineNumbersItem1.Id = 139
            Me.toggleParagraphSuppressLineNumbersItem1.Name = "toggleParagraphSuppressLineNumbersItem1"
            ' 
            ' showLineNumberingFormItem1
            ' 
            Me.showLineNumberingFormItem1.Id = 140
            Me.showLineNumberingFormItem1.Name = "showLineNumberingFormItem1"
            ' 
            ' changePageColorItem1
            ' 
            Me.changePageColorItem1.Id = 141
            Me.changePageColorItem1.Name = "changePageColorItem1"
            ' 
            ' switchToSimpleViewItem1
            ' 
            Me.switchToSimpleViewItem1.Id = 142
            Me.switchToSimpleViewItem1.Name = "switchToSimpleViewItem1"
            ' 
            ' switchToDraftViewItem1
            ' 
            Me.switchToDraftViewItem1.Id = 143
            Me.switchToDraftViewItem1.Name = "switchToDraftViewItem1"
            ' 
            ' switchToPrintLayoutViewItem1
            ' 
            Me.switchToPrintLayoutViewItem1.Id = 144
            Me.switchToPrintLayoutViewItem1.Name = "switchToPrintLayoutViewItem1"
            ' 
            ' toggleShowHorizontalRulerItem1
            ' 
            Me.toggleShowHorizontalRulerItem1.Id = 145
            Me.toggleShowHorizontalRulerItem1.Name = "toggleShowHorizontalRulerItem1"
            ' 
            ' toggleShowVerticalRulerItem1
            ' 
            Me.toggleShowVerticalRulerItem1.Id = 146
            Me.toggleShowVerticalRulerItem1.Name = "toggleShowVerticalRulerItem1"
            ' 
            ' zoomOutItem1
            ' 
            Me.zoomOutItem1.Id = 147
            Me.zoomOutItem1.Name = "zoomOutItem1"
            ' 
            ' zoomInItem1
            ' 
            Me.zoomInItem1.Id = 148
            Me.zoomInItem1.Name = "zoomInItem1"
            ' 
            ' snapBarToolbarsListItem1
            ' 
            Me.snapBarToolbarsListItem1.Hint = "Show or hide the Data Explorer and Report Explorer windows."
            Me.snapBarToolbarsListItem1.Id = 149
            Me.snapBarToolbarsListItem1.ImageOptions.Image = (DirectCast(resources.GetObject("snapBarToolbarsListItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.snapBarToolbarsListItem1.ImageOptions.LargeImage = (DirectCast(resources.GetObject("snapBarToolbarsListItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.snapBarToolbarsListItem1.Name = "snapBarToolbarsListItem1"
            Me.snapBarToolbarsListItem1.ShowCustomizationItem = False
            Me.snapBarToolbarsListItem1.ShowDockPanels = True
            Me.snapBarToolbarsListItem1.ShowToolbars = False
            ' 
            ' commandBarCheckItem1
            ' 
            Me.commandBarCheckItem1.Id = 150
            Me.commandBarCheckItem1.Name = "commandBarCheckItem1"
            Me.commandBarCheckItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.HighlightActiveElement
            ' 
            ' showAllFieldCodesItem1
            ' 
            Me.showAllFieldCodesItem1.Id = 151
            Me.showAllFieldCodesItem1.Name = "showAllFieldCodesItem1"
            ' 
            ' showAllFieldResultsItem1
            ' 
            Me.showAllFieldResultsItem1.Id = 152
            Me.showAllFieldResultsItem1.Name = "showAllFieldResultsItem1"
            ' 
            ' toggleFieldHighlightingItem1
            ' 
            Me.toggleFieldHighlightingItem1.Id = 153
            Me.toggleFieldHighlightingItem1.ImageOptions.Image = (DirectCast(resources.GetObject("toggleFieldHighlightingItem1.ImageOptions.Image"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.ImageOptions.LargeImage = (DirectCast(resources.GetObject("toggleFieldHighlightingItem1.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.toggleFieldHighlightingItem1.Name = "toggleFieldHighlightingItem1"
            ' 
            ' goToPageHeaderItem1
            ' 
            Me.goToPageHeaderItem1.Id = 154
            Me.goToPageHeaderItem1.Name = "goToPageHeaderItem1"
            ' 
            ' goToPageFooterItem1
            ' 
            Me.goToPageFooterItem1.Id = 155
            Me.goToPageFooterItem1.Name = "goToPageFooterItem1"
            ' 
            ' goToNextHeaderFooterItem1
            ' 
            Me.goToNextHeaderFooterItem1.Id = 156
            Me.goToNextHeaderFooterItem1.Name = "goToNextHeaderFooterItem1"
            ' 
            ' goToPreviousHeaderFooterItem1
            ' 
            Me.goToPreviousHeaderFooterItem1.Id = 157
            Me.goToPreviousHeaderFooterItem1.Name = "goToPreviousHeaderFooterItem1"
            ' 
            ' toggleLinkToPreviousItem1
            ' 
            Me.toggleLinkToPreviousItem1.Id = 158
            Me.toggleLinkToPreviousItem1.Name = "toggleLinkToPreviousItem1"
            ' 
            ' toggleDifferentFirstPageItem1
            ' 
            Me.toggleDifferentFirstPageItem1.Id = 159
            Me.toggleDifferentFirstPageItem1.Name = "toggleDifferentFirstPageItem1"
            ' 
            ' toggleDifferentOddAndEvenPagesItem1
            ' 
            Me.toggleDifferentOddAndEvenPagesItem1.Id = 160
            Me.toggleDifferentOddAndEvenPagesItem1.Name = "toggleDifferentOddAndEvenPagesItem1"
            ' 
            ' closePageHeaderFooterItem1
            ' 
            Me.closePageHeaderFooterItem1.Id = 161
            Me.closePageHeaderFooterItem1.Name = "closePageHeaderFooterItem1"
            ' 
            ' toggleFirstRowItem1
            ' 
            Me.toggleFirstRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstRowItem1.Id = 162
            Me.toggleFirstRowItem1.Name = "toggleFirstRowItem1"
            ' 
            ' toggleLastRowItem1
            ' 
            Me.toggleLastRowItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastRowItem1.Id = 163
            Me.toggleLastRowItem1.Name = "toggleLastRowItem1"
            ' 
            ' toggleBandedRowsItem1
            ' 
            Me.toggleBandedRowsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedRowsItem1.Id = 164
            Me.toggleBandedRowsItem1.Name = "toggleBandedRowsItem1"
            ' 
            ' toggleFirstColumnItem1
            ' 
            Me.toggleFirstColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleFirstColumnItem1.Id = 165
            Me.toggleFirstColumnItem1.Name = "toggleFirstColumnItem1"
            ' 
            ' toggleLastColumnItem1
            ' 
            Me.toggleLastColumnItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleLastColumnItem1.Id = 166
            Me.toggleLastColumnItem1.Name = "toggleLastColumnItem1"
            ' 
            ' toggleBandedColumnsItem1
            ' 
            Me.toggleBandedColumnsItem1.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText
            Me.toggleBandedColumnsItem1.Id = 167
            Me.toggleBandedColumnsItem1.Name = "toggleBandedColumnsItem1"
            ' 
            ' galleryChangeTableStyleItem1
            ' 
            Me.galleryChangeTableStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            Me.galleryChangeTableStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup2})
            Me.galleryChangeTableStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableStyleItem1.Id = 168
            Me.galleryChangeTableStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableStyleItem1.Name = "galleryChangeTableStyleItem1"
            Me.galleryChangeTableStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableStyleItem1.PopupGallery = Nothing
            ' 
            ' galleryChangeTableCellStyleItem1
            ' 
            Me.galleryChangeTableCellStyleItem1.CurrentItem = Nothing
            Me.galleryChangeTableCellStyleItem1.DeleteItemLink = Nothing
            ' 
            ' 
            ' 
            Me.galleryChangeTableCellStyleItem1.Gallery.ColumnCount = 3
            Me.galleryChangeTableCellStyleItem1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup3})
            Me.galleryChangeTableCellStyleItem1.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeTableCellStyleItem1.Id = 169
            Me.galleryChangeTableCellStyleItem1.ModifyItemLink = Nothing
            Me.galleryChangeTableCellStyleItem1.Name = "galleryChangeTableCellStyleItem1"
            Me.galleryChangeTableCellStyleItem1.NewItemLink = Nothing
            Me.galleryChangeTableCellStyleItem1.PopupGallery = Nothing
            ' 
            ' changeTableBorderLineStyleItem1
            ' 
            Me.changeTableBorderLineStyleItem1.Edit = Me.repositoryItemBorderLineStyle1
            Me.changeTableBorderLineStyleItem1.EditWidth = 130
            Me.changeTableBorderLineStyleItem1.Id = 170
            Me.changeTableBorderLineStyleItem1.Name = "changeTableBorderLineStyleItem1"
            ' 
            ' repositoryItemBorderLineStyle1
            ' 
            Me.repositoryItemBorderLineStyle1.AutoHeight = False
            Me.repositoryItemBorderLineStyle1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineStyle1.Control = Me.snapControl1
            Me.repositoryItemBorderLineStyle1.Name = "repositoryItemBorderLineStyle1"
            ' 
            ' changeTableBorderLineWeightItem1
            ' 
            Me.changeTableBorderLineWeightItem1.Edit = Me.repositoryItemBorderLineWeight1
            Me.changeTableBorderLineWeightItem1.EditValue = 20
            Me.changeTableBorderLineWeightItem1.EditWidth = 130
            Me.changeTableBorderLineWeightItem1.Id = 171
            Me.changeTableBorderLineWeightItem1.Name = "changeTableBorderLineWeightItem1"
            ' 
            ' repositoryItemBorderLineWeight1
            ' 
            Me.repositoryItemBorderLineWeight1.AutoHeight = False
            Me.repositoryItemBorderLineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemBorderLineWeight1.Control = Me.snapControl1
            Me.repositoryItemBorderLineWeight1.Name = "repositoryItemBorderLineWeight1"
            ' 
            ' changeTableBorderColorItem1
            ' 
            Me.changeTableBorderColorItem1.Id = 172
            Me.changeTableBorderColorItem1.Name = "changeTableBorderColorItem1"
            ' 
            ' changeTableBordersItem1
            ' 
            Me.changeTableBordersItem1.Id = 173
            Me.changeTableBordersItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsBottomBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsTopBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsLeftBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsRightBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.resetTableCellsAllBordersItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsAllBordersItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsOutsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideHorizontalBorderItem1, True), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableCellsInsideVerticalBorderItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.KeyTip, Me.toggleShowTableGridLinesItem1, "", True, True, True, 0, Nothing, DevExpress.XtraBars.BarItemPaintStyle.Standard, "TG", "") _
            })
            Me.changeTableBordersItem1.Name = "changeTableBordersItem1"
            ' 
            ' toggleTableCellsBottomBorderItem1
            ' 
            Me.toggleTableCellsBottomBorderItem1.Id = 174
            Me.toggleTableCellsBottomBorderItem1.Name = "toggleTableCellsBottomBorderItem1"
            ' 
            ' toggleTableCellsTopBorderItem1
            ' 
            Me.toggleTableCellsTopBorderItem1.Id = 175
            Me.toggleTableCellsTopBorderItem1.Name = "toggleTableCellsTopBorderItem1"
            ' 
            ' toggleTableCellsLeftBorderItem1
            ' 
            Me.toggleTableCellsLeftBorderItem1.Id = 176
            Me.toggleTableCellsLeftBorderItem1.Name = "toggleTableCellsLeftBorderItem1"
            ' 
            ' toggleTableCellsRightBorderItem1
            ' 
            Me.toggleTableCellsRightBorderItem1.Id = 177
            Me.toggleTableCellsRightBorderItem1.Name = "toggleTableCellsRightBorderItem1"
            ' 
            ' resetTableCellsAllBordersItem1
            ' 
            Me.resetTableCellsAllBordersItem1.Id = 178
            Me.resetTableCellsAllBordersItem1.Name = "resetTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsAllBordersItem1
            ' 
            Me.toggleTableCellsAllBordersItem1.Id = 179
            Me.toggleTableCellsAllBordersItem1.Name = "toggleTableCellsAllBordersItem1"
            ' 
            ' toggleTableCellsOutsideBorderItem1
            ' 
            Me.toggleTableCellsOutsideBorderItem1.Id = 180
            Me.toggleTableCellsOutsideBorderItem1.Name = "toggleTableCellsOutsideBorderItem1"
            ' 
            ' toggleTableCellsInsideBorderItem1
            ' 
            Me.toggleTableCellsInsideBorderItem1.Id = 181
            Me.toggleTableCellsInsideBorderItem1.Name = "toggleTableCellsInsideBorderItem1"
            ' 
            ' toggleTableCellsInsideHorizontalBorderItem1
            ' 
            Me.toggleTableCellsInsideHorizontalBorderItem1.Id = 182
            Me.toggleTableCellsInsideHorizontalBorderItem1.Name = "toggleTableCellsInsideHorizontalBorderItem1"
            ' 
            ' toggleTableCellsInsideVerticalBorderItem1
            ' 
            Me.toggleTableCellsInsideVerticalBorderItem1.Id = 183
            Me.toggleTableCellsInsideVerticalBorderItem1.Name = "toggleTableCellsInsideVerticalBorderItem1"
            ' 
            ' toggleShowTableGridLinesItem1
            ' 
            Me.toggleShowTableGridLinesItem1.Id = 184
            Me.toggleShowTableGridLinesItem1.Name = "toggleShowTableGridLinesItem1"
            ' 
            ' changeTableCellsShadingItem1
            ' 
            Me.changeTableCellsShadingItem1.Id = 185
            Me.changeTableCellsShadingItem1.Name = "changeTableCellsShadingItem1"
            ' 
            ' selectTableElementsItem1
            ' 
            Me.selectTableElementsItem1.Id = 186
            Me.selectTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableCellItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableColumnItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableRowItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.selectTableItem1) _
            })
            Me.selectTableElementsItem1.Name = "selectTableElementsItem1"
            ' 
            ' selectTableCellItem1
            ' 
            Me.selectTableCellItem1.Id = 187
            Me.selectTableCellItem1.Name = "selectTableCellItem1"
            ' 
            ' selectTableColumnItem1
            ' 
            Me.selectTableColumnItem1.Id = 188
            Me.selectTableColumnItem1.Name = "selectTableColumnItem1"
            ' 
            ' selectTableRowItem1
            ' 
            Me.selectTableRowItem1.Id = 189
            Me.selectTableRowItem1.Name = "selectTableRowItem1"
            ' 
            ' selectTableItem1
            ' 
            Me.selectTableItem1.Id = 190
            Me.selectTableItem1.Name = "selectTableItem1"
            ' 
            ' showTablePropertiesFormItem1
            ' 
            Me.showTablePropertiesFormItem1.Id = 191
            Me.showTablePropertiesFormItem1.Name = "showTablePropertiesFormItem1"
            ' 
            ' deleteTableElementsItem1
            ' 
            Me.deleteTableElementsItem1.Id = 192
            Me.deleteTableElementsItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.showDeleteTableCellsFormItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableColumnsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableRowsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.deleteTableItem1) _
            })
            Me.deleteTableElementsItem1.Name = "deleteTableElementsItem1"
            ' 
            ' showDeleteTableCellsFormItem1
            ' 
            Me.showDeleteTableCellsFormItem1.Id = 193
            Me.showDeleteTableCellsFormItem1.Name = "showDeleteTableCellsFormItem1"
            ' 
            ' deleteTableColumnsItem1
            ' 
            Me.deleteTableColumnsItem1.Id = 194
            Me.deleteTableColumnsItem1.Name = "deleteTableColumnsItem1"
            ' 
            ' deleteTableRowsItem1
            ' 
            Me.deleteTableRowsItem1.Id = 195
            Me.deleteTableRowsItem1.Name = "deleteTableRowsItem1"
            ' 
            ' deleteTableItem1
            ' 
            Me.deleteTableItem1.Id = 196
            Me.deleteTableItem1.Name = "deleteTableItem1"
            ' 
            ' insertTableRowAboveItem1
            ' 
            Me.insertTableRowAboveItem1.Id = 197
            Me.insertTableRowAboveItem1.Name = "insertTableRowAboveItem1"
            ' 
            ' insertTableRowBelowItem1
            ' 
            Me.insertTableRowBelowItem1.Id = 198
            Me.insertTableRowBelowItem1.Name = "insertTableRowBelowItem1"
            ' 
            ' insertTableColumnToLeftItem1
            ' 
            Me.insertTableColumnToLeftItem1.Id = 199
            Me.insertTableColumnToLeftItem1.Name = "insertTableColumnToLeftItem1"
            ' 
            ' insertTableColumnToRightItem1
            ' 
            Me.insertTableColumnToRightItem1.Id = 200
            Me.insertTableColumnToRightItem1.Name = "insertTableColumnToRightItem1"
            ' 
            ' mergeTableCellsItem1
            ' 
            Me.mergeTableCellsItem1.Id = 201
            Me.mergeTableCellsItem1.Name = "mergeTableCellsItem1"
            ' 
            ' showSplitTableCellsForm1
            ' 
            Me.showSplitTableCellsForm1.Id = 202
            Me.showSplitTableCellsForm1.Name = "showSplitTableCellsForm1"
            ' 
            ' splitTableItem1
            ' 
            Me.splitTableItem1.Id = 203
            Me.splitTableItem1.Name = "splitTableItem1"
            ' 
            ' toggleTableAutoFitItem1
            ' 
            Me.toggleTableAutoFitItem1.Id = 204
            Me.toggleTableAutoFitItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitContentsItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableAutoFitWindowItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.toggleTableFixedColumnWidthItem1) _
            })
            Me.toggleTableAutoFitItem1.Name = "toggleTableAutoFitItem1"
            ' 
            ' toggleTableAutoFitContentsItem1
            ' 
            Me.toggleTableAutoFitContentsItem1.Id = 205
            Me.toggleTableAutoFitContentsItem1.Name = "toggleTableAutoFitContentsItem1"
            ' 
            ' toggleTableAutoFitWindowItem1
            ' 
            Me.toggleTableAutoFitWindowItem1.Id = 206
            Me.toggleTableAutoFitWindowItem1.Name = "toggleTableAutoFitWindowItem1"
            ' 
            ' toggleTableFixedColumnWidthItem1
            ' 
            Me.toggleTableFixedColumnWidthItem1.Id = 207
            Me.toggleTableFixedColumnWidthItem1.Name = "toggleTableFixedColumnWidthItem1"
            ' 
            ' toggleTableCellsTopLeftAlignmentItem1
            ' 
            Me.toggleTableCellsTopLeftAlignmentItem1.Id = 208
            Me.toggleTableCellsTopLeftAlignmentItem1.Name = "toggleTableCellsTopLeftAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleLeftAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Id = 209
            Me.toggleTableCellsMiddleLeftAlignmentItem1.Name = "toggleTableCellsMiddleLeftAlignmentItem1"
            ' 
            ' toggleTableCellsBottomLeftAlignmentItem1
            ' 
            Me.toggleTableCellsBottomLeftAlignmentItem1.Id = 210
            Me.toggleTableCellsBottomLeftAlignmentItem1.Name = "toggleTableCellsBottomLeftAlignmentItem1"
            ' 
            ' toggleTableCellsTopCenterAlignmentItem1
            ' 
            Me.toggleTableCellsTopCenterAlignmentItem1.Id = 211
            Me.toggleTableCellsTopCenterAlignmentItem1.Name = "toggleTableCellsTopCenterAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleCenterAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Id = 212
            Me.toggleTableCellsMiddleCenterAlignmentItem1.Name = "toggleTableCellsMiddleCenterAlignmentItem1"
            ' 
            ' toggleTableCellsBottomCenterAlignmentItem1
            ' 
            Me.toggleTableCellsBottomCenterAlignmentItem1.Id = 213
            Me.toggleTableCellsBottomCenterAlignmentItem1.Name = "toggleTableCellsBottomCenterAlignmentItem1"
            ' 
            ' toggleTableCellsTopRightAlignmentItem1
            ' 
            Me.toggleTableCellsTopRightAlignmentItem1.Id = 214
            Me.toggleTableCellsTopRightAlignmentItem1.Name = "toggleTableCellsTopRightAlignmentItem1"
            ' 
            ' toggleTableCellsMiddleRightAlignmentItem1
            ' 
            Me.toggleTableCellsMiddleRightAlignmentItem1.Id = 215
            Me.toggleTableCellsMiddleRightAlignmentItem1.Name = "toggleTableCellsMiddleRightAlignmentItem1"
            ' 
            ' toggleTableCellsBottomRightAlignmentItem1
            ' 
            Me.toggleTableCellsBottomRightAlignmentItem1.Id = 216
            Me.toggleTableCellsBottomRightAlignmentItem1.Name = "toggleTableCellsBottomRightAlignmentItem1"
            ' 
            ' showTableOptionsFormItem1
            ' 
            Me.showTableOptionsFormItem1.Id = 217
            Me.showTableOptionsFormItem1.Name = "showTableOptionsFormItem1"
            ' 
            ' checkSpellingItem1
            ' 
            Me.checkSpellingItem1.Id = 218
            Me.checkSpellingItem1.Name = "checkSpellingItem1"
            ' 
            ' insertTableOfContentsItem1
            ' 
            Me.insertTableOfContentsItem1.Id = 219
            Me.insertTableOfContentsItem1.Name = "insertTableOfContentsItem1"
            ' 
            ' updateTableOfContentsItem1
            ' 
            Me.updateTableOfContentsItem1.Id = 220
            Me.updateTableOfContentsItem1.Name = "updateTableOfContentsItem1"
            ' 
            ' addParagraphsToTableOfContentItem1
            ' 
            Me.addParagraphsToTableOfContentItem1.Id = 221
            Me.addParagraphsToTableOfContentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem3), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem4), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem9), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setParagraphHeadingLevelItem10) _
            })
            Me.addParagraphsToTableOfContentItem1.Name = "addParagraphsToTableOfContentItem1"
            ' 
            ' setParagraphHeadingLevelItem1
            ' 
            Me.setParagraphHeadingLevelItem1.Id = 222
            Me.setParagraphHeadingLevelItem1.Name = "setParagraphHeadingLevelItem1"
            Me.setParagraphHeadingLevelItem1.OutlineLevel = 0
            ' 
            ' setParagraphHeadingLevelItem2
            ' 
            Me.setParagraphHeadingLevelItem2.Id = 223
            Me.setParagraphHeadingLevelItem2.Name = "setParagraphHeadingLevelItem2"
            Me.setParagraphHeadingLevelItem2.OutlineLevel = 1
            ' 
            ' setParagraphHeadingLevelItem3
            ' 
            Me.setParagraphHeadingLevelItem3.Id = 224
            Me.setParagraphHeadingLevelItem3.Name = "setParagraphHeadingLevelItem3"
            Me.setParagraphHeadingLevelItem3.OutlineLevel = 2
            ' 
            ' setParagraphHeadingLevelItem4
            ' 
            Me.setParagraphHeadingLevelItem4.Id = 225
            Me.setParagraphHeadingLevelItem4.Name = "setParagraphHeadingLevelItem4"
            Me.setParagraphHeadingLevelItem4.OutlineLevel = 3
            ' 
            ' setParagraphHeadingLevelItem5
            ' 
            Me.setParagraphHeadingLevelItem5.Id = 226
            Me.setParagraphHeadingLevelItem5.Name = "setParagraphHeadingLevelItem5"
            Me.setParagraphHeadingLevelItem5.OutlineLevel = 4
            ' 
            ' setParagraphHeadingLevelItem6
            ' 
            Me.setParagraphHeadingLevelItem6.Id = 227
            Me.setParagraphHeadingLevelItem6.Name = "setParagraphHeadingLevelItem6"
            Me.setParagraphHeadingLevelItem6.OutlineLevel = 5
            ' 
            ' setParagraphHeadingLevelItem7
            ' 
            Me.setParagraphHeadingLevelItem7.Id = 228
            Me.setParagraphHeadingLevelItem7.Name = "setParagraphHeadingLevelItem7"
            Me.setParagraphHeadingLevelItem7.OutlineLevel = 6
            ' 
            ' setParagraphHeadingLevelItem8
            ' 
            Me.setParagraphHeadingLevelItem8.Id = 229
            Me.setParagraphHeadingLevelItem8.Name = "setParagraphHeadingLevelItem8"
            Me.setParagraphHeadingLevelItem8.OutlineLevel = 7
            ' 
            ' setParagraphHeadingLevelItem9
            ' 
            Me.setParagraphHeadingLevelItem9.Id = 230
            Me.setParagraphHeadingLevelItem9.Name = "setParagraphHeadingLevelItem9"
            Me.setParagraphHeadingLevelItem9.OutlineLevel = 8
            ' 
            ' setParagraphHeadingLevelItem10
            ' 
            Me.setParagraphHeadingLevelItem10.Id = 231
            Me.setParagraphHeadingLevelItem10.Name = "setParagraphHeadingLevelItem10"
            Me.setParagraphHeadingLevelItem10.OutlineLevel = 9
            ' 
            ' insertCaptionPlaceholderItem1
            ' 
            Me.insertCaptionPlaceholderItem1.Id = 232
            Me.insertCaptionPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertFiguresCaptionItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTablesCaptionItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertEquationsCaptionItems1) _
            })
            Me.insertCaptionPlaceholderItem1.Name = "insertCaptionPlaceholderItem1"
            ' 
            ' insertFiguresCaptionItems1
            ' 
            Me.insertFiguresCaptionItems1.Id = 233
            Me.insertFiguresCaptionItems1.Name = "insertFiguresCaptionItems1"
            ' 
            ' insertTablesCaptionItems1
            ' 
            Me.insertTablesCaptionItems1.Id = 234
            Me.insertTablesCaptionItems1.Name = "insertTablesCaptionItems1"
            ' 
            ' insertEquationsCaptionItems1
            ' 
            Me.insertEquationsCaptionItems1.Id = 235
            Me.insertEquationsCaptionItems1.Name = "insertEquationsCaptionItems1"
            ' 
            ' insertTableOfFiguresPlaceholderItem1
            ' 
            Me.insertTableOfFiguresPlaceholderItem1.Id = 236
            Me.insertTableOfFiguresPlaceholderItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfFiguresItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfTablesItems1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.insertTableOfEquationsItems1) _
            })
            Me.insertTableOfFiguresPlaceholderItem1.Name = "insertTableOfFiguresPlaceholderItem1"
            ' 
            ' insertTableOfFiguresItems1
            ' 
            Me.insertTableOfFiguresItems1.Id = 237
            Me.insertTableOfFiguresItems1.Name = "insertTableOfFiguresItems1"
            ' 
            ' insertTableOfTablesItems1
            ' 
            Me.insertTableOfTablesItems1.Id = 238
            Me.insertTableOfTablesItems1.Name = "insertTableOfTablesItems1"
            ' 
            ' insertTableOfEquationsItems1
            ' 
            Me.insertTableOfEquationsItems1.Id = 239
            Me.insertTableOfEquationsItems1.Name = "insertTableOfEquationsItems1"
            ' 
            ' updateTableOfFiguresItem1
            ' 
            Me.updateTableOfFiguresItem1.Id = 240
            Me.updateTableOfFiguresItem1.Name = "updateTableOfFiguresItem1"
            ' 
            ' changeFloatingObjectFillColorItem1
            ' 
            Me.changeFloatingObjectFillColorItem1.Id = 241
            Me.changeFloatingObjectFillColorItem1.Name = "changeFloatingObjectFillColorItem1"
            ' 
            ' changeFloatingObjectOutlineColorItem1
            ' 
            Me.changeFloatingObjectOutlineColorItem1.Id = 242
            Me.changeFloatingObjectOutlineColorItem1.Name = "changeFloatingObjectOutlineColorItem1"
            ' 
            ' changeFloatingObjectOutlineWeightItem1
            ' 
            Me.changeFloatingObjectOutlineWeightItem1.Edit = Me.repositoryItemFloatingObjectOutlineWeight1
            Me.changeFloatingObjectOutlineWeightItem1.EditValue = 20
            Me.changeFloatingObjectOutlineWeightItem1.Id = 243
            Me.changeFloatingObjectOutlineWeightItem1.Name = "changeFloatingObjectOutlineWeightItem1"
            ' 
            ' repositoryItemFloatingObjectOutlineWeight1
            ' 
            Me.repositoryItemFloatingObjectOutlineWeight1.AutoHeight = False
            Me.repositoryItemFloatingObjectOutlineWeight1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFloatingObjectOutlineWeight1.Control = Me.snapControl1
            Me.repositoryItemFloatingObjectOutlineWeight1.Name = "repositoryItemFloatingObjectOutlineWeight1"
            ' 
            ' changeFloatingObjectTextWrapTypeItem1
            ' 
            Me.changeFloatingObjectTextWrapTypeItem1.Id = 244
            Me.changeFloatingObjectTextWrapTypeItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectSquareTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTightTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectThroughTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBehindTextWrapTypeItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectInFrontOfTextWrapTypeItem1) _
            })
            Me.changeFloatingObjectTextWrapTypeItem1.Name = "changeFloatingObjectTextWrapTypeItem1"
            ' 
            ' setFloatingObjectSquareTextWrapTypeItem1
            ' 
            Me.setFloatingObjectSquareTextWrapTypeItem1.Id = 245
            Me.setFloatingObjectSquareTextWrapTypeItem1.Name = "setFloatingObjectSquareTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTightTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTightTextWrapTypeItem1.Id = 246
            Me.setFloatingObjectTightTextWrapTypeItem1.Name = "setFloatingObjectTightTextWrapTypeItem1"
            ' 
            ' setFloatingObjectThroughTextWrapTypeItem1
            ' 
            Me.setFloatingObjectThroughTextWrapTypeItem1.Id = 247
            Me.setFloatingObjectThroughTextWrapTypeItem1.Name = "setFloatingObjectThroughTextWrapTypeItem1"
            ' 
            ' setFloatingObjectTopAndBottomTextWrapTypeItem1
            ' 
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Id = 248
            Me.setFloatingObjectTopAndBottomTextWrapTypeItem1.Name = "setFloatingObjectTopAndBottomTextWrapTypeItem1"
            ' 
            ' setFloatingObjectBehindTextWrapTypeItem1
            ' 
            Me.setFloatingObjectBehindTextWrapTypeItem1.Id = 249
            Me.setFloatingObjectBehindTextWrapTypeItem1.Name = "setFloatingObjectBehindTextWrapTypeItem1"
            ' 
            ' setFloatingObjectInFrontOfTextWrapTypeItem1
            ' 
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Id = 250
            Me.setFloatingObjectInFrontOfTextWrapTypeItem1.Name = "setFloatingObjectInFrontOfTextWrapTypeItem1"
            ' 
            ' changeFloatingObjectAlignmentItem1
            ' 
            Me.changeFloatingObjectAlignmentItem1.Id = 251
            Me.changeFloatingObjectAlignmentItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectTopRightAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectMiddleRightAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomLeftAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomCenterAlignmentItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.setFloatingObjectBottomRightAlignmentItem1) _
            })
            Me.changeFloatingObjectAlignmentItem1.Name = "changeFloatingObjectAlignmentItem1"
            ' 
            ' setFloatingObjectTopLeftAlignmentItem1
            ' 
            Me.setFloatingObjectTopLeftAlignmentItem1.Id = 252
            Me.setFloatingObjectTopLeftAlignmentItem1.Name = "setFloatingObjectTopLeftAlignmentItem1"
            ' 
            ' setFloatingObjectTopCenterAlignmentItem1
            ' 
            Me.setFloatingObjectTopCenterAlignmentItem1.Id = 253
            Me.setFloatingObjectTopCenterAlignmentItem1.Name = "setFloatingObjectTopCenterAlignmentItem1"
            ' 
            ' setFloatingObjectTopRightAlignmentItem1
            ' 
            Me.setFloatingObjectTopRightAlignmentItem1.Id = 254
            Me.setFloatingObjectTopRightAlignmentItem1.Name = "setFloatingObjectTopRightAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleLeftAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Id = 255
            Me.setFloatingObjectMiddleLeftAlignmentItem1.Name = "setFloatingObjectMiddleLeftAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleCenterAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Id = 256
            Me.setFloatingObjectMiddleCenterAlignmentItem1.Name = "setFloatingObjectMiddleCenterAlignmentItem1"
            ' 
            ' setFloatingObjectMiddleRightAlignmentItem1
            ' 
            Me.setFloatingObjectMiddleRightAlignmentItem1.Id = 257
            Me.setFloatingObjectMiddleRightAlignmentItem1.Name = "setFloatingObjectMiddleRightAlignmentItem1"
            ' 
            ' setFloatingObjectBottomLeftAlignmentItem1
            ' 
            Me.setFloatingObjectBottomLeftAlignmentItem1.Id = 258
            Me.setFloatingObjectBottomLeftAlignmentItem1.Name = "setFloatingObjectBottomLeftAlignmentItem1"
            ' 
            ' setFloatingObjectBottomCenterAlignmentItem1
            ' 
            Me.setFloatingObjectBottomCenterAlignmentItem1.Id = 259
            Me.setFloatingObjectBottomCenterAlignmentItem1.Name = "setFloatingObjectBottomCenterAlignmentItem1"
            ' 
            ' setFloatingObjectBottomRightAlignmentItem1
            ' 
            Me.setFloatingObjectBottomRightAlignmentItem1.Id = 260
            Me.setFloatingObjectBottomRightAlignmentItem1.Name = "setFloatingObjectBottomRightAlignmentItem1"
            ' 
            ' floatingObjectBringForwardSubItem1
            ' 
            Me.floatingObjectBringForwardSubItem1.Id = 261
            Me.floatingObjectBringForwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringForwardItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringToFrontItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectBringInFrontOfTextItem1) _
            })
            Me.floatingObjectBringForwardSubItem1.Name = "floatingObjectBringForwardSubItem1"
            ' 
            ' floatingObjectBringForwardItem1
            ' 
            Me.floatingObjectBringForwardItem1.Id = 262
            Me.floatingObjectBringForwardItem1.Name = "floatingObjectBringForwardItem1"
            ' 
            ' floatingObjectBringToFrontItem1
            ' 
            Me.floatingObjectBringToFrontItem1.Id = 263
            Me.floatingObjectBringToFrontItem1.Name = "floatingObjectBringToFrontItem1"
            ' 
            ' floatingObjectBringInFrontOfTextItem1
            ' 
            Me.floatingObjectBringInFrontOfTextItem1.Id = 264
            Me.floatingObjectBringInFrontOfTextItem1.Name = "floatingObjectBringInFrontOfTextItem1"
            ' 
            ' floatingObjectSendBackwardSubItem1
            ' 
            Me.floatingObjectSendBackwardSubItem1.Id = 265
            Me.floatingObjectSendBackwardSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBackwardItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendToBackItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.floatingObjectSendBehindTextItem1) _
            })
            Me.floatingObjectSendBackwardSubItem1.Name = "floatingObjectSendBackwardSubItem1"
            ' 
            ' floatingObjectSendBackwardItem1
            ' 
            Me.floatingObjectSendBackwardItem1.Id = 266
            Me.floatingObjectSendBackwardItem1.Name = "floatingObjectSendBackwardItem1"
            ' 
            ' floatingObjectSendToBackItem1
            ' 
            Me.floatingObjectSendToBackItem1.Id = 267
            Me.floatingObjectSendToBackItem1.Name = "floatingObjectSendToBackItem1"
            ' 
            ' floatingObjectSendBehindTextItem1
            ' 
            Me.floatingObjectSendBehindTextItem1.Id = 268
            Me.floatingObjectSendBehindTextItem1.Name = "floatingObjectSendBehindTextItem1"
            ' 
            ' commandBarCheckItem2
            ' 
            Me.commandBarCheckItem2.Id = 270
            Me.commandBarCheckItem2.Name = "commandBarCheckItem2"
            Me.commandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarCheckItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupByField
            ' 
            ' commandBarCheckItem3
            ' 
            Me.commandBarCheckItem3.Id = 271
            Me.commandBarCheckItem3.Name = "commandBarCheckItem3"
            Me.commandBarCheckItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldAscending
            ' 
            ' commandBarCheckItem4
            ' 
            Me.commandBarCheckItem4.Id = 272
            Me.commandBarCheckItem4.Name = "commandBarCheckItem4"
            Me.commandBarCheckItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapSortFieldDescending
            ' 
            ' commandBarSubItem1
            ' 
            Me.commandBarSubItem1.Id = 273
            Me.commandBarSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem5), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem6), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem7), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem8), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem9) _
            })
            Me.commandBarSubItem1.Name = "commandBarSubItem1"
            Me.commandBarSubItem1.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryByField
            ' 
            ' commandBarCheckItem5
            ' 
            Me.commandBarCheckItem5.Id = 274
            Me.commandBarCheckItem5.Name = "commandBarCheckItem5"
            Me.commandBarCheckItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryCount
            ' 
            ' commandBarCheckItem6
            ' 
            Me.commandBarCheckItem6.Id = 275
            Me.commandBarCheckItem6.Name = "commandBarCheckItem6"
            Me.commandBarCheckItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummarySum
            ' 
            ' commandBarCheckItem7
            ' 
            Me.commandBarCheckItem7.Id = 276
            Me.commandBarCheckItem7.Name = "commandBarCheckItem7"
            Me.commandBarCheckItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryAverage
            ' 
            ' commandBarCheckItem8
            ' 
            Me.commandBarCheckItem8.Id = 277
            Me.commandBarCheckItem8.Name = "commandBarCheckItem8"
            Me.commandBarCheckItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMax
            ' 
            ' commandBarCheckItem9
            ' 
            Me.commandBarCheckItem9.Id = 278
            Me.commandBarCheckItem9.Name = "commandBarCheckItem9"
            Me.commandBarCheckItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SummaryMin
            ' 
            ' filterPopupButtonItem1
            ' 
            Me.filterPopupButtonItem1.ActAsDropDown = True
            Me.filterPopupButtonItem1.Id = 279
            Me.filterPopupButtonItem1.Name = "filterPopupButtonItem1"
            ' 
            ' propertiesBarButtonItem1
            ' 
            Me.propertiesBarButtonItem1.ActAsDropDown = True
            Me.propertiesBarButtonItem1.Id = 280
            Me.propertiesBarButtonItem1.Name = "propertiesBarButtonItem1"
            Me.propertiesBarButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarSubItem2
            ' 
            Me.commandBarSubItem2.Id = 281
            Me.commandBarSubItem2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem10), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem11) _
            })
            Me.commandBarSubItem2.Name = "commandBarSubItem2"
            Me.commandBarSubItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem2.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupHeader
            ' 
            ' commandBarCheckItem10
            ' 
            Me.commandBarCheckItem10.Id = 282
            Me.commandBarCheckItem10.Name = "commandBarCheckItem10"
            Me.commandBarCheckItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupHeader
            ' 
            ' commandBarCheckItem11
            ' 
            Me.commandBarCheckItem11.Id = 283
            Me.commandBarCheckItem11.Name = "commandBarCheckItem11"
            Me.commandBarCheckItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupHeader
            ' 
            ' commandBarSubItem3
            ' 
            Me.commandBarSubItem3.Id = 284
            Me.commandBarSubItem3.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem12), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem13) _
            })
            Me.commandBarSubItem3.Name = "commandBarSubItem3"
            Me.commandBarSubItem3.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFooter
            ' 
            ' commandBarCheckItem12
            ' 
            Me.commandBarCheckItem12.Id = 285
            Me.commandBarCheckItem12.Name = "commandBarCheckItem12"
            Me.commandBarCheckItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupFooter
            ' 
            ' commandBarCheckItem13
            ' 
            Me.commandBarCheckItem13.Id = 286
            Me.commandBarCheckItem13.Name = "commandBarCheckItem13"
            Me.commandBarCheckItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveGroupFooter
            ' 
            ' commandBarItem8
            ' 
            Me.commandBarItem8.Id = 287
            Me.commandBarItem8.Name = "commandBarItem8"
            Me.commandBarItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.GroupFieldsCollection
            ' 
            ' commandBarItem9
            ' 
            Me.commandBarItem9.Id = 288
            Me.commandBarItem9.Name = "commandBarItem9"
            Me.commandBarItem9.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ShowReportStructureEditorForm
            ' 
            ' commandBarSubItem4
            ' 
            Me.commandBarSubItem4.Id = 289
            Me.commandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem15), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem16), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem17), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem18), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem19), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem20) _
            })
            Me.commandBarSubItem4.Name = "commandBarSubItem4"
            Me.commandBarSubItem4.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertGroupSeparator
            ' 
            ' commandBarCheckItem14
            ' 
            Me.commandBarCheckItem14.Id = 290
            Me.commandBarCheckItem14.Name = "commandBarCheckItem14"
            Me.commandBarCheckItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakGroupSeparator
            ' 
            ' commandBarCheckItem15
            ' 
            Me.commandBarCheckItem15.Id = 291
            Me.commandBarCheckItem15.Name = "commandBarCheckItem15"
            Me.commandBarCheckItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageGroupSeparator
            ' 
            ' commandBarCheckItem16
            ' 
            Me.commandBarCheckItem16.Id = 292
            Me.commandBarCheckItem16.Name = "commandBarCheckItem16"
            Me.commandBarCheckItem16.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageGroupSeparator
            ' 
            ' commandBarCheckItem17
            ' 
            Me.commandBarCheckItem17.Id = 293
            Me.commandBarCheckItem17.Name = "commandBarCheckItem17"
            Me.commandBarCheckItem17.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageGroupSeparator
            ' 
            ' commandBarCheckItem18
            ' 
            Me.commandBarCheckItem18.Id = 294
            Me.commandBarCheckItem18.Name = "commandBarCheckItem18"
            Me.commandBarCheckItem18.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphGroupSeparator
            ' 
            ' commandBarCheckItem19
            ' 
            Me.commandBarCheckItem19.Id = 295
            Me.commandBarCheckItem19.Name = "commandBarCheckItem19"
            Me.commandBarCheckItem19.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowGroupSeparator
            ' 
            ' commandBarCheckItem20
            ' 
            Me.commandBarCheckItem20.Id = 296
            Me.commandBarCheckItem20.Name = "commandBarCheckItem20"
            Me.commandBarCheckItem20.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneGroupSeparator
            ' 
            ' commandBarSubItem5
            ' 
            Me.commandBarSubItem5.Id = 298
            Me.commandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem21), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem22) _
            })
            Me.commandBarSubItem5.Name = "commandBarSubItem5"
            Me.commandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem5.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListHeader
            ' 
            ' commandBarCheckItem21
            ' 
            Me.commandBarCheckItem21.Id = 299
            Me.commandBarCheckItem21.Name = "commandBarCheckItem21"
            Me.commandBarCheckItem21.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListHeader
            ' 
            ' commandBarCheckItem22
            ' 
            Me.commandBarCheckItem22.Id = 300
            Me.commandBarCheckItem22.Name = "commandBarCheckItem22"
            Me.commandBarCheckItem22.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListHeader
            ' 
            ' commandBarSubItem6
            ' 
            Me.commandBarSubItem6.Id = 301
            Me.commandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem23), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem24) _
            })
            Me.commandBarSubItem6.Name = "commandBarSubItem6"
            Me.commandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem6.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ListFooter
            ' 
            ' commandBarCheckItem23
            ' 
            Me.commandBarCheckItem23.Id = 302
            Me.commandBarCheckItem23.Name = "commandBarCheckItem23"
            Me.commandBarCheckItem23.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertListFooter
            ' 
            ' commandBarCheckItem24
            ' 
            Me.commandBarCheckItem24.Id = 303
            Me.commandBarCheckItem24.Name = "commandBarCheckItem24"
            Me.commandBarCheckItem24.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.RemoveListFooter
            ' 
            ' commandBarSubItem7
            ' 
            Me.commandBarSubItem7.Id = 304
            Me.commandBarSubItem7.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem25), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem26), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem27), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem28), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem29), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem30), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarCheckItem31) _
            })
            Me.commandBarSubItem7.Name = "commandBarSubItem7"
            Me.commandBarSubItem7.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertDataRowSeparator
            ' 
            ' commandBarCheckItem25
            ' 
            Me.commandBarCheckItem25.Id = 305
            Me.commandBarCheckItem25.Name = "commandBarCheckItem25"
            Me.commandBarCheckItem25.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertPageBreakDataRowSeparator
            ' 
            ' commandBarCheckItem26
            ' 
            Me.commandBarCheckItem26.Id = 306
            Me.commandBarCheckItem26.Name = "commandBarCheckItem26"
            Me.commandBarCheckItem26.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakNextPageDataRowSeparator
            ' 
            ' commandBarCheckItem27
            ' 
            Me.commandBarCheckItem27.Id = 307
            Me.commandBarCheckItem27.Name = "commandBarCheckItem27"
            Me.commandBarCheckItem27.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakEvenPageDataRowSeparator
            ' 
            ' commandBarCheckItem28
            ' 
            Me.commandBarCheckItem28.Id = 308
            Me.commandBarCheckItem28.Name = "commandBarCheckItem28"
            Me.commandBarCheckItem28.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertSectionBreakOddPageDataRowSeparator
            ' 
            ' commandBarCheckItem29
            ' 
            Me.commandBarCheckItem29.Id = 309
            Me.commandBarCheckItem29.Name = "commandBarCheckItem29"
            Me.commandBarCheckItem29.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyParagraphDataRowSeparator
            ' 
            ' commandBarCheckItem30
            ' 
            Me.commandBarCheckItem30.Id = 310
            Me.commandBarCheckItem30.Name = "commandBarCheckItem30"
            Me.commandBarCheckItem30.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertEmptyRowDataRowSeparator
            ' 
            ' commandBarCheckItem31
            ' 
            Me.commandBarCheckItem31.Id = 311
            Me.commandBarCheckItem31.Name = "commandBarCheckItem31"
            Me.commandBarCheckItem31.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.InsertNoneDataRowSeparator
            ' 
            ' commandBarItem10
            ' 
            Me.commandBarItem10.Id = 312
            Me.commandBarItem10.Name = "commandBarItem10"
            Me.commandBarItem10.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FilterList
            ' 
            ' commandBarItem11
            ' 
            Me.commandBarItem11.Id = 313
            Me.commandBarItem11.Name = "commandBarItem11"
            Me.commandBarItem11.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.ConvertToParagraphs
            ' 
            ' commandBarItem12
            ' 
            Me.commandBarItem12.Id = 314
            Me.commandBarItem12.Name = "commandBarItem12"
            Me.commandBarItem12.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.DeleteList
            ' 
            ' barButtonGroup8
            ' 
            Me.barButtonGroup8.Id = 297
            Me.barButtonGroup8.ItemLinks.Add(Me.changeEditorRowLimitItem1)
            Me.barButtonGroup8.Name = "barButtonGroup8"
            Me.barButtonGroup8.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' changeEditorRowLimitItem1
            ' 
            Me.changeEditorRowLimitItem1.Edit = Me.repositoryItemEditorRowLimitEdit1
            Me.changeEditorRowLimitItem1.EditWidth = 90
            Me.changeEditorRowLimitItem1.Id = 315
            Me.changeEditorRowLimitItem1.Name = "changeEditorRowLimitItem1"
            ' 
            ' repositoryItemEditorRowLimitEdit1
            ' 
            Me.repositoryItemEditorRowLimitEdit1.AutoHeight = False
            Me.repositoryItemEditorRowLimitEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemEditorRowLimitEdit1.Control = Me.snapControl1
            Me.repositoryItemEditorRowLimitEdit1.Name = "repositoryItemEditorRowLimitEdit1"
            ' 
            ' createBarBaseItem1
            ' 
            Me.createBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown1
            Me.createBarBaseItem1.Id = 316
            Me.createBarBaseItem1.Name = "createBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown1
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown1.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown1.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroup2DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBarChartItem1, createFullStackedBarChartItem1, createSideBySideFullStackedBarChartItem1, createSideBySideStackedBarChartItem1, createStackedBarChartItem1})
            chartControlCommandGalleryItemGroup3DColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createBar3DChartItem1, createFullStackedBar3DChartItem1, createManhattanBarChartItem1, createSideBySideFullStackedBar3DChartItem1, createSideBySideStackedBar3DChartItem1, createStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupCylinderColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createCylinderBar3DChartItem1, createCylinderFullStackedBar3DChartItem1, createCylinderManhattanBarChartItem1, createCylinderSideBySideFullStackedBar3DChartItem1, createCylinderSideBySideStackedBar3DChartItem1, createCylinderStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupConeColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createConeBar3DChartItem1, createConeFullStackedBar3DChartItem1, createConeManhattanBarChartItem1, createConeSideBySideFullStackedBar3DChartItem1, createConeSideBySideStackedBar3DChartItem1, createConeStackedBar3DChartItem1})
            chartControlCommandGalleryItemGroupPyramidColumn1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPyramidBar3DChartItem1, createPyramidFullStackedBar3DChartItem1, createPyramidManhattanBarChartItem1, createPyramidSideBySideFullStackedBar3DChartItem1, createPyramidSideBySideStackedBar3DChartItem1, createPyramidStackedBar3DChartItem1})
            Me.commandBarGalleryDropDown1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DColumn1, chartControlCommandGalleryItemGroup3DColumn1, chartControlCommandGalleryItemGroupCylinderColumn1, chartControlCommandGalleryItemGroupConeColumn1, chartControlCommandGalleryItemGroupPyramidColumn1})
            Me.commandBarGalleryDropDown1.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown1.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown1.Name = "commandBarGalleryDropDown1"
            Me.commandBarGalleryDropDown1.Ribbon = Me.ribbonControl1
            ' 
            ' createLineBaseItem1
            ' 
            Me.createLineBaseItem1.DropDownControl = Me.commandBarGalleryDropDown2
            Me.createLineBaseItem1.Id = 317
            Me.createLineBaseItem1.Name = "createLineBaseItem1"
            ' 
            ' commandBarGalleryDropDown2
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown2.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown2.Gallery.ColumnCount = 3
            chartControlCommandGalleryItemGroup2DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLineChartItem1, createFullStackedLineChartItem1, createScatterLineChartItem1, createSplineChartItem1, createStackedLineChartItem1, createStepLineChartItem1})
            chartControlCommandGalleryItemGroup3DLine1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createLine3DChartItem1, createFullStackedLine3DChartItem1, createSpline3DChartItem1, createStackedLine3DChartItem1, createStepLine3DChartItem1})
            Me.commandBarGalleryDropDown2.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DLine1, chartControlCommandGalleryItemGroup3DLine1})
            Me.commandBarGalleryDropDown2.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown2.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown2.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown2.Name = "commandBarGalleryDropDown2"
            Me.commandBarGalleryDropDown2.Ribbon = Me.ribbonControl1
            ' 
            ' createPieBaseItem1
            ' 
            Me.createPieBaseItem1.DropDownControl = Me.commandBarGalleryDropDown3
            Me.createPieBaseItem1.Id = 318
            Me.createPieBaseItem1.Name = "createPieBaseItem1"
            ' 
            ' commandBarGalleryDropDown3
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown3.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown3.Gallery.ColumnCount = 3
            chartControlCommandGalleryItemGroup2DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPieChartItem1, createDoughnutChartItem1, createNestedDoughnutChartItem1})
            chartControlCommandGalleryItemGroup3DPie1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPie3DChartItem1, createDoughnut3DChartItem1})
            Me.commandBarGalleryDropDown3.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DPie1, chartControlCommandGalleryItemGroup3DPie1})
            Me.commandBarGalleryDropDown3.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown3.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown3.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown3.Name = "commandBarGalleryDropDown3"
            Me.commandBarGalleryDropDown3.Ribbon = Me.ribbonControl1
            ' 
            ' createRotatedBarBaseItem1
            ' 
            Me.createRotatedBarBaseItem1.DropDownControl = Me.commandBarGalleryDropDown4
            Me.createRotatedBarBaseItem1.Id = 319
            Me.createRotatedBarBaseItem1.Name = "createRotatedBarBaseItem1"
            ' 
            ' commandBarGalleryDropDown4
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown4.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown4.Gallery.ColumnCount = 3
            chartControlCommandGalleryItemGroup2DBar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRotatedBarChartItem1, createRotatedFullStackedBarChartItem1, createRotatedSideBySideFullStackedBarChartItem1, createRotatedSideBySideStackedBarChartItem1, createRotatedStackedBarChartItem1})
            Me.commandBarGalleryDropDown4.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DBar1})
            Me.commandBarGalleryDropDown4.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown4.Gallery.RowCount = 2
            Me.commandBarGalleryDropDown4.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown4.Name = "commandBarGalleryDropDown4"
            Me.commandBarGalleryDropDown4.Ribbon = Me.ribbonControl1
            ' 
            ' createAreaBaseItem1
            ' 
            Me.createAreaBaseItem1.DropDownControl = Me.commandBarGalleryDropDown5
            Me.createAreaBaseItem1.Id = 320
            Me.createAreaBaseItem1.Name = "createAreaBaseItem1"
            ' 
            ' commandBarGalleryDropDown5
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown5.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown5.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroup2DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createAreaChartItem1, createFullStackedAreaChartItem1, createFullStackedSplineAreaChartItem1, createFullStackedStepAreaChartItem1, createSplineAreaChartItem1, createStackedAreaChartItem1, createStackedStepAreaChartItem1, createStackedSplineAreaChartItem1, createStepAreaChartItem1})
            chartControlCommandGalleryItemGroup3DArea1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createArea3DChartItem1, createFullStackedArea3DChartItem1, createFullStackedSplineArea3DChartItem1, createSplineArea3DChartItem1, createStackedArea3DChartItem1, createStackedSplineArea3DChartItem1, createStepArea3DChartItem1})
            Me.commandBarGalleryDropDown5.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroup2DArea1, chartControlCommandGalleryItemGroup3DArea1})
            Me.commandBarGalleryDropDown5.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown5.Gallery.RowCount = 4
            Me.commandBarGalleryDropDown5.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown5.Name = "commandBarGalleryDropDown5"
            Me.commandBarGalleryDropDown5.Ribbon = Me.ribbonControl1
            ' 
            ' createOtherSeriesTypesBaseItem1
            ' 
            Me.createOtherSeriesTypesBaseItem1.DropDownControl = Me.commandBarGalleryDropDown6
            Me.createOtherSeriesTypesBaseItem1.Id = 321
            Me.createOtherSeriesTypesBaseItem1.Name = "createOtherSeriesTypesBaseItem1"
            ' 
            ' commandBarGalleryDropDown6
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown6.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown6.Gallery.ColumnCount = 4
            chartControlCommandGalleryItemGroupPoint1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPointChartItem1, createBubbleChartItem1})
            chartControlCommandGalleryItemGroupFunnel1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createFunnelChartItem1, createFunnel3DChartItem1})
            chartControlCommandGalleryItemGroupFinancial1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createStockChartItem1, createCandleStickChartItem1})
            chartControlCommandGalleryItemGroupRadar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRadarPointChartItem1, createRadarLineChartItem1, createRadarAreaChartItem1, createRadarRangeAreaChartItem1, createScatterRadarLineChartItem1})
            chartControlCommandGalleryItemGroupPolar1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createPolarPointChartItem1, createPolarLineChartItem1, createPolarAreaChartItem1, createPolarRangeAreaChartItem1, createScatterPolarLineChartItem1})
            chartControlCommandGalleryItemGroupRange1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createRangeBarChartItem1, createSideBySideRangeBarChartItem1, createRangeAreaChartItem1, createRangeArea3DChartItem1})
            chartControlCommandGalleryItemGroupGantt1.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { createGanttChartItem1, createSideBySideGanttChartItem1})
            Me.commandBarGalleryDropDown6.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { chartControlCommandGalleryItemGroupPoint1, chartControlCommandGalleryItemGroupFunnel1, chartControlCommandGalleryItemGroupFinancial1, chartControlCommandGalleryItemGroupRadar1, chartControlCommandGalleryItemGroupPolar1, chartControlCommandGalleryItemGroupRange1, chartControlCommandGalleryItemGroupGantt1})
            Me.commandBarGalleryDropDown6.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown6.Gallery.RowCount = 7
            Me.commandBarGalleryDropDown6.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown6.Name = "commandBarGalleryDropDown6"
            Me.commandBarGalleryDropDown6.Ribbon = Me.ribbonControl1
            ' 
            ' changePaletteGalleryBaseItem1
            ' 
            Me.changePaletteGalleryBaseItem1.DropDownControl = Me.commandBarGalleryDropDown7
            Me.changePaletteGalleryBaseItem1.Id = 322
            Me.changePaletteGalleryBaseItem1.Name = "changePaletteGalleryBaseItem1"
            ' 
            ' commandBarGalleryDropDown7
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown7.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemCaptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Hovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Normal.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseFont = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.Options.UseTextOptions = True
            Me.commandBarGalleryDropDown7.Gallery.Appearance.ItemDescriptionAppearance.Pressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.commandBarGalleryDropDown7.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown7.Gallery.ImageSize = New System.Drawing.Size(160, 10)
            Me.commandBarGalleryDropDown7.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.commandBarGalleryDropDown7.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Right
            skinPaddingEdges1.Bottom = -3
            skinPaddingEdges1.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemImagePadding = skinPaddingEdges1
            skinPaddingEdges2.Bottom = -3
            skinPaddingEdges2.Top = -3
            Me.commandBarGalleryDropDown7.Gallery.ItemTextPadding = skinPaddingEdges2
            Me.commandBarGalleryDropDown7.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown7.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown7.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown7.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown7.Name = "commandBarGalleryDropDown7"
            Me.commandBarGalleryDropDown7.Ribbon = Me.ribbonControl1
            ' 
            ' changeAppearanceGalleryBaseItem1
            ' 
            ' 
            ' 
            ' 
            Me.changeAppearanceGalleryBaseItem1.Gallery.ColumnCount = 7
            Me.changeAppearanceGalleryBaseItem1.Gallery.ImageSize = New System.Drawing.Size(80, 50)
            Me.changeAppearanceGalleryBaseItem1.Gallery.RowCount = 4
            Me.changeAppearanceGalleryBaseItem1.Id = 323
            Me.changeAppearanceGalleryBaseItem1.Name = "changeAppearanceGalleryBaseItem1"
            ' 
            ' runDesignerChartItem1
            ' 
            Me.runDesignerChartItem1.Id = 324
            Me.runDesignerChartItem1.Name = "runDesignerChartItem1"
            ' 
            ' mailMergeDataSourceItem1
            ' 
            Me.mailMergeDataSourceItem1.Id = 325
            Me.mailMergeDataSourceItem1.Name = "mailMergeDataSourceItem1"
            ' 
            ' commandBarCheckItem32
            ' 
            Me.commandBarCheckItem32.Id = 326
            Me.commandBarCheckItem32.Name = "commandBarCheckItem32"
            Me.commandBarCheckItem32.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeFilters
            ' 
            ' commandBarCheckItem33
            ' 
            Me.commandBarCheckItem33.Id = 327
            Me.commandBarCheckItem33.Name = "commandBarCheckItem33"
            Me.commandBarCheckItem33.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.MailMergeSorting
            ' 
            ' mailMergeCurrentRecordItem1
            ' 
            Me.mailMergeCurrentRecordItem1.Description = resources.GetString("mailMergeCurrentRecordItem1.Description")
            Me.mailMergeCurrentRecordItem1.Edit = Me.repositoryItemMailMergeCurrentRecordEdit1
            Me.mailMergeCurrentRecordItem1.EditWidth = 90
            Me.mailMergeCurrentRecordItem1.Id = 328
            Me.mailMergeCurrentRecordItem1.Name = "mailMergeCurrentRecordItem1"
            ' 
            ' repositoryItemMailMergeCurrentRecordEdit1
            ' 
            Me.repositoryItemMailMergeCurrentRecordEdit1.AutoHeight = False
            editorButtonImageOptions1.Image = (DirectCast(resources.GetObject("editorButtonImageOptions1.Image"), System.Drawing.Image))
            editorButtonImageOptions1.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            editorButtonImageOptions2.Image = (DirectCast(resources.GetObject("editorButtonImageOptions2.Image"), System.Drawing.Image))
            editorButtonImageOptions2.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
            editorButtonImageOptions3.Image = (DirectCast(resources.GetObject("editorButtonImageOptions3.Image"), System.Drawing.Image))
            editorButtonImageOptions3.Location = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            editorButtonImageOptions4.Image = (DirectCast(resources.GetObject("editorButtonImageOptions4.Image"), System.Drawing.Image))
            editorButtonImageOptions4.Location = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.repositoryItemMailMergeCurrentRecordEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, editorButtonImageOptions1, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Previous", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Prev), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, editorButtonImageOptions2, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Next", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Next), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, True, editorButtonImageOptions3, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "First", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.First), _
                New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", 6, True, True, False, editorButtonImageOptions4, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), "Last", DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordEditorButtonTag.Last) _
            })
            Me.repositoryItemMailMergeCurrentRecordEdit1.Name = "repositoryItemMailMergeCurrentRecordEdit1"
            ' 
            ' commandBarSubItem8
            ' 
            Me.commandBarSubItem8.Id = 329
            Me.commandBarSubItem8.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.commandBarItem15) _
            })
            Me.commandBarSubItem8.Name = "commandBarSubItem8"
            Me.commandBarSubItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            Me.commandBarSubItem8.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.FinishAndMerge
            ' 
            ' commandBarItem13
            ' 
            Me.commandBarItem13.Id = 330
            Me.commandBarItem13.Name = "commandBarItem13"
            Me.commandBarItem13.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergeExportDocument
            ' 
            ' commandBarItem14
            ' 
            Me.commandBarItem14.Id = 331
            Me.commandBarItem14.Name = "commandBarItem14"
            Me.commandBarItem14.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrint
            ' 
            ' commandBarItem15
            ' 
            Me.commandBarItem15.Id = 332
            Me.commandBarItem15.Name = "commandBarItem15"
            Me.commandBarItem15.SnapCommand = DevExpress.Snap.Extensions.UI.SnapCommand.SnapMailMergePrintPreview
            ' 
            ' barBtnSheetToSnap
            ' 
            Me.barBtnSheetToSnap.Caption = "Provide Data to Snap"
            Me.barBtnSheetToSnap.Id = 333
            Me.barBtnSheetToSnap.ImageOptions.Image = (DirectCast(resources.GetObject("barBtnSheetToSnap.ImageOptions.Image"), System.Drawing.Image))
            Me.barBtnSheetToSnap.ImageOptions.LargeImage = (DirectCast(resources.GetObject("barBtnSheetToSnap.ImageOptions.LargeImage"), System.Drawing.Image))
            Me.barBtnSheetToSnap.Name = "barBtnSheetToSnap"
            Me.barBtnSheetToSnap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' barButtonGroup9
            ' 
            Me.barButtonGroup9.Id = 334
            Me.barButtonGroup9.ItemLinks.Add(Me.changeEditorRowLimitItem1)
            Me.barButtonGroup9.Name = "barButtonGroup9"
            Me.barButtonGroup9.Tag = "{97BBE334-159B-44d9-A168-0411957565E8}"
            ' 
            ' spreadsheetCommandBarButtonItem26
            ' 
            Me.spreadsheetCommandBarButtonItem26.CommandName = "PasteSelection"
            Me.spreadsheetCommandBarButtonItem26.Id = 345
            Me.spreadsheetCommandBarButtonItem26.Name = "spreadsheetCommandBarButtonItem26"
            Me.spreadsheetCommandBarButtonItem26.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' spreadsheetCommandBarButtonItem27
            ' 
            Me.spreadsheetCommandBarButtonItem27.CommandName = "CutSelection"
            Me.spreadsheetCommandBarButtonItem27.Id = 346
            Me.spreadsheetCommandBarButtonItem27.Name = "spreadsheetCommandBarButtonItem27"
            Me.spreadsheetCommandBarButtonItem27.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem28
            ' 
            Me.spreadsheetCommandBarButtonItem28.CommandName = "CopySelection"
            Me.spreadsheetCommandBarButtonItem28.Id = 347
            Me.spreadsheetCommandBarButtonItem28.Name = "spreadsheetCommandBarButtonItem28"
            Me.spreadsheetCommandBarButtonItem28.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem29
            ' 
            Me.spreadsheetCommandBarButtonItem29.CommandName = "ShowPasteSpecialForm"
            Me.spreadsheetCommandBarButtonItem29.Id = 348
            Me.spreadsheetCommandBarButtonItem29.Name = "spreadsheetCommandBarButtonItem29"
            Me.spreadsheetCommandBarButtonItem29.RibbonStyle = (CType((DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText Or DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText), DevExpress.XtraBars.Ribbon.RibbonItemStyles))
            ' 
            ' barButtonGroup10
            ' 
            Me.barButtonGroup10.Id = 335
            Me.barButtonGroup10.ItemLinks.Add(Me.changeFontNameItem2)
            Me.barButtonGroup10.ItemLinks.Add(Me.changeFontSizeItem2)
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem30)
            Me.barButtonGroup10.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.barButtonGroup10.Name = "barButtonGroup10"
            Me.barButtonGroup10.Tag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            ' 
            ' changeFontNameItem2
            ' 
            Me.changeFontNameItem2.Edit = Me.repositoryItemFontEdit2
            Me.changeFontNameItem2.Id = 349
            Me.changeFontNameItem2.Name = "changeFontNameItem2"
            ' 
            ' repositoryItemFontEdit2
            ' 
            Me.repositoryItemFontEdit2.AutoHeight = False
            Me.repositoryItemFontEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemFontEdit2.Name = "repositoryItemFontEdit2"
            ' 
            ' changeFontSizeItem2
            ' 
            Me.changeFontSizeItem2.Edit = Me.repositoryItemSpreadsheetFontSizeEdit1
            Me.changeFontSizeItem2.Id = 350
            Me.changeFontSizeItem2.Name = "changeFontSizeItem2"
            ' 
            ' repositoryItemSpreadsheetFontSizeEdit1
            ' 
            Me.repositoryItemSpreadsheetFontSizeEdit1.AutoHeight = False
            Me.repositoryItemSpreadsheetFontSizeEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemSpreadsheetFontSizeEdit1.Control = Me.spreadsheetControl1
            Me.repositoryItemSpreadsheetFontSizeEdit1.Name = "repositoryItemSpreadsheetFontSizeEdit1"
            ' 
            ' spreadsheetControl1
            ' 
            Me.spreadsheetControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.spreadsheetControl1.Location = New System.Drawing.Point(0, 0)
            Me.spreadsheetControl1.MenuManager = Me.ribbonControl1
            Me.spreadsheetControl1.Name = "spreadsheetControl1"
            Me.spreadsheetControl1.Options.Import.Csv.Encoding = (DirectCast(resources.GetObject("spreadsheetControl1.Options.Import.Csv.Encoding"), System.Text.Encoding))
            Me.spreadsheetControl1.Options.Import.Txt.Encoding = (DirectCast(resources.GetObject("spreadsheetControl1.Options.Import.Txt.Encoding"), System.Text.Encoding))
            Me.spreadsheetControl1.Size = New System.Drawing.Size(1109, 528)
            Me.spreadsheetControl1.TabIndex = 0
            Me.spreadsheetControl1.Text = "spreadsheetControl1"
            ' 
            ' spreadsheetCommandBarButtonItem30
            ' 
            Me.spreadsheetCommandBarButtonItem30.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem30.CommandName = "FormatIncreaseFontSize"
            Me.spreadsheetCommandBarButtonItem30.Id = 351
            Me.spreadsheetCommandBarButtonItem30.Name = "spreadsheetCommandBarButtonItem30"
            Me.spreadsheetCommandBarButtonItem30.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem31
            ' 
            Me.spreadsheetCommandBarButtonItem31.ButtonGroupTag = "{B0CA3FA8-82D6-4BC4-BD31-D9AE56C1D033}"
            Me.spreadsheetCommandBarButtonItem31.CommandName = "FormatDecreaseFontSize"
            Me.spreadsheetCommandBarButtonItem31.Id = 352
            Me.spreadsheetCommandBarButtonItem31.Name = "spreadsheetCommandBarButtonItem31"
            Me.spreadsheetCommandBarButtonItem31.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup11
            ' 
            Me.barButtonGroup11.Id = 336
            Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.barButtonGroup11.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.barButtonGroup11.Name = "barButtonGroup11"
            Me.barButtonGroup11.Tag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            ' 
            ' spreadsheetCommandBarCheckItem2
            ' 
            Me.spreadsheetCommandBarCheckItem2.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem2.CommandName = "FormatFontBold"
            Me.spreadsheetCommandBarCheckItem2.Id = 353
            Me.spreadsheetCommandBarCheckItem2.Name = "spreadsheetCommandBarCheckItem2"
            Me.spreadsheetCommandBarCheckItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem3
            ' 
            Me.spreadsheetCommandBarCheckItem3.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem3.CommandName = "FormatFontItalic"
            Me.spreadsheetCommandBarCheckItem3.Id = 354
            Me.spreadsheetCommandBarCheckItem3.Name = "spreadsheetCommandBarCheckItem3"
            Me.spreadsheetCommandBarCheckItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem4
            ' 
            Me.spreadsheetCommandBarCheckItem4.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem4.CommandName = "FormatFontUnderline"
            Me.spreadsheetCommandBarCheckItem4.Id = 355
            Me.spreadsheetCommandBarCheckItem4.Name = "spreadsheetCommandBarCheckItem4"
            Me.spreadsheetCommandBarCheckItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem5
            ' 
            Me.spreadsheetCommandBarCheckItem5.ButtonGroupTag = "{56C139FB-52E5-405B-A03F-FA7DCABD1D17}"
            Me.spreadsheetCommandBarCheckItem5.CommandName = "FormatFontStrikeout"
            Me.spreadsheetCommandBarCheckItem5.Id = 356
            Me.spreadsheetCommandBarCheckItem5.Name = "spreadsheetCommandBarCheckItem5"
            Me.spreadsheetCommandBarCheckItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup12
            ' 
            Me.barButtonGroup12.Id = 337
            Me.barButtonGroup12.ItemLinks.Add(Me.spreadsheetCommandBarSubItem4)
            Me.barButtonGroup12.Name = "barButtonGroup12"
            Me.barButtonGroup12.Tag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            ' 
            ' spreadsheetCommandBarSubItem4
            ' 
            Me.spreadsheetCommandBarSubItem4.ButtonGroupTag = "{DDB05A32-9207-4556-85CB-FE3403A197C7}"
            Me.spreadsheetCommandBarSubItem4.CommandName = "FormatBordersCommandGroup"
            Me.spreadsheetCommandBarSubItem4.Id = 357
            Me.spreadsheetCommandBarSubItem4.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem32), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem33), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem34), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem35), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem36), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem37), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem38), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem39), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem40), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem41), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem42), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem43), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem44), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineColorItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeBorderLineStyleItem1) _
            })
            Me.spreadsheetCommandBarSubItem4.Name = "spreadsheetCommandBarSubItem4"
            Me.spreadsheetCommandBarSubItem4.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem32
            ' 
            Me.spreadsheetCommandBarButtonItem32.CommandName = "FormatBottomBorder"
            Me.spreadsheetCommandBarButtonItem32.Id = 358
            Me.spreadsheetCommandBarButtonItem32.Name = "spreadsheetCommandBarButtonItem32"
            ' 
            ' spreadsheetCommandBarButtonItem33
            ' 
            Me.spreadsheetCommandBarButtonItem33.CommandName = "FormatTopBorder"
            Me.spreadsheetCommandBarButtonItem33.Id = 359
            Me.spreadsheetCommandBarButtonItem33.Name = "spreadsheetCommandBarButtonItem33"
            ' 
            ' spreadsheetCommandBarButtonItem34
            ' 
            Me.spreadsheetCommandBarButtonItem34.CommandName = "FormatLeftBorder"
            Me.spreadsheetCommandBarButtonItem34.Id = 360
            Me.spreadsheetCommandBarButtonItem34.Name = "spreadsheetCommandBarButtonItem34"
            ' 
            ' spreadsheetCommandBarButtonItem35
            ' 
            Me.spreadsheetCommandBarButtonItem35.CommandName = "FormatRightBorder"
            Me.spreadsheetCommandBarButtonItem35.Id = 361
            Me.spreadsheetCommandBarButtonItem35.Name = "spreadsheetCommandBarButtonItem35"
            ' 
            ' spreadsheetCommandBarButtonItem36
            ' 
            Me.spreadsheetCommandBarButtonItem36.CommandName = "FormatNoBorders"
            Me.spreadsheetCommandBarButtonItem36.Id = 362
            Me.spreadsheetCommandBarButtonItem36.Name = "spreadsheetCommandBarButtonItem36"
            ' 
            ' spreadsheetCommandBarButtonItem37
            ' 
            Me.spreadsheetCommandBarButtonItem37.CommandName = "FormatAllBorders"
            Me.spreadsheetCommandBarButtonItem37.Id = 363
            Me.spreadsheetCommandBarButtonItem37.Name = "spreadsheetCommandBarButtonItem37"
            ' 
            ' spreadsheetCommandBarButtonItem38
            ' 
            Me.spreadsheetCommandBarButtonItem38.CommandName = "FormatOutsideBorders"
            Me.spreadsheetCommandBarButtonItem38.Id = 364
            Me.spreadsheetCommandBarButtonItem38.Name = "spreadsheetCommandBarButtonItem38"
            ' 
            ' spreadsheetCommandBarButtonItem39
            ' 
            Me.spreadsheetCommandBarButtonItem39.CommandName = "FormatThickBorder"
            Me.spreadsheetCommandBarButtonItem39.Id = 365
            Me.spreadsheetCommandBarButtonItem39.Name = "spreadsheetCommandBarButtonItem39"
            ' 
            ' spreadsheetCommandBarButtonItem40
            ' 
            Me.spreadsheetCommandBarButtonItem40.CommandName = "FormatBottomDoubleBorder"
            Me.spreadsheetCommandBarButtonItem40.Id = 366
            Me.spreadsheetCommandBarButtonItem40.Name = "spreadsheetCommandBarButtonItem40"
            ' 
            ' spreadsheetCommandBarButtonItem41
            ' 
            Me.spreadsheetCommandBarButtonItem41.CommandName = "FormatBottomThickBorder"
            Me.spreadsheetCommandBarButtonItem41.Id = 367
            Me.spreadsheetCommandBarButtonItem41.Name = "spreadsheetCommandBarButtonItem41"
            ' 
            ' spreadsheetCommandBarButtonItem42
            ' 
            Me.spreadsheetCommandBarButtonItem42.CommandName = "FormatTopAndBottomBorder"
            Me.spreadsheetCommandBarButtonItem42.Id = 368
            Me.spreadsheetCommandBarButtonItem42.Name = "spreadsheetCommandBarButtonItem42"
            ' 
            ' spreadsheetCommandBarButtonItem43
            ' 
            Me.spreadsheetCommandBarButtonItem43.CommandName = "FormatTopAndThickBottomBorder"
            Me.spreadsheetCommandBarButtonItem43.Id = 369
            Me.spreadsheetCommandBarButtonItem43.Name = "spreadsheetCommandBarButtonItem43"
            ' 
            ' spreadsheetCommandBarButtonItem44
            ' 
            Me.spreadsheetCommandBarButtonItem44.CommandName = "FormatTopAndDoubleBottomBorder"
            Me.spreadsheetCommandBarButtonItem44.Id = 370
            Me.spreadsheetCommandBarButtonItem44.Name = "spreadsheetCommandBarButtonItem44"
            ' 
            ' changeBorderLineColorItem1
            ' 
            Me.changeBorderLineColorItem1.ActAsDropDown = True
            Me.changeBorderLineColorItem1.Id = 371
            Me.changeBorderLineColorItem1.Name = "changeBorderLineColorItem1"
            ' 
            ' changeBorderLineStyleItem1
            ' 
            Me.changeBorderLineStyleItem1.DropDownControl = Me.commandBarGalleryDropDown8
            Me.changeBorderLineStyleItem1.Id = 372
            Me.changeBorderLineStyleItem1.Name = "changeBorderLineStyleItem1"
            ' 
            ' commandBarGalleryDropDown8
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown8.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown8.Gallery.ColumnCount = 1
            Me.commandBarGalleryDropDown8.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown8.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.commandBarGalleryDropDown8.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown8.Gallery.ItemSize = New System.Drawing.Size(136, 26)
            Me.commandBarGalleryDropDown8.Gallery.RowCount = 14
            Me.commandBarGalleryDropDown8.Gallery.ShowGroupCaption = False
            Me.commandBarGalleryDropDown8.Gallery.ShowItemText = True
            Me.commandBarGalleryDropDown8.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown8.Name = "commandBarGalleryDropDown8"
            Me.commandBarGalleryDropDown8.Ribbon = Me.ribbonControl1
            ' 
            ' barButtonGroup13
            ' 
            Me.barButtonGroup13.Id = 338
            Me.barButtonGroup13.ItemLinks.Add(Me.changeCellFillColorItem1)
            Me.barButtonGroup13.ItemLinks.Add(Me.changeFontColorItem2)
            Me.barButtonGroup13.Name = "barButtonGroup13"
            Me.barButtonGroup13.Tag = "{C2275623-04A3-41E8-8D6A-EB5C7F8541D1}"
            ' 
            ' changeCellFillColorItem1
            ' 
            Me.changeCellFillColorItem1.Id = 373
            Me.changeCellFillColorItem1.Name = "changeCellFillColorItem1"
            ' 
            ' changeFontColorItem2
            ' 
            Me.changeFontColorItem2.Id = 374
            Me.changeFontColorItem2.Name = "changeFontColorItem2"
            ' 
            ' barButtonGroup14
            ' 
            Me.barButtonGroup14.Id = 339
            Me.barButtonGroup14.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.barButtonGroup14.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.barButtonGroup14.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.barButtonGroup14.Name = "barButtonGroup14"
            Me.barButtonGroup14.Tag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            ' 
            ' spreadsheetCommandBarCheckItem6
            ' 
            Me.spreadsheetCommandBarCheckItem6.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem6.CommandName = "FormatAlignmentTop"
            Me.spreadsheetCommandBarCheckItem6.Id = 375
            Me.spreadsheetCommandBarCheckItem6.Name = "spreadsheetCommandBarCheckItem6"
            Me.spreadsheetCommandBarCheckItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem7
            ' 
            Me.spreadsheetCommandBarCheckItem7.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem7.CommandName = "FormatAlignmentMiddle"
            Me.spreadsheetCommandBarCheckItem7.Id = 376
            Me.spreadsheetCommandBarCheckItem7.Name = "spreadsheetCommandBarCheckItem7"
            Me.spreadsheetCommandBarCheckItem7.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem8
            ' 
            Me.spreadsheetCommandBarCheckItem8.ButtonGroupTag = "{03A0322B-12A2-4434-A487-8B5AAF64CCFC}"
            Me.spreadsheetCommandBarCheckItem8.CommandName = "FormatAlignmentBottom"
            Me.spreadsheetCommandBarCheckItem8.Id = 377
            Me.spreadsheetCommandBarCheckItem8.Name = "spreadsheetCommandBarCheckItem8"
            Me.spreadsheetCommandBarCheckItem8.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup15
            ' 
            Me.barButtonGroup15.Id = 340
            Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.barButtonGroup15.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.barButtonGroup15.Name = "barButtonGroup15"
            Me.barButtonGroup15.Tag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            ' 
            ' spreadsheetCommandBarCheckItem9
            ' 
            Me.spreadsheetCommandBarCheckItem9.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem9.CommandName = "FormatAlignmentLeft"
            Me.spreadsheetCommandBarCheckItem9.Id = 378
            Me.spreadsheetCommandBarCheckItem9.Name = "spreadsheetCommandBarCheckItem9"
            Me.spreadsheetCommandBarCheckItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem10
            ' 
            Me.spreadsheetCommandBarCheckItem10.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem10.CommandName = "FormatAlignmentCenter"
            Me.spreadsheetCommandBarCheckItem10.Id = 379
            Me.spreadsheetCommandBarCheckItem10.Name = "spreadsheetCommandBarCheckItem10"
            Me.spreadsheetCommandBarCheckItem10.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem11
            ' 
            Me.spreadsheetCommandBarCheckItem11.ButtonGroupTag = "{ECC693B7-EF59-4007-A0DB-A9550214A0F2}"
            Me.spreadsheetCommandBarCheckItem11.CommandName = "FormatAlignmentRight"
            Me.spreadsheetCommandBarCheckItem11.Id = 380
            Me.spreadsheetCommandBarCheckItem11.Name = "spreadsheetCommandBarCheckItem11"
            Me.spreadsheetCommandBarCheckItem11.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup16
            ' 
            Me.barButtonGroup16.Id = 341
            Me.barButtonGroup16.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem45)
            Me.barButtonGroup16.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem46)
            Me.barButtonGroup16.Name = "barButtonGroup16"
            Me.barButtonGroup16.Tag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            ' 
            ' spreadsheetCommandBarButtonItem45
            ' 
            Me.spreadsheetCommandBarButtonItem45.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem45.CommandName = "FormatDecreaseIndent"
            Me.spreadsheetCommandBarButtonItem45.Id = 381
            Me.spreadsheetCommandBarButtonItem45.Name = "spreadsheetCommandBarButtonItem45"
            Me.spreadsheetCommandBarButtonItem45.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem46
            ' 
            Me.spreadsheetCommandBarButtonItem46.ButtonGroupTag = "{A5E37DED-106E-44FC-8044-CE3824C08225}"
            Me.spreadsheetCommandBarButtonItem46.CommandName = "FormatIncreaseIndent"
            Me.spreadsheetCommandBarButtonItem46.Id = 382
            Me.spreadsheetCommandBarButtonItem46.Name = "spreadsheetCommandBarButtonItem46"
            Me.spreadsheetCommandBarButtonItem46.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarCheckItem12
            ' 
            Me.spreadsheetCommandBarCheckItem12.CommandName = "FormatWrapText"
            Me.spreadsheetCommandBarCheckItem12.Id = 383
            Me.spreadsheetCommandBarCheckItem12.Name = "spreadsheetCommandBarCheckItem12"
            Me.spreadsheetCommandBarCheckItem12.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarSubItem5
            ' 
            Me.spreadsheetCommandBarSubItem5.CommandName = "EditingMergeCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem5.Id = 384
            Me.spreadsheetCommandBarSubItem5.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem47), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem48), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem49) _
            })
            Me.spreadsheetCommandBarSubItem5.Name = "spreadsheetCommandBarSubItem5"
            Me.spreadsheetCommandBarSubItem5.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarCheckItem13
            ' 
            Me.spreadsheetCommandBarCheckItem13.CommandName = "EditingMergeAndCenterCells"
            Me.spreadsheetCommandBarCheckItem13.Id = 385
            Me.spreadsheetCommandBarCheckItem13.Name = "spreadsheetCommandBarCheckItem13"
            ' 
            ' spreadsheetCommandBarButtonItem47
            ' 
            Me.spreadsheetCommandBarButtonItem47.CommandName = "EditingMergeCellsAcross"
            Me.spreadsheetCommandBarButtonItem47.Id = 386
            Me.spreadsheetCommandBarButtonItem47.Name = "spreadsheetCommandBarButtonItem47"
            ' 
            ' spreadsheetCommandBarButtonItem48
            ' 
            Me.spreadsheetCommandBarButtonItem48.CommandName = "EditingMergeCells"
            Me.spreadsheetCommandBarButtonItem48.Id = 387
            Me.spreadsheetCommandBarButtonItem48.Name = "spreadsheetCommandBarButtonItem48"
            ' 
            ' spreadsheetCommandBarButtonItem49
            ' 
            Me.spreadsheetCommandBarButtonItem49.CommandName = "EditingUnmergeCells"
            Me.spreadsheetCommandBarButtonItem49.Id = 388
            Me.spreadsheetCommandBarButtonItem49.Name = "spreadsheetCommandBarButtonItem49"
            ' 
            ' barButtonGroup17
            ' 
            Me.barButtonGroup17.Id = 342
            Me.barButtonGroup17.ItemLinks.Add(Me.changeNumberFormatItem1)
            Me.barButtonGroup17.Name = "barButtonGroup17"
            Me.barButtonGroup17.Tag = "{0B3A7A43-3079-4ce0-83A8-3789F5F6DC9F}"
            ' 
            ' changeNumberFormatItem1
            ' 
            Me.changeNumberFormatItem1.Edit = Me.repositoryItemPopupGalleryEdit1
            Me.changeNumberFormatItem1.Id = 389
            Me.changeNumberFormatItem1.Name = "changeNumberFormatItem1"
            ' 
            ' repositoryItemPopupGalleryEdit1
            ' 
            Me.repositoryItemPopupGalleryEdit1.AutoHeight = False
            Me.repositoryItemPopupGalleryEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            ' 
            ' 
            ' 
            Me.repositoryItemPopupGalleryEdit1.Gallery.AllowFilter = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.AutoFitColumns = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ColumnCount = 1
            Me.repositoryItemPopupGalleryEdit1.Gallery.FixedImageSize = False
            spreadsheetCommandGalleryItem13.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem13.CaptionAsValue = True
            spreadsheetCommandGalleryItem13.CommandName = "FormatNumberGeneral"
            spreadsheetCommandGalleryItem13.IsEmptyHint = True
            spreadsheetCommandGalleryItem14.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem14.CaptionAsValue = True
            spreadsheetCommandGalleryItem14.CommandName = "FormatNumberDecimal"
            spreadsheetCommandGalleryItem14.IsEmptyHint = True
            spreadsheetCommandGalleryItem15.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem15.CaptionAsValue = True
            spreadsheetCommandGalleryItem15.CommandName = "FormatNumberAccountingCurrency"
            spreadsheetCommandGalleryItem15.IsEmptyHint = True
            spreadsheetCommandGalleryItem16.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem16.CaptionAsValue = True
            spreadsheetCommandGalleryItem16.CommandName = "FormatNumberAccountingRegular"
            spreadsheetCommandGalleryItem16.IsEmptyHint = True
            spreadsheetCommandGalleryItem17.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem17.CaptionAsValue = True
            spreadsheetCommandGalleryItem17.CommandName = "FormatNumberShortDate"
            spreadsheetCommandGalleryItem17.IsEmptyHint = True
            spreadsheetCommandGalleryItem18.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem18.CaptionAsValue = True
            spreadsheetCommandGalleryItem18.CommandName = "FormatNumberLongDate"
            spreadsheetCommandGalleryItem18.IsEmptyHint = True
            spreadsheetCommandGalleryItem19.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem19.CaptionAsValue = True
            spreadsheetCommandGalleryItem19.CommandName = "FormatNumberTime"
            spreadsheetCommandGalleryItem19.IsEmptyHint = True
            spreadsheetCommandGalleryItem20.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem20.CaptionAsValue = True
            spreadsheetCommandGalleryItem20.CommandName = "FormatNumberPercentage"
            spreadsheetCommandGalleryItem20.IsEmptyHint = True
            spreadsheetCommandGalleryItem21.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem21.CaptionAsValue = True
            spreadsheetCommandGalleryItem21.CommandName = "FormatNumberFraction"
            spreadsheetCommandGalleryItem21.IsEmptyHint = True
            spreadsheetCommandGalleryItem22.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem22.CaptionAsValue = True
            spreadsheetCommandGalleryItem22.CommandName = "FormatNumberScientific"
            spreadsheetCommandGalleryItem22.IsEmptyHint = True
            spreadsheetCommandGalleryItem23.AlwaysUpdateDescription = True
            spreadsheetCommandGalleryItem23.CaptionAsValue = True
            spreadsheetCommandGalleryItem23.CommandName = "FormatNumberText"
            spreadsheetCommandGalleryItem23.IsEmptyHint = True
            galleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem13, spreadsheetCommandGalleryItem14, spreadsheetCommandGalleryItem15, spreadsheetCommandGalleryItem16, spreadsheetCommandGalleryItem17, spreadsheetCommandGalleryItem18, spreadsheetCommandGalleryItem19, spreadsheetCommandGalleryItem20, spreadsheetCommandGalleryItem21, spreadsheetCommandGalleryItem22, spreadsheetCommandGalleryItem23})
            Me.repositoryItemPopupGalleryEdit1.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { galleryItemGroup4})
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleLeft
            Me.repositoryItemPopupGalleryEdit1.Gallery.ItemImageLocation = DevExpress.Utils.Locations.Left
            Me.repositoryItemPopupGalleryEdit1.Gallery.RowCount = 11
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowGroupCaption = False
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowItemText = True
            Me.repositoryItemPopupGalleryEdit1.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Hide
            Me.repositoryItemPopupGalleryEdit1.Gallery.StretchItems = True
            Me.repositoryItemPopupGalleryEdit1.Name = "repositoryItemPopupGalleryEdit1"
            Me.repositoryItemPopupGalleryEdit1.ShowButtons = False
            Me.repositoryItemPopupGalleryEdit1.ShowPopupCloseButton = False
            Me.repositoryItemPopupGalleryEdit1.ShowSizeGrip = False
            ' 
            ' barButtonGroup18
            ' 
            Me.barButtonGroup18.Id = 343
            Me.barButtonGroup18.ItemLinks.Add(Me.spreadsheetCommandBarSubItem6)
            Me.barButtonGroup18.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem55)
            Me.barButtonGroup18.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem56)
            Me.barButtonGroup18.Name = "barButtonGroup18"
            Me.barButtonGroup18.Tag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            ' 
            ' spreadsheetCommandBarSubItem6
            ' 
            Me.spreadsheetCommandBarSubItem6.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarSubItem6.CommandName = "FormatNumberAccountingCommandGroup"
            Me.spreadsheetCommandBarSubItem6.Id = 390
            Me.spreadsheetCommandBarSubItem6.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem50), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem51), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem52), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem53), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem54) _
            })
            Me.spreadsheetCommandBarSubItem6.Name = "spreadsheetCommandBarSubItem6"
            Me.spreadsheetCommandBarSubItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem50
            ' 
            Me.spreadsheetCommandBarButtonItem50.CommandName = "FormatNumberAccountingUS"
            Me.spreadsheetCommandBarButtonItem50.Id = 391
            Me.spreadsheetCommandBarButtonItem50.Name = "spreadsheetCommandBarButtonItem50"
            ' 
            ' spreadsheetCommandBarButtonItem51
            ' 
            Me.spreadsheetCommandBarButtonItem51.CommandName = "FormatNumberAccountingUK"
            Me.spreadsheetCommandBarButtonItem51.Id = 392
            Me.spreadsheetCommandBarButtonItem51.Name = "spreadsheetCommandBarButtonItem51"
            ' 
            ' spreadsheetCommandBarButtonItem52
            ' 
            Me.spreadsheetCommandBarButtonItem52.CommandName = "FormatNumberAccountingEuro"
            Me.spreadsheetCommandBarButtonItem52.Id = 393
            Me.spreadsheetCommandBarButtonItem52.Name = "spreadsheetCommandBarButtonItem52"
            ' 
            ' spreadsheetCommandBarButtonItem53
            ' 
            Me.spreadsheetCommandBarButtonItem53.CommandName = "FormatNumberAccountingPRC"
            Me.spreadsheetCommandBarButtonItem53.Id = 394
            Me.spreadsheetCommandBarButtonItem53.Name = "spreadsheetCommandBarButtonItem53"
            ' 
            ' spreadsheetCommandBarButtonItem54
            ' 
            Me.spreadsheetCommandBarButtonItem54.CommandName = "FormatNumberAccountingSwiss"
            Me.spreadsheetCommandBarButtonItem54.Id = 395
            Me.spreadsheetCommandBarButtonItem54.Name = "spreadsheetCommandBarButtonItem54"
            ' 
            ' spreadsheetCommandBarButtonItem55
            ' 
            Me.spreadsheetCommandBarButtonItem55.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem55.CommandName = "FormatNumberPercent"
            Me.spreadsheetCommandBarButtonItem55.Id = 396
            Me.spreadsheetCommandBarButtonItem55.Name = "spreadsheetCommandBarButtonItem55"
            Me.spreadsheetCommandBarButtonItem55.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem56
            ' 
            Me.spreadsheetCommandBarButtonItem56.ButtonGroupTag = "{508C2CE6-E1C8-4DD1-BA50-6C210FDB31B0}"
            Me.spreadsheetCommandBarButtonItem56.CommandName = "FormatNumberAccounting"
            Me.spreadsheetCommandBarButtonItem56.Id = 397
            Me.spreadsheetCommandBarButtonItem56.Name = "spreadsheetCommandBarButtonItem56"
            Me.spreadsheetCommandBarButtonItem56.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' barButtonGroup19
            ' 
            Me.barButtonGroup19.Id = 344
            Me.barButtonGroup19.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem57)
            Me.barButtonGroup19.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem58)
            Me.barButtonGroup19.Name = "barButtonGroup19"
            Me.barButtonGroup19.Tag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            ' 
            ' spreadsheetCommandBarButtonItem57
            ' 
            Me.spreadsheetCommandBarButtonItem57.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem57.CommandName = "FormatNumberIncreaseDecimal"
            Me.spreadsheetCommandBarButtonItem57.Id = 398
            Me.spreadsheetCommandBarButtonItem57.Name = "spreadsheetCommandBarButtonItem57"
            Me.spreadsheetCommandBarButtonItem57.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonItem58
            ' 
            Me.spreadsheetCommandBarButtonItem58.ButtonGroupTag = "{BBAB348B-BDB2-487A-A883-EFB9982DC698}"
            Me.spreadsheetCommandBarButtonItem58.CommandName = "FormatNumberDecreaseDecimal"
            Me.spreadsheetCommandBarButtonItem58.Id = 399
            Me.spreadsheetCommandBarButtonItem58.Name = "spreadsheetCommandBarButtonItem58"
            Me.spreadsheetCommandBarButtonItem58.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem2
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.DropDownControl = Me.commandBarGalleryDropDown10
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Id = 417
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.Name = "spreadsheetCommandBarButtonGalleryDropDownItem2"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown10
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown10.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup3.CommandName = "ConditionalFormattingColorScalesCommandGroup"
            spreadsheetCommandGalleryItem24.CommandName = "ConditionalFormattingColorScaleGreenYellowRed"
            spreadsheetCommandGalleryItem25.CommandName = "ConditionalFormattingColorScaleRedYellowGreen"
            spreadsheetCommandGalleryItem26.CommandName = "ConditionalFormattingColorScaleGreenWhiteRed"
            spreadsheetCommandGalleryItem27.CommandName = "ConditionalFormattingColorScaleRedWhiteGreen"
            spreadsheetCommandGalleryItem28.CommandName = "ConditionalFormattingColorScaleBlueWhiteRed"
            spreadsheetCommandGalleryItem29.CommandName = "ConditionalFormattingColorScaleRedWhiteBlue"
            spreadsheetCommandGalleryItem30.CommandName = "ConditionalFormattingColorScaleWhiteRed"
            spreadsheetCommandGalleryItem31.CommandName = "ConditionalFormattingColorScaleRedWhite"
            spreadsheetCommandGalleryItem32.CommandName = "ConditionalFormattingColorScaleGreenWhite"
            spreadsheetCommandGalleryItem33.CommandName = "ConditionalFormattingColorScaleWhiteGreen"
            spreadsheetCommandGalleryItem34.CommandName = "ConditionalFormattingColorScaleGreenYellow"
            spreadsheetCommandGalleryItem35.CommandName = "ConditionalFormattingColorScaleYellowGreen"
            spreadsheetCommandGalleryItemGroup3.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem24, spreadsheetCommandGalleryItem25, spreadsheetCommandGalleryItem26, spreadsheetCommandGalleryItem27, spreadsheetCommandGalleryItem28, spreadsheetCommandGalleryItem29, spreadsheetCommandGalleryItem30, spreadsheetCommandGalleryItem31, spreadsheetCommandGalleryItem32, spreadsheetCommandGalleryItem33, spreadsheetCommandGalleryItem34, spreadsheetCommandGalleryItem35})
            Me.commandBarGalleryDropDown10.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup3})
            Me.commandBarGalleryDropDown10.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown10.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown10.Name = "commandBarGalleryDropDown10"
            Me.commandBarGalleryDropDown10.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonGalleryDropDownItem3
            ' 
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.CommandName = "ConditionalFormattingIconSetsCommandGroup"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.DropDownControl = Me.commandBarGalleryDropDown11
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Id = 418
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.Name = "spreadsheetCommandBarButtonGalleryDropDownItem3"
            Me.spreadsheetCommandBarButtonGalleryDropDownItem3.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large
            ' 
            ' commandBarGalleryDropDown11
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown11.Gallery.AllowFilter = False
            spreadsheetCommandGalleryItemGroup4.CommandName = "ConditionalFormattingIconSetsDirectionalCommandGroup"
            spreadsheetCommandGalleryItem36.CommandName = "ConditionalFormattingIconSetArrows3Colored"
            spreadsheetCommandGalleryItem37.CommandName = "ConditionalFormattingIconSetArrows3Grayed"
            spreadsheetCommandGalleryItem38.CommandName = "ConditionalFormattingIconSetArrows4Colored"
            spreadsheetCommandGalleryItem39.CommandName = "ConditionalFormattingIconSetArrows4Grayed"
            spreadsheetCommandGalleryItem40.CommandName = "ConditionalFormattingIconSetArrows5Colored"
            spreadsheetCommandGalleryItem41.CommandName = "ConditionalFormattingIconSetArrows5Grayed"
            spreadsheetCommandGalleryItem42.CommandName = "ConditionalFormattingIconSetTriangles3"
            spreadsheetCommandGalleryItemGroup4.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem36, spreadsheetCommandGalleryItem37, spreadsheetCommandGalleryItem38, spreadsheetCommandGalleryItem39, spreadsheetCommandGalleryItem40, spreadsheetCommandGalleryItem41, spreadsheetCommandGalleryItem42})
            spreadsheetCommandGalleryItemGroup5.CommandName = "ConditionalFormattingIconSetsShapesCommandGroup"
            spreadsheetCommandGalleryItem43.CommandName = "ConditionalFormattingIconSetTrafficLights3"
            spreadsheetCommandGalleryItem44.CommandName = "ConditionalFormattingIconSetTrafficLights3Rimmed"
            spreadsheetCommandGalleryItem45.CommandName = "ConditionalFormattingIconSetTrafficLights4"
            spreadsheetCommandGalleryItem46.CommandName = "ConditionalFormattingIconSetSigns3"
            spreadsheetCommandGalleryItem47.CommandName = "ConditionalFormattingIconSetRedToBlack"
            spreadsheetCommandGalleryItemGroup5.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem43, spreadsheetCommandGalleryItem44, spreadsheetCommandGalleryItem45, spreadsheetCommandGalleryItem46, spreadsheetCommandGalleryItem47})
            spreadsheetCommandGalleryItemGroup6.CommandName = "ConditionalFormattingIconSetsIndicatorsCommandGroup"
            spreadsheetCommandGalleryItem48.CommandName = "ConditionalFormattingIconSetSymbols3Circled"
            spreadsheetCommandGalleryItem49.CommandName = "ConditionalFormattingIconSetSymbols3"
            spreadsheetCommandGalleryItem50.CommandName = "ConditionalFormattingIconSetFlags3"
            spreadsheetCommandGalleryItemGroup6.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem48, spreadsheetCommandGalleryItem49, spreadsheetCommandGalleryItem50})
            spreadsheetCommandGalleryItemGroup7.CommandName = "ConditionalFormattingIconSetsRatingsCommandGroup"
            spreadsheetCommandGalleryItem51.CommandName = "ConditionalFormattingIconSetStars3"
            spreadsheetCommandGalleryItem52.CommandName = "ConditionalFormattingIconSetRatings4"
            spreadsheetCommandGalleryItem53.CommandName = "ConditionalFormattingIconSetRatings5"
            spreadsheetCommandGalleryItem54.CommandName = "ConditionalFormattingIconSetQuarters5"
            spreadsheetCommandGalleryItem55.CommandName = "ConditionalFormattingIconSetBoxes5"
            spreadsheetCommandGalleryItemGroup7.Items.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItem() { spreadsheetCommandGalleryItem51, spreadsheetCommandGalleryItem52, spreadsheetCommandGalleryItem53, spreadsheetCommandGalleryItem54, spreadsheetCommandGalleryItem55})
            Me.commandBarGalleryDropDown11.Gallery.Groups.AddRange(New DevExpress.XtraBars.Ribbon.GalleryItemGroup() { spreadsheetCommandGalleryItemGroup4, spreadsheetCommandGalleryItemGroup5, spreadsheetCommandGalleryItemGroup6, spreadsheetCommandGalleryItemGroup7})
            Me.commandBarGalleryDropDown11.Gallery.ImageSize = New System.Drawing.Size(32, 32)
            Me.commandBarGalleryDropDown11.Gallery.ShowScrollBar = DevExpress.XtraBars.Ribbon.Gallery.ShowScrollBar.Auto
            Me.commandBarGalleryDropDown11.Name = "commandBarGalleryDropDown11"
            Me.commandBarGalleryDropDown11.Ribbon = Me.ribbonControl1
            ' 
            ' spreadsheetCommandBarButtonItem72
            ' 
            Me.spreadsheetCommandBarButtonItem72.CommandName = "NewConditionalFormattingRule"
            Me.spreadsheetCommandBarButtonItem72.Id = 419
            Me.spreadsheetCommandBarButtonItem72.Name = "spreadsheetCommandBarButtonItem72"
            ' 
            ' spreadsheetCommandBarButtonItem73
            ' 
            Me.spreadsheetCommandBarButtonItem73.CommandName = "ConditionalFormattingRemoveFromSheet"
            Me.spreadsheetCommandBarButtonItem73.Id = 420
            Me.spreadsheetCommandBarButtonItem73.Name = "spreadsheetCommandBarButtonItem73"
            ' 
            ' spreadsheetCommandBarButtonItem74
            ' 
            Me.spreadsheetCommandBarButtonItem74.CommandName = "ConditionalFormattingRemove"
            Me.spreadsheetCommandBarButtonItem74.Id = 421
            Me.spreadsheetCommandBarButtonItem74.Name = "spreadsheetCommandBarButtonItem74"
            ' 
            ' spreadsheetCommandBarSubItem10
            ' 
            Me.spreadsheetCommandBarSubItem10.CommandName = "ConditionalFormattingRemoveCommandGroup"
            Me.spreadsheetCommandBarSubItem10.Id = 422
            Me.spreadsheetCommandBarSubItem10.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem73), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem74) _
            })
            Me.spreadsheetCommandBarSubItem10.Name = "spreadsheetCommandBarSubItem10"
            ' 
            ' galleryFormatAsTableItem1
            ' 
            Me.galleryFormatAsTableItem1.DropDownControl = Me.commandBarGalleryDropDown12
            Me.galleryFormatAsTableItem1.Id = 423
            Me.galleryFormatAsTableItem1.Name = "galleryFormatAsTableItem1"
            ' 
            ' commandBarGalleryDropDown12
            ' 
            ' 
            ' 
            ' 
            Me.commandBarGalleryDropDown12.Gallery.AllowFilter = False
            Me.commandBarGalleryDropDown12.Gallery.ColumnCount = 7
            Me.commandBarGalleryDropDown12.Gallery.DrawImageBackground = False
            Me.commandBarGalleryDropDown12.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.commandBarGalleryDropDown12.Gallery.ItemSize = New System.Drawing.Size(73, 58)
            Me.commandBarGalleryDropDown12.Gallery.RowCount = 10
            Me.commandBarGalleryDropDown12.Name = "commandBarGalleryDropDown12"
            Me.commandBarGalleryDropDown12.Ribbon = Me.ribbonControl1
            ' 
            ' galleryChangeStyleItem2
            ' 
            ' 
            ' 
            ' 
            Me.galleryChangeStyleItem2.Gallery.DrawImageBackground = False
            Me.galleryChangeStyleItem2.Gallery.ImageSize = New System.Drawing.Size(65, 46)
            Me.galleryChangeStyleItem2.Gallery.ItemAutoSizeMode = DevExpress.XtraBars.Ribbon.Gallery.GalleryItemAutoSizeMode.None
            Me.galleryChangeStyleItem2.Gallery.ItemSize = New System.Drawing.Size(106, 28)
            Me.galleryChangeStyleItem2.Gallery.RowCount = 9
            Me.galleryChangeStyleItem2.Gallery.ShowItemText = True
            Me.galleryChangeStyleItem2.Id = 424
            Me.galleryChangeStyleItem2.Name = "galleryChangeStyleItem2"
            ' 
            ' spreadsheetCommandBarSubItem11
            ' 
            Me.spreadsheetCommandBarSubItem11.CommandName = "InsertCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem11.Id = 425
            Me.spreadsheetCommandBarSubItem11.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem75), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem76), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem77) _
            })
            Me.spreadsheetCommandBarSubItem11.Name = "spreadsheetCommandBarSubItem11"
            ' 
            ' spreadsheetCommandBarButtonItem75
            ' 
            Me.spreadsheetCommandBarButtonItem75.CommandName = "InsertSheetRows"
            Me.spreadsheetCommandBarButtonItem75.Id = 426
            Me.spreadsheetCommandBarButtonItem75.Name = "spreadsheetCommandBarButtonItem75"
            ' 
            ' spreadsheetCommandBarButtonItem76
            ' 
            Me.spreadsheetCommandBarButtonItem76.CommandName = "InsertSheetColumns"
            Me.spreadsheetCommandBarButtonItem76.Id = 427
            Me.spreadsheetCommandBarButtonItem76.Name = "spreadsheetCommandBarButtonItem76"
            ' 
            ' spreadsheetCommandBarButtonItem77
            ' 
            Me.spreadsheetCommandBarButtonItem77.CommandName = "InsertSheet"
            Me.spreadsheetCommandBarButtonItem77.Id = 428
            Me.spreadsheetCommandBarButtonItem77.Name = "spreadsheetCommandBarButtonItem77"
            ' 
            ' spreadsheetCommandBarSubItem12
            ' 
            Me.spreadsheetCommandBarSubItem12.CommandName = "RemoveCellsCommandGroup"
            Me.spreadsheetCommandBarSubItem12.Id = 429
            Me.spreadsheetCommandBarSubItem12.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem78), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem79), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem80) _
            })
            Me.spreadsheetCommandBarSubItem12.Name = "spreadsheetCommandBarSubItem12"
            ' 
            ' spreadsheetCommandBarButtonItem78
            ' 
            Me.spreadsheetCommandBarButtonItem78.CommandName = "RemoveSheetRows"
            Me.spreadsheetCommandBarButtonItem78.Id = 430
            Me.spreadsheetCommandBarButtonItem78.Name = "spreadsheetCommandBarButtonItem78"
            ' 
            ' spreadsheetCommandBarButtonItem79
            ' 
            Me.spreadsheetCommandBarButtonItem79.CommandName = "RemoveSheetColumns"
            Me.spreadsheetCommandBarButtonItem79.Id = 431
            Me.spreadsheetCommandBarButtonItem79.Name = "spreadsheetCommandBarButtonItem79"
            ' 
            ' spreadsheetCommandBarButtonItem80
            ' 
            Me.spreadsheetCommandBarButtonItem80.CommandName = "RemoveSheet"
            Me.spreadsheetCommandBarButtonItem80.Id = 432
            Me.spreadsheetCommandBarButtonItem80.Name = "spreadsheetCommandBarButtonItem80"
            ' 
            ' spreadsheetCommandBarSubItem13
            ' 
            Me.spreadsheetCommandBarSubItem13.CommandName = "FormatCommandGroup"
            Me.spreadsheetCommandBarSubItem13.Id = 433
            Me.spreadsheetCommandBarSubItem13.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem81), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem82), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem83), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem84), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem85), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarSubItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem92), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem93), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.changeSheetTabColorItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem94), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem95) _
            })
            Me.spreadsheetCommandBarSubItem13.Name = "spreadsheetCommandBarSubItem13"
            ' 
            ' spreadsheetCommandBarButtonItem81
            ' 
            Me.spreadsheetCommandBarButtonItem81.CommandName = "FormatRowHeight"
            Me.spreadsheetCommandBarButtonItem81.Id = 434
            Me.spreadsheetCommandBarButtonItem81.Name = "spreadsheetCommandBarButtonItem81"
            ' 
            ' spreadsheetCommandBarButtonItem82
            ' 
            Me.spreadsheetCommandBarButtonItem82.CommandName = "FormatAutoFitRowHeight"
            Me.spreadsheetCommandBarButtonItem82.Id = 435
            Me.spreadsheetCommandBarButtonItem82.Name = "spreadsheetCommandBarButtonItem82"
            ' 
            ' spreadsheetCommandBarButtonItem83
            ' 
            Me.spreadsheetCommandBarButtonItem83.CommandName = "FormatColumnWidth"
            Me.spreadsheetCommandBarButtonItem83.Id = 436
            Me.spreadsheetCommandBarButtonItem83.Name = "spreadsheetCommandBarButtonItem83"
            ' 
            ' spreadsheetCommandBarButtonItem84
            ' 
            Me.spreadsheetCommandBarButtonItem84.CommandName = "FormatAutoFitColumnWidth"
            Me.spreadsheetCommandBarButtonItem84.Id = 437
            Me.spreadsheetCommandBarButtonItem84.Name = "spreadsheetCommandBarButtonItem84"
            ' 
            ' spreadsheetCommandBarButtonItem85
            ' 
            Me.spreadsheetCommandBarButtonItem85.CommandName = "FormatDefaultColumnWidth"
            Me.spreadsheetCommandBarButtonItem85.Id = 438
            Me.spreadsheetCommandBarButtonItem85.Name = "spreadsheetCommandBarButtonItem85"
            ' 
            ' spreadsheetCommandBarSubItem14
            ' 
            Me.spreadsheetCommandBarSubItem14.CommandName = "HideAndUnhideCommandGroup"
            Me.spreadsheetCommandBarSubItem14.Id = 445
            Me.spreadsheetCommandBarSubItem14.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem86), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem87), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem88), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem89), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem90), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem91) _
            })
            Me.spreadsheetCommandBarSubItem14.Name = "spreadsheetCommandBarSubItem14"
            ' 
            ' spreadsheetCommandBarButtonItem86
            ' 
            Me.spreadsheetCommandBarButtonItem86.CommandName = "HideRows"
            Me.spreadsheetCommandBarButtonItem86.Id = 439
            Me.spreadsheetCommandBarButtonItem86.Name = "spreadsheetCommandBarButtonItem86"
            ' 
            ' spreadsheetCommandBarButtonItem87
            ' 
            Me.spreadsheetCommandBarButtonItem87.CommandName = "HideColumns"
            Me.spreadsheetCommandBarButtonItem87.Id = 440
            Me.spreadsheetCommandBarButtonItem87.Name = "spreadsheetCommandBarButtonItem87"
            ' 
            ' spreadsheetCommandBarButtonItem88
            ' 
            Me.spreadsheetCommandBarButtonItem88.CommandName = "HideSheet"
            Me.spreadsheetCommandBarButtonItem88.Id = 441
            Me.spreadsheetCommandBarButtonItem88.Name = "spreadsheetCommandBarButtonItem88"
            ' 
            ' spreadsheetCommandBarButtonItem89
            ' 
            Me.spreadsheetCommandBarButtonItem89.CommandName = "UnhideRows"
            Me.spreadsheetCommandBarButtonItem89.Id = 442
            Me.spreadsheetCommandBarButtonItem89.Name = "spreadsheetCommandBarButtonItem89"
            ' 
            ' spreadsheetCommandBarButtonItem90
            ' 
            Me.spreadsheetCommandBarButtonItem90.CommandName = "UnhideColumns"
            Me.spreadsheetCommandBarButtonItem90.Id = 443
            Me.spreadsheetCommandBarButtonItem90.Name = "spreadsheetCommandBarButtonItem90"
            ' 
            ' spreadsheetCommandBarButtonItem91
            ' 
            Me.spreadsheetCommandBarButtonItem91.CommandName = "UnhideSheet"
            Me.spreadsheetCommandBarButtonItem91.Id = 444
            Me.spreadsheetCommandBarButtonItem91.Name = "spreadsheetCommandBarButtonItem91"
            ' 
            ' spreadsheetCommandBarButtonItem92
            ' 
            Me.spreadsheetCommandBarButtonItem92.CommandName = "RenameSheet"
            Me.spreadsheetCommandBarButtonItem92.Id = 446
            Me.spreadsheetCommandBarButtonItem92.Name = "spreadsheetCommandBarButtonItem92"
            ' 
            ' spreadsheetCommandBarButtonItem93
            ' 
            Me.spreadsheetCommandBarButtonItem93.CommandName = "MoveOrCopySheet"
            Me.spreadsheetCommandBarButtonItem93.Id = 447
            Me.spreadsheetCommandBarButtonItem93.Name = "spreadsheetCommandBarButtonItem93"
            ' 
            ' changeSheetTabColorItem1
            ' 
            Me.changeSheetTabColorItem1.ActAsDropDown = True
            Me.changeSheetTabColorItem1.Id = 448
            Me.changeSheetTabColorItem1.Name = "changeSheetTabColorItem1"
            ' 
            ' spreadsheetCommandBarButtonItem94
            ' 
            Me.spreadsheetCommandBarButtonItem94.CommandName = "ReviewProtectSheet"
            Me.spreadsheetCommandBarButtonItem94.Id = 449
            Me.spreadsheetCommandBarButtonItem94.Name = "spreadsheetCommandBarButtonItem94"
            ' 
            ' spreadsheetCommandBarCheckItem14
            ' 
            Me.spreadsheetCommandBarCheckItem14.CommandName = "FormatCellLocked"
            Me.spreadsheetCommandBarCheckItem14.Id = 450
            Me.spreadsheetCommandBarCheckItem14.Name = "spreadsheetCommandBarCheckItem14"
            ' 
            ' spreadsheetCommandBarButtonItem95
            ' 
            Me.spreadsheetCommandBarButtonItem95.CommandName = "FormatCellsContextMenuItem"
            Me.spreadsheetCommandBarButtonItem95.Id = 451
            Me.spreadsheetCommandBarButtonItem95.Name = "spreadsheetCommandBarButtonItem95"
            ' 
            ' spreadsheetCommandBarSubItem15
            ' 
            Me.spreadsheetCommandBarSubItem15.CommandName = "EditingAutoSumCommandGroup"
            Me.spreadsheetCommandBarSubItem15.Id = 452
            Me.spreadsheetCommandBarSubItem15.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem96), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem97), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem98), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem99), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem100) _
            })
            Me.spreadsheetCommandBarSubItem15.Name = "spreadsheetCommandBarSubItem15"
            Me.spreadsheetCommandBarSubItem15.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem96
            ' 
            Me.spreadsheetCommandBarButtonItem96.CommandName = "FunctionsInsertSum"
            Me.spreadsheetCommandBarButtonItem96.Id = 453
            Me.spreadsheetCommandBarButtonItem96.Name = "spreadsheetCommandBarButtonItem96"
            ' 
            ' spreadsheetCommandBarButtonItem97
            ' 
            Me.spreadsheetCommandBarButtonItem97.CommandName = "FunctionsInsertAverage"
            Me.spreadsheetCommandBarButtonItem97.Id = 454
            Me.spreadsheetCommandBarButtonItem97.Name = "spreadsheetCommandBarButtonItem97"
            ' 
            ' spreadsheetCommandBarButtonItem98
            ' 
            Me.spreadsheetCommandBarButtonItem98.CommandName = "FunctionsInsertCountNumbers"
            Me.spreadsheetCommandBarButtonItem98.Id = 455
            Me.spreadsheetCommandBarButtonItem98.Name = "spreadsheetCommandBarButtonItem98"
            ' 
            ' spreadsheetCommandBarButtonItem99
            ' 
            Me.spreadsheetCommandBarButtonItem99.CommandName = "FunctionsInsertMax"
            Me.spreadsheetCommandBarButtonItem99.Id = 456
            Me.spreadsheetCommandBarButtonItem99.Name = "spreadsheetCommandBarButtonItem99"
            ' 
            ' spreadsheetCommandBarButtonItem100
            ' 
            Me.spreadsheetCommandBarButtonItem100.CommandName = "FunctionsInsertMin"
            Me.spreadsheetCommandBarButtonItem100.Id = 457
            Me.spreadsheetCommandBarButtonItem100.Name = "spreadsheetCommandBarButtonItem100"
            ' 
            ' spreadsheetCommandBarSubItem16
            ' 
            Me.spreadsheetCommandBarSubItem16.CommandName = "EditingFillCommandGroup"
            Me.spreadsheetCommandBarSubItem16.Id = 458
            Me.spreadsheetCommandBarSubItem16.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem101), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem102), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem103), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem104) _
            })
            Me.spreadsheetCommandBarSubItem16.Name = "spreadsheetCommandBarSubItem16"
            Me.spreadsheetCommandBarSubItem16.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem101
            ' 
            Me.spreadsheetCommandBarButtonItem101.CommandName = "EditingFillDown"
            Me.spreadsheetCommandBarButtonItem101.Id = 459
            Me.spreadsheetCommandBarButtonItem101.Name = "spreadsheetCommandBarButtonItem101"
            ' 
            ' spreadsheetCommandBarButtonItem102
            ' 
            Me.spreadsheetCommandBarButtonItem102.CommandName = "EditingFillRight"
            Me.spreadsheetCommandBarButtonItem102.Id = 460
            Me.spreadsheetCommandBarButtonItem102.Name = "spreadsheetCommandBarButtonItem102"
            ' 
            ' spreadsheetCommandBarButtonItem103
            ' 
            Me.spreadsheetCommandBarButtonItem103.CommandName = "EditingFillUp"
            Me.spreadsheetCommandBarButtonItem103.Id = 461
            Me.spreadsheetCommandBarButtonItem103.Name = "spreadsheetCommandBarButtonItem103"
            ' 
            ' spreadsheetCommandBarButtonItem104
            ' 
            Me.spreadsheetCommandBarButtonItem104.CommandName = "EditingFillLeft"
            Me.spreadsheetCommandBarButtonItem104.Id = 462
            Me.spreadsheetCommandBarButtonItem104.Name = "spreadsheetCommandBarButtonItem104"
            ' 
            ' spreadsheetCommandBarSubItem17
            ' 
            Me.spreadsheetCommandBarSubItem17.CommandName = "FormatClearCommandGroup"
            Me.spreadsheetCommandBarSubItem17.Id = 463
            Me.spreadsheetCommandBarSubItem17.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem105), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem106), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem107), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem108), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem109), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem110) _
            })
            Me.spreadsheetCommandBarSubItem17.Name = "spreadsheetCommandBarSubItem17"
            Me.spreadsheetCommandBarSubItem17.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText
            ' 
            ' spreadsheetCommandBarButtonItem105
            ' 
            Me.spreadsheetCommandBarButtonItem105.CommandName = "FormatClearAll"
            Me.spreadsheetCommandBarButtonItem105.Id = 464
            Me.spreadsheetCommandBarButtonItem105.Name = "spreadsheetCommandBarButtonItem105"
            ' 
            ' spreadsheetCommandBarButtonItem106
            ' 
            Me.spreadsheetCommandBarButtonItem106.CommandName = "FormatClearFormats"
            Me.spreadsheetCommandBarButtonItem106.Id = 465
            Me.spreadsheetCommandBarButtonItem106.Name = "spreadsheetCommandBarButtonItem106"
            ' 
            ' spreadsheetCommandBarButtonItem107
            ' 
            Me.spreadsheetCommandBarButtonItem107.CommandName = "FormatClearContents"
            Me.spreadsheetCommandBarButtonItem107.Id = 466
            Me.spreadsheetCommandBarButtonItem107.Name = "spreadsheetCommandBarButtonItem107"
            ' 
            ' spreadsheetCommandBarButtonItem108
            ' 
            Me.spreadsheetCommandBarButtonItem108.CommandName = "FormatClearComments"
            Me.spreadsheetCommandBarButtonItem108.Id = 467
            Me.spreadsheetCommandBarButtonItem108.Name = "spreadsheetCommandBarButtonItem108"
            ' 
            ' spreadsheetCommandBarButtonItem109
            ' 
            Me.spreadsheetCommandBarButtonItem109.CommandName = "FormatClearHyperlinks"
            Me.spreadsheetCommandBarButtonItem109.Id = 468
            Me.spreadsheetCommandBarButtonItem109.Name = "spreadsheetCommandBarButtonItem109"
            ' 
            ' spreadsheetCommandBarButtonItem110
            ' 
            Me.spreadsheetCommandBarButtonItem110.CommandName = "FormatRemoveHyperlinks"
            Me.spreadsheetCommandBarButtonItem110.Id = 469
            Me.spreadsheetCommandBarButtonItem110.Name = "spreadsheetCommandBarButtonItem110"
            ' 
            ' spreadsheetCommandBarSubItem18
            ' 
            Me.spreadsheetCommandBarSubItem18.CommandName = "EditingSortAndFilterCommandGroup"
            Me.spreadsheetCommandBarSubItem18.Id = 470
            Me.spreadsheetCommandBarSubItem18.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem12), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem13), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarCheckItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem14), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem15) _
            })
            Me.spreadsheetCommandBarSubItem18.Name = "spreadsheetCommandBarSubItem18"
            ' 
            ' spreadsheetCommandBarSubItem19
            ' 
            Me.spreadsheetCommandBarSubItem19.CommandName = "EditingFindAndSelectCommandGroup"
            Me.spreadsheetCommandBarSubItem19.Id = 471
            Me.spreadsheetCommandBarSubItem19.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem115), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem116), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem117), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem118), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem119), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem120), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.spreadsheetCommandBarButtonItem121) _
            })
            Me.spreadsheetCommandBarSubItem19.Name = "spreadsheetCommandBarSubItem19"
            ' 
            ' spreadsheetCommandBarButtonItem115
            ' 
            Me.spreadsheetCommandBarButtonItem115.CommandName = "EditingFind"
            Me.spreadsheetCommandBarButtonItem115.Id = 472
            Me.spreadsheetCommandBarButtonItem115.Name = "spreadsheetCommandBarButtonItem115"
            ' 
            ' spreadsheetCommandBarButtonItem116
            ' 
            Me.spreadsheetCommandBarButtonItem116.CommandName = "EditingReplace"
            Me.spreadsheetCommandBarButtonItem116.Id = 473
            Me.spreadsheetCommandBarButtonItem116.Name = "spreadsheetCommandBarButtonItem116"
            ' 
            ' spreadsheetCommandBarButtonItem117
            ' 
            Me.spreadsheetCommandBarButtonItem117.CommandName = "EditingSelectFormulas"
            Me.spreadsheetCommandBarButtonItem117.Id = 474
            Me.spreadsheetCommandBarButtonItem117.Name = "spreadsheetCommandBarButtonItem117"
            ' 
            ' spreadsheetCommandBarButtonItem118
            ' 
            Me.spreadsheetCommandBarButtonItem118.CommandName = "EditingSelectComments"
            Me.spreadsheetCommandBarButtonItem118.Id = 475
            Me.spreadsheetCommandBarButtonItem118.Name = "spreadsheetCommandBarButtonItem118"
            ' 
            ' spreadsheetCommandBarButtonItem119
            ' 
            Me.spreadsheetCommandBarButtonItem119.CommandName = "EditingSelectConditionalFormatting"
            Me.spreadsheetCommandBarButtonItem119.Id = 476
            Me.spreadsheetCommandBarButtonItem119.Name = "spreadsheetCommandBarButtonItem119"
            ' 
            ' spreadsheetCommandBarButtonItem120
            ' 
            Me.spreadsheetCommandBarButtonItem120.CommandName = "EditingSelectConstants"
            Me.spreadsheetCommandBarButtonItem120.Id = 477
            Me.spreadsheetCommandBarButtonItem120.Name = "spreadsheetCommandBarButtonItem120"
            ' 
            ' spreadsheetCommandBarButtonItem121
            ' 
            Me.spreadsheetCommandBarButtonItem121.CommandName = "EditingSelectDataValidation"
            Me.spreadsheetCommandBarButtonItem121.Id = 478
            Me.spreadsheetCommandBarButtonItem121.Name = "spreadsheetCommandBarButtonItem121"
            ' 
            ' sheetPageCategory
            ' 
            Me.sheetPageCategory.Name = "sheetPageCategory"
            Me.sheetPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage1, Me.homeRibbonPage2, Me.dataRibbonPage1})
            Me.sheetPageCategory.Text = "Sheet"
            ' 
            ' fileRibbonPage1
            ' 
            Me.fileRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup1})
            Me.fileRibbonPage1.Name = "fileRibbonPage1"
            ' 
            ' commonRibbonPageGroup1
            ' 
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.commonRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.commonRibbonPageGroup1.Name = "commonRibbonPageGroup1"
            ' 
            ' homeRibbonPage2
            ' 
            Me.homeRibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup2, Me.fontRibbonPageGroup2, Me.alignmentRibbonPageGroup1, Me.numberRibbonPageGroup1, Me.stylesRibbonPageGroup2, Me.cellsRibbonPageGroup1, Me.editingRibbonPageGroup2})
            Me.homeRibbonPage2.Name = "homeRibbonPage2"
            reduceOperation1.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation1.Group = Me.stylesRibbonPageGroup2
            reduceOperation1.ItemLinkIndex = 2
            reduceOperation1.ItemLinksCount = 0
            reduceOperation1.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage2.ReduceOperations.Add(reduceOperation1)
            ' 
            ' clipboardRibbonPageGroup2
            ' 
            Me.clipboardRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.clipboardRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.clipboardRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.clipboardRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.clipboardRibbonPageGroup2.Name = "clipboardRibbonPageGroup2"
            ' 
            ' fontRibbonPageGroup2
            ' 
            Me.fontRibbonPageGroup2.ItemLinks.Add(Me.barButtonGroup10)
            Me.fontRibbonPageGroup2.ItemLinks.Add(Me.barButtonGroup11)
            Me.fontRibbonPageGroup2.ItemLinks.Add(Me.barButtonGroup12)
            Me.fontRibbonPageGroup2.ItemLinks.Add(Me.barButtonGroup13)
            Me.fontRibbonPageGroup2.Name = "fontRibbonPageGroup2"
            ' 
            ' alignmentRibbonPageGroup1
            ' 
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup14)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup15)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup16)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarCheckItem12)
            Me.alignmentRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem5)
            Me.alignmentRibbonPageGroup1.Name = "alignmentRibbonPageGroup1"
            ' 
            ' numberRibbonPageGroup1
            ' 
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup17)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup18)
            Me.numberRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup19)
            Me.numberRibbonPageGroup1.Name = "numberRibbonPageGroup1"
            ' 
            ' cellsRibbonPageGroup1
            ' 
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem11)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem12)
            Me.cellsRibbonPageGroup1.ItemLinks.Add(Me.spreadsheetCommandBarSubItem13)
            Me.cellsRibbonPageGroup1.Name = "cellsRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup2
            ' 
            Me.editingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem15)
            Me.editingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem16)
            Me.editingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem17)
            Me.editingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem18)
            Me.editingRibbonPageGroup2.ItemLinks.Add(Me.spreadsheetCommandBarSubItem19)
            Me.editingRibbonPageGroup2.Name = "editingRibbonPageGroup2"
            ' 
            ' dataRibbonPage1
            ' 
            Me.dataRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.ribbonPageGroup1})
            Me.dataRibbonPage1.Name = "dataRibbonPage1"
            ' 
            ' ribbonPageGroup1
            ' 
            Me.ribbonPageGroup1.ItemLinks.Add(Me.barBtnSheetToSnap)
            Me.ribbonPageGroup1.Name = "ribbonPageGroup1"
            Me.ribbonPageGroup1.Text = "Sheet to Snap"
            ' 
            ' snapPageCategory
            ' 
            Me.snapPageCategory.Name = "snapPageCategory"
            Me.snapPageCategory.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.fileRibbonPage2, Me.homeRibbonPage1, Me.insertRibbonPage1, Me.pageLayoutRibbonPage1, Me.viewRibbonPage1, Me.reviewRibbonPage1, Me.referencesRibbonPage1})
            Me.snapPageCategory.Text = "Snap"
            Me.snapPageCategory.Visible = False
            ' 
            ' fileRibbonPage2
            ' 
            Me.fileRibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.commonRibbonPageGroup2, Me.infoRibbonPageGroup2, Me.dataRibbonPageGroup1})
            Me.fileRibbonPage2.Name = "fileRibbonPage2"
            Me.fileRibbonPage2.Visible = False
            ' 
            ' commonRibbonPageGroup2
            ' 
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.undoItem1)
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.redoItem1)
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.fileNewItem1, "N")
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.fileOpenItem1, "O")
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.fileSaveItem1, "S")
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.fileSaveAsItem1, "A")
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.commandBarItem1)
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.quickPrintItem1)
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.printItem1, "P")
            Me.commonRibbonPageGroup2.ItemLinks.Add(Me.printPreviewItem1)
            Me.commonRibbonPageGroup2.Name = "commonRibbonPageGroup2"
            ' 
            ' infoRibbonPageGroup2
            ' 
            Me.infoRibbonPageGroup2.ItemLinks.Add(Me.showDocumentPropertiesFormItem1)
            Me.infoRibbonPageGroup2.Name = "infoRibbonPageGroup2"
            ' 
            ' dataRibbonPageGroup1
            ' 
            Me.dataRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem2)
            Me.dataRibbonPageGroup1.Name = "dataRibbonPageGroup1"
            ' 
            ' homeRibbonPage1
            ' 
            Me.homeRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.clipboardRibbonPageGroup1, Me.fontRibbonPageGroup1, Me.paragraphRibbonPageGroup1, Me.stylesRibbonPageGroup1, Me.editingRibbonPageGroup1})
            Me.homeRibbonPage1.Name = "homeRibbonPage1"
            reduceOperation2.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation2.Group = Me.stylesRibbonPageGroup1
            reduceOperation2.ItemLinkIndex = 0
            reduceOperation2.ItemLinksCount = 0
            reduceOperation2.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.homeRibbonPage1.ReduceOperations.Add(reduceOperation2)
            Me.homeRibbonPage1.Visible = False
            ' 
            ' clipboardRibbonPageGroup1
            ' 
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteItem1, "V")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.cutItem1, "X")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.copyItem1, "C")
            Me.clipboardRibbonPageGroup1.ItemLinks.Add(Me.pasteSpecialItem1)
            Me.clipboardRibbonPageGroup1.Name = "clipboardRibbonPageGroup1"
            ' 
            ' fontRibbonPageGroup1
            ' 
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup2)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup3)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.changeTextCaseItem1)
            Me.fontRibbonPageGroup1.ItemLinks.Add(Me.clearFormattingItem1, "E")
            Me.fontRibbonPageGroup1.Name = "fontRibbonPageGroup1"
            ' 
            ' paragraphRibbonPageGroup1
            ' 
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup4)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup5)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup6)
            Me.paragraphRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup7)
            Me.paragraphRibbonPageGroup1.Name = "paragraphRibbonPageGroup1"
            ' 
            ' editingRibbonPageGroup1
            ' 
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.findItem1, "FD")
            Me.editingRibbonPageGroup1.ItemLinks.Add(Me.replaceItem1, "R")
            Me.editingRibbonPageGroup1.Name = "editingRibbonPageGroup1"
            ' 
            ' insertRibbonPage1
            ' 
            Me.insertRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pagesRibbonPageGroup1, Me.tablesRibbonPageGroup1, Me.illustrationsRibbonPageGroup1, Me.toolboxRibbonPageGroup1, Me.linksRibbonPageGroup1, Me.headerFooterRibbonPageGroup1, Me.textRibbonPageGroup1, Me.symbolsRibbonPageGroup1})
            Me.insertRibbonPage1.Name = "insertRibbonPage1"
            Me.insertRibbonPage1.Visible = False
            ' 
            ' pagesRibbonPageGroup1
            ' 
            Me.pagesRibbonPageGroup1.AllowTextClipping = False
            Me.pagesRibbonPageGroup1.ItemLinks.Add(Me.insertPageBreakItem21, "B")
            Me.pagesRibbonPageGroup1.Name = "pagesRibbonPageGroup1"
            ' 
            ' tablesRibbonPageGroup1
            ' 
            Me.tablesRibbonPageGroup1.AllowTextClipping = False
            Me.tablesRibbonPageGroup1.ItemLinks.Add(Me.insertTableItem1, "T")
            Me.tablesRibbonPageGroup1.Name = "tablesRibbonPageGroup1"
            ' 
            ' illustrationsRibbonPageGroup1
            ' 
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertPictureItem1, "P")
            Me.illustrationsRibbonPageGroup1.ItemLinks.Add(Me.insertFloatingPictureItem1)
            Me.illustrationsRibbonPageGroup1.Name = "illustrationsRibbonPageGroup1"
            ' 
            ' toolboxRibbonPageGroup1
            ' 
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem3)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem4)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem5)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem6)
            Me.toolboxRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem7)
            Me.toolboxRibbonPageGroup1.Name = "toolboxRibbonPageGroup1"
            ' 
            ' linksRibbonPageGroup1
            ' 
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertBookmarkItem1, "K")
            Me.linksRibbonPageGroup1.ItemLinks.Add(Me.insertHyperlinkItem1, "I")
            Me.linksRibbonPageGroup1.Name = "linksRibbonPageGroup1"
            ' 
            ' headerFooterRibbonPageGroup1
            ' 
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageHeaderItem1, "H")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.editPageFooterItem1, "O")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageNumberItem1, "NU")
            Me.headerFooterRibbonPageGroup1.ItemLinks.Add(Me.insertPageCountItem1)
            Me.headerFooterRibbonPageGroup1.Name = "headerFooterRibbonPageGroup1"
            ' 
            ' textRibbonPageGroup1
            ' 
            Me.textRibbonPageGroup1.Glyph = (DirectCast(resources.GetObject("textRibbonPageGroup1.Glyph"), System.Drawing.Image))
            Me.textRibbonPageGroup1.ItemLinks.Add(Me.insertTextBoxItem1, "X")
            Me.textRibbonPageGroup1.Name = "textRibbonPageGroup1"
            ' 
            ' symbolsRibbonPageGroup1
            ' 
            Me.symbolsRibbonPageGroup1.AllowTextClipping = False
            Me.symbolsRibbonPageGroup1.ItemLinks.Add(Me.insertSymbolItem1, "U")
            Me.symbolsRibbonPageGroup1.Name = "symbolsRibbonPageGroup1"
            ' 
            ' pageLayoutRibbonPage1
            ' 
            Me.pageLayoutRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.pageSetupRibbonPageGroup1, Me.pageBackgroundRibbonPageGroup1})
            Me.pageLayoutRibbonPage1.Name = "pageLayoutRibbonPage1"
            Me.pageLayoutRibbonPage1.Visible = False
            ' 
            ' pageSetupRibbonPageGroup1
            ' 
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageMarginsItem1, "M")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPageOrientationItem1, "O")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionPaperKindItem1, "SZ")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionColumnsItem1, "J")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.insertBreakItem1, "B")
            Me.pageSetupRibbonPageGroup1.ItemLinks.Add(Me.changeSectionLineNumberingItem1, "LN")
            Me.pageSetupRibbonPageGroup1.Name = "pageSetupRibbonPageGroup1"
            ' 
            ' pageBackgroundRibbonPageGroup1
            ' 
            Me.pageBackgroundRibbonPageGroup1.AllowTextClipping = False
            Me.pageBackgroundRibbonPageGroup1.ItemLinks.Add(Me.changePageColorItem1, "PC")
            Me.pageBackgroundRibbonPageGroup1.Name = "pageBackgroundRibbonPageGroup1"
            ' 
            ' viewRibbonPage1
            ' 
            Me.viewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentViewsRibbonPageGroup1, Me.showRibbonPageGroup1, Me.zoomRibbonPageGroup1, Me.viewRibbonPageGroup1, Me.viewFieldsRibbonPageGroup1})
            Me.viewRibbonPage1.Name = "viewRibbonPage1"
            Me.viewRibbonPage1.Visible = False
            ' 
            ' documentViewsRibbonPageGroup1
            ' 
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToSimpleViewItem1, "L")
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToDraftViewItem1, "E")
            Me.documentViewsRibbonPageGroup1.ItemLinks.Add(Me.switchToPrintLayoutViewItem1, "P")
            Me.documentViewsRibbonPageGroup1.Name = "documentViewsRibbonPageGroup1"
            ' 
            ' showRibbonPageGroup1
            ' 
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowHorizontalRulerItem1)
            Me.showRibbonPageGroup1.ItemLinks.Add(Me.toggleShowVerticalRulerItem1)
            Me.showRibbonPageGroup1.Name = "showRibbonPageGroup1"
            ' 
            ' zoomRibbonPageGroup1
            ' 
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomOutItem1)
            Me.zoomRibbonPageGroup1.ItemLinks.Add(Me.zoomInItem1)
            Me.zoomRibbonPageGroup1.Name = "zoomRibbonPageGroup1"
            ' 
            ' viewRibbonPageGroup1
            ' 
            Me.viewRibbonPageGroup1.ItemLinks.Add(Me.snapBarToolbarsListItem1)
            Me.viewRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem1)
            Me.viewRibbonPageGroup1.Name = "viewRibbonPageGroup1"
            ' 
            ' viewFieldsRibbonPageGroup1
            ' 
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldCodesItem1)
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.showAllFieldResultsItem1)
            Me.viewFieldsRibbonPageGroup1.ItemLinks.Add(Me.toggleFieldHighlightingItem1)
            Me.viewFieldsRibbonPageGroup1.Name = "viewFieldsRibbonPageGroup1"
            ' 
            ' reviewRibbonPage1
            ' 
            Me.reviewRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.documentProofingRibbonPageGroup1})
            Me.reviewRibbonPage1.Name = "reviewRibbonPage1"
            Me.reviewRibbonPage1.Visible = False
            ' 
            ' documentProofingRibbonPageGroup1
            ' 
            Me.documentProofingRibbonPageGroup1.ItemLinks.Add(Me.checkSpellingItem1, "S")
            Me.documentProofingRibbonPageGroup1.Name = "documentProofingRibbonPageGroup1"
            ' 
            ' referencesRibbonPage1
            ' 
            Me.referencesRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.tableOfContentsRibbonPageGroup1, Me.captionsRibbonPageGroup1})
            Me.referencesRibbonPage1.Name = "referencesRibbonPage1"
            Me.referencesRibbonPage1.Visible = False
            ' 
            ' tableOfContentsRibbonPageGroup1
            ' 
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfContentsItem1, "T")
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfContentsItem1, "U")
            Me.tableOfContentsRibbonPageGroup1.ItemLinks.Add(Me.addParagraphsToTableOfContentItem1, "A")
            Me.tableOfContentsRibbonPageGroup1.Name = "tableOfContentsRibbonPageGroup1"
            ' 
            ' captionsRibbonPageGroup1
            ' 
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertCaptionPlaceholderItem1, "C")
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.insertTableOfFiguresPlaceholderItem1, "G")
            Me.captionsRibbonPageGroup1.ItemLinks.Add(Me.updateTableOfFiguresItem1, "U")
            Me.captionsRibbonPageGroup1.Name = "captionsRibbonPageGroup1"
            ' 
            ' dataToolsRibbonPageCategory1
            ' 
            Me.dataToolsRibbonPageCategory1.Color = System.Drawing.Color.FromArgb((CInt((CByte(31)))), (CInt((CByte(166)))), (CInt((CByte(207)))))
            Me.dataToolsRibbonPageCategory1.Control = Me.snapControl1
            Me.dataToolsRibbonPageCategory1.Name = "dataToolsRibbonPageCategory1"
            Me.dataToolsRibbonPageCategory1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() { Me.snMergeFieldToolsRibbonPage1, Me.groupToolsRibbonPage1, Me.listToolsRibbonPage1, Me.appearanceRibbonPage1})
            Me.dataToolsRibbonPageCategory1.Visible = False
            ' 
            ' snMergeFieldToolsRibbonPage1
            ' 
            Me.snMergeFieldToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.dataShapingRibbonPageGroup1, Me.snMergeFieldPropertiesRibbonPageGroup1})
            Me.snMergeFieldToolsRibbonPage1.Name = "snMergeFieldToolsRibbonPage1"
            Me.snMergeFieldToolsRibbonPage1.Visible = False
            ' 
            ' dataShapingRibbonPageGroup1
            ' 
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem2)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem3)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarCheckItem4)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem1)
            Me.dataShapingRibbonPageGroup1.ItemLinks.Add(Me.filterPopupButtonItem1)
            Me.dataShapingRibbonPageGroup1.Name = "dataShapingRibbonPageGroup1"
            ' 
            ' snMergeFieldPropertiesRibbonPageGroup1
            ' 
            Me.snMergeFieldPropertiesRibbonPageGroup1.ItemLinks.Add(Me.propertiesBarButtonItem1)
            Me.snMergeFieldPropertiesRibbonPageGroup1.Name = "snMergeFieldPropertiesRibbonPageGroup1"
            ' 
            ' groupToolsRibbonPage1
            ' 
            Me.groupToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.groupingRibbonPageGroup1})
            Me.groupToolsRibbonPage1.Name = "groupToolsRibbonPage1"
            Me.groupToolsRibbonPage1.Visible = False
            ' 
            ' groupingRibbonPageGroup1
            ' 
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem2)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem3)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem8)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem9)
            Me.groupingRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem4)
            Me.groupingRibbonPageGroup1.Name = "groupingRibbonPageGroup1"
            ' 
            ' listToolsRibbonPage1
            ' 
            Me.listToolsRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.listHeaderAndFooterRibbonPageGroup1, Me.listCommandsRibbonPageGroup1, Me.listEditorRowLimitRibbonPageGroup1})
            Me.listToolsRibbonPage1.Name = "listToolsRibbonPage1"
            Me.listToolsRibbonPage1.Visible = False
            ' 
            ' listHeaderAndFooterRibbonPageGroup1
            ' 
            Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem5)
            Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem6)
            Me.listHeaderAndFooterRibbonPageGroup1.ItemLinks.Add(Me.commandBarSubItem7)
            Me.listHeaderAndFooterRibbonPageGroup1.Name = "listHeaderAndFooterRibbonPageGroup1"
            ' 
            ' listCommandsRibbonPageGroup1
            ' 
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem10)
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem11)
            Me.listCommandsRibbonPageGroup1.ItemLinks.Add(Me.commandBarItem12)
            Me.listCommandsRibbonPageGroup1.Name = "listCommandsRibbonPageGroup1"
            ' 
            ' listEditorRowLimitRibbonPageGroup1
            ' 
            Me.listEditorRowLimitRibbonPageGroup1.ItemLinks.Add(Me.barButtonGroup9)
            Me.listEditorRowLimitRibbonPageGroup1.Name = "listEditorRowLimitRibbonPageGroup1"
            ' 
            ' appearanceRibbonPage1
            ' 
            Me.appearanceRibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() { Me.themesRibbonPageGroup1})
            Me.appearanceRibbonPage1.Name = "appearanceRibbonPage1"
            reduceOperation3.Behavior = DevExpress.XtraBars.Ribbon.ReduceOperationBehavior.UntilAvailable
            reduceOperation3.Group = Me.themesRibbonPageGroup1
            reduceOperation3.ItemLinkIndex = 0
            reduceOperation3.ItemLinksCount = 0
            reduceOperation3.Operation = DevExpress.XtraBars.Ribbon.ReduceOperationType.Gallery
            Me.appearanceRibbonPage1.ReduceOperations.Add(reduceOperation3)
            Me.appearanceRibbonPage1.Visible = False
            ' 
            ' xtraTabControl1
            ' 
            Me.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.xtraTabControl1.Location = New System.Drawing.Point(0, 146)
            Me.xtraTabControl1.Name = "xtraTabControl1"
            Me.xtraTabControl1.SelectedTabPage = Me.tbSheet
            Me.xtraTabControl1.Size = New System.Drawing.Size(1111, 572)
            Me.xtraTabControl1.TabIndex = 1
            Me.xtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() { Me.tbSheet, Me.tbSnap, Me.tbGauge})
            ' 
            ' tbSheet
            ' 
            Me.tbSheet.Controls.Add(Me.spreadsheetControl1)
            Me.tbSheet.Image = (DirectCast(resources.GetObject("tbSheet.Image"), System.Drawing.Image))
            Me.tbSheet.Name = "tbSheet"
            Me.tbSheet.Size = New System.Drawing.Size(1109, 528)
            Me.tbSheet.Text = "Sheet"
            ' 
            ' tbSnap
            ' 
            Me.tbSnap.Controls.Add(Me.snapControl1)
            Me.tbSnap.Image = (DirectCast(resources.GetObject("tbSnap.Image"), System.Drawing.Image))
            Me.tbSnap.Name = "tbSnap"
            Me.tbSnap.Size = New System.Drawing.Size(1109, 528)
            Me.tbSnap.Text = "Snap"
            ' 
            ' tbGauge
            ' 
            Me.tbGauge.Controls.Add(Me.gridControl1)
            Me.tbGauge.Controls.Add(Me.textBox1)
            Me.tbGauge.Controls.Add(Me.dataNavigator1)
            Me.tbGauge.Controls.Add(Me.gaugeControl1)
            Me.tbGauge.Image = (DirectCast(resources.GetObject("tbGauge.Image"), System.Drawing.Image))
            Me.tbGauge.Name = "tbGauge"
            Me.tbGauge.Size = New System.Drawing.Size(1109, 528)
            Me.tbGauge.Text = "Thermometer"
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.Location = New System.Drawing.Point(260, 40)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.MenuManager = Me.ribbonControl1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(849, 488)
            Me.gridControl1.TabIndex = 3
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' textBox1
            ' 
            Me.textBox1.Font = New System.Drawing.Font("Tahoma", 16F)
            Me.textBox1.Location = New System.Drawing.Point(266, 472)
            Me.textBox1.Multiline = True
            Me.textBox1.Name = "textBox1"
            Me.textBox1.Size = New System.Drawing.Size(429, 72)
            Me.textBox1.TabIndex = 2
            Me.textBox1.Text = "Drag the thermometer column to change worksheet data."
            Me.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
            ' 
            ' dataNavigator1
            ' 
            Me.dataNavigator1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
            Me.dataNavigator1.Dock = System.Windows.Forms.DockStyle.Top
            Me.dataNavigator1.Location = New System.Drawing.Point(260, 0)
            Me.dataNavigator1.Name = "dataNavigator1"
            Me.dataNavigator1.Size = New System.Drawing.Size(849, 40)
            Me.dataNavigator1.TabIndex = 1
            Me.dataNavigator1.Text = "dataNavigator1"
            Me.dataNavigator1.TextLocation = DevExpress.XtraEditors.NavigatorButtonsTextLocation.Center
            ' 
            ' gaugeControl1
            ' 
            Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() { Me.linearGauge1})
            Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
            Me.gaugeControl1.Name = "gaugeControl1"
            Me.gaugeControl1.Size = New System.Drawing.Size(260, 528)
            Me.gaugeControl1.TabIndex = 0
            ' 
            ' linearGauge1
            ' 
            Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() { Me.linearScaleBackgroundLayerComponent1})
            Me.linearGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 248, 516)
            Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() { Me.linearScaleLevelComponent1})
            Me.linearGauge1.Name = "linearGauge1"
            Me.linearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}"
            Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() { Me.linearScaleComponent1})
            ' 
            ' linearScaleBackgroundLayerComponent1
            ' 
            Me.linearScaleBackgroundLayerComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleBackgroundLayerComponent1.Name = "bg1"
            Me.linearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5F, 0.85F)
            Me.linearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style16
            Me.linearScaleBackgroundLayerComponent1.ZOrder = 1000
            ' 
            ' linearScaleComponent1
            ' 
            Me.linearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
            Me.linearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
            Me.linearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
            Me.linearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 38F)
            Me.linearScaleComponent1.MajorTickCount = 6
            Me.linearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
            Me.linearScaleComponent1.MajorTickmark.ShapeOffset = -23F
            Me.linearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_1
            Me.linearScaleComponent1.MajorTickmark.TextOffset = -33F
            Me.linearScaleComponent1.MaxValue = 100F
            Me.linearScaleComponent1.MinorTickCount = 4
            Me.linearScaleComponent1.MinorTickmark.ShapeOffset = -17F
            Me.linearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style16_2
            Me.linearScaleComponent1.Name = "scale1"
            linearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#8CBE5C")
            linearScaleRange1.EndThickness = 13F
            linearScaleRange1.EndValue = 33F
            linearScaleRange1.Name = "Range0"
            linearScaleRange1.ShapeOffset = -23F
            linearScaleRange1.StartThickness = 13F
            linearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#F1C05D")
            linearScaleRange2.EndThickness = 13F
            linearScaleRange2.EndValue = 66F
            linearScaleRange2.Name = "Range1"
            linearScaleRange2.ShapeOffset = -23F
            linearScaleRange2.StartThickness = 13F
            linearScaleRange2.StartValue = 33F
            linearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#ED8D77")
            linearScaleRange3.EndThickness = 13F
            linearScaleRange3.EndValue = 100F
            linearScaleRange3.Name = "Range2"
            linearScaleRange3.ShapeOffset = -23F
            linearScaleRange3.StartThickness = 13F
            linearScaleRange3.StartValue = 66F
            Me.linearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() { linearScaleRange1, linearScaleRange2, linearScaleRange3})
            Me.linearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5F, 212F)
            Me.linearScaleComponent1.Value = 50F
            ' 
            ' linearScaleLevelComponent1
            ' 
            Me.linearScaleLevelComponent1.LinearScale = Me.linearScaleComponent1
            Me.linearScaleLevelComponent1.Name = "level1"
            Me.linearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style16
            Me.linearScaleLevelComponent1.ZOrder = -50
            ' 
            ' spreadsheetBarController1
            ' 
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem20)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem21)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem22)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem23)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem24)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem25)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem26)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem27)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem28)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem29)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontNameItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontSizeItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem30)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem31)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem4)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem32)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem33)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem34)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem35)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem36)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem37)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem38)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem39)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem40)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem41)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem42)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem43)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem44)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeBorderLineStyleItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeCellFillColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeFontColorItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem45)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem46)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem5)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem47)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem48)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem49)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeNumberFormatItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem6)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem50)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem51)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem52)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem53)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem54)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem55)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem56)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem57)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem58)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem7)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem8)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem59)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem60)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem61)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem62)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem63)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem64)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem65)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem9)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem66)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem67)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem68)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem69)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem70)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem71)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonGalleryDropDownItem3)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem72)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem10)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem73)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem74)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryFormatAsTableItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.galleryChangeStyleItem2)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem11)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem75)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem76)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem77)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem12)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem78)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem79)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem80)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem13)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem81)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem82)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem83)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem84)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem85)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem86)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem87)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem88)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem89)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem90)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem91)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem92)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem93)
            Me.spreadsheetBarController1.BarItems.Add(Me.changeSheetTabColorItem1)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem94)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem14)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem95)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem96)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem97)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem98)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem99)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem100)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem16)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem101)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem102)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem103)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem104)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem17)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem105)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem106)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem107)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem108)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem109)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem110)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem18)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem111)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem112)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarCheckItem15)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem113)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem114)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarSubItem19)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem115)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem116)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem117)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem118)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem119)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem120)
            Me.spreadsheetBarController1.BarItems.Add(Me.spreadsheetCommandBarButtonItem121)
            Me.spreadsheetBarController1.Control = Me.spreadsheetControl1
            ' 
            ' spreadsheetCommandBarButtonItem111
            ' 
            Me.spreadsheetCommandBarButtonItem111.CommandName = "DataSortAscending"
            Me.spreadsheetCommandBarButtonItem111.Id = -1
            Me.spreadsheetCommandBarButtonItem111.Name = "spreadsheetCommandBarButtonItem111"
            ' 
            ' spreadsheetCommandBarButtonItem112
            ' 
            Me.spreadsheetCommandBarButtonItem112.CommandName = "DataSortDescending"
            Me.spreadsheetCommandBarButtonItem112.Id = -1
            Me.spreadsheetCommandBarButtonItem112.Name = "spreadsheetCommandBarButtonItem112"
            ' 
            ' spreadsheetCommandBarCheckItem15
            ' 
            Me.spreadsheetCommandBarCheckItem15.CommandName = "DataFilterToggle"
            Me.spreadsheetCommandBarCheckItem15.Id = -1
            Me.spreadsheetCommandBarCheckItem15.Name = "spreadsheetCommandBarCheckItem15"
            ' 
            ' spreadsheetCommandBarButtonItem113
            ' 
            Me.spreadsheetCommandBarButtonItem113.CommandName = "DataFilterClear"
            Me.spreadsheetCommandBarButtonItem113.Id = -1
            Me.spreadsheetCommandBarButtonItem113.Name = "spreadsheetCommandBarButtonItem113"
            ' 
            ' spreadsheetCommandBarButtonItem114
            ' 
            Me.spreadsheetCommandBarButtonItem114.CommandName = "DataFilterReApply"
            Me.spreadsheetCommandBarButtonItem114.Id = -1
            Me.spreadsheetCommandBarButtonItem114.Name = "spreadsheetCommandBarButtonItem114"
            ' 
            ' snapBarController1
            ' 
            Me.snapBarController1.BarItems.Add(Me.undoItem1)
            Me.snapBarController1.BarItems.Add(Me.redoItem1)
            Me.snapBarController1.BarItems.Add(Me.fileNewItem1)
            Me.snapBarController1.BarItems.Add(Me.fileOpenItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveItem1)
            Me.snapBarController1.BarItems.Add(Me.fileSaveAsItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem1)
            Me.snapBarController1.BarItems.Add(Me.quickPrintItem1)
            Me.snapBarController1.BarItems.Add(Me.printItem1)
            Me.snapBarController1.BarItems.Add(Me.printPreviewItem1)
            Me.snapBarController1.BarItems.Add(Me.showDocumentPropertiesFormItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem2)
            Me.snapBarController1.BarItems.Add(Me.pasteItem1)
            Me.snapBarController1.BarItems.Add(Me.cutItem1)
            Me.snapBarController1.BarItems.Add(Me.copyItem1)
            Me.snapBarController1.BarItems.Add(Me.pasteSpecialItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontNameItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontSizeItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeIncreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.fontSizeDecreaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontBoldItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontItalicItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleUnderlineItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontDoubleStrikeoutItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSuperscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFontSubscriptItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFontHighlightColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextUpperCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.makeTextLowerCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.capitalizeEachWordCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTextCaseItem1)
            Me.snapBarController1.BarItems.Add(Me.clearFormattingItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBulletedListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleNumberingListItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleMultiLevelListItem1)
            Me.snapBarController1.BarItems.Add(Me.decreaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.increaseIndentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentLeftItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentCenterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentRightItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphAlignmentJustifyItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowWhitespaceItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphLineSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSingleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSesquialteralParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.setDoubleParagraphSpacingItem1)
            Me.snapBarController1.BarItems.Add(Me.showLineSpacingFormItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingBeforeParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.addSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.removeSpacingAfterParagraphItem1)
            Me.snapBarController1.BarItems.Add(Me.changeParagraphBackColorItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.findItem1)
            Me.snapBarController1.BarItems.Add(Me.replaceItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem21)
            Me.snapBarController1.BarItems.Add(Me.insertTableItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPictureItem1)
            Me.snapBarController1.BarItems.Add(Me.insertFloatingPictureItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem7)
            Me.snapBarController1.BarItems.Add(Me.insertBookmarkItem1)
            Me.snapBarController1.BarItems.Add(Me.insertHyperlinkItem1)
            Me.snapBarController1.BarItems.Add(Me.editPageHeaderItem1)
            Me.snapBarController1.BarItems.Add(Me.editPageFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageNumberItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageCountItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTextBoxItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSymbolItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setNormalSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setNarrowSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setModerateSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.setWideSectionPageMarginsItem1)
            Me.snapBarController1.BarItems.Add(Me.showPageMarginsSetupFormItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.setPortraitPageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.setLandscapePageOrientationItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionPaperKindItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionOneColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionTwoColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionThreeColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.showColumnsSetupFormItem1)
            Me.snapBarController1.BarItems.Add(Me.insertBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertPageBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertColumnBreakItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakNextPageItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakEvenPageItem1)
            Me.snapBarController1.BarItems.Add(Me.insertSectionBreakOddPageItem1)
            Me.snapBarController1.BarItems.Add(Me.changeSectionLineNumberingItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingNoneItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingContinuousItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewPageItem1)
            Me.snapBarController1.BarItems.Add(Me.setSectionLineNumberingRestartNewSectionItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleParagraphSuppressLineNumbersItem1)
            Me.snapBarController1.BarItems.Add(Me.showLineNumberingFormItem1)
            Me.snapBarController1.BarItems.Add(Me.changePageColorItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToSimpleViewItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToDraftViewItem1)
            Me.snapBarController1.BarItems.Add(Me.switchToPrintLayoutViewItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowHorizontalRulerItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowVerticalRulerItem1)
            Me.snapBarController1.BarItems.Add(Me.zoomOutItem1)
            Me.snapBarController1.BarItems.Add(Me.zoomInItem1)
            Me.snapBarController1.BarItems.Add(Me.snapBarToolbarsListItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldCodesItem1)
            Me.snapBarController1.BarItems.Add(Me.showAllFieldResultsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFieldHighlightingItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPageHeaderItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPageFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.goToNextHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.goToPreviousHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLinkToPreviousItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleDifferentFirstPageItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleDifferentOddAndEvenPagesItem1)
            Me.snapBarController1.BarItems.Add(Me.closePageHeaderFooterItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFirstRowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLastRowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBandedRowsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleFirstColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleLastColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleBandedColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeTableStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.galleryChangeTableCellStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineStyleItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderLineWeightItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBorderColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsLeftBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsRightBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.resetTableCellsAllBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsAllBordersItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsOutsideBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideHorizontalBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsInsideVerticalBorderItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleShowTableGridLinesItem1)
            Me.snapBarController1.BarItems.Add(Me.changeTableCellsShadingItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableElementsItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableCellItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableColumnItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableRowItem1)
            Me.snapBarController1.BarItems.Add(Me.selectTableItem1)
            Me.snapBarController1.BarItems.Add(Me.showTablePropertiesFormItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableElementsItem1)
            Me.snapBarController1.BarItems.Add(Me.showDeleteTableCellsFormItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableColumnsItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableRowsItem1)
            Me.snapBarController1.BarItems.Add(Me.deleteTableItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableRowAboveItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableRowBelowItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableColumnToLeftItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableColumnToRightItem1)
            Me.snapBarController1.BarItems.Add(Me.mergeTableCellsItem1)
            Me.snapBarController1.BarItems.Add(Me.showSplitTableCellsForm1)
            Me.snapBarController1.BarItems.Add(Me.splitTableItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableAutoFitWindowItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableFixedColumnWidthItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsTopRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsMiddleRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.toggleTableCellsBottomRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.showTableOptionsFormItem1)
            Me.snapBarController1.BarItems.Add(Me.checkSpellingItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.updateTableOfContentsItem1)
            Me.snapBarController1.BarItems.Add(Me.addParagraphsToTableOfContentItem1)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem1)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem2)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem3)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem4)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem5)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem6)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem7)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem8)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem9)
            Me.snapBarController1.BarItems.Add(Me.setParagraphHeadingLevelItem10)
            Me.snapBarController1.BarItems.Add(Me.insertCaptionPlaceholderItem1)
            Me.snapBarController1.BarItems.Add(Me.insertFiguresCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTablesCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertEquationsCaptionItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresPlaceholderItem1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfFiguresItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfTablesItems1)
            Me.snapBarController1.BarItems.Add(Me.insertTableOfEquationsItems1)
            Me.snapBarController1.BarItems.Add(Me.updateTableOfFiguresItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectFillColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineColorItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectOutlineWeightItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectSquareTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTightTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectThroughTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopAndBottomTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBehindTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectInFrontOfTextWrapTypeItem1)
            Me.snapBarController1.BarItems.Add(Me.changeFloatingObjectAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectTopRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectMiddleRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomLeftAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomCenterAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.setFloatingObjectBottomRightAlignmentItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardSubItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringForwardItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringToFrontItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectBringInFrontOfTextItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardSubItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBackwardItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendToBackItem1)
            Me.snapBarController1.BarItems.Add(Me.floatingObjectSendBehindTextItem1)
            Me.snapBarController1.BarItems.Add(Me.themesGalleryBarItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem2)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem7)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem9)
            Me.snapBarController1.BarItems.Add(Me.filterPopupButtonItem1)
            Me.snapBarController1.BarItems.Add(Me.propertiesBarButtonItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem2)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem10)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem11)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem3)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem12)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem13)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem9)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem4)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem14)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem15)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem16)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem17)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem18)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem19)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem20)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem5)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem21)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem22)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem6)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem23)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem24)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem7)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem25)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem26)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem27)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem28)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem29)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem30)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem31)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem10)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem11)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem12)
            Me.snapBarController1.BarItems.Add(Me.changeEditorRowLimitItem1)
            Me.snapBarController1.BarItems.Add(Me.createBarBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createLineBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createPieBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createRotatedBarBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createAreaBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.createOtherSeriesTypesBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.changePaletteGalleryBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.changeAppearanceGalleryBaseItem1)
            Me.snapBarController1.BarItems.Add(Me.runDesignerChartItem1)
            Me.snapBarController1.BarItems.Add(Me.mailMergeDataSourceItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem32)
            Me.snapBarController1.BarItems.Add(Me.commandBarCheckItem33)
            Me.snapBarController1.BarItems.Add(Me.mailMergeCurrentRecordItem1)
            Me.snapBarController1.BarItems.Add(Me.commandBarSubItem8)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem13)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem14)
            Me.snapBarController1.BarItems.Add(Me.commandBarItem15)
            Me.snapBarController1.ContextPageCategories.Add(New DevExpress.Snap.Extensions.UI.ContextRibbonPageCategoryItem(Me.dataToolsRibbonPageCategory1))
            Me.snapBarController1.Control = Me.snapControl1
            Me.snapBarController1.RibbonControl = Me.ribbonControl1
            Me.snapBarController1.SnapDockManager = Nothing
            ' 
            ' defaultLookAndFeel1
            ' 
            Me.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' snapDockManager1
            ' 
            Me.snapDockManager1.Form = Me
            Me.snapDockManager1.HiddenPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.fieldListDockPanel1, Me.reportExplorerDockPanel1})
            Me.snapDockManager1.SnapControl = Me.snapControl1
            Me.snapDockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl", "DevExpress.XtraBars.Navigation.OfficeNavigationBar", "DevExpress.XtraBars.Navigation.TileNavPane", "DevExpress.XtraBars.TabFormControl"})
            ' 
            ' fieldListDockPanel1
            ' 
            Me.fieldListDockPanel1.Controls.Add(Me.fieldListDockPanel1_Container)
            Me.fieldListDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.ID = New System.Guid("e684c271-7ab2-4199-b8ee-6fde28e7affb")
            Me.fieldListDockPanel1.Location = New System.Drawing.Point(0, 0)
            Me.fieldListDockPanel1.Name = "fieldListDockPanel1"
            Me.fieldListDockPanel1.OriginalSize = New System.Drawing.Size(200, 286)
            Me.fieldListDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Fill
            Me.fieldListDockPanel1.SavedIndex = 0
            Me.fieldListDockPanel1.SavedParent = Me.reportExplorerDockPanel1
            Me.fieldListDockPanel1.Size = New System.Drawing.Size(200, 286)
            Me.fieldListDockPanel1.SnapControl = Me.snapControl1
            Me.fieldListDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' fieldListDockPanel1_Container
            ' 
            Me.fieldListDockPanel1_Container.Location = New System.Drawing.Point(5, 38)
            Me.fieldListDockPanel1_Container.Name = "fieldListDockPanel1_Container"
            Me.fieldListDockPanel1_Container.Size = New System.Drawing.Size(191, 243)
            Me.fieldListDockPanel1_Container.TabIndex = 0
            ' 
            ' reportExplorerDockPanel1
            ' 
            Me.reportExplorerDockPanel1.Controls.Add(Me.reportExplorerDockPanel1_Container)
            Me.reportExplorerDockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.reportExplorerDockPanel1.ID = New System.Guid("a1e7abb7-9972-4017-9e76-b0191588aa38")
            Me.reportExplorerDockPanel1.Location = New System.Drawing.Point(911, 146)
            Me.reportExplorerDockPanel1.Name = "reportExplorerDockPanel1"
            Me.reportExplorerDockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
            Me.reportExplorerDockPanel1.SavedDock = DevExpress.XtraBars.Docking.DockingStyle.Right
            Me.reportExplorerDockPanel1.SavedIndex = 0
            Me.reportExplorerDockPanel1.Size = New System.Drawing.Size(200, 572)
            Me.reportExplorerDockPanel1.SnapControl = Me.snapControl1
            Me.reportExplorerDockPanel1.Visibility = DevExpress.XtraBars.Docking.DockVisibility.Hidden
            ' 
            ' reportExplorerDockPanel1_Container
            ' 
            Me.reportExplorerDockPanel1_Container.Location = New System.Drawing.Point(5, 38)
            Me.reportExplorerDockPanel1_Container.Name = "reportExplorerDockPanel1_Container"
            Me.reportExplorerDockPanel1_Container.Size = New System.Drawing.Size(191, 530)
            Me.reportExplorerDockPanel1_Container.TabIndex = 0
            ' 
            ' snapDocumentManager1
            ' 
            Me.snapDocumentManager1.ClientControl = Me.snapControl1
            Me.snapDocumentManager1.MenuManager = Me.ribbonControl1
            Me.snapDocumentManager1.View = Me.noDocumentsView1
            Me.snapDocumentManager1.ViewCollection.AddRange(New DevExpress.XtraBars.Docking2010.Views.BaseView() { Me.noDocumentsView1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1111, 718)
            Me.Controls.Add(Me.xtraTabControl1)
            Me.Controls.Add(Me.ribbonControl1)
            Me.Name = "Form1"
            Me.Ribbon = Me.ribbonControl1
            Me.Text = "Range Data Source Example"
            DirectCast(Me.commandBarGalleryDropDown9, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.ribbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemRichEditFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineStyle1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemBorderLineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFloatingObjectOutlineWeight1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemEditorRowLimitEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown4, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown5, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown6, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown7, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemMailMergeCurrentRecordEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemFontEdit2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemSpreadsheetFontSizeEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown8, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.repositoryItemPopupGalleryEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown10, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown11, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.commandBarGalleryDropDown12, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.xtraTabControl1.ResumeLayout(False)
            Me.tbSheet.ResumeLayout(False)
            Me.tbSnap.ResumeLayout(False)
            Me.tbGauge.ResumeLayout(False)
            Me.tbGauge.PerformLayout()
            DirectCast(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.linearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.linearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.linearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.spreadsheetBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapBarController1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.snapDockManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.fieldListDockPanel1.ResumeLayout(False)
            Me.reportExplorerDockPanel1.ResumeLayout(False)
            DirectCast(Me.snapDocumentManager1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.noDocumentsView1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private spreadsheetControl1 As DevExpress.XtraSpreadsheet.SpreadsheetControl
        Private ribbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
        Private spreadsheetCommandBarButtonItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private undoItem1 As DevExpress.XtraRichEdit.UI.UndoItem
        Private redoItem1 As DevExpress.XtraRichEdit.UI.RedoItem
        Private fileNewItem1 As DevExpress.XtraRichEdit.UI.FileNewItem
        Private fileOpenItem1 As DevExpress.XtraRichEdit.UI.FileOpenItem
        Private fileSaveItem1 As DevExpress.XtraRichEdit.UI.FileSaveItem
        Private fileSaveAsItem1 As DevExpress.XtraRichEdit.UI.FileSaveAsItem
        Private commandBarItem1 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private quickPrintItem1 As DevExpress.XtraRichEdit.UI.QuickPrintItem
        Private printItem1 As DevExpress.XtraRichEdit.UI.PrintItem
        Private printPreviewItem1 As DevExpress.XtraRichEdit.UI.PrintPreviewItem
        Private showDocumentPropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowDocumentPropertiesFormItem
        Private commandBarItem2 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private fileRibbonPage1 As DevExpress.XtraSpreadsheet.UI.FileRibbonPage
        Private commonRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CommonRibbonPageGroup
        Private fileRibbonPage2 As DevExpress.XtraRichEdit.UI.FileRibbonPage
        Private commonRibbonPageGroup2 As DevExpress.XtraRichEdit.UI.CommonRibbonPageGroup
        Private infoRibbonPageGroup2 As DevExpress.XtraRichEdit.UI.InfoRibbonPageGroup
        Private dataRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataRibbonPageGroup
        Private WithEvents xtraTabControl1 As DevExpress.XtraTab.XtraTabControl
        Private tbSheet As DevExpress.XtraTab.XtraTabPage
        Private tbSnap As DevExpress.XtraTab.XtraTabPage
        Private spreadsheetBarController1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetBarController
        Private snapBarController1 As DevExpress.Snap.Extensions.SnapBarController
        Private spreadsheetCommandBarButtonItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem20 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem21 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem22 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem23 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem24 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem25 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private pasteItem1 As DevExpress.XtraRichEdit.UI.PasteItem
        Private cutItem1 As DevExpress.XtraRichEdit.UI.CutItem
        Private copyItem1 As DevExpress.XtraRichEdit.UI.CopyItem
        Private pasteSpecialItem1 As DevExpress.XtraRichEdit.UI.PasteSpecialItem
        Private barButtonGroup1 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem1 As DevExpress.XtraRichEdit.UI.ChangeFontNameItem
        Private repositoryItemFontEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem1 As DevExpress.XtraRichEdit.UI.ChangeFontSizeItem
        Private repositoryItemRichEditFontSizeEdit1 As DevExpress.XtraRichEdit.Design.RepositoryItemRichEditFontSizeEdit
        Private fontSizeIncreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeIncreaseItem
        Private fontSizeDecreaseItem1 As DevExpress.XtraRichEdit.UI.FontSizeDecreaseItem
        Private barButtonGroup2 As DevExpress.XtraBars.BarButtonGroup
        Private toggleFontBoldItem1 As DevExpress.XtraRichEdit.UI.ToggleFontBoldItem
        Private toggleFontItalicItem1 As DevExpress.XtraRichEdit.UI.ToggleFontItalicItem
        Private toggleFontUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontUnderlineItem
        Private toggleFontDoubleUnderlineItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleUnderlineItem
        Private toggleFontStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontStrikeoutItem
        Private toggleFontDoubleStrikeoutItem1 As DevExpress.XtraRichEdit.UI.ToggleFontDoubleStrikeoutItem
        Private toggleFontSuperscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSuperscriptItem
        Private toggleFontSubscriptItem1 As DevExpress.XtraRichEdit.UI.ToggleFontSubscriptItem
        Private barButtonGroup3 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontColorItem
        Private changeFontHighlightColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFontHighlightColorItem
        Private changeTextCaseItem1 As DevExpress.XtraRichEdit.UI.ChangeTextCaseItem
        Private makeTextUpperCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextUpperCaseItem
        Private makeTextLowerCaseItem1 As DevExpress.XtraRichEdit.UI.MakeTextLowerCaseItem
        Private capitalizeEachWordCaseItem1 As DevExpress.XtraRichEdit.UI.CapitalizeEachWordCaseItem
        Private toggleTextCaseItem1 As DevExpress.XtraRichEdit.UI.ToggleTextCaseItem
        Private clearFormattingItem1 As DevExpress.XtraRichEdit.UI.ClearFormattingItem
        Private barButtonGroup4 As DevExpress.XtraBars.BarButtonGroup
        Private toggleBulletedListItem1 As DevExpress.XtraRichEdit.UI.ToggleBulletedListItem
        Private toggleNumberingListItem1 As DevExpress.XtraRichEdit.UI.ToggleNumberingListItem
        Private toggleMultiLevelListItem1 As DevExpress.XtraRichEdit.UI.ToggleMultiLevelListItem
        Private barButtonGroup5 As DevExpress.XtraBars.BarButtonGroup
        Private decreaseIndentItem1 As DevExpress.XtraRichEdit.UI.DecreaseIndentItem
        Private increaseIndentItem1 As DevExpress.XtraRichEdit.UI.IncreaseIndentItem
        Private toggleShowWhitespaceItem1 As DevExpress.XtraRichEdit.UI.ToggleShowWhitespaceItem
        Private barButtonGroup6 As DevExpress.XtraBars.BarButtonGroup
        Private toggleParagraphAlignmentLeftItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentLeftItem
        Private toggleParagraphAlignmentCenterItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentCenterItem
        Private toggleParagraphAlignmentRightItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentRightItem
        Private toggleParagraphAlignmentJustifyItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphAlignmentJustifyItem
        Private barButtonGroup7 As DevExpress.XtraBars.BarButtonGroup
        Private changeParagraphLineSpacingItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphLineSpacingItem
        Private setSingleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSingleParagraphSpacingItem
        Private setSesquialteralParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetSesquialteralParagraphSpacingItem
        Private setDoubleParagraphSpacingItem1 As DevExpress.XtraRichEdit.UI.SetDoubleParagraphSpacingItem
        Private showLineSpacingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineSpacingFormItem
        Private addSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingBeforeParagraphItem
        Private removeSpacingBeforeParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingBeforeParagraphItem
        Private addSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.AddSpacingAfterParagraphItem
        Private removeSpacingAfterParagraphItem1 As DevExpress.XtraRichEdit.UI.RemoveSpacingAfterParagraphItem
        Private changeParagraphBackColorItem1 As DevExpress.XtraRichEdit.UI.ChangeParagraphBackColorItem
        Private galleryChangeStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeStyleItem
        Private findItem1 As DevExpress.XtraRichEdit.UI.FindItem
        Private replaceItem1 As DevExpress.XtraRichEdit.UI.ReplaceItem
        Private insertPageBreakItem21 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem2
        Private insertTableItem1 As DevExpress.XtraRichEdit.UI.InsertTableItem
        Private insertPictureItem1 As DevExpress.XtraRichEdit.UI.InsertPictureItem
        Private insertFloatingPictureItem1 As DevExpress.XtraRichEdit.UI.InsertFloatingPictureItem
        Private commandBarItem3 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem4 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem5 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem6 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem7 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private insertBookmarkItem1 As DevExpress.XtraRichEdit.UI.InsertBookmarkItem
        Private insertHyperlinkItem1 As DevExpress.XtraRichEdit.UI.InsertHyperlinkItem
        Private editPageHeaderItem1 As DevExpress.XtraRichEdit.UI.EditPageHeaderItem
        Private editPageFooterItem1 As DevExpress.XtraRichEdit.UI.EditPageFooterItem
        Private insertPageNumberItem1 As DevExpress.XtraRichEdit.UI.InsertPageNumberItem
        Private insertPageCountItem1 As DevExpress.XtraRichEdit.UI.InsertPageCountItem
        Private insertTextBoxItem1 As DevExpress.XtraRichEdit.UI.InsertTextBoxItem
        Private insertSymbolItem1 As DevExpress.XtraRichEdit.UI.InsertSymbolItem
        Private changeSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageMarginsItem
        Private setNormalSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNormalSectionPageMarginsItem
        Private setNarrowSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetNarrowSectionPageMarginsItem
        Private setModerateSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetModerateSectionPageMarginsItem
        Private setWideSectionPageMarginsItem1 As DevExpress.XtraRichEdit.UI.SetWideSectionPageMarginsItem
        Private showPageMarginsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowPageMarginsSetupFormItem
        Private changeSectionPageOrientationItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPageOrientationItem
        Private setPortraitPageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetPortraitPageOrientationItem
        Private setLandscapePageOrientationItem1 As DevExpress.XtraRichEdit.UI.SetLandscapePageOrientationItem
        Private changeSectionPaperKindItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionPaperKindItem
        Private changeSectionColumnsItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionColumnsItem
        Private setSectionOneColumnItem1 As DevExpress.XtraRichEdit.UI.SetSectionOneColumnItem
        Private setSectionTwoColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionTwoColumnsItem
        Private setSectionThreeColumnsItem1 As DevExpress.XtraRichEdit.UI.SetSectionThreeColumnsItem
        Private showColumnsSetupFormItem1 As DevExpress.XtraRichEdit.UI.ShowColumnsSetupFormItem
        Private insertBreakItem1 As DevExpress.XtraRichEdit.UI.InsertBreakItem
        Private insertPageBreakItem1 As DevExpress.XtraRichEdit.UI.InsertPageBreakItem
        Private insertColumnBreakItem1 As DevExpress.XtraRichEdit.UI.InsertColumnBreakItem
        Private insertSectionBreakNextPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakNextPageItem
        Private insertSectionBreakEvenPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakEvenPageItem
        Private insertSectionBreakOddPageItem1 As DevExpress.XtraRichEdit.UI.InsertSectionBreakOddPageItem
        Private changeSectionLineNumberingItem1 As DevExpress.XtraRichEdit.UI.ChangeSectionLineNumberingItem
        Private setSectionLineNumberingNoneItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingNoneItem
        Private setSectionLineNumberingContinuousItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingContinuousItem
        Private setSectionLineNumberingRestartNewPageItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewPageItem
        Private setSectionLineNumberingRestartNewSectionItem1 As DevExpress.XtraRichEdit.UI.SetSectionLineNumberingRestartNewSectionItem
        Private toggleParagraphSuppressLineNumbersItem1 As DevExpress.XtraRichEdit.UI.ToggleParagraphSuppressLineNumbersItem
        Private showLineNumberingFormItem1 As DevExpress.XtraRichEdit.UI.ShowLineNumberingFormItem
        Private changePageColorItem1 As DevExpress.XtraRichEdit.UI.ChangePageColorItem
        Private switchToSimpleViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToSimpleViewItem
        Private switchToDraftViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToDraftViewItem
        Private switchToPrintLayoutViewItem1 As DevExpress.XtraRichEdit.UI.SwitchToPrintLayoutViewItem
        Private toggleShowHorizontalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowHorizontalRulerItem
        Private toggleShowVerticalRulerItem1 As DevExpress.XtraRichEdit.UI.ToggleShowVerticalRulerItem
        Private zoomOutItem1 As DevExpress.XtraRichEdit.UI.ZoomOutItem
        Private zoomInItem1 As DevExpress.XtraRichEdit.UI.ZoomInItem
        Private snapBarToolbarsListItem1 As DevExpress.Snap.Extensions.UI.SnapBarToolbarsListItem
        Private commandBarCheckItem1 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private showAllFieldCodesItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldCodesItem
        Private showAllFieldResultsItem1 As DevExpress.XtraRichEdit.UI.ShowAllFieldResultsItem
        Private toggleFieldHighlightingItem1 As DevExpress.Snap.Extensions.UI.ToggleFieldHighlightingItem
        Private goToPageHeaderItem1 As DevExpress.XtraRichEdit.UI.GoToPageHeaderItem
        Private goToPageFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPageFooterItem
        Private goToNextHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToNextHeaderFooterItem
        Private goToPreviousHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.GoToPreviousHeaderFooterItem
        Private toggleLinkToPreviousItem1 As DevExpress.XtraRichEdit.UI.ToggleLinkToPreviousItem
        Private toggleDifferentFirstPageItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentFirstPageItem
        Private toggleDifferentOddAndEvenPagesItem1 As DevExpress.XtraRichEdit.UI.ToggleDifferentOddAndEvenPagesItem
        Private closePageHeaderFooterItem1 As DevExpress.XtraRichEdit.UI.ClosePageHeaderFooterItem
        Private toggleFirstRowItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstRowItem
        Private toggleLastRowItem1 As DevExpress.XtraRichEdit.UI.ToggleLastRowItem
        Private toggleBandedRowsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedRowsItem
        Private toggleFirstColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleFirstColumnItem
        Private toggleLastColumnItem1 As DevExpress.XtraRichEdit.UI.ToggleLastColumnItem
        Private toggleBandedColumnsItem1 As DevExpress.XtraRichEdit.UI.ToggleBandedColumnsItem
        Private galleryChangeTableStyleItem1 As DevExpress.XtraRichEdit.UI.GalleryChangeTableStyleItem
        Private galleryChangeTableCellStyleItem1 As DevExpress.Snap.Extensions.UI.GalleryChangeTableCellStyleItem
        Private changeTableBorderLineStyleItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineStyleItem
        Private repositoryItemBorderLineStyle1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineStyle
        Private changeTableBorderLineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderLineWeightItem
        Private repositoryItemBorderLineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemBorderLineWeight
        Private changeTableBorderColorItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBorderColorItem
        Private changeTableBordersItem1 As DevExpress.XtraRichEdit.UI.ChangeTableBordersItem
        Private toggleTableCellsBottomBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomBorderItem
        Private toggleTableCellsTopBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopBorderItem
        Private toggleTableCellsLeftBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsLeftBorderItem
        Private toggleTableCellsRightBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsRightBorderItem
        Private resetTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ResetTableCellsAllBordersItem
        Private toggleTableCellsAllBordersItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsAllBordersItem
        Private toggleTableCellsOutsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsOutsideBorderItem
        Private toggleTableCellsInsideBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideBorderItem
        Private toggleTableCellsInsideHorizontalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideHorizontalBorderItem
        Private toggleTableCellsInsideVerticalBorderItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsInsideVerticalBorderItem
        Private toggleShowTableGridLinesItem1 As DevExpress.XtraRichEdit.UI.ToggleShowTableGridLinesItem
        Private changeTableCellsShadingItem1 As DevExpress.XtraRichEdit.UI.ChangeTableCellsShadingItem
        Private selectTableElementsItem1 As DevExpress.XtraRichEdit.UI.SelectTableElementsItem
        Private selectTableCellItem1 As DevExpress.XtraRichEdit.UI.SelectTableCellItem
        Private selectTableColumnItem1 As DevExpress.XtraRichEdit.UI.SelectTableColumnItem
        Private selectTableRowItem1 As DevExpress.XtraRichEdit.UI.SelectTableRowItem
        Private selectTableItem1 As DevExpress.XtraRichEdit.UI.SelectTableItem
        Private showTablePropertiesFormItem1 As DevExpress.XtraRichEdit.UI.ShowTablePropertiesFormItem
        Private deleteTableElementsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableElementsItem
        Private showDeleteTableCellsFormItem1 As DevExpress.XtraRichEdit.UI.ShowDeleteTableCellsFormItem
        Private deleteTableColumnsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableColumnsItem
        Private deleteTableRowsItem1 As DevExpress.XtraRichEdit.UI.DeleteTableRowsItem
        Private deleteTableItem1 As DevExpress.XtraRichEdit.UI.DeleteTableItem
        Private insertTableRowAboveItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowAboveItem
        Private insertTableRowBelowItem1 As DevExpress.XtraRichEdit.UI.InsertTableRowBelowItem
        Private insertTableColumnToLeftItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToLeftItem
        Private insertTableColumnToRightItem1 As DevExpress.XtraRichEdit.UI.InsertTableColumnToRightItem
        Private mergeTableCellsItem1 As DevExpress.XtraRichEdit.UI.MergeTableCellsItem
        Private showSplitTableCellsForm1 As DevExpress.XtraRichEdit.UI.ShowSplitTableCellsForm
        Private splitTableItem1 As DevExpress.XtraRichEdit.UI.SplitTableItem
        Private toggleTableAutoFitItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitItem
        Private toggleTableAutoFitContentsItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitContentsItem
        Private toggleTableAutoFitWindowItem1 As DevExpress.XtraRichEdit.UI.ToggleTableAutoFitWindowItem
        Private toggleTableFixedColumnWidthItem1 As DevExpress.XtraRichEdit.UI.ToggleTableFixedColumnWidthItem
        Private toggleTableCellsTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopLeftAlignmentItem
        Private toggleTableCellsMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleLeftAlignmentItem
        Private toggleTableCellsBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomLeftAlignmentItem
        Private toggleTableCellsTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopCenterAlignmentItem
        Private toggleTableCellsMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleCenterAlignmentItem
        Private toggleTableCellsBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomCenterAlignmentItem
        Private toggleTableCellsTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsTopRightAlignmentItem
        Private toggleTableCellsMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsMiddleRightAlignmentItem
        Private toggleTableCellsBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.ToggleTableCellsBottomRightAlignmentItem
        Private showTableOptionsFormItem1 As DevExpress.XtraRichEdit.UI.ShowTableOptionsFormItem
        Private checkSpellingItem1 As DevExpress.XtraRichEdit.UI.CheckSpellingItem
        Private insertTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfContentsItem
        Private updateTableOfContentsItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfContentsItem
        Private addParagraphsToTableOfContentItem1 As DevExpress.XtraRichEdit.UI.AddParagraphsToTableOfContentItem
        Private setParagraphHeadingLevelItem1 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem2 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem3 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem4 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem5 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem6 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem7 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem8 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem9 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private setParagraphHeadingLevelItem10 As DevExpress.XtraRichEdit.UI.SetParagraphHeadingLevelItem
        Private insertCaptionPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertCaptionPlaceholderItem
        Private insertFiguresCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertFiguresCaptionItems
        Private insertTablesCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertTablesCaptionItems
        Private insertEquationsCaptionItems1 As DevExpress.XtraRichEdit.UI.InsertEquationsCaptionItems
        Private insertTableOfFiguresPlaceholderItem1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresPlaceholderItem
        Private insertTableOfFiguresItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfFiguresItems
        Private insertTableOfTablesItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfTablesItems
        Private insertTableOfEquationsItems1 As DevExpress.XtraRichEdit.UI.InsertTableOfEquationsItems
        Private updateTableOfFiguresItem1 As DevExpress.XtraRichEdit.UI.UpdateTableOfFiguresItem
        Private changeFloatingObjectFillColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectFillColorItem
        Private changeFloatingObjectOutlineColorItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineColorItem
        Private changeFloatingObjectOutlineWeightItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectOutlineWeightItem
        Private repositoryItemFloatingObjectOutlineWeight1 As DevExpress.XtraRichEdit.Forms.Design.RepositoryItemFloatingObjectOutlineWeight
        Private changeFloatingObjectTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectTextWrapTypeItem
        Private setFloatingObjectSquareTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectSquareTextWrapTypeItem
        Private setFloatingObjectTightTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTightTextWrapTypeItem
        Private setFloatingObjectThroughTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectThroughTextWrapTypeItem
        Private setFloatingObjectTopAndBottomTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopAndBottomTextWrapTypeItem
        Private setFloatingObjectBehindTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBehindTextWrapTypeItem
        Private setFloatingObjectInFrontOfTextWrapTypeItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectInFrontOfTextWrapTypeItem
        Private changeFloatingObjectAlignmentItem1 As DevExpress.XtraRichEdit.UI.ChangeFloatingObjectAlignmentItem
        Private setFloatingObjectTopLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopLeftAlignmentItem
        Private setFloatingObjectTopCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopCenterAlignmentItem
        Private setFloatingObjectTopRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectTopRightAlignmentItem
        Private setFloatingObjectMiddleLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleLeftAlignmentItem
        Private setFloatingObjectMiddleCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleCenterAlignmentItem
        Private setFloatingObjectMiddleRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectMiddleRightAlignmentItem
        Private setFloatingObjectBottomLeftAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomLeftAlignmentItem
        Private setFloatingObjectBottomCenterAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomCenterAlignmentItem
        Private setFloatingObjectBottomRightAlignmentItem1 As DevExpress.XtraRichEdit.UI.SetFloatingObjectBottomRightAlignmentItem
        Private floatingObjectBringForwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardSubItem
        Private floatingObjectBringForwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringForwardItem
        Private floatingObjectBringToFrontItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringToFrontItem
        Private floatingObjectBringInFrontOfTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectBringInFrontOfTextItem
        Private floatingObjectSendBackwardSubItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardSubItem
        Private floatingObjectSendBackwardItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBackwardItem
        Private floatingObjectSendToBackItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendToBackItem
        Private floatingObjectSendBehindTextItem1 As DevExpress.XtraRichEdit.UI.FloatingObjectSendBehindTextItem
        Private themesGalleryBarItem1 As DevExpress.Snap.Extensions.UI.ThemesGalleryBarItem
        Private commandBarCheckItem2 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem3 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem4 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem1 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem5 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem6 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem7 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem8 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem9 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private filterPopupButtonItem1 As DevExpress.Snap.Extensions.UI.FilterPopupButtonItem
        Private propertiesBarButtonItem1 As DevExpress.Snap.Extensions.UI.PropertiesBarButtonItem
        Private commandBarSubItem2 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem10 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem11 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem3 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem12 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem13 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarItem8 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem9 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarSubItem4 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem14 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem15 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem16 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem17 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem18 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem19 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem20 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem5 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem21 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem22 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem6 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem23 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem24 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarSubItem7 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarCheckItem25 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem26 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem27 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem28 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem29 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem30 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem31 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarItem10 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem11 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem12 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private barButtonGroup8 As DevExpress.XtraBars.BarButtonGroup
        Private changeEditorRowLimitItem1 As DevExpress.Snap.Extensions.UI.ChangeEditorRowLimitItem
        Private repositoryItemEditorRowLimitEdit1 As DevExpress.Snap.Design.RepositoryItemEditorRowLimitEdit
        Private createBarBaseItem1 As DevExpress.XtraCharts.UI.CreateBarBaseItem
        Private commandBarGalleryDropDown1 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createLineBaseItem1 As DevExpress.XtraCharts.UI.CreateLineBaseItem
        Private commandBarGalleryDropDown2 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createPieBaseItem1 As DevExpress.XtraCharts.UI.CreatePieBaseItem
        Private commandBarGalleryDropDown3 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createRotatedBarBaseItem1 As DevExpress.XtraCharts.UI.CreateRotatedBarBaseItem
        Private commandBarGalleryDropDown4 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createAreaBaseItem1 As DevExpress.XtraCharts.UI.CreateAreaBaseItem
        Private commandBarGalleryDropDown5 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private createOtherSeriesTypesBaseItem1 As DevExpress.XtraCharts.UI.CreateOtherSeriesTypesBaseItem
        Private commandBarGalleryDropDown6 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private changePaletteGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangePaletteGalleryBaseItem
        Private commandBarGalleryDropDown7 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private changeAppearanceGalleryBaseItem1 As DevExpress.XtraCharts.UI.ChangeAppearanceGalleryBaseItem
        Private runDesignerChartItem1 As DevExpress.XtraCharts.UI.RunDesignerChartItem
        Private mailMergeDataSourceItem1 As DevExpress.Snap.Extensions.UI.MailMergeDataSourceItem
        Private commandBarCheckItem32 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private commandBarCheckItem33 As DevExpress.Snap.Extensions.UI.CommandBarCheckItem
        Private mailMergeCurrentRecordItem1 As DevExpress.Snap.Extensions.UI.MailMergeCurrentRecordItem
        Private repositoryItemMailMergeCurrentRecordEdit1 As DevExpress.Snap.Extensions.UI.RepositoryItemMailMergeCurrentRecordEdit
        Private commandBarSubItem8 As DevExpress.Snap.Extensions.UI.CommandBarSubItem
        Private commandBarItem13 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem14 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private commandBarItem15 As DevExpress.Snap.Extensions.UI.CommandBarItem
        Private dataRibbonPage1 As DevExpress.XtraSpreadsheet.UI.DataRibbonPage
        Private homeRibbonPage1 As DevExpress.XtraRichEdit.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.FontRibbonPageGroup
        Private paragraphRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ParagraphRibbonPageGroup
        Private stylesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.StylesRibbonPageGroup
        Private editingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.EditingRibbonPageGroup
        Private insertRibbonPage1 As DevExpress.XtraRichEdit.UI.InsertRibbonPage
        Private pagesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PagesRibbonPageGroup
        Private tablesRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TablesRibbonPageGroup
        Private illustrationsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.IllustrationsRibbonPageGroup
        Private toolboxRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ToolboxRibbonPageGroup
        Private linksRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.LinksRibbonPageGroup
        Private headerFooterRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.HeaderFooterRibbonPageGroup
        Private textRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TextRibbonPageGroup
        Private symbolsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.SymbolsRibbonPageGroup
        Private pageLayoutRibbonPage1 As DevExpress.XtraRichEdit.UI.PageLayoutRibbonPage
        Private pageSetupRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageSetupRibbonPageGroup
        Private pageBackgroundRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.PageBackgroundRibbonPageGroup
        Private viewRibbonPage1 As DevExpress.XtraRichEdit.UI.ViewRibbonPage
        Private documentViewsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentViewsRibbonPageGroup
        Private showRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ShowRibbonPageGroup
        Private zoomRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.ZoomRibbonPageGroup
        Private viewRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewRibbonPageGroup
        Private viewFieldsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ViewFieldsRibbonPageGroup
        Private reviewRibbonPage1 As DevExpress.XtraRichEdit.UI.ReviewRibbonPage
        Private documentProofingRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.DocumentProofingRibbonPageGroup
        Private referencesRibbonPage1 As DevExpress.XtraRichEdit.UI.ReferencesRibbonPage
        Private tableOfContentsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.TableOfContentsRibbonPageGroup
        Private captionsRibbonPageGroup1 As DevExpress.XtraRichEdit.UI.CaptionsRibbonPageGroup
        Private sheetPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Private snapPageCategory As DevExpress.XtraBars.Ribbon.RibbonPageCategory
        Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private WithEvents barBtnSheetToSnap As DevExpress.XtraBars.BarButtonItem
        Private ribbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
        Private dataToolsRibbonPageCategory1 As DevExpress.Snap.Extensions.UI.DataToolsRibbonPageCategory
        Private snMergeFieldToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.SNMergeFieldToolsRibbonPage
        Private dataShapingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.DataShapingRibbonPageGroup
        Private snMergeFieldPropertiesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.SNMergeFieldPropertiesRibbonPageGroup
        Private noDocumentsView1 As DevExpress.XtraBars.Docking2010.Views.NoDocuments.NoDocumentsView
        Private snapDocumentManager1 As DevExpress.Snap.Extensions.SnapDocumentManager
        Private reportExplorerDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private reportExplorerDockPanel1 As DevExpress.Snap.Extensions.UI.ReportExplorerDockPanel
        Private fieldListDockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
        Private fieldListDockPanel1 As DevExpress.Snap.Extensions.UI.FieldListDockPanel
        Private snapDockManager1 As DevExpress.Snap.Extensions.SnapDockManager
        Private snapControl1 As DevExpress.Snap.SnapControl
        Private barButtonGroup9 As DevExpress.XtraBars.BarButtonGroup
        Private groupToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.GroupToolsRibbonPage
        Private groupingRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.GroupingRibbonPageGroup
        Private listToolsRibbonPage1 As DevExpress.Snap.Extensions.UI.ListToolsRibbonPage
        Private listHeaderAndFooterRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListHeaderAndFooterRibbonPageGroup
        Private listCommandsRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListCommandsRibbonPageGroup
        Private listEditorRowLimitRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ListEditorRowLimitRibbonPageGroup
        Private appearanceRibbonPage1 As DevExpress.Snap.Extensions.UI.AppearanceRibbonPage
        Private themesRibbonPageGroup1 As DevExpress.Snap.Extensions.UI.ThemesRibbonPageGroup
        Private tbGauge As DevExpress.XtraTab.XtraTabPage
        Private linearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
        Private linearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
        Private linearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
        Private linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
        Private WithEvents gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
        Private dataNavigator1 As DevExpress.XtraEditors.DataNavigator
        Private textBox1 As System.Windows.Forms.TextBox
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private spreadsheetCommandBarButtonItem26 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem27 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem28 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem29 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup10 As DevExpress.XtraBars.BarButtonGroup
        Private changeFontNameItem2 As DevExpress.XtraSpreadsheet.UI.ChangeFontNameItem
        Private repositoryItemFontEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemFontEdit
        Private changeFontSizeItem2 As DevExpress.XtraSpreadsheet.UI.ChangeFontSizeItem
        Private repositoryItemSpreadsheetFontSizeEdit1 As DevExpress.XtraSpreadsheet.Design.RepositoryItemSpreadsheetFontSizeEdit
        Private spreadsheetCommandBarButtonItem30 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem31 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup11 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup12 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarSubItem4 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem32 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem33 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem34 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem35 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem36 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem37 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem38 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem39 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem40 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem41 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem42 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem43 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem44 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private changeBorderLineColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineColorItem
        Private changeBorderLineStyleItem1 As DevExpress.XtraSpreadsheet.UI.ChangeBorderLineStyleItem
        Private commandBarGalleryDropDown8 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private barButtonGroup13 As DevExpress.XtraBars.BarButtonGroup
        Private changeCellFillColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeCellFillColorItem
        Private changeFontColorItem2 As DevExpress.XtraSpreadsheet.UI.ChangeFontColorItem
        Private barButtonGroup14 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup15 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarCheckItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarCheckItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private barButtonGroup16 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarButtonItem45 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem46 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarSubItem5 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarCheckItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem47 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem48 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem49 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup17 As DevExpress.XtraBars.BarButtonGroup
        Private changeNumberFormatItem1 As DevExpress.XtraSpreadsheet.UI.ChangeNumberFormatItem
        Private repositoryItemPopupGalleryEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemPopupGalleryEdit
        Private barButtonGroup18 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarSubItem6 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem50 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem51 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem52 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem53 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem54 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem55 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem56 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private barButtonGroup19 As DevExpress.XtraBars.BarButtonGroup
        Private spreadsheetCommandBarButtonItem57 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem58 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem7 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarSubItem8 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem59 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem60 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem61 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem62 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem63 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem64 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem65 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem9 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem66 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem67 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem68 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem69 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem70 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem71 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonGalleryDropDownItem1 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown9 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonGalleryDropDownItem2 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown10 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonGalleryDropDownItem3 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonGalleryDropDownItem
        Private commandBarGalleryDropDown11 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private spreadsheetCommandBarButtonItem72 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem10 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem73 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem74 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private galleryFormatAsTableItem1 As DevExpress.XtraSpreadsheet.UI.GalleryFormatAsTableItem
        Private commandBarGalleryDropDown12 As DevExpress.XtraBars.Commands.CommandBarGalleryDropDown
        Private galleryChangeStyleItem2 As DevExpress.XtraSpreadsheet.UI.GalleryChangeStyleItem
        Private spreadsheetCommandBarSubItem11 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem75 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem76 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem77 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem12 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem78 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem79 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem80 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem13 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem81 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem82 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem83 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem84 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem85 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem86 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem87 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem88 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem89 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem90 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem91 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem92 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem93 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private changeSheetTabColorItem1 As DevExpress.XtraSpreadsheet.UI.ChangeSheetTabColorItem
        Private spreadsheetCommandBarButtonItem94 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem14 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem95 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem96 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem97 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem98 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem99 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem100 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem16 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem101 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem102 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem103 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem104 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem17 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem105 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem106 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem107 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem108 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem109 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem110 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarSubItem18 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarSubItem19 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarSubItem
        Private spreadsheetCommandBarButtonItem115 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem116 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem117 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem118 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem119 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem120 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem121 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private homeRibbonPage2 As DevExpress.XtraSpreadsheet.UI.HomeRibbonPage
        Private clipboardRibbonPageGroup2 As DevExpress.XtraSpreadsheet.UI.ClipboardRibbonPageGroup
        Private fontRibbonPageGroup2 As DevExpress.XtraSpreadsheet.UI.FontRibbonPageGroup
        Private alignmentRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.AlignmentRibbonPageGroup
        Private numberRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.NumberRibbonPageGroup
        Private stylesRibbonPageGroup2 As DevExpress.XtraSpreadsheet.UI.StylesRibbonPageGroup
        Private cellsRibbonPageGroup1 As DevExpress.XtraSpreadsheet.UI.CellsRibbonPageGroup
        Private editingRibbonPageGroup2 As DevExpress.XtraSpreadsheet.UI.EditingRibbonPageGroup
        Private spreadsheetCommandBarButtonItem111 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem112 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarCheckItem15 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarCheckItem
        Private spreadsheetCommandBarButtonItem113 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
        Private spreadsheetCommandBarButtonItem114 As DevExpress.XtraSpreadsheet.UI.SpreadsheetCommandBarButtonItem
    End Class
End Namespace

