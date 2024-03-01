using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class Routes : Form
    {
        private string username;
        private string password;
        private DatabaseHelper db;



        // Dictionary for routes and respective bus models
        private Dictionary<string, List<string>> routeToBusModels = new Dictionary<string, List<string>>()
        {
            { "Cagayan de Oro – Davao", new List<string> { "King Long XMQ6129Y5", "King Long XMQ6125AY", "King Long XMQ6128AYW", "King Long XMQ6128AYWO", "Viking 11", "Yutong ZK6127HA" } },
            { "Cagayan de Oro – Maramag", new List<string> { "Yutong ZK6127HA" } },
            { "Cagayan de Oro – Kibawe", new List<string> { "Viking 10", "Viking 11", "Yutong ZK6119HYG" } },
            { "Cagayan de Oro – Damulog", new List<string> { "Viking 10", "Viking 11", "Yutong ZK6119HYG" } },
            { "Cagayan de Oro – Kadingilan", new List<string> { "Viking 11" } },
            { "Cagayan de Oro – Tacurong", new List<string> { "Viking 11", "Yutong ZK6119HYG" } },
            { "Cagayan de Oro – General Santos", new List<string> { "Viking 11", "Yutong ZK6127HA" } },
            { "Cagayan de Oro – Balingasag", new List<string> { "Yutong ZK6858H9" } },
            { "Cagayan de Oro – Balingoan", new List<string> { "FB4J" } },
            { "Valencia – Kibawe", new List<string> { "FB4J" } },
            { "Valencia – Kadingilan", new List<string> { "FB4J" } },
            { "Valencia – Wao", new List<string> { "FB4J" } },
            { "Malaybalay – Kibawe", new List<string> { "FB4J" } },
            { "Malaybalay – Kalilangan", new List<string> { "FB4J" } }
        };




        public Routes(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;

            comboBox_Route.SelectedIndexChanged += new EventHandler(comboBox_Route_SelectedIndexChanged);
            comboBox_routeBusModel.SelectedIndexChanged += new EventHandler(comboBox_routeBusModel_SelectedIndexChanged);
            comboBox_routeBusID.SelectedIndexChanged += new EventHandler(comboBox_routeBusID_SelectedIndexChanged);
        }



        // Obviously
        private void Refresh_Table()
        {
            // In this query, to make it simpler for the OpMan, it shows the name instead of empID, so I join EMPLOYEE with ROUTE with some conditions
            string query = @"
                SELECT
                    R.RouteID,
                    R.RouteName,
                    R.BusID,
                    CONCAT(ED.FirstName, ' ', ED.LastName) AS DriverFullName,
                    CONCAT(EC.FirstName, ' ', EC.LastName) AS ConductorFullName,
                    R.RouteSchedule,
                    R.RouteStatus
                FROM
                    ROUTE R
                LEFT JOIN
                    EMPLOYEE ED ON R.AssignedDriver = ED.EmployeeID
                LEFT JOIN
                    EMPLOYEE EC ON R.AssignedConductor = EC.EmployeeID
            ";

            DataTable dtGetdata = db.GetData(query);
            dataGrid_Routes.DataSource = dtGetdata;
        }



        // When open routes.cs, do this
        private void Routes_Load(object sender, EventArgs e)
        {
            // AAAAAAAAAAAA, yes connect db
            string vStrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI;";
            db = new DatabaseHelper(vStrConnection);
            DataTable dtgetdata = new DataTable();

            // initial load sa data, same thing sa query sa Refresh_Table()
            string query = @"
                SELECT
                    R.RouteID,
                    R.RouteName,
                    R.BusID,
                    CONCAT(ED.FirstName, ' ', ED.LastName) AS DriverFullName,
                    CONCAT(EC.FirstName, ' ', EC.LastName) AS ConductorFullName,
                    R.RouteSchedule,
                    R.RouteStatus
                FROM
                    ROUTE R
                LEFT JOIN
                    EMPLOYEE ED ON R.AssignedDriver = ED.EmployeeID
                LEFT JOIN
                    EMPLOYEE EC ON R.AssignedConductor = EC.EmployeeID
            ";

            // show table
            dtgetdata = db.GetData(query);
            dataGrid_Routes.DataSource = dtgetdata;
            dataGrid_Routes.Sort(dataGrid_Routes.Columns["RouteID"], ListSortDirection.Ascending);

            // Load routetobus dict then populate
            comboBox_Route.DataSource = routeToBusModels.Keys.ToList();
            comboBox_Route.DisplayMember = "Key";

            // retrieve driver names then populate the combo box
            string driverQuery = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM EMPLOYEE WHERE EmployeeRole = 'Driver'";
            DataTable dtDrivers = db.GetData(driverQuery);
            comboBox_routeDriver.DisplayMember = "FullName";
            comboBox_routeDriver.ValueMember = "EmployeeID";
            comboBox_routeDriver.DataSource = dtDrivers;

            // retrieve conductor names then populate the combo box
            string conductorQuery = "SELECT EmployeeID, CONCAT(FirstName, ' ', LastName) AS FullName FROM EMPLOYEE WHERE EmployeeRole = 'Conductor'";
            DataTable dtConductors = db.GetData(conductorQuery);
            comboBox_routeConductor.DisplayMember = "FullName";
            comboBox_routeConductor.ValueMember = "EmployeeID";
            comboBox_routeConductor.DataSource = dtConductors;
        }



        // same function, check empty fields
        bool verify()
        {
            if (string.IsNullOrEmpty(comboBox_Route.Text) ||
                string.IsNullOrEmpty(comboBox_routeBusModel.Text) ||
                string.IsNullOrEmpty(comboBox_routeDriver.Text) ||
                string.IsNullOrEmpty(comboBox_routeConductor.Text) ||
                string.IsNullOrEmpty(comboBox_routeStatus.Text) ||
                dateTimePicker_routeDate.Value == null ||
                dateTimePicker_routeTime.Value == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }



        // usual, clear fields lmao
        private void ClearFields()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is ComboBox)
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



        //  Retrieve bus ids with that bus model
        private string GetBusModelByBusID(int busID)
        {
            string query = $"SELECT BusModel FROM BUS WHERE BusID = {busID}";
            DataTable dtgetdata = db.GetData(query);

            if (dtgetdata.Rows.Count > 0)
            {
                return dtgetdata.Rows[0]["BusModel"].ToString();
            }
            else
            {
                return "";
            }
        }



        // Usual row data to entry fields
        private void dataGrid_Routes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                comboBox_Route.SelectedIndex = -1;
                comboBox_routeBusModel.SelectedIndex = -1;
                comboBox_routeBusID.SelectedIndex = -1;
                comboBox_routeDriver.SelectedIndex = -1;
                comboBox_routeConductor.SelectedIndex = -1;
                comboBox_routeStatus.SelectedIndex = -1;

                comboBox_Route.Text = dataGrid_Routes.Rows[e.RowIndex].Cells["RouteName"].Value.ToString();
                comboBox_routeBusID.Text = dataGrid_Routes.Rows[e.RowIndex].Cells["BusID"].Value.ToString();
                comboBox_routeBusModel.Text = GetBusModelByBusID(Convert.ToInt32(comboBox_routeBusID.Text));
                comboBox_routeDriver.Text = dataGrid_Routes.Rows[e.RowIndex].Cells["DriverFullName"].Value.ToString();
                comboBox_routeConductor.Text = dataGrid_Routes.Rows[e.RowIndex].Cells["ConductorFullName"].Value.ToString();
                comboBox_routeStatus.Text = dataGrid_Routes.Rows[e.RowIndex].Cells["RouteStatus"].Value.ToString();

                dateTimePicker_routeDate.Value = Convert.ToDateTime(dataGrid_Routes.Rows[e.RowIndex].Cells["RouteSchedule"].Value);
                dateTimePicker_routeTime.Value = Convert.ToDateTime(dataGrid_Routes.Rows[e.RowIndex].Cells["RouteSchedule"].Value);

            }
        }



        // Check if there is data change in combobox
        private void comboBox_Route_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string selectedRoute = comboBox.Text;

            if (routeToBusModels.ContainsKey(selectedRoute))
            {
                List<string> compatibleBusModels = routeToBusModels[selectedRoute];

                string query = $@"
               SELECT DISTINCT BusModel
               FROM BUS
               WHERE BusModel IN ('{string.Join("', '", compatibleBusModels)}') AND BusStatus IN ('Operational', 'In Garage');";

                DataTable dtBusModels = db.GetData(query);

                comboBox_routeBusModel.DisplayMember = "BusModel";
                comboBox_routeBusModel.ValueMember = "BusModel";
                comboBox_routeBusModel.DataSource = dtBusModels;
                comboBox_routeBusModel.SelectedIndex = -1;
            }
        }


      
        // Check if there is data change in combobox
        private void comboBox_routeBusModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_routeBusModel.SelectedValue != null)
            {
                string busModel = comboBox_routeBusModel.SelectedValue.ToString();

                string query = $@"
                               SELECT BusID
                               FROM BUS
                               WHERE BusModel = '{busModel}' AND BusStatus IN ('Operational', 'In Garage');";

                DataTable dtBusIDs = db.GetData(query);

                comboBox_routeBusID.DisplayMember = "BusID";
                comboBox_routeBusID.ValueMember = "BusID";
                comboBox_routeBusID.DataSource = dtBusIDs;
                comboBox_routeBusID.SelectedIndex = -1;
            }
        }



        // Check if there is data change in combobox
        private void comboBox_routeBusID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_routeBusID.SelectedValue != null)
            {
                string busID = comboBox_routeBusID.SelectedValue.ToString();

                // Retrieve the last maintenance date
                string query = $"SELECT MAX(MaintenanceDate) FROM MAINTENANCE WHERE BusID = {busID}";
                DataTable dtLastMaintenance = db.GetData(query);
                DateTime lastMaintenanceDate;
                if (dtLastMaintenance.Rows.Count > 0)
                {
                    string dateStr = dtLastMaintenance.Rows[0]["MAX"].ToString();
                    if (!DateTime.TryParse(dateStr, out lastMaintenanceDate))
                    {
                        // Handle the case where the date string could not be parsed
                        label_lastMaintenance.Text = "Last Maintenance: Too long ago!";
                        return;
                    }
                }
                else
                {
                    // Handle case where no maintenance records exist for the busID
                    label_lastMaintenance.Text = "No maintenance records available.";
                    return;
                }

                // Calculate the difference in days
                TimeSpan timeSpan = DateTime.Now - lastMaintenanceDate;
                int daysSinceLastMaintenance = timeSpan.Days;

                // Display the result
                label_lastMaintenance.Text = $"Last maintenance was {daysSinceLastMaintenance} days ago.";
            }
        }



        // Update row details
        private void button_routesUpdate_Click(object sender, EventArgs e)
        {
            if (dataGrid_Routes.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGrid_Routes.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGrid_Routes.Rows[selectedIndex];

                string selectedDriverName = comboBox_routeDriver.Text;
                int selectedDriverId = (int)comboBox_routeDriver.SelectedValue;

                string selectedConductorName = comboBox_routeDriver.Text;
                int selectedConductorID = (int)comboBox_routeConductor.SelectedValue;

                // Assuming the RouteID is stored in the first column of the DataGridView
                int id = Convert.ToInt32(dataGrid_Routes.SelectedRows[0].Cells["RouteID"].Value);

                // Check if fields are empty
                if (!string.IsNullOrEmpty(comboBox_Route.Text) && !string.IsNullOrEmpty(comboBox_routeBusID.Text) &&
                    !string.IsNullOrEmpty(comboBox_routeStatus.Text) && comboBox_routeDriver.SelectedItem != null &&
                    comboBox_routeConductor.SelectedItem != null)
                {
                    // Construct the SQL UPDATE command
                    string sql = $"UPDATE ROUTE SET " +
                                $"RouteName = '{comboBox_Route.Text}', " +
                                $"BusID = {comboBox_routeBusID.Text}, " +
                                $"AssignedDriver = '{selectedDriverId}' , " +
                                $"AssignedConductor = '{selectedConductorID}' , " +
                                $"RouteStatus = '{comboBox_routeStatus.Text}', " +
                                $"RouteSchedule = '{dateTimePicker_routeDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}' " +
                                $"WHERE RouteID = {id}";

                    // Execute the SQL command
                    int rowsAffected = db.ExecuteNonQuery(sql);

                    if (rowsAffected > 0)
                    {
                        // Refresh the DataGridView
                        MessageBox.Show("Route data has been succesfully updated.");
                        Refresh_Table();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update the route. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("One or more fields are empty. Please fill them out before updating.");
                }
            }
        }



        // delete row data
        private void button_routesDelete_Click(object sender, EventArgs e)
        {
            if (dataGrid_Routes.SelectedCells.Count > 0)
            {
                int selectedIndex = dataGrid_Routes.CurrentCell.RowIndex;
                DataGridViewRow selectedRow = dataGrid_Routes.Rows[selectedIndex];

                // Assuming the RouteID is stored in the first column of the DataGridView
                string routeID = selectedRow.Cells[0].Value.ToString();

                // Construct the SQL DELETE command
                string sql = $"DELETE FROM ROUTE WHERE RouteID = {routeID}";

                // Execute the SQL command
                int rowsAffected = db.ExecuteNonQuery(sql);

                if (rowsAffected > 0)
                {
                    // Refresh the DataGridView
                    MessageBox.Show("Route data has been successfully deleted.");
                    Refresh_Table();
                }
                else
                {
                    MessageBox.Show("Failed to delete the route. Please try again.");
                }
            }
        }



        // add row data
        private void button_routesAdd_Click(object sender, EventArgs e)
        {
            if (!verify())
            {
                MessageBox.Show("Invalid input! Please fill in all required fields.");
                return;
            }


            string selectedDriverName = comboBox_routeDriver.Text;
            int selectedDriverId = (int)comboBox_routeDriver.SelectedValue;

            string selectedConductorName = comboBox_routeDriver.Text;
            int selectedConductorID = (int)comboBox_routeConductor.SelectedValue;

            // Construct the INSERT query for ROUTE table using selectedDriverId
            string sql = $"INSERT INTO ROUTE (RouteName, BusID, AssignedDriver, AssignedConductor, RouteSchedule, RouteStatus) " +
                         $"VALUES ('{comboBox_Route.SelectedValue}', {comboBox_routeBusID.SelectedValue}, " +
                         $"{selectedDriverId}, {selectedConductorID}, '{dateTimePicker_routeDate.Value.ToString("yyyy-MM-dd HH:mm:ss")}', " +
                         $"'{comboBox_routeStatus.Text}')";



            int rowsAffected = db.ExecuteNonQuery(sql);    // Execute the query to insert the new route
            if (rowsAffected > 0)
            {
                Refresh_Table();

                ClearFields();

                MessageBox.Show("New route has been succesfully added!");
            }
            else
            {
                MessageBox.Show("Failed to add new route. Please try again.");
            }
        }   
    }
}
