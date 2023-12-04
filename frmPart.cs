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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CSE412_PCBusinessApp
{
    public partial class frmPart : Form
    {
        public frmPart()
        {
            InitializeComponent();
        }

        private void cbPartName_SelectedIndexChanged(object sender, EventArgs e)
        {
            lParts.Items.Clear();
            string selectedItem = cbPartName.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedItem))
            {
                if(selectedItem.Equals("All Parts"))
                {
                    showPartsList();
                }
                else
                {
                    updatePartsList(selectedItem);
                }
            }
            else
            {
                showPartsList();
            }
        }

        private void frmPart_Load(object sender, EventArgs e)
        {
            showPartsList();
            Settings.Default.Save();
        }

        private void showPartsList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ("SELECT p_pid, p_name, p_type, p_manufacturer, p_price FROM part ORDER BY p_pid ASC ");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lParts.Items.Add(listViewItem);
                }
            }
        }
        private void updatePartsList(String selectedItem)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ("SELECT p_pid, p_name, p_type, p_manufacturer, p_price FROM part WHERE p_type = '"+selectedItem+"' ORDER BY p_pid ASC ");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lParts.Items.Add(listViewItem);
                }
            }
        }
    }
}
