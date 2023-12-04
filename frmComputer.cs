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
    public partial class frmComputer : Form
    {
        public frmComputer()
        {
            InitializeComponent();
        }

        private void frmComputer_Load(object sender, EventArgs e)
        {
            showComputerList();
        }
        private void showComputerList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ("SELECT c_comp_id, c_oid, c_type, c_weight FROM computer, orders WHERE c_oid=o_oid ORDER BY c_comp_id ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString()};
                    var listViewItem = new ListViewItem(row);
                    lComputers.Items.Add(listViewItem);
                }
            }
        }
    }
}
