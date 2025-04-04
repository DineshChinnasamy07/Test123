using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace MondayTask
{
    public partial class Login : DevExpress.XtraEditors.XtraForm
    {
        public Login()
        {
            InitializeComponent();
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            // Ensure that the GridControl is used, not the GridView
            gridControlEmployees.DataSource = null;
            gridControlEmployees.DataSource = EmployeeDataStore.Employees;
            gridControlEmployees.RefreshDataSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Employee Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox5.Text))
            {
                MessageBox.Show("Name and Email are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Employee erp = new Employee()
            {
                Name = textBox1.Text,
                Department = textBox2.Text,
                Unit = textBox3.Text,
                Contect = textBox4.Text,
                Email = textBox5.Text,
            };

            // Ensure the correct method name is used
            EmployeeDataStore.InserEmployee(erp);
            LoadEmployeeData();
            ClearForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            GridView gridView = gridControlEmployees.MainView as GridView;
            if (gridView != null)
            {
                Employee selectedEmployee = gridView.GetFocusedRow() as Employee;
                if (selectedEmployee != null)
                {
                    selectedEmployee.Name = textBox1.Text;
                    selectedEmployee.Department = textBox2.Text;
                    selectedEmployee.Unit = textBox3.Text;
                    selectedEmployee.Contect = textBox4.Text;
                    selectedEmployee.Email = textBox5.Text;

                    LoadEmployeeData();
                    ClearForm();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            GridView gridView = gridControlEmployees.MainView as GridView;
            if (gridView != null)
            {
                Employee selectedEmployee = gridView.GetFocusedRow() as Employee;
                if (selectedEmployee != null)
                {
                    EmployeeDataStore.Employees.Remove(selectedEmployee);
                    LoadEmployeeData();
                    ClearForm();
                }
            }
        }

        private void gridViewEmployees_Click(object sender, EventArgs e)
        {
            GridView gridView = gridControlEmployees.MainView as GridView;
            if (gridView != null)
            {
                Employee erp = gridView.GetFocusedRow() as Employee;
                if (erp != null)
                {
                    textBox1.Text = erp.Name;
                    textBox2.Text = erp.Department;
                    textBox3.Text = erp.Unit;
                    textBox4.Text = erp.Contect;
                    textBox5.Text = erp.Email;
                }
            }
        }

        private void ClearForm()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void wcfInstantFeedbackSource1_GetSource(object sender, DevExpress.Data.WcfLinq.GetSourceEventArgs e)
        {

        }
    }
}
