using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PizzaShopManagementSystem
{
    public partial class OrderForm : Form
    {
        public OrderForm()
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
        int GetPrice(string item)
        {
            
            if (item.Contains("Margherita") && item.Contains("8")) return 500;
            if (item.Contains("Margherita") && item.Contains("12")) return 800;
            if (item.Contains("Margherita") && item.Contains("16")) return 1200;

            if (item.Contains("Pepperoni") && item.Contains("8")) return 600;
            if (item.Contains("Pepperoni") && item.Contains("12")) return 900;
            if (item.Contains("Pepperoni") && item.Contains("16")) return 1300;

            
            if (item.Contains("Quattro Formaggi") && item.Contains("8")) return 700;
            if (item.Contains("Quattro Formaggi") && item.Contains("12")) return 1000;
            if (item.Contains("Quattro Formaggi") && item.Contains("16")) return 1400;

           
            if (item.Contains("BBQ Chicken") && item.Contains("8")) return 650;
            if (item.Contains("BBQ Chicken") && item.Contains("12")) return 950;
            if (item.Contains("BBQ Chicken") && item.Contains("16")) return 1350;

    
            if (item.Contains("Veggie Delight") && item.Contains("8")) return 550;
            if (item.Contains("Veggie Delight") && item.Contains("12")) return 850;
            if (item.Contains("Veggie Delight") && item.Contains("16")) return 1200;

          
            if (item.Contains("Hawaiian") && item.Contains("8")) return 600;
            if (item.Contains("Hawaiian") && item.Contains("12")) return 900;
            if (item.Contains("Hawaiian") && item.Contains("16")) return 1300;

           
            if (item.Contains("Italian Sausage") && item.Contains("8")) return 650;
            if (item.Contains("Italian Sausage") && item.Contains("12")) return 950;
            if (item.Contains("Italian Sausage") && item.Contains("16")) return 1350;

           
            if (item.Contains("Capricciosa") && item.Contains("8")) return 700;
            if (item.Contains("Capricciosa") && item.Contains("12")) return 1000;
            if (item.Contains("Capricciosa") && item.Contains("16")) return 1400;

            if (item.Contains("Diavola") && item.Contains("8")) return 650;
            if (item.Contains("Diavola") && item.Contains("12")) return 950;
            if (item.Contains("Diavola") && item.Contains("16")) return 1350;

           
            if (item == "Coke") return 80;
            if (item == "Diet Coke") return 80;
            if (item == "Pepsi") return 80;
            if (item == "Mountain Dew") return 80;
            if (item == "7 Up") return 80;
            if (item == "Sprite") return 80;
            if (item == "Fanta Orange") return 80;
            if (item == "Orange Juice") return 120;
            if (item == "Apple Juice") return 120;
            if (item == "Mango Juice") return 120;
            if (item == "Lemonade") return 120;
            if (item == "Water (500ml)") return 40;
            if (item == "Water (1L)") return 70;

            return 0;
        }
        void CalculateTotal()
        {
            int sum = 0;

            foreach (DataGridViewRow row in dgvOrderItems.Rows)
            {
                sum += Convert.ToInt32(row.Cells[4].Value);
            }

            lblTotalAmount.Text = sum.ToString();
        }




        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            if (cmbDrink.Text == "")
            {
                MessageBox.Show("Select drink");
                return;
            }

            int qty = (int)numDrinkQuantity.Value;
            int price = GetPrice(cmbDrink.Text);
            int total = price * qty;

            dgvOrderItems.Rows.Add(
                cmbDrink.Text,
                "Drink",
                qty,
                price,
                total
            );

            CalculateTotal();

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            lblTokenNo.Text = DateTime.Now.Ticks.ToString().Substring(10);
            lblTotalAmount.Text = "0";

            numPizzaQuantity.Value = 1;
            numDrinkQuantity.Value = 1;

        }

        private void btnAddPizza_Click(object sender, EventArgs e)
        {
            if (cmbPizza.SelectedIndex == -1)
            {
                MessageBox.Show("Select pizza");
                return;
            }

            int qty = (int)numPizzaQuantity.Value;
            int price = GetPrice(cmbPizza.Text);
            int total = price * qty;

            dgvOrderItems.Rows.Add(
                cmbPizza.Text,
                "Pizza",
                qty,
                price,
                total
            );

            CalculateTotal();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvOrderItems.Rows.Clear();

            lblTotalAmount.Text = "0";

            cmbPizza.SelectedIndex = -1;
            cmbDrink.SelectedIndex = -1;

            numPizzaQuantity.Value = 1;
            numDrinkQuantity.Value = 1;

            
            lblTokenNo.Text = DateTime.Now.Ticks.ToString().Substring(10);
        }

        private void btnGenerateBill_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.Rows.Count == 0)
            {
                MessageBox.Show("No items in order");
                return;
            }

            try
            {
                con.Open();

              
                string orderQuery = "INSERT INTO Orders (TokenNo, TableNo, OrderDate, CreatedBy) " +
                                    "VALUES ('" + lblTokenNo.Text + "','" +
                                                 cmbTableNo.Text + "','" +
                                                 DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                                                 "Cashier" + "');";

                SqlCommand cmd = new SqlCommand(orderQuery, con);
                cmd.ExecuteNonQuery();

              
                SqlCommand getId = new SqlCommand("SELECT MAX(OrderId) FROM Orders", con);
                int orderId = Convert.ToInt32(getId.ExecuteScalar());

                
                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        string itemQuery = "INSERT INTO OrderItems (OrderId, ItemName, Category, Quantity, Price, Total) " +
                   "VALUES (" + orderId + ", '" +
                                row.Cells[0].Value.ToString() + "', '" +
                                row.Cells[1].Value.ToString() + "', " +
                                row.Cells[2].Value.ToString() + ", " +
                                row.Cells[3].Value.ToString() + ", " +
                                row.Cells[4].Value.ToString() + ")";

                        SqlCommand itemCmd = new SqlCommand(itemQuery, con);
                        itemCmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Order Saved Successfully");

                
                var itemsList = new List<(string, string, string, string, string)>();
                foreach (DataGridViewRow row in dgvOrderItems.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        itemsList.Add((
                            row.Cells["ItemName"].Value.ToString(),
                            row.Cells["Category"].Value.ToString(),
                            row.Cells["Quantity"].Value.ToString(),
                            row.Cells["Price"].Value.ToString(),
                            row.Cells["Total"].Value.ToString()
                        ));
                    }
                }
                string revenueQuery = "INSERT INTO Revenue (BillId, Amount) VALUES (@BillId, @Amount)";
                using (SqlCommand revCmd = new SqlCommand(revenueQuery, con))
                {
                    revCmd.Parameters.AddWithValue("@BillId", orderId);
                    revCmd.Parameters.AddWithValue("@Amount", Convert.ToDecimal(lblTotalAmount.Text));
                    revCmd.ExecuteNonQuery();
                }

                BillPreviewForm bill = new BillPreviewForm
                {
                    TokenNo = lblTokenNo.Text,
                    TableNo = cmbTableNo.Text,
                    TotalAmount = lblTotalAmount.Text,
                    Items = itemsList
                };

                bill.ShowDialog();

               
                btnClear_Click(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

            SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=AltaFornoPizzaShopDB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True"

);

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            dgvOrderItems.Rows.RemoveAt(dgvOrderItems.SelectedRows[0].Index);

            CalculateTotal();
        }
    }
}
