using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class Login : Form
    {
        private DatabaseHelper db;



        public Login()
        {
            InitializeComponent();
        }



        // Function for user login
        private void button_login_Click(object sender, EventArgs e)
        {
            // Fetch textbox input for username and password
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            // Database Connection String
            string connStr = $"Server=localhost;Port=5432;Database=RTMI;User Id={username};Password={password};";

            try
            {
                // Establish database connection
                db = new DatabaseHelper(connStr);
                db.ConnectionOpen();

                // If the connection is successful, open MainForms.
                if (db.ConnectionState == ConnectionState.Open)
                {
                    // Open MainForms and transfer credentials for future db connection calls
                    MainForms mainForms = new MainForms(username, password);
                    mainForms.Show();

                    // Hide login form
                    this.Hide();
                }
                // If the connection failed, display this
                else
                {
                    MessageBox.Show("The connection to the database failed.");
                }
            }
            // If there are errors in establishing connection to the database
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            // If the credentials are incorrect
            catch (Exception)
            {
                MessageBox.Show("Your username or password is incorrect.");
            }
        }



        // User prompt for forgotten details.
        private void label_ForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Admin.");
        }



        // Cut all db connection every time the app is closed and exit.
        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Check if there is an existing connection to database to prevent issues
            if (db != null)
            {
                db.CloseConnection();
            }
            Application.Exit();
        }
    }
}
