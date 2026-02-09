namespace PizzaShopManagementSystem
{
    partial class TodayOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodayOrdersForm));
            this.header = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Label();
            this.dgvTodayOrders = new System.Windows.Forms.DataGridView();
            this.btnOff = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayOrders)).BeginInit();
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
            this.header.TabIndex = 3;
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
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 53);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 109);
            this.logo.TabIndex = 15;
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.Dashboard.Location = new System.Drawing.Point(499, 53);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(186, 32);
            this.Dashboard.TabIndex = 16;
            this.Dashboard.Text = "Today’s Orders";
            // 
            // dgvTodayOrders
            // 
            this.dgvTodayOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dgvTodayOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodayOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvTodayOrders.Location = new System.Drawing.Point(278, 124);
            this.dgvTodayOrders.Name = "dgvTodayOrders";
            this.dgvTodayOrders.Size = new System.Drawing.Size(685, 447);
            this.dgvTodayOrders.TabIndex = 44;
            // 
            // btnOff
            // 
            this.btnOff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOff.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOff.Location = new System.Drawing.Point(861, 614);
            this.btnOff.Name = "btnOff";
            this.btnOff.Size = new System.Drawing.Size(102, 32);
            this.btnOff.TabIndex = 45;
            this.btnOff.Text = "CLOSE";
            this.btnOff.UseVisualStyleBackColor = false;
            this.btnOff.Click += new System.EventHandler(this.btnOff_Click);
            // 
            // TodayOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnOff);
            this.Controls.Add(this.dgvTodayOrders);
            this.Controls.Add(this.Dashboard);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TodayOrdersForm";
            this.Text = "TodayOrdersForm";
            this.Load += new System.EventHandler(this.TodayOrdersForm_Load);
            this.header.ResumeLayout(false);
            this.management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodayOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel management;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label Dashboard;
        private System.Windows.Forms.DataGridView dgvTodayOrders;
        private System.Windows.Forms.Button btnOff;
    }
}