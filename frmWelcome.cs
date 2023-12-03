using System;
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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        // the Form.Shown event fires after a form finishes loading and the form is "shown."
        // check event listeners under the properties window (F4) by pressing the lightning bolt icon!
        private void Form1_Shown(object sender, EventArgs e)
        {
            grbCustomer.Text = "Modified";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer ac = new frmAddCustomer();
            ac.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCustomer cu = new frmCustomer();
            cu.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            frmOrder o = new frmOrder();
            o.Show();
        }

        private void delItem_Click(object sender, EventArgs e)
        {
            frmDelete d = new frmDelete();
            d.Show();
        }

        private void btnViewComputers_Click(object sender, EventArgs e)
        {
            frmComputer c = new frmComputer();
            c.Show();
        }

        private void btnViewParts_Click(object sender, EventArgs e)
        {
            frmPart p = new frmPart();
            p.Show();
        }

        private void btnPartCheckAvail_Click(object sender, EventArgs e)
        {
            frmPartAvailability pa = new frmPartAvailability();
            pa.Show();
        }

        private void BtnComputerDetails_Click(object sender, EventArgs e)
        {
            frmComputerDetails cd = new frmComputerDetails();
            cd.Show();
        }

        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {
            frmAddOrder ao = new frmAddOrder();
            ao.Show();
        }
    }
}
