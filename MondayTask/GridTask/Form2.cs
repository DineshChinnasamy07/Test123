using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars.Alerter; 

namespace GridTask
{
    public partial class Form2 : DevExpress.XtraEditors.XtraForm
    {
       // public List<LedgerEntry> ledgerEntry = new List<LedgerEntry>();
        public List<LedgerEntry> ledgerentry = new List<LedgerEntry>();

       private Form1 mainForm;
       private string columnValue;
      // private string receivedData;

       //public BindingList<LedgerEntry> ledgerentry = new BindingList<LedgerEntry>();

        public Form2(Form1 form1)
        {
            InitializeComponent();
       

            this.mainForm = form1;          
        }

        public Form2(string columnValue)
        {
          
            this.columnValue = columnValue;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              //  LedgerEntry ledger = new LedgerEntry();

                string Code = textBox1.Text.Trim();
                string Name = textBox2.Text.Trim();
                DateTime Date = dateTimePicker1.Value;
                string Nature = (comboBox1.SelectedItem != null) ? comboBox1.SelectedItem.ToString() : "";

             
                if(string.IsNullOrEmpty(Code)|| string.IsNullOrEmpty(Name)||string.IsNullOrEmpty(Nature))
                {
                    MessageBox.Show("Please fill in all Required fildes .","Validation Error ",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                    return;
                }

                LedgerEntry entry = new LedgerEntry(Code, Name, Date, Nature);
                mainForm.ledgerEntry.Add(entry);

               mainForm.RefreshGrid();

                MessageBox.Show("Ledger Entry SuccessFully:");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error Saving ledger Entry :" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        // toas Message box 
      //  private void ShowToastNotification(string message) 
        //{
          //  AlertControl alert = new AlertControl();
            //AlertInfo info = new AlertInfo("Notification", message);
            //alert.Show(this, info);
       // }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }   
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        public string code { get; set; }
    }
}