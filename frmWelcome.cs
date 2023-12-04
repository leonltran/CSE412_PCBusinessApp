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
        private void frmWelcome_Load(object sender, EventArgs e)
        {
            try
            {
                updateOrdersList();
            }
            catch { }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer ac = new frmAddCustomer();
            ac.Show();
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            frmCustomer c = new frmCustomer();
            c.Show();
        }

        private void btnNewOrder_Click_1(object sender, EventArgs e)
        {
            frmAddOrder ao = new frmAddOrder();
            ao.Show();
        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {
            try
            {
                string orderID = lsvOrders.SelectedItems[0].Text; // get the order ID

                // open frmOrder
                frmOrder o = new frmOrder(orderID);
                o.Show();
            }
            catch
            {
                MessageBox.Show("Select an order.", "INFO");
            }
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

        private void btnPassword_Click(object sender, EventArgs e)
        {
            string oldPass = Settings.Default.password;
            string newPass = Microsoft.VisualBasic.Interaction.InputBox("Enter the password you used when setting up PostgreSQL:", "Database Password", oldPass);
            Settings.Default.password = newPass;
            try
            {
                Settings.Default.Save();
                updateOrdersList();
            }
            catch
            {
                MessageBox.Show("Invalid password...", "Error");
            }
        }

        /* This method handles the population of the Orders list upon application load.
         */
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
    }
}