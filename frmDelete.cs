using CSE412_PCBusinessApp.Properties;
using Microsoft.VisualBasic.Devices;
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
    public partial class frmDelete : Form
    {
        public frmDelete()
        {
            InitializeComponent();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            // code to complete delete
            string itemType = cbDelType.Text;
            int computerID = int.Parse(cbItemUID.Text);

            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand command = new NpgsqlCommand($"DELETE FROM comppart WHERE cp_comp_id = {computerID}", connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            // Deletion successful
                            MessageBox.Show("Item has been deleted successfully.", "Deletion Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // No rows were affected, deletion not successful
                            MessageBox.Show("Deletion failed. Item not found or an error occurred.", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }

            // close window when finished
            this.Close();
        }

        private void labelItemType_Click(object sender, EventArgs e)
        {

        }
    }
}
