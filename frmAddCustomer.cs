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
    public partial class frmAddCustomer : Form
    {
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text == "" || txtEmail.Text == "")
                {
                    throw new ArgumentNullException();
                }
                string nextCustomerID = "";
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                // get next customer ID serially
                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT MAX(cu_cid) FROM customer");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    // if the database was originally made with the primary key as SERIAL
                    // this wouldn't be necessary, but we weren't taught that in class were we?
                    nextCustomerID = (dr.GetInt32(0)+1).ToString(); 
                }

                // INSERT content of textfields
                command = dataSource.CreateCommand
                    ("INSERT INTO customer(cu_cid, cu_name, cu_email, cu_address, cu_phone, cu_comment) " +
                    $"VALUES({nextCustomerID}, '{txtName.Text}', '{txtEmail.Text}', '{txtAddress.Text}', '{txtPhone.Text}', '{txtComment.Text}')");
                command.ExecuteNonQuery();

                MessageBox.Show("Customer added!", "INFO");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Name and Email fields can not be empty.", "Error");
            }
        }
    }
}
