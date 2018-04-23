using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraCharts;
using DevExpress.XtraPivotGrid;

namespace WindowsApplication53
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateTable();
            pivotGridControl1.RefreshData();
            pivotGridControl1.BestFit();
        }
        private void PopulateTable()
        {
            DataTable myTable = dataSet1.Tables["Data"];
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today, 7 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddDays(1), 4 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today, 12 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1), 14 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today, 11 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1), 10 });

            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1), 4 });
            myTable.Rows.Add(new object[] { "Aaa", DateTime.Today.AddYears(1).AddDays(1), 2 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddYears(1), 3 });
            myTable.Rows.Add(new object[] { "Bbb", DateTime.Today.AddDays(1).AddYears(1), 1 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddYears(1), 8 });
            myTable.Rows.Add(new object[] { "Ccc", DateTime.Today.AddDays(1).AddYears(1), 22 });
        }

        private void pivotGridControl1_CustomChartDataSourceData(object sender, DevExpress.XtraPivotGrid.PivotCustomChartDataSourceDataEventArgs e)
        {

        }


        Point hotTrackPoint = new Point(-1, -1);
        private void chartControl1_ObjectHotTracked(object sender, DevExpress.XtraCharts.HotTrackEventArgs e)
        {
            SeriesPoint point = e.AdditionalObject as SeriesPoint;
            if (point == null)
            {
                InvalidateCell(pivotGridControl1, hotTrackPoint);
                hotTrackPoint = new Point(-1, -1);
            }
            else
            {
                PivotChartDataSourceRow coordinates = point.Tag as PivotChartDataSourceRow;

                InvalidateCell(pivotGridControl1, hotTrackPoint);
                hotTrackPoint.X = coordinates.CellX ;
                hotTrackPoint.Y = coordinates.CellY ;
                InvalidateCell(pivotGridControl1, hotTrackPoint);
            }
        }

        private void InvalidateCell(DevExpress.XtraPivotGrid.PivotGridControl pivot, Point cell)
        {
            if (cell != new Point(-1, -1))
                pivot.Invalidate(pivot.Cells.GetCellInfo(cell.X, cell.Y).Bounds);
        }

        private void pivotGridControl1_CustomDrawCell(object sender, DevExpress.XtraPivotGrid.PivotCustomDrawCellEventArgs e)
        {

        }

        private void pivotGridControl1_CustomAppearance(object sender, DevExpress.XtraPivotGrid.PivotCustomAppearanceEventArgs e)
        {
            if (hotTrackPoint == new Point(-1, -1)) return;
            if (e.RowIndex == hotTrackPoint.Y && e.ColumnIndex == hotTrackPoint.X)
                e.Appearance.BackColor = Color.LightGreen;
        }

    }
}