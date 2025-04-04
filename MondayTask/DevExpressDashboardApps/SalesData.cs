using System;
using System.ComponentModel;
using System.Collections.Generic;

namespace DevExpressDashboardApps.Model
{
    public class SalesData
    {
        public string ProductName { get; set; }
        public string Category { get; set; }
        public double SalesAmount { get; set; }
        public int  Year { get; set; }


        public static List<SalesData> GetSales() 
        {
            return new List<SalesData>
            {
                new SalesData   {ProductName = "laptop ",Category ="Electronics",SalesAmount= 50000,Year=2003},
                  new SalesData   {ProductName = "Fan ",Category ="Electronics",SalesAmount= 50000,Year=2020},
                    new SalesData   {ProductName = "TV ",Category ="Electronics",SalesAmount= 50000,Year=2013},
                      new SalesData   {ProductName = " Shows",Category ="Fasion",SalesAmount= 50000,Year=2010},
                        new SalesData   {ProductName = "Watch ",Category ="Fasion",SalesAmount= 50000,Year=2008},
                          new SalesData   {ProductName = "Jewllary ",Category ="Gold",SalesAmount= 50000,Year=2005},
                            new SalesData   {ProductName = "Ring ",Category ="Gold",SalesAmount= 50000,Year=2004},
                            new SalesData   {ProductName = "Shoba ",Category ="furniture",SalesAmount= 5000,Year=2003},
                              new SalesData   {ProductName = "Phone ",Category ="Electronics",SalesAmount= 40000,Year=2003},

            };

        }
    }



}
