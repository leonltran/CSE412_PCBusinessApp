using CSE412_PCBusinessApp.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace CSE412_PCBusinessApp
{
    public partial class frmOrder : Form
    {
        private string oid = "";
        private string cName = "";
        private frmWelcome parentForm = null;
        public frmOrder()
        {
            InitializeComponent();
        }
        public frmOrder(string oid)
        {
            InitializeComponent();
            this.oid = oid;
        }
        public frmOrder(string oid, Form callingForm)
        {
            InitializeComponent();
            this.oid = oid;
            this.parentForm = callingForm as frmWelcome;
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            updateComputerList();
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            frmChangeOrderStatus cos = new frmChangeOrderStatus(oid, this);
            cos.Show();
        }

        private void btnOrderNewComputer_Click(object sender, EventArgs e)
        {   
            frmAddComputer ac = new frmAddComputer(oid, this);
            ac.Show();
        }
        private void btnNewComputer_Click(object sender, EventArgs e)
        {
            frmComputer c = new frmComputer();
            c.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (frmWelcome.ActiveForm != null)
            {
                Form previousForm = frmWelcome.formStack.Pop();
                previousForm.Show();
                this.Close();
            }
        }
        private void btnComputerDetails_Click(object sender, EventArgs e)
        {
            try
            {
                string compID = lsvComputers.SelectedItems[0].Text; // get the computer ID

                // open frmComputer
                frmComputerDetails cd = new frmComputerDetails(compID);
                cd.Show();
            }
            catch
            {
                MessageBox.Show("Select an computer.", "INFO");
            }
        }
        private void btnCustomerDetails_Click(object sender, EventArgs e)
        {
            // open frmComputer
            frmCustomer c = new frmCustomer(cName);
            c.Show();
        }
        public void updateComputerList()
        {
            if (oid != "")
            {
                lsvComputers.Items.Clear();

                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                updateOrderInfo();

                // SELECT command for order's PCs
                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT computer.* FROM orders, computer WHERE o_oid = {oid} AND c_oid = {oid}");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lsvComputers.Items.Add(listViewItem);
                }
            }
        }
        public void updateOrderInfo()
        {
            string pass = Settings.Default.password;
            string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
            var dataSource = NpgsqlDataSource.Create(connectionString);

            // SELECT command for order information
            NpgsqlCommand command = dataSource.CreateCommand
                ($"SELECT * FROM orders WHERE o_oid = {oid}");
            NpgsqlDataReader dr = command.ExecuteReader();

            string cid = "";
            while (dr.Read())
            {
                lblOrderID.Text = $"Order ID: {dr[0]}";
                cid = dr.GetInt32(1).ToString();
                lblPrice.Text = $"Total Price: ${dr[2]}";
                lblDate.Text = $"Order Date: {dr.GetDateTime(3).Date.ToShortDateString()}";
                lblType.Text = $"Order Type: {dr[4]}";
                lblStatus.Text = $"Order Status: {dr[5]}";
                lblComment.Text = dr[6].ToString();
            }

            // SELECT command for customer name
            command = dataSource.CreateCommand
                ($"SELECT cu_name FROM orders, customer WHERE cu_cid = {cid}");
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                lblCustomer.Text = $"Customer: {dr[0]}";
                cName = dr[0].ToString();
            }
        }
        public void updateParentForm()
        {
            parentForm.updateOrdersList();
        }
    }
}
