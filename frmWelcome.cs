using CSE412_PCBusinessApp.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // grbActions.Text = "aaaaa";
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
            // following two lines make it so that the Orders form appears in the exact same location as the current form
            o.Location = this.Location;
            o.StartPosition = FormStartPosition.Manual;
            // the following line is important because closing a non-main form doesnt restore this form, and doesnt terminate app
            o.FormClosing += delegate { this.Show(); };
            o.Show();
            this.Hide();
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            updateOrdersList();
        }

        private void updateOrdersList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ("SELECT o_oid, cu_name, o_status, o_date FROM orders, customer WHERE o_cid = cu_cid ORDER BY o_date ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), (dr.GetDateTime(3).Date.ToShortDateString()).ToString() };
                    var listViewItem = new ListViewItem(row);
                    lsvOrders.Items.Add(listViewItem);

                }
            }
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string oldPass = Settings.Default.password;
            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Enter the password you used when setting up PostgreSQL:", "Database Password", oldPass);
            Settings.Default.password = newPass;
            try
            {
                updateOrdersList();
                Settings.Default.Save();
            }
            catch
            {
                MessageBox.Show("Invalid password...", "Error");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                string orderID = lsvOrders.SelectedItems[0].Text; // get the order ID

                // open frmOrder
                frmOrder o = new frmOrder();
                o.oid = orderID; 
                formStack.Push(this);
                o.Location = this.Location;
                o.StartPosition = FormStartPosition.Manual;
                o.FormClosing += delegate { this.Show(); };
                o.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Select an order.", "INFO");
            }
            
        }
    }
}