Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace WindowsApplication53
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PopulateTable()
			pivotGridControl1.RefreshData()
			pivotGridControl1.BestFit()
		End Sub
		Private Sub PopulateTable()
			Dim myTable As DataTable = dataSet1.Tables("Data")
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today, 7 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddDays(1), 4 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today, 12 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1), 14 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today, 11 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1), 10 })

			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1), 4 })
			myTable.Rows.Add(New Object() { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddYears(1), 3 })
			myTable.Rows.Add(New Object() { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddYears(1), 8 })
			myTable.Rows.Add(New Object() { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 })
		End Sub

		Private Sub pivotGridControl1_CustomChartDataSourceData(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs) Handles pivotGridControl1.CustomChartDataSourceData

		End Sub


		Private hotTrackPoint As New Point(-1, -1)
		Private Sub chartControl1_ObjectHotTracked(ByVal sender As Object, ByVal e As DevExpress.XtraCharts.HotTrackEventArgs) Handles chartControl1.ObjectHotTracked
			Dim point As SeriesPoint = TryCast(e.AdditionalObject, SeriesPoint)
			If point Is Nothing Then
				InvalidateCell(pivotGridControl1, hotTrackPoint)
				hotTrackPoint = New Point(-1, -1)
			Else
				Dim coordinates() As Integer = CType(point.Tag, Integer())

				InvalidateCell(pivotGridControl1, hotTrackPoint)
				hotTrackPoint.X = coordinates(0)
				hotTrackPoint.Y = coordinates(1)
				InvalidateCell(pivotGridControl1, hotTrackPoint)
			End If
		End Sub

		Private Sub InvalidateCell(ByVal pivot As DevExpress.XtraPivotGrid.PivotGridControl, ByVal cell As Point)
			If cell <> New Point(-1, -1) Then
				pivot.Invalidate(pivot.Cells.GetCellInfo(cell.X, cell.Y).Bounds)
			End If
		End Sub

		Private Sub pivotGridControl1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs) Handles pivotGridControl1.CustomDrawCell

		End Sub

		Private Sub pivotGridControl1_CustomAppearance(ByVal sender As Object, ByVal e As DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs) Handles pivotGridControl1.CustomAppearance
			If hotTrackPoint = New Point(-1, -1) Then
				Return
			End If
			If e.RowIndex = hotTrackPoint.Y AndAlso e.ColumnIndex = hotTrackPoint.X Then
				e.Appearance.BackColor = Color.LightGreen
			End If
		End Sub

	End Class
End Namespace