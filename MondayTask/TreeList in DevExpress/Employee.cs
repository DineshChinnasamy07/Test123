using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeList_in_DevExpress
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public int? ParentId { get; set; }  // For hierarchical relationships
    }




}
