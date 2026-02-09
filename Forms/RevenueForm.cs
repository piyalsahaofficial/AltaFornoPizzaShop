using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaShopManagementSystem
{
    public partial class RevenueForm : Form
    {
        public RevenueForm()
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
        private void MakeDraggable(Control c)
        {
            if (c is Button || c is DataGridView || c is TextBox)
                return;

            c.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
                }
            };

            foreach (Control child in c.Controls)
            {
                MakeDraggable(child);
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

        SqlConnection con = new SqlConnection(
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void LoadRevenue()
        {
            dgvRevenue.Rows.Clear();
            decimal totalRevenue = 0;

            try
            {
                con.Open();

                string query = @"
            SELECT r.RevenueId AS BillId, o.TokenNo, o.OrderDate, r.Amount
            FROM Revenue r
            INNER JOIN Orders o ON r.BillId = o.OrderId
            WHERE r.RevenueDate >= @From AND r.RevenueDate < @ToNext
            ORDER BY r.RevenueDate ASC";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@From", dtFrom.Value.Date);
                cmd.Parameters.AddWithValue("@ToNext", dtTo.Value.Date.AddDays(1)); 

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    dgvRevenue.Rows.Add(
                        reader["BillId"].ToString(),
                        reader["TokenNo"].ToString(),
                        Convert.ToDateTime(reader["OrderDate"]).ToString("dd-MM-yyyy HH:mm"),
                        Convert.ToDecimal(reader["Amount"]).ToString("N2")
                    );

                    totalRevenue += Convert.ToDecimal(reader["Amount"]);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading revenue: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            lblTotalRevenue.Text = totalRevenue.ToString("N2");
        }


        private void RevenueForm_Load(object sender, EventArgs e)
        {

            dgvRevenue.Columns.Clear();
            dgvRevenue.Columns.Add("OrderId", "Order ID");
            dgvRevenue.Columns.Add("TokenNo", "Token No");
            dgvRevenue.Columns.Add("OrderDate", "Date");
            dgvRevenue.Columns.Add("Amount", "Amount");

            dgvRevenue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRevenue.AllowUserToAddRows = false;
            dgvRevenue.ReadOnly = true;

            dtFrom.Value = DateTime.Today;
            dtTo.Value = DateTime.Today;

            
            LoadRevenue();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvRevenue.Rows.Clear();
            decimal totalRevenue = 0;

            try
            {
                con.Open();

                string query = @"
            SELECT r.RevenueId AS BillId, o.TokenNo, o.OrderDate, r.Amount
            FROM Revenue r
            INNER JOIN Orders o ON r.BillId = o.OrderId
            WHERE r.RevenueDate >= @From AND r.RevenueDate < @ToNext
            ORDER BY r.RevenueDate ASC";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@From", dtFrom.Value.Date);
                    cmd.Parameters.AddWithValue("@ToNext", dtTo.Value.Date.AddDays(1)); 

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dgvRevenue.Rows.Add(
                                reader["BillId"].ToString(),
                                reader["TokenNo"].ToString(),
                                Convert.ToDateTime(reader["OrderDate"]).ToString("dd-MM-yyyy HH:mm"),
                                Convert.ToDecimal(reader["Amount"]).ToString("N2")
                            );

                            totalRevenue += Convert.ToDecimal(reader["Amount"]);
                        }
                    }
                }

                lblTotalRevenue.Text = totalRevenue.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching revenue: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            LoadRevenue();
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
    }
}
