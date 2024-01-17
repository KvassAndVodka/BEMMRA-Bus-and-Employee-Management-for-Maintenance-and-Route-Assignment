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
            // Same thing lmao... GRAB PERSONAL DATA RAHHHHHHHHHH
            this.username = username;
            this.password = password;
        }



        // At load, do this
        private void Maintenance_Load(object sender, EventArgs e)
        {
            // DB query string and connection
            string vStrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI";
            db = new DatabaseHelper(vStrConnection);
            
            // Load the table here bro 
            DataTable dtgetdata = new DataTable();
            dtgetdata = db.GetData("SELECT * FROM MAINTENANCE ORDER BY MaintenanceID ASC");
            dataGrid_Maintenance.DataSource = dtgetdata;
            dataGrid_Maintenance.Sort(dataGrid_Maintenance.Columns["MaintenanceID"], ListSortDirection.Ascending);
            PopulateBusComboBox();
        }



        // Checker if user has made inputs bro
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



        // Clear the inputs here bro
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



        // Row selection and data input 
        private void dataGrid_Maintenance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Initialize input field for comboBox
                comboBox_maintenanceBusID.SelectedIndex = -1;
                comboBox_maintenanceStatus.SelectedIndex = -1;

                // Bus ID
                comboBox_maintenanceBusID.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["BusID"].Value.ToString();
                
                // Maintenance Status
                comboBox_maintenanceStatus.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceStatus"].Value.ToString();

                // Maintenance Date
                dateTimePicker_maintenanceDate.Value = Convert.ToDateTime(dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceDate"].Value);

                // Maintenance Remarks
                textBox_Remarks.Text = dataGrid_Maintenance.Rows[e.RowIndex].Cells["MaintenanceRemarks"].Value.ToString();
            }
        }



        // Populate ComboBox obv
        private void PopulateBusComboBox()
        {
            // Query retrives busID that has not been in maintenance in more than 3 days
            string sql = "SELECT DISTINCT b.BusID " +
                         "FROM BUS b " +
                         "WHERE b.BusID NOT IN " +
                         "(SELECT m.BusID FROM MAINTENANCE m WHERE m.MaintenanceDate > NOW() - INTERVAL '3 days')";

            DataTable dt = db.GetData(sql);

            //populate silly combobox with them busID
            comboBox_maintenanceBusID.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                comboBox_maintenanceBusID.Items.Add(row["BusID"]);
            }
        }



        // Updating maintenance details
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

            // this id is for row reference
            int id = Convert.ToInt32(dataGrid_Maintenance.SelectedRows[0].Cells["MaintenanceID"].Value);
            
            // Query is basically for all maintenance details
            string sql = $"UPDATE MAINTENANCE SET BusID={comboBox_maintenanceBusID.Text.ToString()}, " +
                         $"MaintenanceStatus='{comboBox_maintenanceStatus.SelectedItem.ToString()}', " +
                         $"MaintenanceDate='{dateTimePicker_maintenanceDate.Value.ToString("yyyy-MM-dd")}', " +
                         $"MaintenanceRemarks='{textBox_Remarks.Text}' WHERE MaintenanceID={id}";

            // Execute query
            int rowAffected = db.ExecuteNonQuery(sql);

            if (rowAffected > 0)
            {
                DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                dataGrid_Maintenance.DataSource = dtgetdata;

                PopulateBusComboBox(); // Update the combo box data
                MessageBox.Show("Bus details have been successfully updated!");
            }
            else
            {
                MessageBox.Show("Failed to update Bus details. Please try again.");
            }
        }



        // Delete row lmao
        private void button_MaintenanceDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid_Maintenance.SelectedRows.Count > 0)
            {
                // Reference for row deletion
                int id = Convert.ToInt32(dataGrid_Maintenance.SelectedRows[0].Cells["MaintenanceID"].Value);

                // Query states this row
                string sql = $"DELETE FROM MAINTENANCE WHERE MaintenanceID = {id}";
                
                // Execute Query
                int rowsAffected = db.ExecuteNonQuery(sql);
                if (rowsAffected > 0)
                {
                    DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                    dataGrid_Maintenance.DataSource = dtgetdata;

                    PopulateBusComboBox(); // Update the combo box data
                    MessageBox.Show("Maintenance record has been successfully deleted!");
                }
                else
                {
                    MessageBox.Show("Failed to delete record. Please try again.");
                }
            }
        }



        // Yes, obviously, add new maintenance 
        private void button_MaintenanceAdd_Click(object sender, EventArgs e)
        {
            // Entries check
            if (!verify())
            {
                MessageBox.Show("Invalid input! Please fill in all required fields.");
                return;
            }

            // Yes, query states add this details into the table
            string sql = $"INSERT INTO MAINTENANCE (BusID, MaintenanceDate, MaintenanceStatus, MaintenanceRemarks) " +
                         $"VALUES ('{comboBox_maintenanceBusID.Text.ToString()}', " +
                         $"'{dateTimePicker_maintenanceDate.Value.ToString("yyyy-MM-dd")}', " +
                         $"'{comboBox_maintenanceStatus.SelectedItem.ToString()}', " +
                         $"'{textBox_Remarks.Text}')";

            // Execute query
            int rowsAffected = db.ExecuteNonQuery(sql);

            if (rowsAffected > 0)
            {
                DataTable dtgetdata = db.GetData("SELECT * FROM MAINTENANCE");
                dataGrid_Maintenance.DataSource = dtgetdata;

                ClearFields();
                PopulateBusComboBox(); // Update the combo box data
                MessageBox.Show("New maintenance appointment has been successfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add the appointment. Please try again.");
            }
        }
    }

}



