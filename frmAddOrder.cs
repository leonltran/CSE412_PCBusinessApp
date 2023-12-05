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
    public partial class frmAddOrder : Form
    {
        private frmWelcome mainForm = null;

        private List<string> cids = [];

        private List<string> cpuPID = [];
        private List<string> gpuPID = [];
        private List<string> hddPID = [];
        private List<string> ramPID = [];
        private List<string> ssdPID = [];
        private List<string> usbPID = [];
        public frmAddOrder()
        {
            InitializeComponent();
        }
        public frmAddOrder(Form callingForm)
        {
            mainForm = callingForm as frmWelcome;
            InitializeComponent();
        }
        private void frmAddOrder_Load(object sender, EventArgs e)
        {
            string pass = Settings.Default.password;
            string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
            var dataSource = NpgsqlDataSource.Create(connectionString);

            // SELECT command for combo box population
            NpgsqlCommand command = dataSource.CreateCommand
                ($"SELECT p_pid, p_name, p_type, p_manufacturer FROM part");
            NpgsqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                string pid = dr[0].ToString();
                string name = dr[1].ToString();
                string type = dr[2].ToString();
                string manufacturer = dr[3].ToString();
                string entry = $"{manufacturer} - {name}";
                switch (type)
                {
                    case "CPU":
                        cbCPU.Items.Add(entry);
                        cpuPID.Add(pid);
                        break;
                    case "GPU":
                        cbGPU.Items.Add(entry);
                        gpuPID.Add(pid);
                        break;
                    case "HDD":
                        cbHDD.Items.Add(entry);
                        hddPID.Add(pid);
                        break;
                    case "RAM":
                        cbRAM.Items.Add(entry);
                        ramPID.Add(pid);
                        break;
                    case "SSD":
                        cbSSD.Items.Add(entry);
                        ssdPID.Add(pid);
                        break;
                    case "USB":
                        cbUSB.Items.Add(entry);
                        usbPID.Add(pid);
                        break;
                }
            }

            command = dataSource.CreateCommand
                ($"SELECT cu_cid, cu_name FROM customer");
            dr = command.ExecuteReader();

            while (dr.Read())
            {
                string cid = dr[0].ToString();
                string name = dr[1].ToString();
                string entry = $"{cid} - {name}";
                cbCustomer.Items.Add(entry);
                cids.Add(cid);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double price = 0;
                double weight = 0;

                // ARGUMENT CHECKING
                foreach (Control c in this.Controls)
                {
                    if (c is ComboBox)
                    {
                        ComboBox cb = c as ComboBox;
                        if (cb.SelectedIndex < 0)
                        {
                            throw new ArgumentNullException();
                        }
                    }
                }
                if (txtPrice.Text == "" || txtWeight.Text == "") throw new ArgumentNullException();
                if (!double.TryParse(txtPrice.Text, out price)) // if parse == false
                {
                    throw new ArgumentException();
                }
                if (!double.TryParse(txtWeight.Text, out weight)) // if parse == false
                {
                    throw new ArgumentException();
                }



                string nextOrderID = "";
                string nextComputerID = "";

                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                // get next computer ID serially
                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT MAX(c_comp_id) FROM computer");
                NpgsqlDataReader dr = command.ExecuteReader();
                while (dr.Read())
                {
                    // if the database was originally made with the primary key as SERIAL
                    // this wouldn't be necessary, but we weren't taught that in class were we?
                    nextComputerID = (dr.GetInt32(0) + 1).ToString();
                }

                // get next order ID serially
                command = dataSource.CreateCommand
                    ($"SELECT MAX(o_oid) FROM orders");
                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    // if the database was originally made with the primary key as SERIAL
                    // this wouldn't be necessary, but we weren't taught that in class were we?
                    nextOrderID = (dr.GetInt32(0) + 1).ToString();
                }



                // get cid of customer
                string cid = cids[cbCustomer.SelectedIndex];
                string date = dtpDate.Value.ToString("yyyy-MM-dd");

                // INSERT into orders
                command = dataSource.CreateCommand
                    ("INSERT INTO orders(o_oid, o_cid, o_price, o_date, o_type, o_status, o_comment) " +
                $"VALUES({nextOrderID}, {cid}, '{price}', '{date}', '{cbType.Text}', 'Processing', '{txtComment.Text}')");
                command.ExecuteNonQuery();



                // get PID of parts
                string cpu = cpuPID[cbCPU.SelectedIndex];
                string gpu = gpuPID[cbGPU.SelectedIndex];
                string hdd = hddPID[cbHDD.SelectedIndex];
                string ram = ramPID[cbRAM.SelectedIndex];
                string ssd = ssdPID[cbSSD.SelectedIndex];
                string usb = usbPID[cbUSB.SelectedIndex];

                // INSERT computer
                command = dataSource.CreateCommand
                    ("INSERT INTO computer(c_oid, c_comp_id, c_type, c_weight) " +
                $"VALUES({nextOrderID}, {nextComputerID}, '{cbComputerType.Text}', {weight})");
                command.ExecuteNonQuery();

                // INSERT compparts
                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{cpu}')");
                command.ExecuteNonQuery();

                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{gpu}')");
                command.ExecuteNonQuery();

                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{hdd}')");
                command.ExecuteNonQuery();

                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{ram}')");
                command.ExecuteNonQuery();

                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{ssd}')");
                command.ExecuteNonQuery();

                command = dataSource.CreateCommand
                    ("INSERT INTO comppart(cp_comp_id, cp_pid) " +
                $"VALUES({nextComputerID}, '{usb}')");
                command.ExecuteNonQuery();

                mainForm.updateOrdersList();
                MessageBox.Show("Order added!", "INFO");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("All fields must be specified.", "Error");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Price or computer weight must be a numerical value.", "Error");
            }
        }
    }
}
