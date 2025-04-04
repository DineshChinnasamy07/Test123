using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;

namespace MondayTask
{
    public partial class Test : DevExpress.XtraEditors.XtraForm
    {
        private BarManager barmanger;
        private PopupMenu popupMenu;


        public Test()
        {
            InitializeComponent();

            barmanger = new BarManager();
            barmanger.Form = this;

            popupMenu = new PopupMenu(barmanger);


            popupMenu.AddItem(new BarButtonItem(barmanger, "genral Settinges"));
            popupMenu.AddItem(new BarButtonItem(barmanger, "Security  Settinges"));
            popupMenu.AddItem(new BarButtonItem(barmanger, "Account  Settinges"));
            popupMenu.AddItem(new BarButtonItem(barmanger, "Ledger Settinges"));
            popupMenu.AddItem(new BarButtonItem(barmanger, " Profile Settinges"));
            popupMenu.AddItem(new BarButtonItem(barmanger, "Account Settinges"));


            foreach (BarItemLink item in popupMenu.ItemLinks )
            {
                item.Item.ItemClick += Item_ItemClick;
            }
        }

        private void dropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void dropDownButton4_Click(object sender, EventArgs e)
        {

        }

        private void dropDownButton2_Click(object sender, EventArgs e)
        {
            popupMenu.ShowPopup(MousePosition);
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void Item_ItemClick(object sender,EventArgs e )
        {
            MessageBox.Show("You Selected :{e. Item.Caption}");

           
        }


    }
}