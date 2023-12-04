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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (comboBox1.Text != "")
                {
                    listView1.Items.Clear();
                    label2.Text = $"Comment:";
                    string keyword = comboBox1.Text;
                    searchCustomerList(keyword);
                }
                else
                {
                    listView1.Items.Clear();
                    label2.Text = $"Comment:";
                    loadCustomerList();
                }
            }
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            loadCustomerList();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string selectedCustId = listView1.SelectedItems[0].SubItems[0].Text;
                getCustomerComment(selectedCustId);
            }
            else
            {
                label2.Text = $"Comment:";
            }
        }

        private void loadCustomerList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT cu_cid, cu_name, cu_email, cu_address, cu_phone FROM customer ORDER BY cu_cid ASC ");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        private void searchCustomerList(String keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT cu_cid, cu_name, cu_email, cu_address, cu_phone FROM customer WHERE cu_name LIKE '%{keyword}%' ORDER BY cu_name ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString() };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                }
            }
        }
        private void getCustomerComment(String keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT cu_comment FROM customer WHERE cu_cid = '{int.Parse(keyword)}' ORDER BY cu_cid ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    label2.Text = $"Comment: {dr[0].ToString()}";
              
                }
            }
        }
    }
}
