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
using static System.Windows.Forms.DataFormats;

namespace CSE412_PCBusinessApp
{
    public partial class frmChangeOrderStatus : Form
    {
        
        private string oid = "";
        private frmOrder parentForm = null;
        public frmChangeOrderStatus(string oid)
        {
            InitializeComponent();
            this.oid = oid;
        }
        public frmChangeOrderStatus(string oid, Form callingForm)
        {
            InitializeComponent();
            this.oid = oid;
            this.parentForm = callingForm as frmOrder;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedStatus = comboBox1.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedStatus))
            {
                // Update the order status in the database
                UpdateOrderStatus(selectedStatus);
                parentForm.updateComputerList();
                parentForm.updateParentForm();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateOrderStatus(string keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                
                int orderId = int.Parse(this.oid);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"UPDATE orders SET o_status = '{keyword}' WHERE o_oid = {orderId}");

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
