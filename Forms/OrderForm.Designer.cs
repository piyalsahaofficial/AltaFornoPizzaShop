namespace PizzaShopManagementSystem
{
    partial class OrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderForm));
            this.header = new System.Windows.Forms.Panel();
            this.management = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.orderinfo = new System.Windows.Forms.Label();
            this.tokennumber = new System.Windows.Forms.Label();
            this.lblTokenNo = new System.Windows.Forms.Label();
            this.tableortakeaway = new System.Windows.Forms.Label();
            this.cmbTableNo = new System.Windows.Forms.ComboBox();
            this.menuitems = new System.Windows.Forms.Label();
            this.pizza = new System.Windows.Forms.Label();
            this.cmbPizza = new System.Windows.Forms.ComboBox();
            this.quantityPIZZA = new System.Windows.Forms.Label();
            this.numPizzaQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddPizza = new System.Windows.Forms.Button();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.numDrinkQuantity = new System.Windows.Forms.NumericUpDown();
            this.quantityDRINK = new System.Windows.Forms.Label();
            this.cmbDrink = new System.Windows.Forms.ComboBox();
            this.drink = new System.Windows.Forms.Label();
            this.dgvOrderItems = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersummary = new System.Windows.Forms.Label();
            this.totalamount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.btnGenerateBill = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.header.SuspendLayout();
            this.management.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPizzaQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).BeginInit();
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
            // orderinfo
            // 
            this.orderinfo.AutoSize = true;
            this.orderinfo.BackColor = System.Drawing.Color.Transparent;
            this.orderinfo.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderinfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.orderinfo.Location = new System.Drawing.Point(525, 53);
            this.orderinfo.Name = "orderinfo";
            this.orderinfo.Size = new System.Drawing.Size(162, 32);
            this.orderinfo.TabIndex = 16;
            this.orderinfo.Text = "ORDER INFO";
            // 
            // tokennumber
            // 
            this.tokennumber.AutoSize = true;
            this.tokennumber.BackColor = System.Drawing.Color.Transparent;
            this.tokennumber.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tokennumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.tokennumber.Location = new System.Drawing.Point(148, 115);
            this.tokennumber.Name = "tokennumber";
            this.tokennumber.Size = new System.Drawing.Size(132, 32);
            this.tokennumber.TabIndex = 17;
            this.tokennumber.Text = "Token No:";
            // 
            // lblTokenNo
            // 
            this.lblTokenNo.AutoSize = true;
            this.lblTokenNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTokenNo.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTokenNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblTokenNo.Location = new System.Drawing.Point(286, 115);
            this.lblTokenNo.Name = "lblTokenNo";
            this.lblTokenNo.Size = new System.Drawing.Size(195, 32);
            this.lblTokenNo.TabIndex = 18;
            this.lblTokenNo.Text = "Auto Generated";
            // 
            // tableortakeaway
            // 
            this.tableortakeaway.AutoSize = true;
            this.tableortakeaway.BackColor = System.Drawing.Color.Transparent;
            this.tableortakeaway.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableortakeaway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.tableortakeaway.Location = new System.Drawing.Point(712, 115);
            this.tableortakeaway.Name = "tableortakeaway";
            this.tableortakeaway.Size = new System.Drawing.Size(233, 32);
            this.tableortakeaway.TabIndex = 19;
            this.tableortakeaway.Text = "Table or Takeaway:";
            // 
            // cmbTableNo
            // 
            this.cmbTableNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.cmbTableNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbTableNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTableNo.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTableNo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbTableNo.FormattingEnabled = true;
            this.cmbTableNo.ItemHeight = 25;
            this.cmbTableNo.Items.AddRange(new object[] {
            "Takeaway",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbTableNo.Location = new System.Drawing.Point(951, 114);
            this.cmbTableNo.MaxDropDownItems = 11;
            this.cmbTableNo.Name = "cmbTableNo";
            this.cmbTableNo.Size = new System.Drawing.Size(147, 33);
            this.cmbTableNo.TabIndex = 30;
            // 
            // menuitems
            // 
            this.menuitems.AutoSize = true;
            this.menuitems.BackColor = System.Drawing.Color.Transparent;
            this.menuitems.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuitems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.menuitems.Location = new System.Drawing.Point(244, 193);
            this.menuitems.Name = "menuitems";
            this.menuitems.Size = new System.Drawing.Size(150, 32);
            this.menuitems.TabIndex = 31;
            this.menuitems.Text = "Menu Items";
            // 
            // pizza
            // 
            this.pizza.AutoSize = true;
            this.pizza.BackColor = System.Drawing.Color.Transparent;
            this.pizza.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.pizza.Location = new System.Drawing.Point(93, 257);
            this.pizza.Name = "pizza";
            this.pizza.Size = new System.Drawing.Size(79, 32);
            this.pizza.TabIndex = 32;
            this.pizza.Text = "Pizza:";
            // 
            // cmbPizza
            // 
            this.cmbPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.cmbPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbPizza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPizza.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPizza.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbPizza.FormattingEnabled = true;
            this.cmbPizza.ItemHeight = 25;
            this.cmbPizza.Items.AddRange(new object[] {
            "Margherita – 8 inch",
            "Margherita – 12 inch",
            "Margherita – 16 inch",
            "Pepperoni – 8 inch",
            "Pepperoni – 12 inch",
            "Pepperoni – 16 inch",
            "Quattro Formaggi (Four Cheese) – 8 inch",
            "Quattro Formaggi – 12 inch",
            "Quattro Formaggi – 16 inch",
            "BBQ Chicken – 8 inch",
            "BBQ Chicken – 12 inch",
            "BBQ Chicken – 16 inch",
            "Veggie Delight – 8 inch",
            "Veggie Delight – 12 inch",
            "Veggie Delight – 16 inch",
            "Hawaiian (Ham & Pineapple) – 8 inch",
            "Hawaiian – 12 inch",
            "Hawaiian – 16 inch",
            "Italian Sausage – 8 inch",
            "Italian Sausage – 12 inch",
            "Italian Sausage – 16 inch",
            "Capricciosa – 8 inch",
            "Capricciosa – 12 inch",
            "Capricciosa – 16 inch",
            "Diavola (Spicy Salami) – 8 inch",
            "Diavola – 12 inch",
            "Diavola – 16 inch"});
            this.cmbPizza.Location = new System.Drawing.Point(188, 256);
            this.cmbPizza.MaxDropDownItems = 10;
            this.cmbPizza.Name = "cmbPizza";
            this.cmbPizza.Size = new System.Drawing.Size(326, 33);
            this.cmbPizza.TabIndex = 33;
            // 
            // quantityPIZZA
            // 
            this.quantityPIZZA.AutoSize = true;
            this.quantityPIZZA.BackColor = System.Drawing.Color.Transparent;
            this.quantityPIZZA.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityPIZZA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.quantityPIZZA.Location = new System.Drawing.Point(93, 328);
            this.quantityPIZZA.Name = "quantityPIZZA";
            this.quantityPIZZA.Size = new System.Drawing.Size(120, 32);
            this.quantityPIZZA.TabIndex = 34;
            this.quantityPIZZA.Text = "Quantity:";
            // 
            // numPizzaQuantity
            // 
            this.numPizzaQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.numPizzaQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numPizzaQuantity.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPizzaQuantity.Location = new System.Drawing.Point(222, 327);
            this.numPizzaQuantity.Name = "numPizzaQuantity";
            this.numPizzaQuantity.ReadOnly = true;
            this.numPizzaQuantity.Size = new System.Drawing.Size(120, 33);
            this.numPizzaQuantity.TabIndex = 35;
            this.numPizzaQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddPizza
            // 
            this.btnAddPizza.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnAddPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPizza.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPizza.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddPizza.Location = new System.Drawing.Point(368, 323);
            this.btnAddPizza.Name = "btnAddPizza";
            this.btnAddPizza.Size = new System.Drawing.Size(146, 38);
            this.btnAddPizza.TabIndex = 36;
            this.btnAddPizza.Text = "ADD PIZZA";
            this.btnAddPizza.UseVisualStyleBackColor = false;
            this.btnAddPizza.Click += new System.EventHandler(this.btnAddPizza_Click);
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnAddDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDrink.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDrink.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDrink.Location = new System.Drawing.Point(368, 458);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(146, 38);
            this.btnAddDrink.TabIndex = 41;
            this.btnAddDrink.Text = "ADD DRINK";
            this.btnAddDrink.UseVisualStyleBackColor = false;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // numDrinkQuantity
            // 
            this.numDrinkQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.numDrinkQuantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numDrinkQuantity.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDrinkQuantity.Location = new System.Drawing.Point(222, 462);
            this.numDrinkQuantity.Name = "numDrinkQuantity";
            this.numDrinkQuantity.ReadOnly = true;
            this.numDrinkQuantity.Size = new System.Drawing.Size(120, 33);
            this.numDrinkQuantity.TabIndex = 40;
            this.numDrinkQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // quantityDRINK
            // 
            this.quantityDRINK.AutoSize = true;
            this.quantityDRINK.BackColor = System.Drawing.Color.Transparent;
            this.quantityDRINK.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityDRINK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.quantityDRINK.Location = new System.Drawing.Point(93, 463);
            this.quantityDRINK.Name = "quantityDRINK";
            this.quantityDRINK.Size = new System.Drawing.Size(120, 32);
            this.quantityDRINK.TabIndex = 39;
            this.quantityDRINK.Text = "Quantity:";
            // 
            // cmbDrink
            // 
            this.cmbDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.cmbDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbDrink.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDrink.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDrink.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cmbDrink.FormattingEnabled = true;
            this.cmbDrink.ItemHeight = 25;
            this.cmbDrink.Items.AddRange(new object[] {
            "Coke",
            "Diet Coke",
            "Pepsi",
            "Mountain Dew",
            "7 Up / Sprite",
            "Fanta Orange",
            "Orange Juice",
            "Apple Juice",
            "Mango Juice",
            "Lemonade",
            "Water (500ml)",
            "Water (1L)"});
            this.cmbDrink.Location = new System.Drawing.Point(188, 391);
            this.cmbDrink.MaxDropDownItems = 20;
            this.cmbDrink.Name = "cmbDrink";
            this.cmbDrink.Size = new System.Drawing.Size(326, 33);
            this.cmbDrink.TabIndex = 38;
            // 
            // drink
            // 
            this.drink.AutoSize = true;
            this.drink.BackColor = System.Drawing.Color.Transparent;
            this.drink.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.drink.Location = new System.Drawing.Point(93, 392);
            this.drink.Name = "drink";
            this.drink.Size = new System.Drawing.Size(82, 32);
            this.drink.TabIndex = 37;
            this.drink.Text = "Drink:";
            // 
            // dgvOrderItems
            // 
            this.dgvOrderItems.AllowUserToAddRows = false;
            this.dgvOrderItems.AllowUserToDeleteRows = false;
            this.dgvOrderItems.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.dgvOrderItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Category,
            this.Quantity,
            this.Price,
            this.Total});
            this.dgvOrderItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvOrderItems.Location = new System.Drawing.Point(610, 256);
            this.dgvOrderItems.Name = "dgvOrderItems";
            this.dgvOrderItems.ReadOnly = true;
            this.dgvOrderItems.Size = new System.Drawing.Size(542, 302);
            this.dgvOrderItems.TabIndex = 42;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Type";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // ordersummary
            // 
            this.ordersummary.AutoSize = true;
            this.ordersummary.BackColor = System.Drawing.Color.Transparent;
            this.ordersummary.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordersummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.ordersummary.Location = new System.Drawing.Point(761, 193);
            this.ordersummary.Name = "ordersummary";
            this.ordersummary.Size = new System.Drawing.Size(195, 32);
            this.ordersummary.TabIndex = 43;
            this.ordersummary.Text = "Order Summary";
            // 
            // totalamount
            // 
            this.totalamount.AutoSize = true;
            this.totalamount.BackColor = System.Drawing.Color.Transparent;
            this.totalamount.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalamount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.totalamount.Location = new System.Drawing.Point(93, 603);
            this.totalamount.Name = "totalamount";
            this.totalamount.Size = new System.Drawing.Size(179, 32);
            this.totalamount.TabIndex = 44;
            this.totalamount.Text = "Total Amount:";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalAmount.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(169)))), ((int)(((byte)(120)))));
            this.lblTotalAmount.Location = new System.Drawing.Point(278, 603);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(195, 32);
            this.lblTotalAmount.TabIndex = 45;
            this.lblTotalAmount.Text = "Auto Generated";
            // 
            // btnGenerateBill
            // 
            this.btnGenerateBill.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnGenerateBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerateBill.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBill.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerateBill.Location = new System.Drawing.Point(1006, 597);
            this.btnGenerateBill.Name = "btnGenerateBill";
            this.btnGenerateBill.Size = new System.Drawing.Size(146, 38);
            this.btnGenerateBill.TabIndex = 46;
            this.btnGenerateBill.Text = "BILL";
            this.btnGenerateBill.UseVisualStyleBackColor = false;
            this.btnGenerateBill.Click += new System.EventHandler(this.btnGenerateBill_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Location = new System.Drawing.Point(610, 597);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 38);
            this.btnClear.TabIndex = 47;
            this.btnClear.Text = "CLEAR ";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBack.Location = new System.Drawing.Point(1098, 56);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(90, 29);
            this.btnBack.TabIndex = 48;
            this.btnBack.Text = "BACK";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(109)))), ((int)(((byte)(72)))));
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRemove.Location = new System.Drawing.Point(810, 597);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(146, 38);
            this.btnRemove.TabIndex = 65;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateBill);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.totalamount);
            this.Controls.Add(this.ordersummary);
            this.Controls.Add(this.dgvOrderItems);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.numDrinkQuantity);
            this.Controls.Add(this.quantityDRINK);
            this.Controls.Add(this.cmbDrink);
            this.Controls.Add(this.drink);
            this.Controls.Add(this.btnAddPizza);
            this.Controls.Add(this.numPizzaQuantity);
            this.Controls.Add(this.quantityPIZZA);
            this.Controls.Add(this.cmbPizza);
            this.Controls.Add(this.pizza);
            this.Controls.Add(this.menuitems);
            this.Controls.Add(this.cmbTableNo);
            this.Controls.Add(this.tableortakeaway);
            this.Controls.Add(this.lblTokenNo);
            this.Controls.Add(this.tokennumber);
            this.Controls.Add(this.orderinfo);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            this.header.ResumeLayout(false);
            this.management.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPizzaQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrinkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private System.Windows.Forms.Panel management;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Label orderinfo;
        private System.Windows.Forms.Label tokennumber;
        private System.Windows.Forms.Label lblTokenNo;
        private System.Windows.Forms.Label tableortakeaway;
        private System.Windows.Forms.ComboBox cmbTableNo;
        private System.Windows.Forms.Label menuitems;
        private System.Windows.Forms.Label pizza;
        private System.Windows.Forms.ComboBox cmbPizza;
        private System.Windows.Forms.Label quantityPIZZA;
        private System.Windows.Forms.NumericUpDown numPizzaQuantity;
        private System.Windows.Forms.Button btnAddPizza;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.NumericUpDown numDrinkQuantity;
        private System.Windows.Forms.Label quantityDRINK;
        private System.Windows.Forms.ComboBox cmbDrink;
        private System.Windows.Forms.Label drink;
        private System.Windows.Forms.DataGridView dgvOrderItems;
        private System.Windows.Forms.Label ordersummary;
        private System.Windows.Forms.Label totalamount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Button btnGenerateBill;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRemove;
    }
}