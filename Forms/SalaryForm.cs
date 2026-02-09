using System;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PizzaShopManagementSystem
{
    public partial class SalaryForm : Form
    {
        public SalaryForm()
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

        SqlConnection con = new SqlConnection(
            "Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;TrustServerCertificate=True");

        private void SalaryForm_Load(object sender, EventArgs e)
        {
            cmbEmployee.Items.Clear();
            cmbEmployee.Items.Add("Restaurant Manager");
            cmbEmployee.Items.Add("Cashier");
            cmbEmployee.Items.Add("Account Manager");
            cmbEmployee.Items.Add("Chef");
            cmbEmployee.Items.Add("Waiter");
            cmbEmployee.Items.Add("Cleaner");

            LoadSalaryHistory();
        }

        void LoadSalaryHistory()
        {
            dgvSalaryHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (dgvSalaryHistory.Columns.Count == 0)
            {
                dgvSalaryHistory.Columns.Add("EmployeeRole", "Employee Role");
                dgvSalaryHistory.Columns.Add("Amount", "Amount");
                dgvSalaryHistory.Columns.Add("PaidDate", "Paid Date");
                dgvSalaryHistory.Columns.Add("PaidBy", "Paid By");
            }
            dgvSalaryHistory.Rows.Clear();
            con.Open();

            string query = "SELECT SalaryId, EmployeeRole, Amount, PaidDate, PaidBy FROM Salaries ORDER BY PaidDate DESC";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dgvSalaryHistory.Rows.Add(
                    dr["SalaryId"],
                    dr["EmployeeRole"],
                    dr["Amount"],
                    dr["PaidDate"],
                    dr["PaidBy"]
                );
            }

            con.Close();
        }

        void ClearFields()
        {
            cmbEmployee.SelectedIndex = -1;
            txtSalaryAmount.Clear();
            dtSalaryDate.Value = DateTime.Now;
        }

        private void btnPaySalary_Click(object sender, EventArgs e)
        {
            if (cmbEmployee.Text == "" || txtSalaryAmount.Text == "")
            {
                MessageBox.Show("Please select employee and enter amount");
                return;
            }

            con.Open();

            string query = "INSERT INTO Salaries (EmployeeRole, Amount, PaidDate, PaidBy) VALUES (@EmployeeRole, @Amount, @PaidDate, @PaidBy)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@EmployeeRole", cmbEmployee.Text);
            cmd.Parameters.AddWithValue("@Amount", decimal.Parse(txtSalaryAmount.Text));
            cmd.Parameters.AddWithValue("@PaidDate", dtSalaryDate.Value);
            cmd.Parameters.AddWithValue("@PaidBy", "Admin"); 

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Salary paid successfully");

            LoadSalaryHistory();
            ClearFields();
        }

        private void txtSalaryAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
                e.Handled = true;
        }

        private void btnMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;


        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}