using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoGridLookup
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        // Sample data method to simulate a data source
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Department = "Sales" },
            new Employee { Id = 2, Name = "Jane Smith", Department = "IT" },
            new Employee { Id = 3, Name = "Alice Johnson", Department = "HR" },
            new Employee { Id = 4, Name = "Bob Brown", Department = "Marketing" }
        };
        }
    }

}
