using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class Maintenance : Form
    {
        private string username;
        private string password;


        private DatabaseHelper db;
        public Maintenance(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            string vStrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI";
            db = new DatabaseHelper(vStrConnection);
            DataTable dtgetdata = new DataTable();

            dtgetdata = db.GetData("SELECT * FROM MAINTENANCE ORDER BY MaintenanceID ASC");

            dataGrid_Maintenance.DataSource = dtgetdata;

            dataGrid_Maintenance.Sort(dataGrid_Maintenance.Columns["MaintenanceID"], ListSortDirection.Ascending);
            PopulateBusComboBox();
        }

        bool verify()
        {
            if (string.IsNullOrWhiteSpace(comboBox_maintenanceBusID.Text) ||
                string.IsNullOrWhiteSpace(comboBox_maintenanceStatus.Text) ||
                dateTimePicker_maintenanceDate.Value == null)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private void ClearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    TextBox tb = (TextBox)ctrl;
                    if (tb != null)
                    {
                        tb.Text = string.Empty;
                    }
                }
                else if (ctrl is ComboBox)
                {
                    ComboBox cb = (ComboBox)ctrl;
                    if (cb != null)
                    {
                        cb.Text = string.Empty;
                        cb.SelectedIndex = -1;
                    }
                }
                else if (ctrl is DateTimePicker)
                {
                    DateTimePicker dtp = (DateTimePicker)ctrl;
                    if (dtp != null)
                    {
                        dtp.Value = DateTime.Now;
                    }
                }
            }
        }

        private void dataGrid_Maintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboBox_maintenanceBusID.SelectedIndex = -1;
                comboBox_maintenanceStatus.SelectedIndex = -1;

                comboBox_maintenanceBusID.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["BusID"].Value.ToString();
                comboBox_maintenanceStatus.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceStatus"].Value.ToString();

                dateTimePicker_maintenanceDate.Value = Convert.ToDateTime(dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceDate"].Value);

                textBox_Remarks.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceRemarks"].Value.ToString();
            }
        }

        private void PopulateBusComboBox()
        {
            string sql = "SELECT BusID FROM MAINTENANCE WHERE MaintenanceDate <= NOW() - INTERVAL '3 days' GROUP BY BusID";
            DataTable dt = db.GetData(sql);

            comboBox_maintenanceBusID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox_maintenanceBusID.Items.Add(row["BusID"]);
            }
        }

        private void button_MaintenanceUpdate_Click(object sender, EventArgs e)
        {
            if (dataGrid_Maintenance.SelectedRows.Count > 0)
            {
                if (!verify())
                {
                    MessageBox.Show("Invalid input! Please fill in all required fields.");
                    return;
                }
            }

            int id = Convert.ToInt32(dataGrid_Maintenance.SelectedRows[0].Cells["MaintenanceID"].Value);

            string sql = $"UPDATE MAINTENANCE SET BusID={comboBox_maintenanceBusID.Text.ToString()}, " +
                         $"MaintenanceStatus='{comboBox_maintenanceStatus.SelectedItem.ToString()}', " +
                         $"MaintenanceDate='{dateTimePicker_maintenanceDate.Value.ToString("yyyy-MM-dd")}', " +
                         $"MaintenanceRemarks='{textBox_Remarks.Text}' WHERE MaintenanceID={id}";

            int rowAffected = db.ExecuteNonQuery(sql);

            if (rowAffected > 0)
            {
                DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                dataGrid_Maintenance.DataSource = dtgetdata;

                MessageBox.Show("Bus details have been successfully updated!");
            }
            else
            {
                MessageBox.Show("Failed to update Bus details. Please try again.");
            }
        }


        private void button_MaintenanceDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid_Maintenance.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGrid_Maintenance.SelectedRows[0].Cells["MaintenanceID"].Value);

                string sql = $"DELETE FROM MAINTENANCE WHERE MaintenanceID = {id}";

                int rowsAffected = db.ExecuteNonQuery(sql);
                if (rowsAffected > 0)
                {
                    DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                    dataGrid_Maintenance.DataSource = dtgetdata;

                    MessageBox.Show("Maintenance record has been successfully deleted!");
                }
                else
                {
                    MessageBox.Show("Failed to delete record. Please try again.");
                }

            }
        }

        private void button_MaintenanceAdd_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Invalid input! Please fill in all required fields.");
                return;
            }

            string sql = $"INSERT INTO MAINTENANCE (BusID, MaintenanceDate, MaintenanceStatus, MaintenanceRemarks) " +
                         $"VALUES ('{comboBox_maintenanceBusID.Text.ToString()}', " +
                         $"'{dateTimePicker_maintenanceDate.Value.ToString("yyyy-MM-dd")}', " +
                         $"'{comboBox_maintenanceStatus.SelectedItem.ToString()}', " +
                         $"'{textBox_Remarks.Text}')";

            int rowsAffected = db.ExecuteNonQuery(sql);

            if (rowsAffected > 0)
            {
                DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                dataGrid_Maintenance.DataSource = dtgetdata;

                ClearFields();
                MessageBox.Show("New maintenance appointment has been successfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add the appointment. Please try again.");
            }

        }

    }
}


