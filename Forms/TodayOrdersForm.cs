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
    public partial class TodayOrdersForm : Form
    {
        public TodayOrdersForm()
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
        string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;TrustServerCertificate=True";

        private void TodayOrdersForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);

            string query =
                "SELECT TokenNo, TableNo, OrderDate " +
                "FROM Orders " +
                "WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();

            da.Fill(dt);

            dgvTodayOrders.DataSource = dt;
            dgvTodayOrders.ReadOnly = true;
            dgvTodayOrders.AllowUserToAddRows = false;
            dgvTodayOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
