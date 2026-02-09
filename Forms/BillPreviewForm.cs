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
using System.Drawing.Printing;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using System.Diagnostics;
using System.IO;



namespace PizzaShopManagementSystem
{
    public partial class BillPreviewForm : Form
    {
        public BillPreviewForm()
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

        PrintDocument printDoc = new PrintDocument();
        int printRowIndex = 0;



        public string TokenNo { get; set; }
        public string TableNo { get; set; }
        public string TotalAmount { get; set; }
        public List<(string, string, string, string, string)> Items { get; set; } = new List<(string, string, string, string, string)>();

        private void BillPreviewForm_Load(object sender, EventArgs e)
        {
            lblTokenNo.Text = TokenNo;
            lblTableNo.Text = TableNo;
            lblGrandTotal.Text = TotalAmount;

            dgvBillItems.Columns.Clear();
            dgvBillItems.Columns.Add("ItemName", "Item");
            dgvBillItems.Columns.Add("Category", "Type");
            dgvBillItems.Columns.Add("Quantity", "Qty");
            dgvBillItems.Columns.Add("Price", "Price");
            dgvBillItems.Columns.Add("Total", "Total");

            dgvBillItems.ReadOnly = true;
            dgvBillItems.AllowUserToAddRows = false;
            dgvBillItems.AutoGenerateColumns = false;

            foreach (var item in Items)
            {
                dgvBillItems.Rows.Add(item.Item1, item.Item2, item.Item3, item.Item4, item.Item5);
            }

            MakeDraggable(this);

            dgvBillItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDownloadPDF_Click(object sender, EventArgs e)
        {
            try
            {
                PrintReceiptA4();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Print Error: " + ex.Message);
            }
        }
        private void PrintReceiptA4()
        {
            string filePath = Path.Combine(Path.GetTempPath(),
                $"Receipt_{TokenNo}_{DateTime.Now.Ticks}.pdf");

            PdfWriter writer = new PdfWriter(filePath);
            PdfDocument pdf = new PdfDocument(writer);
            Document doc = new Document(pdf);

            PdfFont font = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

           
            doc.Add(new Paragraph("ALTA FORNO")
                .SetFont(bold)
                .SetFontSize(18)
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Add(new Paragraph("Receipt")
                .SetFont(bold)
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Add(new Paragraph("\n"));

            
            doc.Add(new Paragraph($"Token No : {TokenNo}").SetFont(font));
            doc.Add(new Paragraph($"Table No : {TableNo}").SetFont(font));
            doc.Add(new Paragraph($"Date     : {DateTime.Now:dd-MM-yyyy HH:mm}").SetFont(font));

            doc.Add(new Paragraph("\n"));

            
            Table table = new Table(new float[] { 4, 2, 2, 2 });
            table.SetWidth(UnitValue.CreatePercentValue(100));

            table.AddHeaderCell(new Cell().Add(new Paragraph("Item")).SetFont(bold));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Qty")).SetFont(bold));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Price")).SetFont(bold));
            table.AddHeaderCell(new Cell().Add(new Paragraph("Total")).SetFont(bold));

            foreach (var item in Items)
            {
                table.AddCell(new Paragraph(item.Item1).SetFont(font));
                table.AddCell(new Paragraph(item.Item3).SetFont(font));
                table.AddCell(new Paragraph(item.Item4).SetFont(font));
                table.AddCell(new Paragraph(item.Item5).SetFont(font));
            }

            doc.Add(table);

            doc.Add(new Paragraph("\n"));

            
            doc.Add(new Paragraph($"Grand Total : {TotalAmount} BDT")
                .SetFont(bold)
                .SetFontSize(14)
                .SetTextAlignment(TextAlignment.RIGHT));

            doc.Add(new Paragraph("\n\nThank you for dining with us! ~ Greetings from Piyal Saha")
                .SetFont(font)
                .SetTextAlignment(TextAlignment.CENTER));

            doc.Close();

            
            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = filePath,
                UseShellExecute = true
            };
            System.Threading.Thread.Sleep(500);
            Process.Start(psi);



        }


    }
}
