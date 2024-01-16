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

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            string connStr = $"Server=localhost;Port=5432;Database=RTMI;User Id={username};Password={password};";

            try
            {
                db = new DatabaseHelper(connStr);

                // Explicitly open the connection
                db.ConnectionOpen();

                // If the connection is successful, proceed to the next form or perform necessary actions
                if (db.ConnectionState == ConnectionState.Open)
                {
                    MainForms mainForms = new MainForms(username, password);
                    mainForms.Show();

                    // Close the login form
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("The connection to the database failed.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception)
            {
                MessageBox.Show("Your username or password is incorrect.");
            }
        }




        private void label_ForgotPassword_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Admin.");
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (db != null)
            {
                db.CloseConnection();
            }
            Application.Exit();
        }
    }
}
