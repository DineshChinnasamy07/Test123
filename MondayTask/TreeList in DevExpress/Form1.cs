using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

using System.Windows.Forms;

namespace TreeList_in_DevExpress
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        } 

        // Method to fetch employee data
        public List<Employee> GetEmployees()
        {
            return new List<Employee>
        {
            new Employee { Id = 1, Name = "John Doe", Department = "HR", ParentId = null },
            new Employee { Id = 2, Name = "Jane Smith", Department = "IT", ParentId = null },
            new Employee { Id = 3, Name = "Alice Johnson", Department = "HR", ParentId = 1 },
            new Employee { Id = 4, Name = "Bob Brown", Department = "IT", ParentId = 2 }
        };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Bind the data source
            var employees = GetEmployees();
            treeList1.DataSource = employees;

            // Set up the key and parent field names for hierarchical data
            treeList1.KeyFieldName = "Id";
            treeList1.ParentFieldName = "ParentId";

            // Force the TreeList to generate columns from the data source
            treeList1.PopulateColumns();

            // Check if the "Id" column exists before hiding it
            if (treeList1.Columns["Id"] != null)
            {
                treeList1.Columns["Id"].Visible = false;
            }

            // Optionally, set captions for other columns
            if (treeList1.Columns["Name"] != null)
                treeList1.Columns["Name"].Caption = "Employee Name";
            if (treeList1.Columns["Department"] != null)
                treeList1.Columns["Department"].Caption = "Department";

            // Attach other event handlers if needed
        }


        private void treeList1_FocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e)
        {
            if(e.Node != null)
           
            {

                string employeName = e.Node.GetValue("Name").ToString();
                string department = e.Node.GetValue("Department").ToString();


                MessageBox.Show("Select Employee :"+ employeName + "\nDepartment:"+  department);

            }

        }
    }
}
