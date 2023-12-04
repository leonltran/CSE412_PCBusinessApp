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
    public partial class frmComputerDetails : Form
    {
        public frmComputerDetails()
        {
            InitializeComponent();
        }

        private void frmComputerDetails_Load(object sender, EventArgs e)
        {
            loadComputerList();
        }

        private void cbCompID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbCompID.Text != "")
                {
                    lCompDetails.Items.Clear();
                    lbCpu.Text = $"CPU:";
                    lbGpu.Text = $"GPU:";
                    lbHdd.Text = $"HDD:";
                    lbRam.Text = $"RAM:";
                    lbSsd.Text = $"SSD:";
                    lbUsb.Text = $"USB:";
                    string keyword = cbCompID.Text;
                    searchCompList(keyword);
                }
                else
                {
                    lCompDetails.Items.Clear();
                    lbCpu.Text = $"CPU:";
                    lbGpu.Text = $"GPU:";
                    lbHdd.Text = $"HDD:";
                    lbRam.Text = $"RAM:";
                    lbSsd.Text = $"SSD:";
                    lbUsb.Text = $"USB:";
                    loadComputerList();
                }
            }
        }
        private void loadComputerList()
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ("SELECT c_comp_id, c_type, c_weight FROM computer ORDER BY c_comp_id ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lCompDetails.Items.Add(listViewItem);
                }
            }
        }
        private void searchCompList(String keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($"SELECT c_comp_id, c_type, c_weight FROM computer WHERE c_comp_id = {int.Parse(keyword)} ORDER BY c_comp_id ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    string[] row = { dr[0].ToString(), dr[1].ToString(), dr[2].ToString() };
                    var listViewItem = new ListViewItem(row);
                    lCompDetails.Items.Add(listViewItem);
                }
            }
        }
        private void getCompDetails(String keyword)
        {
            if (Settings.Default.password != "")
            {
                string pass = Settings.Default.password;
                string connectionString = $"Host=localhost;Username=postgres;Password={pass};Database=postgres";
                var dataSource = NpgsqlDataSource.Create(connectionString);

                NpgsqlCommand command = dataSource.CreateCommand
                    ($@"
            SELECT
                c.c_comp_id,
                MAX(CASE WHEN p.p_type = 'CPU' THEN p.p_name END) AS CPU,
                MAX(CASE WHEN p.p_type = 'GPU' THEN p.p_name END) AS GPU,
                MAX(CASE WHEN p.p_type = 'HDD' THEN p.p_name END) AS HDD,
                MAX(CASE WHEN p.p_type = 'RAM' THEN p.p_name END) AS RAM,
                MAX(CASE WHEN p.p_type = 'SSD' THEN p.p_name END) AS SSD,
                MAX(CASE WHEN p.p_type = 'USB' THEN p.p_name END) AS USB
            FROM
                computer c
            JOIN
                compPart cp ON c.c_comp_id = cp.cp_comp_id
            JOIN
                part p ON cp.cp_pid = p.p_pid
            WHERE
                c.c_comp_id = {int.Parse(keyword)}
            GROUP BY
                c.c_comp_id
            ORDER BY
                c.c_comp_id ASC");
                NpgsqlDataReader dr = command.ExecuteReader();

                while (dr.Read())
                {
                    lbCpu.Text = $"CPU: {dr[1].ToString()}";
                    lbGpu.Text = $"GPU: {dr[2].ToString()}";
                    lbHdd.Text = $"HDD: {dr[3].ToString()}";
                    lbRam.Text = $"RAM: {dr[4].ToString()}";
                    lbSsd.Text = $"SSD: {dr[5].ToString()}";
                    lbUsb.Text = $"USB: {dr[6].ToString()}";
                }
            }
        }

        private void lCompDetails_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lCompDetails.SelectedItems.Count > 0)
            {
                string selectedId = lCompDetails.SelectedItems[0].SubItems[0].Text;
                getCompDetails(selectedId);
            }
            else
            {
                lbCpu.Text = $"CPU:";
                lbGpu.Text = $"GPU:";
                lbHdd.Text = $"HDD:";
                lbRam.Text = $"RAM:";
                lbSsd.Text = $"SSD:";
                lbUsb.Text = $"USB:";
            }
        }
    }
}
