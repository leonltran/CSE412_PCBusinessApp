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

namespace CSE412_PCBusinessApp
{
    public partial class frmOrder : Form
    {
        public string oid = "";
        public frmOrder()
        {
            InitializeComponent();
        }
        private void frmOrder_Load(object sender, EventArgs e)
        {
            if (oid != "")
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
                }

                // SELECT command for order's PCs
                command = dataSource.CreateCommand
                    ($"SELECT computer.* FROM orders, computer WHERE o_oid = {oid} AND c_oid = {oid}");
                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[1].ToString(), dr[2].ToString(), dr[3].ToString()};
                    var listViewItem = new ListViewItem(row);
                    lsvComputers.Items.Add(listViewItem);
                }
            }
        }

        private void btnChangeStatus_Click(object sender, EventArgs e)
        {
            frmChangeOrderStatus cos = new frmChangeOrderStatus();
            cos.Show();
        }

        private void btnOrderNewComputer_Click(object sender, EventArgs e)
        {
            frmAddComputer ac = new frmAddComputer();
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
    }
}
