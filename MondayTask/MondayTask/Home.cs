using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace MondayTask
{
    public partial class Home : XtraForm
    {
        public Home()
        {
            InitializeComponent();
        }

   
        public class Account
        {
            public int AccountID { get; set; }
            public string AccountName { get; set; }
            public decimal Balance { get; set; }
        }

        private List<Account> GetAccountsData()
        {
            try
            {
                return new List<Account>
                {
                    new Account { AccountID = 1, AccountName = "John Doe", Balance = 1000.00m },
                    new Account { AccountID = 2, AccountName = "Jane Smith", Balance = 2000.50m },
                    new Account { AccountID = 3, AccountName = "Samuel Green", Balance = 5000.75m }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Account>();  // Return empty list to prevent further issues
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            try
            {
                InitializeGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during form load: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeGrid()
        {
            try
            {
                // Create GridControl
                GridControl gridControl = new GridControl
                {
                    Dock = DockStyle.Fill,
                    Name = "gridControl1"  // Set the Name property to match your existing gridControl
                };

                // Create GridView
                GridView gridView = new GridView();
                gridControl.MainView = gridView;

                // Add GridControl to the form (if not added already)
                this.Controls.Add(gridControl);

                // Bind data to GridControl
                gridControl.DataSource = GetAccountsData();

                // Set column captions
                gridView.Columns["AccountID"].Caption = "Account ID";
                gridView.Columns["AccountName"].Caption = "Account Name";
                gridView.Columns["Balance"].Caption = "Balance";

                // Optionally: Auto-size columns for better display
                gridView.BestFitColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing grid: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   
        }

        private void accountsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // You can add code here to navigate to the Accounts view or handle actions
                MessageBox.Show("Accounts button clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Accounts button: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void transactionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add code to show transactions or perform relevant actions
                MessageBox.Show("Transactions button clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Transactions button: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Add code to generate reports or perform relevant actions
                MessageBox.Show("Reports button clicked");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in Reports button: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                // Handle GridControl click event (for example, show details of the selected row)
                GridView gridView = (GridView)((GridControl)sender).MainView;
                var selectedRow = gridView.GetFocusedRow();
                MessageBox.Show("Selected Account ID: " + ((Account)selectedRow).AccountID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in GridControl click event: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
