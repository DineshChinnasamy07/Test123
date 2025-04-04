using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Card;

namespace Design
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();

            CardView cardView1 = new CardView();
            gridControl1.MainView = cardView1;
            gridControl1.ViewCollection.Add(cardView1);

            List<Person> people = new List<Person>
            {
                new Person { Name = "Dinesh", Age = 22, Occupation = "Engineer" },
                new Person { Name = "Bharth", Age = 25, Occupation = "Designer" },
                new Person { Name = "Velan", Age = 35, Occupation = "Manager" },
                new Person { Name = "Velan", Age = 35, Occupation = "Manager" }
            };
            gridControl1.DataSource = people;
            cardView1.Columns["Name"].Caption = "Full Name";
            cardView1.Columns["Age"].Caption = "Age (Years)";
            cardView1.Columns["Occupation"].Caption = "Job Title";
            cardView1.DoubleClick += CardView1_DoubleClick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CardView1_DoubleClick(object sender, EventArgs e)
        {
            CardView view = sender as CardView;
            if (view == null) return;
            int rowHandle = view.FocusedRowHandle;
            if (rowHandle < 0)
                return;

              Person person = view.GetRow(rowHandle) as Person;
              if (person != null) 
              {
                   MessageBox.Show("Name: {person.Name}\nAge: {person.Age}\nOccupation: {person.Occupation}", 
                                "Card Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }


        }
    }
}
