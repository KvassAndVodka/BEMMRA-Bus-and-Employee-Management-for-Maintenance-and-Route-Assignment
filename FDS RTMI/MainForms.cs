using Npgsql;
using System;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class MainForms : Form
    {
        private string userRole;
        private DatabaseHelper db;
        private bool logoutRequested = false;


        public MainForms(string userRole)
        {
            InitializeComponent();
            this.userRole = userRole;
            UpdateUIForUserRole();

            // Instantiate the DatabaseHelper
            db = new DatabaseHelper("Server=localhost; port=5432; user id=postgres; password=bunbun; database=RTMI");

            // Subscribe to the FormClosed event
            this.FormClosed += MainForms_FormClosed;
        }

        private void UpdateUIForUserRole()
        {
            switch (userRole)
            {
                case "ADMIN":
                    // All buttons should be accessible
                    break;

                case "MAINTENANCE MANAGER":
                    // Disable or hide buttons not allowed for Maintenance Manager
                    button_buses.Enabled = false;
                    button_routes.Enabled = false;
                    button_buses.Visible = false;
                    button_routes.Visible = false;
                    break;

                case "OPERATIONS MANAGER":
                    // Disable or hide buttons not allowed for Operations Manager
                    button_employee.Enabled = false;
                    button_employee.Visible = false;
                    break;

                case "HR MANAGER":
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
                    break;
            }
        }

        string vstrConnection = "Server=localhost; port=5432; user id=postgres; password=bunbun; database=RTMI ;";
        NpgsqlConnection vCon;

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


        private void connection()
        {
            vCon = new NpgsqlConnection();
            vCon.ConnectionString = vstrConnection;
            vCon.Open();
        }
        private void MainForms_Load(object sender, EventArgs e)
        {
            connection();
            label_homeBusTotal.Text = "Total Number of Buses: " + CountBusesInStatus("In Garage", "Operational", "Maintenance").ToString();
            label_homeBusOperational.Text = "Operational: " + CountBusesInStatus("Operational").ToString();
            label_homeBusMaintenance.Text = "Maintenance: " + CountBusesInStatus("Maintenance").ToString();
            label_homeBusGarage.Text = "In Garage: " + CountBusesInStatus("In Garage").ToString();
            vCon.Close();
        }


        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                submenu.Visible = true;
            }

            else
                submenu.Visible = false;
        }
        private void button_home_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            panel_Home.Controls.Add(panel_cover);
        }

        private void button_employee_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageEmployee());
        }


        private void button_buses_Click(object sender, EventArgs e)
        {
            openChildForm(new Bus());
        }


        private void button_maintenance_Click(object sender, EventArgs e)
        {
            openChildForm(new Maintenance());
        }


        private void button_routes_Click(object sender, EventArgs e)
        {
            openChildForm(new Routes());
        }


        private Form activeForm = null;
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