using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MondayTask
{    

    /// <summary>
    ///   gathring for Employee Details 
    /// </summary>
    public class Employee 
    {   
        public int EmployeeID {get ; set;}
        public string Name { get; set;}
        public string Department { get; set; }
        public string Unit { get; set;}
        public string Contect { get; set; }
        public string Email { get; set; }
    }
      /// <summary>
      /// I have create for One CRUD  opration employe Data
      /// </summary>
    public static class EmployeeDataStore 
    {
        public static int nextId = 1;
        public static List<Employee> Employees { get; private set; }

        static EmployeeDataStore() 
        {
            Employees = new List<Employee>();

        }
        public static void InserEmployee(Employee erp) 
        {
            Employees.Add(erp);
        }

       public static void  InsertEmployees (Employee erp)
       {
           erp.EmployeeID = nextId++;
           Employees.Add(erp);
       }
       public static void UpDateEmloyee(Employee erp) 
       {
           var existing = Employees.Find(e => e.EmployeeID == erp.EmployeeID);
           if (existing != null) 
           {
               existing.Name = erp.Name;
               existing.Department = erp.Department;
               existing.Unit = erp.Unit;
               existing.Contect = erp.Contect;
               existing.Email = erp.Email;
           }
       }

       public static void DeleteEmployee(int EmployeID) 
       {
           Employees.RemoveAll(e => e.EmployeeID == EmployeID);

       }

    }
}
