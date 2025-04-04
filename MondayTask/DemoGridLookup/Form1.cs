using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace DemoGridLookup
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DemoLookUp_Load(object sender, EventArgs e)
        {
            List<Employee> employees = Employee.GetEmployees();

            gridLookUpEdit1.Properties.DataSource = employees;
            gridLookUpEdit1.Properties.DisplayMember = "Name";
            gridLookUpEdit1.Properties.ValueMember = "Id";

            var gridView = gridLookUpEdit1.Properties.View as DevExpress.XtraGrid.Views.Grid.GridView;
            if (gridView != null) 
            {
              //  if(gridView.Columns["Id"] !=null  )
              //  {
             //       gridView.Columns["Id"].Visible = false;
               // }
             
               // gridView.Columns["Name"].Caption = "Name";
               // gridView.Columns["Department"].Caption = "Department";

                gridView.PopulateColumns();

                var idColumn = gridView.Columns["Id"];
                if (idColumn != null)
                    idColumn.Visible = false;
                var nameColumn = gridView.Columns["Name"];
                if (nameColumn != null)
                    nameColumn.Caption = "Employee Name";
                var deptColumn = gridView.Columns["Department"];
                  if(deptColumn != null)
                  deptColumn.Caption = "Department";

            }

            gridLookUpEdit1.EditValueChanged += GridLookUpEdit1_EditValueChanged;

        }

        private void GridLookUpEdit1_EditValueChanged(object sender, EventArgs e) 
        {

            GridLookUpEdit lookup = sender as GridLookUpEdit;
            if (lookup != null && lookup.EditValue != null)
            {

                int selectedId = (int)lookup.EditValue;
                MessageBox.Show("Selected  Employee ID: " + selectedId);   // safe for This null value 


                Employee selectedEmployee = Employee.GetEmployees().FirstOrDefault(emp => emp.Id == selectedId);
                if (selectedEmployee != null )
                {

                    MessageBox.Show("Selected: " + selectedEmployee.Name + " - " + selectedEmployee.Department);

                }


            }


       }
 
    }  
}