using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class Bus : Form
    {
        private string username;
        private string password;

        private DatabaseHelper db;



        public Bus(string username, string password)
        {
            InitializeComponent();
            
            // Grab username and password
            this.username = username;
            this.password = password;
        }




        // Processes on load
        private void Bus_Load(object sender, EventArgs e)
        {
            // Connection String
            string vStrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI;";
            
            // Connection handler
            db = new DatabaseHelper(vStrConnection);
            DataTable dtgetdata = new DataTable();

            
            // Query and displaying Bus table
            dtgetdata = db.GetData("SELECT * FROM BUS ORDER BY BusID ASC");
            dataGrid_Buses.DataSource = dtgetdata;
            dataGrid_Buses.Sort(dataGrid_Buses.Columns["BusID"], ListSortDirection.Ascending);
        }



        // Function to check if inputs are complete
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_busesBusID.Text) ||
                string.IsNullOrWhiteSpace(textBox_busesBusModel.Text) ||
                dateTimePicker_busesDateInFleet.Value == null ||
                comboBox_busesBusStatus.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // Function to clear inputs
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



        // Function to load data from the row of the table to the input fields
        private void dataGrid_Buses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Bus ID
                textBox_busesBusID.Text = dataGrid_Buses.Rows[e.RowIndex].Cells["BusID"].Value.ToString();
                
                // Bus Model
                textBox_busesBusModel.Text = dataGrid_Buses.Rows[e.RowIndex].Cells["BusModel"].Value.ToString();

                // Date in Fleet
                dateTimePicker_busesDateInFleet.Value = Convert.ToDateTime(dataGrid_Buses.Rows[e.RowIndex].Cells["DateInFleet"].Value);

                // Bus Status
                comboBox_busesBusStatus.SelectedIndex = -1;
                comboBox_busesBusStatus.Text = dataGrid_Buses.Rows[e.RowIndex].Cells["BusStatus"].Value.ToString();

                // Calculate and display years in fleet
                DateTime dateInFleet = Convert.ToDateTime(dataGrid_Buses.Rows[e.RowIndex].Cells["DateInFleet"].Value);
                int yearsInFleet = DateTime.Now.Year - dateInFleet.Year;
                label_busesYearsInFleet.Text = "Years In Fleet:     " + yearsInFleet.ToString();

                // Bus Route
                string routeName = db.GetRouteNameByBusID(Convert.ToInt32(dataGrid_Buses.Rows[e.RowIndex].Cells["BusID"].Value));
                label_busesRoute.Text = "Route:     " + routeName;
            }
        }



        // Update bus details
        private void button_busesUpdate_Click(object sender, EventArgs e)
        {
            // Check if all inputs are filled
            if (dataGrid_Buses.SelectedRows.Count > 0)
            {
                if (!verify())
                {
                    MessageBox.Show("Invalid input! Please fill in all required fields.");
                    return;
                }
            }

            // Notes the bus id of the row of details that needs to be changed
            int id = Convert.ToInt32(dataGrid_Buses.SelectedRows[0].Cells["BusID"].Value);
            
            // Update query string for bus row
            string sql = $"UPDATE BUS SET BusID='{textBox_busesBusID.Text}', BusModel='{textBox_busesBusModel.Text}', dateInFleet='{dateTimePicker_busesDateInFleet.Value.ToString("yyyy-MM-dd")}', " +
                $"BusStatus='{comboBox_busesBusStatus.SelectedItem.ToString()}' WHERE BusID={id}";

            // Execute query
            int rowsAffected = db.ExecuteNonQuery(sql);

            if (rowsAffected > 0)
            {
                // Fetch the data again from the database
                DataTable dtgetdata = db.GetData("SELECT * FROM BUS");
                // Assign the fetched data to the DataSource of the DataGridView
                dataGrid_Buses.DataSource = dtgetdata;
                // Show success message
                MessageBox.Show("Bus details have been successfully updated!");
            }
            else
            {
                MessageBox.Show("Failed to update Bus details. Please try again.");
            }
        }


        
        // Delete row function
        private void button_busesDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid_Buses.SelectedRows.Count > 0)
            {
                // Row selection and query
                int id = Convert.ToInt32(dataGrid_Buses.SelectedRows[0].Cells["BusID"].Value);
                string sql = $"DELETE FROM BUS WHERE BusID = {id}";

                // Execute query
                int rowsAffected = db.ExecuteNonQuery(sql);
                
                if (rowsAffected > 0)
                {
                    DataTable dtgetdata = db.GetData("SELECT * FROM BUS");
                    dataGrid_Buses.DataSource = dtgetdata;
                    MessageBox.Show("Bus has been succesfully deleted");

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete bus. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No bus seleected for deletion.");
            }

        }



        // Add bus function
        private void button_busesAdd_Click(object sender, EventArgs e)
        {
            // Check if input is complete
            if (!verify())
            {
                MessageBox.Show("Invalid input! Please fill in all required fields.");
                return;
            }


            // SQL Query for data insertion
            string sql = $"INSERT INTO BUS (BusID, BusModel, DateInFleet, BusStatus) " +
                         $"VALUES ('{textBox_busesBusID.Text}', '{textBox_busesBusModel.Text}', " +
                         $"'{dateTimePicker_busesDateInFleet.Value.ToString("yyyy-MM-dd")}', " +
                         $"'{comboBox_busesBusStatus.SelectedItem.ToString()}')";

            // Execute Query
            int rowsAffected = db.ExecuteNonQuery(sql);
            
            if (rowsAffected > 0)
            {
                DataTable dtgetdata = db.GetData("SELECT * FROM BUS");

                dataGrid_Buses.DataSource = dtgetdata;

                ClearFields();
                MessageBox.Show("New bus has been succesfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add new bus. Please try again.");
            }

        }
    }
}
