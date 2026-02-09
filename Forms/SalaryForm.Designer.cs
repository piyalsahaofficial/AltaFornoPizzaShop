namespace PizzaShopManagementSystem
{
    partial class SalaryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalaryForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.header = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.salary = new System.Windows.Forms.Label();
            this.employee = new System.Windows.Forms.Label();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalaryAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSalaryDate = new System.Windows.Forms.DateTimePicker();
            this.btnPaySalary = new System.Windows.Forms.Button();
            this.dgvSalaryHistory = new System.Windows.Forms.DataGridView();
            this.logo = new System.Windows.Forms.Panel();
            this.header.SuspendLayout();
            this.management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHistory)).BeginInit();
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
            this.header.TabIndex = 6;
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
            // salary
            // 
            this.salary.AutoSize = true;
            this.salary.BackColor = System.Drawing.Color.Transparent;
            this.salary.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.salary.Location = new System.Drawing.Point(522, 50);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(105, 32);
            this.salary.TabIndex = 20;
            this.salary.Text = "SALARY";
            // 
            // employee
            // 
            this.employee.AutoSize = true;
            this.employee.BackColor = System.Drawing.Color.Transparent;
            this.employee.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.employee.Location = new System.Drawing.Point(98, 243);
            this.employee.Name = "employee";
            this.employee.Size = new System.Drawing.Size(131, 32);
            this.employee.TabIndex = 21;
            this.employee.Text = "Employee:";
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.cmbEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEmployee.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.ItemHeight = 25;
            this.cmbEmployee.Items.AddRange(new object[] {
            "Restaurant Manager",
            "Cashier",
            "Account Manager",
            "Chef",
            "Waiter",
            "Cleaner"});
            this.cmbEmployee.Location = new System.Drawing.Point(253, 242);
            this.cmbEmployee.MaxDropDownItems = 20;
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(326, 33);
            this.cmbEmployee.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(39, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 35;
            this.label1.Text = "Salary Amount:";
            // 
            // txtSalaryAmount
            // 
            this.txtSalaryAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.txtSalaryAmount.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaryAmount.Location = new System.Drawing.Point(253, 310);
            this.txtSalaryAmount.Name = "txtSalaryAmount";
            this.txtSalaryAmount.Size = new System.Drawing.Size(200, 39);
            this.txtSalaryAmount.TabIndex = 36;
            this.txtSalaryAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.label2.Location = new System.Drawing.Point(48, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 32);
            this.label2.TabIndex = 37;
            this.label2.Text = "Payment Date:";
            // 
            // dtSalaryDate
            // 
            this.dtSalaryDate.Location = new System.Drawing.Point(253, 381);
            this.dtSalaryDate.Name = "dtSalaryDate";
            this.dtSalaryDate.Size = new System.Drawing.Size(200, 20);
            this.dtSalaryDate.TabIndex = 38;
            // 
            // btnPaySalary
            // 
            this.btnPaySalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnPaySalary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPaySalary.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaySalary.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPaySalary.Location = new System.Drawing.Point(376, 465);
            this.btnPaySalary.Name = "btnPaySalary";
            this.btnPaySalary.Size = new System.Drawing.Size(203, 38);
            this.btnPaySalary.TabIndex = 50;
            this.btnPaySalary.Text = "PAY SALARY";
            this.btnPaySalary.UseVisualStyleBackColor = false;
            this.btnPaySalary.Click += new System.EventHandler(this.btnPaySalary_Click);
            // 
            // dgvSalaryHistory
            // 
            this.dgvSalaryHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSalaryHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSalaryHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalaryHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSalaryHistory.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSalaryHistory.Location = new System.Drawing.Point(628, 180);
            this.dgvSalaryHistory.Name = "dgvSalaryHistory";
            this.dgvSalaryHistory.Size = new System.Drawing.Size(547, 351);
            this.dgvSalaryHistory.TabIndex = 51;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(12, 53);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(117, 109);
            this.logo.TabIndex = 52;
            // 
            // SalaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.dgvSalaryHistory);
            this.Controls.Add(this.btnPaySalary);
            this.Controls.Add(this.dtSalaryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalaryAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEmployee);
            this.Controls.Add(this.employee);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalaryForm";
            this.Text = "SalaryForm";
            this.Load += new System.EventHandler(this.SalaryForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.header.ResumeLayout(false);
            this.management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalaryHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel management;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label salary;
        private System.Windows.Forms.Label employee;
        private System.Windows.Forms.ComboBox cmbEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalaryAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtSalaryDate;
        private System.Windows.Forms.Button btnPaySalary;
        private System.Windows.Forms.DataGridView dgvSalaryHistory;
        private System.Windows.Forms.Panel logo;
    }
}