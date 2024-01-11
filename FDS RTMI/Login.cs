using System;
using System.Data;
using System.Windows.Forms;

namespace FDS_RTMI
{
    public partial class Login : Form
    {
        private string vStrConnection = "Server=localhost; port=5432; user id=postgres; password=bunbun; database=RTMI";
        private DatabaseHelper db;

        public Login()
        {
            InitializeComponent();

            db = new DatabaseHelper(vStrConnection);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string password = textBox_password.Text;

            // TODO: Add proper password hashing for security

            string sql = $"SELECT * FROM USERS WHERE UserName = '{username}' AND Password = '{password}'";
            DataTable dt = db.GetData(sql);

            if (dt.Rows.Count > 0)
            {
                // Authentication successful
                string userRole = dt.Rows[0]["UserRole"].ToString();
                string routeName = db.GetRouteNameByBusID(Convert.ToInt32(dt.Rows[0]["UserID"]));

                // Proceed to the next form or perform necessary actions
                // For example: Open the MainForms form
                MainForms mainForms = new MainForms(userRole);
                mainForms.Show();


                // Close the login form
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            db.CloseConnection();
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please contact Admin.");
        }
    }
}
