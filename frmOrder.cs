﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSE412_PCBusinessApp
{
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }

        private void btnNewComputer_Click(object sender, EventArgs e)
        {
            frmComputer c = new frmComputer();
            c.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(frmWelcome.ActiveForm != null)
            {
                Form previousForm = frmWelcome.formStack.Pop();
                previousForm.Show();
                this.Close();
            }
        }
    }
}
