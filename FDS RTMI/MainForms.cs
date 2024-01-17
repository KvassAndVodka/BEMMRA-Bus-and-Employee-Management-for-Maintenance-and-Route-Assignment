using Npgsql;
using System;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class MainForms : Form
    {

        private string username;
        private string password;
        private bool logoutRequested = false;
        private Form activeForm = null;
        private DatabaseHelper db;

        NpgsqlConnection vCon;




        public MainForms(string username, string password)
        {
            InitializeComponent();
            
            // Retrieve user credentials for db connection and winForms management.
            this.username = username;
            this.password = password;
            UpdateUIForUserRole();

            // Instantiate the DatabaseHelper
            db = new DatabaseHelper($"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI");

            // Subscribe to the FormClosed event
            this.FormClosed += MainForms_FormClosed;
        }

        

        // Function to show the windows that the user is only allowed to have an access
        private void UpdateUIForUserRole()
        {
            switch (username)
            {
                case "admin":
                    // All buttons should be accessible
                    break;

                case "mtcmanager":
                    // Disable or hide buttons not allowed for Maintenance Manager
                    button_buses.Enabled = false;
                    button_routes.Enabled = false;
                    button_buses.Visible = false;
                    button_routes.Visible = false;
                    button_employee.Enabled = false;
                    button_employee.Visible = false;
                    break;

                case "opmanager":
                    // Disable or hide buttons not allowed for Operations Manager
                    button_employee.Enabled = false;
                    button_employee.Visible = false;
                    button_maintenance.Enabled = false;
                    button_maintenance.Visible = false;
                    break;

                case "hrmanager":
                    // Disable or hide buttons not allowed for HR Manager
                    button_buses.Enabled = false;
                    button_buses.Visible = false;
                    button_maintenance.Enabled = false;
                    button_maintenance.Visible = false;
                    button_routes.Enabled = false;
                    button_routes.Visible = false;
                    break;

                default:
                    // Default case, handle accordingly
                    Console.WriteLine(username.ToString());
                    break;
            }
        }



        // Function for counting buses in home panel
        private int CountBusesInStatus(params string[] statuses)
        {
            int total = 0;
            foreach (string status in statuses)
            {
                string query = $"SELECT COUNT(*) FROM BUS WHERE BusStatus = '{status}'";
                using (var cmd = new NpgsqlCommand(query, vCon))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        total += Convert.ToInt32(result);
                    }
                }
            }
            return total;
        }



        // Function for establishing connection to the database
        private void connection()
        {
            string vstrConnection = $"Server=localhost; port=5432; user id={username}; password={password}; database=RTMI ;";
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vstrConnection;
            vCon.Open();
        }
        


        // Load MainForms
        private void MainForms_Load(object sender, EventArgs e)
        {
            connection();
            label_Welcome.Text = $"Welcome, {username}!";
            label_homeBusTotal.Text = "Total Number of Buses: " + CountBusesInStatus("In Garage", "Operational", "Maintenance").ToString();
            label_homeBusOperational.Text = "Operational: " + CountBusesInStatus("Operational").ToString();
            label_homeBusMaintenance.Text = "Maintenance: " + CountBusesInStatus("Maintenance").ToString();
            label_homeBusGarage.Text = "In Garage: " + CountBusesInStatus("In Garage").ToString();
            vCon.Close();
        }



        // Show Home Panel when opening the application and or clicking home button
        private void button_home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_Home.Controls.Add(panel_cover);
        }



        // Show ManageEmployee.cs when pressing employee button
        private void button_employee_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageEmployee(username, password));
        }



        // Show Bus.cs when pressing buses button
        private void button_buses_Click(object sender, EventArgs e)
        {
            openChildForm(new Bus(username, password));
        }



        // Show Maintenance.cs when pressing maintenance button
        private void button_maintenance_Click(object sender, EventArgs e)
        {
            openChildForm(new Maintenance(username, password));
        }



        // Show Routes.cs when pressing routes button
        private void button_routes_Click(object sender, EventArgs e)
        {
            openChildForm(new Routes(username, password));
        }
        

        
        // Function for opening new winforms
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Home.Controls.Add(childForm);
            panel_Home.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        // Close database connection when the application is closed.
        private void MainForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the database connection
            db.CloseConnection();

            // Check if logout was requested
            if (logoutRequested == false)
            {
                Application.Exit();
            }
        }



        // Logout functionality
        private void button_logout_Click(object sender, EventArgs e)
        {
            // Set the flag to indicate logout
            logoutRequested = true;

            // Close the current MainForms form
            this.Close();

            Login loginForm = new Login();
            loginForm.Show();
        }
    }
}