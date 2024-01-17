using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class ManageEmployee : Form
    {
        private string username;
        private string password;

        private DatabaseHelper db;



        public ManageEmployee(string username, string password)
        {
            InitializeComponent();
            
            // Grab Credentials
            this.username = username;
            this.password = password;
        }



        // WinForms load processes
        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // Database query, and connection 
            string vStrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI;";
            db = new DatabaseHelper(vStrConnection);
            
            // Load Employee Data
            DataTable dtgetdata = new DataTable();
            dtgetdata = db.GetData("SELECT * FROM EMPLOYEE ORDER BY EmployeeID ASC");
            dataGrid_AddEmployee.DataSource = dtgetdata;
            dataGrid_AddEmployee.Sort(dataGrid_AddEmployee.Columns["EmployeeID"], ListSortDirection.Ascending);
        }



        // Veryify if all fields are filled up
        bool verify()
        {
            if (string.IsNullOrWhiteSpace(textBox_firstName.Text) ||
                string.IsNullOrWhiteSpace(textBox_lastName.Text) ||
                string.IsNullOrWhiteSpace(textBox_employeeAddress.Text) ||
                dateTimePicker_birthdate.Value == null ||
                comboBox_employeeRole.SelectedItem == null ||
                comboBox_Gender.SelectedItem == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // Clear all fields
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



        // Row click and data fillup function
        private void dataGrid_AddEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // First Name
                textBox_firstName.Text = dataGrid_AddEmployee.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                
                // Last Name
                textBox_lastName.Text = dataGrid_AddEmployee.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                
                // Address
                textBox_employeeAddress.Text = dataGrid_AddEmployee.Rows[e.RowIndex].Cells["EmployeeAddress"].Value.ToString();

                // Gender
                comboBox_Gender.Text = dataGrid_AddEmployee.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                
                // Role
                comboBox_employeeRole.Text = dataGrid_AddEmployee.Rows[e.RowIndex].Cells["EmployeeRole"].Value.ToString();

                // Birthdate
                dateTimePicker_birthdate.Value = Convert.ToDateTime(dataGrid_AddEmployee.Rows[e.RowIndex].Cells["Birthdate"].Value);
                
                // Date Employed
                dateTimePicker_employmentDate.Value = Convert.ToDateTime(dataGrid_AddEmployee.Rows[e.RowIndex].Cells["EmploymentDate"].Value);

                // Calculate and display years employed
                DateTime employmentDate = Convert.ToDateTime(dataGrid_AddEmployee.Rows[e.RowIndex].Cells["EmploymentDate"].Value);
                int yearsEmployed = DateTime.Now.Year - employmentDate.Year;
                label_yearsEmployed.Text = "Years Employed:     " + yearsEmployed.ToString();
            }
        }



        // Add employee
        private void button_EmployeeAdd_Click(object sender, EventArgs e)
        {
            // Verify if fields are complete
            if (!verify())
            {
                MessageBox.Show("Invalid input! Please fill in all required fields.");
                return;
            }

            // SQL Query for data insertion
            string sql = $"INSERT INTO EMPLOYEE (FirstName, LastName, EmployeeAddress, Gender, EmployeeRole, Birthdate, EmploymentDate) " +
                         $"VALUES ('{textBox_firstName.Text}', '{textBox_lastName.Text}', '{textBox_employeeAddress.Text}', " +
                         $"'{comboBox_Gender.SelectedItem.ToString()}', '{comboBox_employeeRole.SelectedItem.ToString()}', " +
                         $"'{dateTimePicker_birthdate.Value.ToString("yyyy-MM-dd")}', '{dateTimePicker_employmentDate.Value.ToString("yyyy-MM-dd")}')";

            // Execute Query
            int rowsAffected = db.ExecuteNonQuery(sql);
            
            if (rowsAffected > 0)
            {
                // Fetch the data again from the database
                DataTable dtgetdata = db.GetData("SELECT * FROM EMPLOYEE");
                // Assign the fetched data to the DataSource of the DataGridView
                dataGrid_AddEmployee.DataSource = dtgetdata;
                // Clear all fields
                ClearFields();
                // Show success message
                MessageBox.Show("New employee has been successfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add new employee. Please try again.");
            }
        }



        // Delete employee details
        private void button_EmployeeDelete_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGrid_AddEmployee.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int id = Convert.ToInt32(dataGrid_AddEmployee.SelectedRows[0].Cells["EmployeeID"].Value);

                // Create a DELETE SQL command
                string sql = $"DELETE FROM EMPLOYEE WHERE EmployeeID = {id}";

                // Execute the DELETE operation
                int rowsAffected = db.ExecuteNonQuery(sql);
                if (rowsAffected > 0)
                {
                    // Fetch the data again from the database
                    DataTable dtgetdata = db.GetData("SELECT * FROM EMPLOYEE");
                    // Assign the fetched data to the DataSource of the DataGridView
                    dataGrid_AddEmployee.DataSource = dtgetdata;
                    // Show success message
                    MessageBox.Show("Employee has been successfully deleted!");

                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Failed to delete employee. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No employee selected for deletion.");
            }
        }



        // Update Employee data
        private void button_EmployeeUpdate_Click(object sender, EventArgs e)
        {
            // Check if a row is selected
            if (dataGrid_AddEmployee.SelectedRows.Count > 0)
            {
                // Call the verify function
                if (!verify())
                {
                    MessageBox.Show("Invalid input! Please fill in all required fields.");
                    return;
                }

                // Get the ID of the selected row
                int id = Convert.ToInt32(dataGrid_AddEmployee.SelectedRows[0].Cells["EmployeeID"].Value);

                // Construct the UPDATE SQL command
                string sql = $"UPDATE EMPLOYEE SET FirstName='{textBox_firstName.Text}', LastName='{textBox_lastName.Text}', EmployeeAddress='{textBox_employeeAddress.Text}', " +
                    $"Gender='{comboBox_Gender.SelectedItem.ToString()}', EmployeeRole='{comboBox_employeeRole.SelectedItem.ToString()}', " +
                    $"Birthdate='{dateTimePicker_birthdate.Value.ToString("yyyy-MM-dd")}', EmploymentDate='{dateTimePicker_employmentDate.Value.ToString("yyyy-MM-dd")}' " +
                    $"WHERE EmployeeID={id}";

                // Execute the UPDATE operation
                int rowsAffected = db.ExecuteNonQuery(sql);
                if (rowsAffected > 0)
                {
                    // Fetch the data again from the database
                    DataTable dtgetdata = db.GetData("SELECT * FROM EMPLOYEE");
                    // Assign the fetched data to the DataSource of the DataGridView
                    dataGrid_AddEmployee.DataSource = dtgetdata;
                    // Show success message
                    MessageBox.Show("Employee details have been successfully updated!");
                }
                else
                {
                    MessageBox.Show("Failed to update employee details. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No employee selected for updating.");
            }
        }


    }
}