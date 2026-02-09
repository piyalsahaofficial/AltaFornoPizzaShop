namespace PizzaShopManagementSystem
{
    partial class BillPreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillPreviewForm));
            this.btnDownloadPDF = new System.Windows.Forms.Button();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.grandtotal = new System.Windows.Forms.Label();
            this.lblTableNo = new System.Windows.Forms.Label();
            this.tableumber = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.tokennumber = new System.Windows.Forms.Label();
            this.bill = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvBillItems = new System.Windows.Forms.DataGridView();
            this.header.SuspendLayout();
            this.management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDownloadPDF
            // 
            this.btnDownloadPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnDownloadPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownloadPDF.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadPDF.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDownloadPDF.Location = new System.Drawing.Point(930, 552);
            this.btnDownloadPDF.Name = "btnDownloadPDF";
            this.btnDownloadPDF.Size = new System.Drawing.Size(203, 38);
            this.btnDownloadPDF.TabIndex = 57;
            this.btnDownloadPDF.Text = "Downlod Receipt";
            this.btnDownloadPDF.UseVisualStyleBackColor = false;
            this.btnDownloadPDF.Click += new System.EventHandler(this.btnDownloadPDF_Click);
            // 
            // lblGrandTotal
            // 
            this.lblGrandTotal.AutoSize = true;
            this.lblGrandTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblGrandTotal.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrandTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblGrandTotal.Location = new System.Drawing.Point(260, 379);
            this.lblGrandTotal.Name = "lblGrandTotal";
            this.lblGrandTotal.Size = new System.Drawing.Size(195, 32);
            this.lblGrandTotal.TabIndex = 56;
            this.lblGrandTotal.Text = "Auto Generated";
            // 
            // grandtotal
            // 
            this.grandtotal.AutoSize = true;
            this.grandtotal.BackColor = System.Drawing.Color.Transparent;
            this.grandtotal.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grandtotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.grandtotal.Location = new System.Drawing.Point(99, 379);
            this.grandtotal.Name = "grandtotal";
            this.grandtotal.Size = new System.Drawing.Size(155, 32);
            this.grandtotal.TabIndex = 55;
            this.grandtotal.Text = "Grand Total:";
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNo.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblTableNo.Location = new System.Drawing.Point(260, 331);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(195, 32);
            this.lblTableNo.TabIndex = 53;
            this.lblTableNo.Text = "Auto Generated";
            // 
            // tableumber
            // 
            this.tableumber.AutoSize = true;
            this.tableumber.BackColor = System.Drawing.Color.Transparent;
            this.tableumber.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.tableumber.Location = new System.Drawing.Point(130, 331);
            this.tableumber.Name = "tableumber";
            this.tableumber.Size = new System.Drawing.Size(124, 32);
            this.tableumber.TabIndex = 52;
            this.tableumber.Text = "Table No:";
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.AutoSize = true;
            this.lblTokenNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTokenNo.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblTokenNo.Location = new System.Drawing.Point(260, 280);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(195, 32);
            this.lblTokenNo.TabIndex = 51;
            this.lblTokenNo.Text = "Auto Generated";
            // 
            // tokennumber
            // 
            this.tokennumber.AutoSize = true;
            this.tokennumber.BackColor = System.Drawing.Color.Transparent;
            this.tokennumber.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokennumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.tokennumber.Location = new System.Drawing.Point(122, 280);
            this.tokennumber.Name = "tokennumber";
            this.tokennumber.Size = new System.Drawing.Size(132, 32);
            this.tokennumber.TabIndex = 50;
            this.tokennumber.Text = "Token No:";
            // 
            // bill
            // 
            this.bill.AutoSize = true;
            this.bill.BackColor = System.Drawing.Color.Transparent;
            this.bill.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.bill.Location = new System.Drawing.Point(551, 50);
            this.bill.Name = "bill";
            this.bill.Size = new System.Drawing.Size(60, 32);
            this.bill.TabIndex = 49;
            this.bill.Text = "BILL";
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.header.Controls.Add(this.management);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 47);
            this.header.TabIndex = 48;
            // 
            // management
            // 
            this.management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.management.Controls.Add(this.btnMinimize);
            this.management.Controls.Add(this.btnClose);
            this.management.Dock = System.Windows.Forms.DockStyle.Right;
            this.management.Location = new System.Drawing.Point(1032, 0);
            this.management.Name = "management";
            this.management.Size = new System.Drawing.Size(168, 47);
            this.management.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinimize.BackgroundImage")));
            this.btnMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.btnMinimize.Location = new System.Drawing.Point(90, 12);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 23);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(126, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dgvBillItems
            // 
            this.dgvBillItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dgvBillItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBillItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvBillItems.Location = new System.Drawing.Point(586, 162);
            this.dgvBillItems.Name = "dgvBillItems";
            this.dgvBillItems.Size = new System.Drawing.Size(547, 351);
            this.dgvBillItems.TabIndex = 58;
            // 
            // BillPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.dgvBillItems);
            this.Controls.Add(this.btnDownloadPDF);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.grandtotal);
            this.Controls.Add(this.lblTableNo);
            this.Controls.Add(this.tableumber);
            this.Controls.Add(this.lblTokenNo);
            this.Controls.Add(this.tokennumber);
            this.Controls.Add(this.bill);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillPreviewForm";
            this.Text = "BillPreviewForm";
            this.Load += new System.EventHandler(this.BillPreviewForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.ResumeLayout(false);
            this.management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBillItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownloadPDF;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label grandtotal;
        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Label tableumber;
        private System.Windows.Forms.Label lblTokenNo;
        private System.Windows.Forms.Label tokennumber;
        private System.Windows.Forms.Label bill;
        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel management;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvBillItems;
    }
}