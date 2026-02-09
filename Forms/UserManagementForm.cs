using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PizzaShopManagementSystem
{
    public partial class UserManagementForm : Form
    {
        public UserManagementForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        int selectedUserId = 0;

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
            this.Close();
        }



        private void LoadUsers()
        {
            SqlConnection con = new SqlConnection(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            string query =
                "SELECT UserId, Username, Role, CreatedDate FROM Users";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvUsers.DataSource = dt;
            dgvUsers.Columns["UserId"].Visible = false;
        }
        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("Restaurant Manager");
            cmbRole.Items.Add("Cashier");
            cmbRole.Items.Add("Account Manager");

            cmbRole.SelectedIndex = 0;
            LoadUsers();
        }
        private void ClearForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            selectedUserId = 0;
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username and Password required");
                return;
            }

            string password = txtPassword.Text;

            SqlConnection con = new SqlConnection(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            string query =
                "INSERT INTO Users (Username, Password, Role) VALUES (" +
                "'" + txtUsername.Text + "'," +
                "'" + password + "'," +
                "'" + cmbRole.Text + "')";

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadUsers();
            ClearForm();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex < 0) return;

            selectedUserId = Convert.ToInt32(
                dgvUsers.Rows[e.RowIndex].Cells["UserId"].Value);

            txtUsername.Text =
                dgvUsers.Rows[e.RowIndex].Cells["Username"].Value.ToString();

            cmbRole.Text =
                dgvUsers.Rows[e.RowIndex].Cells["Role"].Value.ToString();

            txtPassword.Clear(); 

        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Select a user first");
                return;
            }

            SqlConnection con = new SqlConnection(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            string query;

            if (txtPassword.Text == "")
            {
                query =
                    "UPDATE Users SET " +
                    "Username = '" + txtUsername.Text + "', " +
                    "Role = '" + cmbRole.Text + "' " +
                    "WHERE UserId = " + selectedUserId;
            }
            else
            {
                query =
                    "UPDATE Users SET " +
                    "Username = '" + txtUsername.Text + "', " +
                    "Password = '" + txtPassword.Text + "', " +
                    "Role = '" + cmbRole.Text + "' " +
                    "WHERE UserId = " + selectedUserId;
            }

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadUsers();
            ClearForm();
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUserId == 0)
            {
                MessageBox.Show("Select a user first");
                return;
            }

            if (MessageBox.Show("Delete this user?", "Confirm",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            SqlConnection con = new SqlConnection(
                "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

            string query =
                "DELETE FROM Users WHERE UserId = " + selectedUserId;

            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            LoadUsers();
            ClearForm();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


    }
}
