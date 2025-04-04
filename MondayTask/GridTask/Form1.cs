using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace GridTask
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        public BindingList<LedgerEntry> ledgerEntry = new BindingList<LedgerEntry>();     
        public Form1()
        {
            InitializeComponent();
            gridView1.DoubleClick += gridControl1_DoubleClick;  // Ensure the method name matches
            gridControl1.DataSource = ledgerEntry;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {          
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);  // Pass 'this' (current Form1) to Form2
            form2.ShowDialog();  // Open Form2 as a modal dialog
        }
        public void RefreshGrid()
        {
            gridControl1.RefreshDataSource();
        }
        /// <summary>
        ///  bind the  Value for All are List for Grid Controller 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            gridControl1.RefreshDataSource();

            GridView view = sender as GridView;
            if (view == null)    
            return;

            Point pt = view.GridControl.PointToClient(Control.MousePosition);
            GridHitInfo hitinfo = view.CalcHitInfo(pt);
            if(hitinfo.InRow || hitinfo.InRowCell)
            {
                int selectedRowHandle = view.FocusedRowHandle;
                if( selectedRowHandle >= 0)
                {
                    string columnValue = view.GetRowCellValue(selectedRowHandle, "Name").ToString();


                    Form2 form2 = new Form2(columnValue);
                    form2.ShowDialog();
                }
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {
        
        }
        private void button3_Click(object sender, EventArgs e)
        {
             
        }
    }
}
