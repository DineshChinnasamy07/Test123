using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardWin;
using DevExpress.DashboardCommon;
using DevExpressDashboardApps.Model;

namespace DevExpressDashboardApps
{
    public partial class XtraForm1 : DevExpress.XtraEditors.XtraForm
    {


        private DashboardDesigner dashboardDesigner;

        public XtraForm1()
        {
            InitializeComponent();
            InitializeDashboardDesigner();
           
        }

        private void InitializeDashboardDesigner() 
        {

            dashboardDesigner = new DashboardDesigner()
            {
                Dock = DockStyle.Fill
            };

            this.Controls.Add(dashboardDesigner);
            LoadDashboard();
        }

        private void LoadDashboard() 
        {
            Dashboard dashboard = new Dashboard();
            
              List<SalesData> salesDataList = SalesData.GetSales();

              DevExpress.DashboardCommon.DashboardObjectDataSource dashboardObjectDataSource =
              new DevExpress.DashboardCommon.DashboardObjectDataSource("SalesDataSource", salesDataList);
              dashboardObjectDataSource.DataSources = salesDataList;
        }
        private void XtraForm1_Load(object sender, EventArgs e)
        {


        }

        private void dashboardDesigner1_Load(object sender, EventArgs e)
        {

        }
         
    }
}