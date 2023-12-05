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
using System.Xml;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace CSE412_PCBusinessApp
{
    public partial class frmAddComputer : Form
    {
        private string oid = "";
        private frmOrder mainForm = null;

        private List<string> cpuPID = [];
        private List<string> gpuPID = [];
        private List<string> hddPID = [];
        private List<string> ramPID = [];
        private List<string> ssdPID = [];
        private List<string> usbPID = [];
        public frmAddComputer()
        {
            InitializeComponent();
        }
        public frmAddComputer(string oid, Form callingForm)
        {
            mainForm = callingForm as frmOrder;
            InitializeComponent();
            this.oid = oid;
        }
        private void frmAddComputer_Load(object sender, EventArgs e)
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
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                double weight = 0;

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
                if (txtWeight.Text == "") throw new ArgumentNullException();
                if (!double.TryParse(txtWeight.Text, out weight)) // if parse fails
                {
                    throw new ArgumentException();
                }

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
                $"VALUES({oid}, {nextComputerID}, '{cbType.Text}', {weight})");
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

                mainForm.updateComputerList();
                MessageBox.Show("Computer added!", "INFO");
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Computer type, weight, and parts must be specified.", "Error");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Weight must be a numerical value.", "Error");
            }

        }
    }
}
