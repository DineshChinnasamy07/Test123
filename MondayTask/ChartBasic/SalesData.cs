using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChartBasic
{
      public class SalesData
    {
        public string Month { get; set; }
        public int Sales { get; set; }

      public static List<SalesData> GetSales()
      {
            return new List<SalesData>
        {
            new SalesData { Month = "Jan", Sales = 500 },
            new SalesData { Month = "Feb", Sales = 700 },
            new SalesData { Month = "Mar", Sales = 800 },
            new SalesData { Month = "Apr", Sales = 650 },
            new SalesData { Month = "May", Sales = 900 },
        };
      }
    }
}
