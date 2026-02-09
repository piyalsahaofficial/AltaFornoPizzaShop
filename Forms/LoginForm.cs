using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;


namespace PizzaShopManagementSystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
                e.SuppressKeyPress = true;
            }
        }




        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;TrustServerCertificate=True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(connectionString);

            string query =
                "SELECT Role FROM Users WHERE Username = '" + username +
                "' AND Password = '" + password + "'";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                string role = reader["Role"].ToString();

               

                this.Hide();

                if (role == "Admin" || role == "Restaurant Manager")
                {
                    AdminDashboardForm adminForm = new AdminDashboardForm(role);
                    adminForm.Show();
                }
                else if (role == "Cashier")
                {
                    CashierDashboardForm cashierForm = new CashierDashboardForm();
                    cashierForm.Show();
                }
                else if (role == "Account Manager")
                {
                    RevenueForm revenueForm = new RevenueForm();
                    revenueForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }

            con.Close();

        }


    }
}
