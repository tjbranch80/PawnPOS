namespace POS
{
    partial class Sales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sales));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.CloseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomerIDButton = new System.Windows.Forms.Button();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.RemoveCustomerIDButton = new System.Windows.Forms.Button();
            this.ProductAddedGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateSaleButton = new System.Windows.Forms.Button();
            this.TotalSalesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PrimCatFilterTextBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAddedGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Location = new System.Drawing.Point(559, 690);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 11;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By Last Name";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(179, 21);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 58);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(400, 150);
            this.CustomerGridView.TabIndex = 1;
            // 
            // AddCustomerIDButton
            // 
            this.AddCustomerIDButton.Location = new System.Drawing.Point(434, 82);
            this.AddCustomerIDButton.Name = "AddCustomerIDButton";
            this.AddCustomerIDButton.Size = new System.Drawing.Size(57, 23);
            this.AddCustomerIDButton.TabIndex = 2;
            this.AddCustomerIDButton.Text = "Add";
            this.AddCustomerIDButton.UseVisualStyleBackColor = true;
            this.AddCustomerIDButton.Click += new System.EventHandler(this.AddCustomerIDButton_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Location = new System.Drawing.Point(12, 278);
            this.ProductsGridView.MultiSelect = false;
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.ReadOnly = true;
            this.ProductsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGridView.Size = new System.Drawing.Size(400, 235);
            this.ProductsGridView.TabIndex = 6;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(12, 521);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(57, 23);
            this.AddProductButton.TabIndex = 7;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(511, 84);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(93, 20);
            this.CustomerIDTextBox.TabIndex = 4;
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(100, 521);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(57, 23);
            this.RemoveProductButton.TabIndex = 8;
            this.RemoveProductButton.Text = "Remove";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // RemoveCustomerIDButton
            // 
            this.RemoveCustomerIDButton.Location = new System.Drawing.Point(434, 144);
            this.RemoveCustomerIDButton.Name = "RemoveCustomerIDButton";
            this.RemoveCustomerIDButton.Size = new System.Drawing.Size(57, 23);
            this.RemoveCustomerIDButton.TabIndex = 3;
            this.RemoveCustomerIDButton.Text = "Remove";
            this.RemoveCustomerIDButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerIDButton.Click += new System.EventHandler(this.RemoveCustomerIDButton_Click);
            // 
            // ProductAddedGridView
            // 
            this.ProductAddedGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductAddedGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.SalePrice});
            this.ProductAddedGridView.Location = new System.Drawing.Point(12, 567);
            this.ProductAddedGridView.Name = "ProductAddedGridView";
            this.ProductAddedGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductAddedGridView.Size = new System.Drawing.Size(245, 140);
            this.ProductAddedGridView.TabIndex = 11;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            // 
            // SalePrice
            // 
            dataGridViewCellStyle1.NullValue = null;
            this.SalePrice.DefaultCellStyle = dataGridViewCellStyle1;
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            // 
            // CreateSaleButton
            // 
            this.CreateSaleButton.Location = new System.Drawing.Point(266, 715);
            this.CreateSaleButton.Name = "CreateSaleButton";
            this.CreateSaleButton.Size = new System.Drawing.Size(99, 23);
            this.CreateSaleButton.TabIndex = 10;
            this.CreateSaleButton.Text = "Create Invoice";
            this.CreateSaleButton.UseVisualStyleBackColor = true;
            this.CreateSaleButton.Click += new System.EventHandler(this.CreateSaleButton_Click);
            // 
            // TotalSalesButton
            // 
            this.TotalSalesButton.Location = new System.Drawing.Point(313, 567);
            this.TotalSalesButton.Name = "TotalSalesButton";
            this.TotalSalesButton.Size = new System.Drawing.Size(99, 23);
            this.TotalSalesButton.TabIndex = 9;
            this.TotalSalesButton.Text = "Total Amt Due";
            this.TotalSalesButton.UseVisualStyleBackColor = true;
            this.TotalSalesButton.Click += new System.EventHandler(this.TotalSalesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 610);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Total ";
            // 
            // TotalLabel
            // 
            this.TotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalLabel.Location = new System.Drawing.Point(303, 605);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(100, 23);
            this.TotalLabel.TabIndex = 15;
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 645);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Sales Tax";
            // 
            // TaxLabel
            // 
            this.TaxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TaxLabel.Location = new System.Drawing.Point(323, 640);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(80, 23);
            this.TaxLabel.TabIndex = 17;
            this.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 682);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Grand Total";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GrandTotalLabel.Location = new System.Drawing.Point(332, 677);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(71, 23);
            this.GrandTotalLabel.TabIndex = 19;
            this.GrandTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Filter By Primary Category";
            // 
            // PrimCatFilterTextBox
            // 
            this.PrimCatFilterTextBox.Location = new System.Drawing.Point(191, 234);
            this.PrimCatFilterTextBox.Name = "PrimCatFilterTextBox";
            this.PrimCatFilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrimCatFilterTextBox.TabIndex = 5;
            this.PrimCatFilterTextBox.TextChanged += new System.EventHandler(this.PrimCatFilterTextBox_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 744);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 33);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // Sales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(619, 777);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrimCatFilterTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TotalSalesButton);
            this.Controls.Add(this.CreateSaleButton);
            this.Controls.Add(this.ProductAddedGridView);
            this.Controls.Add(this.RemoveCustomerIDButton);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.AddCustomerIDButton);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CloseButton);
            this.Name = "Sales";
            this.Text = "Sales";
            this.Load += new System.EventHandler(this.Sales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAddedGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button AddCustomerIDButton;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.Button RemoveCustomerIDButton;
        private System.Windows.Forms.DataGridView ProductAddedGridView;
        private System.Windows.Forms.Button CreateSaleButton;
        private System.Windows.Forms.Button TotalSalesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PrimCatFilterTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}