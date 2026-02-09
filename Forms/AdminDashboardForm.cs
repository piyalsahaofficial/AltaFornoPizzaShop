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

namespace PizzaShopManagementSystem
{
    public partial class AdminDashboardForm : Form
    {
        private string currentRole;

        
        public AdminDashboardForm(string role)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            currentRole = role;
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


        private void btnViewRevenue_Click(object sender, EventArgs e)
        {
            RevenueForm frm = new RevenueForm();
            frm.Show();
        }

        private void btnViewExpenses_Click(object sender, EventArgs e)
        {
            ExpenseForm frm = new ExpenseForm();
            frm.Show();
        }

        private void btnViewSalaries_Click(object sender, EventArgs e)
        {
            SalaryForm frm = new SalaryForm();
            frm.Show();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm frm = new UserManagementForm();
            frm.Show();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            OrderForm frm = new OrderForm();
            frm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Confirm",
    MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            LoginForm frm = new LoginForm();
            frm.Show();
            this.Hide();
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentRole))
            {
                MessageBox.Show("Access denied: Role not found");
                this.Close();
                return;
            }

          
            if (currentRole.Trim() == "Admin")
            {
                btnManageUsers.Visible = true;
                btnViewOrders.Visible = true;
                btnViewRevenue.Visible = true;
                btnViewExpenses.Visible = true;
                btnViewSalaries.Visible = true;
            }
            else if (currentRole.Trim() == "Restaurant Manager")
            {
                btnManageUsers.Visible = false;
                btnViewOrders.Visible = false;
                btnViewRevenue.Visible = true;
                btnViewExpenses.Visible = true;
                btnViewSalaries.Visible = true;
            }
            else
            {
                MessageBox.Show("Access denied");
                this.Close();
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
    }
}
