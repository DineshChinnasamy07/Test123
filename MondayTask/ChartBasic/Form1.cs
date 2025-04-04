using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using DevExpress.XtraCharts;
using System.Text;
using System.Windows.Forms;

namespace ChartBasic
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Series series = new Series("Monthly Sales", ViewType.Bar);


            List<SalesData> salesData = SalesData.GetSales();
            foreach(var data in salesData)
            {
                series.Points.Add(new SeriesPoint(data.Month, data.Sales));
            }

            series.LabelsVisibility = DevExpress.Utils.DefaultBoolean.True;

        
           // ((BarSeriesView)series.View).Color = Color.Blue;


            chartControl1.Series.Add(series);
            chartControl1.Legend.Visible = true;


            XYDiagram diagram = (XYDiagram)chartControl1.Diagram;
            diagram.AxisX.Title.Text = "Months";
            diagram.AxisX.Title.Visible = true;
            diagram.AxisY.Title.Text = "Sales";
            diagram.AxisY.Title.Visible = true;
        }

        private void chartControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
