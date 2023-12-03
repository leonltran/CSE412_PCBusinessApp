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
        public static Stack<Form> formStack = new Stack<Form>();
        public frmWelcome()
        {
            InitializeComponent();
        }

        // the Form.Shown event fires after a form finishes loading and the form is "shown."
        // check event listeners under the properties window (F4) by pressing the lightning bolt icon!
        private void Form1_Shown(object sender, EventArgs e)
        {
            grbActions.Text = "Modified";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer a = new frmAddCustomer();
            a.Show();
        }
        
        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            frmOrder o = new frmOrder();
            formStack.Push(this);
            o.Show();
            this.Hide();
        }
    }
}
