﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GridDemoApp
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> employees = Employee.GetEmployees();


            gridControl1.DataSource = employees;

            this.Load += new System.EventHandler(this.Form1_Load);

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
