using CSE412_PCBusinessApp.Properties;
using Npgsql;
using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSE412_PCBusinessApp
{
    public partial class frmPartAvailability : Form
    {
        public frmPartAvailability()
        {
            InitializeComponent();
        }

        private void cbPartName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbPartName.Text != "")
                {
                    lPartStock.Items.Clear();
                    lbPartName.Text = $"Name:";
                    lbPartId.Text = $"Part ID:";
                    lbPartType.Text = $"Type:";
                    lbPartPrice.Text = $"Price:";
                    string keyword = cbPartName.Text;
                    searchPartsList(keyword);
                }
                else
                {
                    lPartStock.Items.Clear();
                    lbPartName.Text = $"Name:";
                    lbPartId.Text = $"Part ID:";
                    lbPartType.Text = $"Type:";
                    lbPartPrice.Text = $"Price:";
                    loadPartsList();
                }
            }

        }
        private void lPartStock_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lPartStock.SelectedItems.Count > 0)
            {
                string selectedPartName = lPartStock.SelectedItems[0].SubItems[0].Text;
                getPartDetails(selectedPartName);
            }
            else
            {
                lbPartName.Text = $"Name:";
                lbPartId.Text = $"Part ID:";
                lbPartType.Text = $"Type:";
                lbPartPrice.Text = $"Price:";
            }
        }
        private void searchPartsList(String keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT p_name, p_manufacturer, p_quantity FROM part WHERE p_name LIKE '%{keyword}%' ORDER BY p_name ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lPartStock.Items.Add(listViewItem);
                }
            }
        }
        private void getPartDetails(String partName)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT p_name, p_pid, p_type, p_price FROM part WHERE p_name = '{partName}' ORDER BY p_pid ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    lbPartName.Text = $"Name: {dr[0].ToString()}";
                    lbPartId.Text = $"Part ID: {dr[1].ToString()}";
                    lbPartType.Text = $"Type: {dr[2].ToString()}";
                    lbPartPrice.Text = $"Price: ${dr[3].ToString()}";
                }
            }
        }
        private void loadPartsList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT p_name, p_manufacturer, p_quantity FROM part ORDER BY p_pid ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lPartStock.Items.Add(listViewItem);
                }
            }
        }

        private void frmPartAvailability_Load(object sender, EventArgs e)
        {
            loadPartsList();
        }
    }
}
