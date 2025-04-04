using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.DashboardCommon
{
    class DashboardObjectDataSource
    {
        private string p;
        private List<DevExpressDashboardApps.Model.SalesData> salesDataList;

        public DashboardObjectDataSource(string p)
        {
            // TODO: Complete member initialization
            this.p = p;
        }

        public DashboardObjectDataSource(string p, List<DevExpressDashboardApps.Model.SalesData> salesDataList)
        {
            // TODO: Complete member initialization
            this.p = p;
            this.salesDataList = salesDataList;
        }

        public List<DevExpressDashboardApps.Model.SalesData> DataSources { get; set; }
    }
}
