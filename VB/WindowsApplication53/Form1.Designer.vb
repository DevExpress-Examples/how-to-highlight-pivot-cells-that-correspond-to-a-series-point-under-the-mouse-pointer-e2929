Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication53
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
			Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
			Dim sideBySideBarSeriesLabel1 As New DevExpress.XtraCharts.SideBySideBarSeriesLabel()
			Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.fiedName = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldValue2 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.fieldDate1 = New DevExpress.XtraPivotGrid.PivotGridField()
			Me.splitContainer1 = New System.Windows.Forms.SplitContainer()
			Me.chartControl1 = New DevExpress.XtraCharts.ChartControl()
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.splitContainer1.Panel1.SuspendLayout()
			Me.splitContainer1.Panel2.SuspendLayout()
			Me.splitContainer1.SuspendLayout()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' pivotGridControl1
			' 
			Me.pivotGridControl1.Cursor = System.Windows.Forms.Cursors.Default
			Me.pivotGridControl1.DataMember = "Data"
			Me.pivotGridControl1.DataSource = Me.dataSet1
			Me.pivotGridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.pivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() { Me.fiedName, Me.fieldDate, Me.fieldValue, Me.fieldValue1, Me.fieldValue2, Me.fieldDate1})
			Me.pivotGridControl1.Location = New System.Drawing.Point(0, 0)
			Me.pivotGridControl1.Name = "pivotGridControl1"
			Me.pivotGridControl1.OptionsChartDataSource.ExportFieldValueMode = DevExpress.XtraPivotGrid.PivotChartExportFieldValueMode.Value
			Me.pivotGridControl1.OptionsChartDataSource.SelectionOnly = False
			Me.pivotGridControl1.OptionsChartDataSource.ShowRowGrandTotals = False
			Me.pivotGridControl1.Size = New System.Drawing.Size(418, 292)
			Me.pivotGridControl1.TabIndex = 0
'			Me.pivotGridControl1.CustomDrawCell += New DevExpress.XtraPivotGrid.PivotCustomDrawCellEventHandler(Me.pivotGridControl1_CustomDrawCell);
'			Me.pivotGridControl1.CustomAppearance += New DevExpress.XtraPivotGrid.PivotCustomAppearanceEventHandler(Me.pivotGridControl1_CustomAppearance);
'			Me.pivotGridControl1.CustomChartDataSourceData += New DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventHandler(Me.pivotGridControl1_CustomChartDataSourceData);
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Data"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Date"
			Me.dataColumn2.DataType = GetType(System.DateTime)
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Value"
			Me.dataColumn3.DataType = GetType(Decimal)
			' 
			' fiedName
			' 
			Me.fiedName.AreaIndex = 1
			Me.fiedName.FieldName = "Name"
			Me.fiedName.Name = "fiedName"
			' 
			' fieldDate
			' 
			Me.fieldDate.AreaIndex = 0
			Me.fieldDate.Caption = "Year"
			Me.fieldDate.FieldName = "Date"
			Me.fieldDate.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.DateYear
			Me.fieldDate.Name = "fieldDate"
			Me.fieldDate.UnboundFieldName = "fieldDate"
			' 
			' fieldValue
			' 
			Me.fieldValue.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue.AreaIndex = 0
			Me.fieldValue.Caption = "Sum"
			Me.fieldValue.FieldName = "Value"
			Me.fieldValue.Name = "fieldValue"
			' 
			' fieldValue1
			' 
			Me.fieldValue1.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldValue1.AreaIndex = 1
			Me.fieldValue1.Caption = "Count"
			Me.fieldValue1.FieldName = "Value"
			Me.fieldValue1.Name = "fieldValue1"
			Me.fieldValue1.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Count
			' 
			' fieldValue2
			' 
			Me.fieldValue2.AreaIndex = 2
			Me.fieldValue2.Caption = "Average"
			Me.fieldValue2.FieldName = "Value"
			Me.fieldValue2.Name = "fieldValue2"
			Me.fieldValue2.SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Average
			' 
			' fieldDate1
			' 
			Me.fieldDate1.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldDate1.AreaIndex = 0
			Me.fieldDate1.Caption = "Date"
			Me.fieldDate1.FieldName = "Date"
			Me.fieldDate1.GroupInterval = DevExpress.XtraPivotGrid.PivotGroupInterval.Date
			Me.fieldDate1.Name = "fieldDate1"
			Me.fieldDate1.UnboundFieldName = "fieldDate1"
			Me.fieldDate1.ValueFormat.FormatString = "dd MMM yyyy"
			Me.fieldDate1.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime
			' 
			' splitContainer1
			' 
			Me.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.splitContainer1.Location = New System.Drawing.Point(0, 0)
			Me.splitContainer1.Name = "splitContainer1"
			' 
			' splitContainer1.Panel1
			' 
			Me.splitContainer1.Panel1.Controls.Add(Me.pivotGridControl1)
			' 
			' splitContainer1.Panel2
			' 
			Me.splitContainer1.Panel2.Controls.Add(Me.chartControl1)
			Me.splitContainer1.Size = New System.Drawing.Size(796, 292)
			Me.splitContainer1.SplitterDistance = 418
			Me.splitContainer1.TabIndex = 1
			' 
			' chartControl1
			' 
			Me.chartControl1.DataSource = Me.pivotGridControl1
			xyDiagram1.AxisX.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisX.Range.SideMarginsEnabled = True
			xyDiagram1.AxisX.VisibleInPanesSerializable = "-1"
			xyDiagram1.AxisY.Range.ScrollingRange.SideMarginsEnabled = True
			xyDiagram1.AxisY.Range.SideMarginsEnabled = True
			xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
			Me.chartControl1.Diagram = xyDiagram1
			Me.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.chartControl1.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
			Me.chartControl1.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.TopOutside
			Me.chartControl1.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
			Me.chartControl1.Location = New System.Drawing.Point(0, 0)
			Me.chartControl1.Name = "chartControl1"
			Me.chartControl1.SeriesDataMember = "Series"
			Me.chartControl1.SeriesSerializable = New DevExpress.XtraCharts.Series(){}
			Me.chartControl1.SeriesTemplate.ArgumentDataMember = "Arguments"
			sideBySideBarSeriesLabel1.LineVisible = True
			Me.chartControl1.SeriesTemplate.Label = sideBySideBarSeriesLabel1
			Me.chartControl1.SeriesTemplate.ValueDataMembersSerializable = "Values"
			Me.chartControl1.Size = New System.Drawing.Size(374, 292)
			Me.chartControl1.TabIndex = 0
'			Me.chartControl1.ObjectHotTracked += New DevExpress.XtraCharts.HotTrackEventHandler(Me.chartControl1_ObjectHotTracked);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(796, 292)
			Me.Controls.Add(Me.splitContainer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.splitContainer1.Panel1.ResumeLayout(False)
			Me.splitContainer1.Panel2.ResumeLayout(False)
			Me.splitContainer1.ResumeLayout(False)
			CType(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(sideBySideBarSeriesLabel1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.chartControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private fiedName As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue1 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldValue2 As DevExpress.XtraPivotGrid.PivotGridField
		Private fieldDate1 As DevExpress.XtraPivotGrid.PivotGridField
		Private splitContainer1 As System.Windows.Forms.SplitContainer
		Private WithEvents chartControl1 As DevExpress.XtraCharts.ChartControl
	End Class
End Namespace

