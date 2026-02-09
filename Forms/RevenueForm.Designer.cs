namespace PizzaShopManagementSystem
{
    partial class RevenueForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RevenueForm));
            this.header = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.revenuereport = new System.Windows.Forms.Label();
            this.from = new System.Windows.Forms.Label();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.to = new System.Windows.Forms.Label();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvRevenue = new System.Windows.Forms.DataGridView();
            this.totalrevenue = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.header.Controls.Add(this.management);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1200, 47);
            this.header.TabIndex = 5;
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
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
            // revenuereport
            // 
            this.revenuereport.AutoSize = true;
            this.revenuereport.BackColor = System.Drawing.Color.Transparent;
            this.revenuereport.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.revenuereport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.revenuereport.Location = new System.Drawing.Point(501, 60);
            this.revenuereport.Name = "revenuereport";
            this.revenuereport.Size = new System.Drawing.Size(223, 32);
            this.revenuereport.TabIndex = 18;
            this.revenuereport.Text = "REVENUE REPORT";
            // 
            // from
            // 
            this.from.AutoSize = true;
            this.from.BackColor = System.Drawing.Color.Transparent;
            this.from.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.from.Location = new System.Drawing.Point(40, 260);
            this.from.Name = "from";
            this.from.Size = new System.Drawing.Size(79, 32);
            this.from.TabIndex = 19;
            this.from.Text = "From:";
            // 
            // dtFrom
            // 
            this.dtFrom.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dtFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtFrom.Location = new System.Drawing.Point(125, 269);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(203, 20);
            this.dtFrom.TabIndex = 20;
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.BackColor = System.Drawing.Color.Transparent;
            this.to.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.to.Location = new System.Drawing.Point(349, 260);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(49, 32);
            this.to.TabIndex = 21;
            this.to.Text = "To:";
            // 
            // dtTo
            // 
            this.dtTo.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dtTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtTo.Location = new System.Drawing.Point(404, 269);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(197, 20);
            this.dtTo.TabIndex = 22;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(242, 320);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 38);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "SEARCH";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvRevenue
            // 
            this.dgvRevenue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dgvRevenue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRevenue.Location = new System.Drawing.Point(624, 180);
            this.dgvRevenue.Name = "dgvRevenue";
            this.dgvRevenue.Size = new System.Drawing.Size(547, 351);
            this.dgvRevenue.TabIndex = 49;
            // 
            // totalrevenue
            // 
            this.totalrevenue.AutoSize = true;
            this.totalrevenue.BackColor = System.Drawing.Color.Transparent;
            this.totalrevenue.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalrevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.totalrevenue.Location = new System.Drawing.Point(37, 430);
            this.totalrevenue.Name = "totalrevenue";
            this.totalrevenue.Size = new System.Drawing.Size(184, 32);
            this.totalrevenue.TabIndex = 50;
            this.totalrevenue.Text = "Total Revenue:";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblTotalRevenue.Location = new System.Drawing.Point(227, 430);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(195, 32);
            this.lblTotalRevenue.TabIndex = 51;
            this.lblTotalRevenue.Text = "Auto Generated";
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 60);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 109);
            this.logo.TabIndex = 52;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(1069, 60);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(102, 32);
            this.btnLogout.TabIndex = 53;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // RevenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.totalrevenue);
            this.Controls.Add(this.dgvRevenue);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.to);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.from);
            this.Controls.Add(this.revenuereport);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RevenueForm";
            this.Text = "RevenueForm";
            this.Load += new System.EventHandler(this.RevenueForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.ResumeLayout(false);
            this.management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRevenue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel management;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label revenuereport;
        private System.Windows.Forms.Label from;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvRevenue;
        private System.Windows.Forms.Label totalrevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btnLogout;
    }
}