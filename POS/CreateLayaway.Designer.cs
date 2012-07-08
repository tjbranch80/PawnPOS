namespace POS
{
    partial class CreateLayaway
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateLayaway));
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CloseLayawayButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InventoryGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductFilterTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.RemoveProductButton = new System.Windows.Forms.Button();
            this.ProductsGridView = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(15, 38);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(400, 121);
            this.CustomerGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filter By Last Name:";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(119, 12);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(131, 20);
            this.FilterTextBox.TabIndex = 2;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(421, 58);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(56, 23);
            this.AddCustomerButton.TabIndex = 3;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButton_Click);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(421, 114);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(56, 23);
            this.RemoveCustomerButton.TabIndex = 4;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButton_Click);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(499, 58);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 5;
            // 
            // CloseLayawayButton
            // 
            this.CloseLayawayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseLayawayButton.BackgroundImage")));
            this.CloseLayawayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseLayawayButton.Location = new System.Drawing.Point(553, 556);
            this.CloseLayawayButton.Name = "CloseLayawayButton";
            this.CloseLayawayButton.Size = new System.Drawing.Size(48, 48);
            this.CloseLayawayButton.TabIndex = 6;
            this.CloseLayawayButton.UseVisualStyleBackColor = true;
            this.CloseLayawayButton.Click += new System.EventHandler(this.CloseLayawayButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Item To Add To Layaway";
            // 
            // InventoryGridView
            // 
            this.InventoryGridView.AllowUserToAddRows = false;
            this.InventoryGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InventoryGridView.Location = new System.Drawing.Point(15, 224);
            this.InventoryGridView.Name = "InventoryGridView";
            this.InventoryGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.InventoryGridView.Size = new System.Drawing.Size(400, 131);
            this.InventoryGridView.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Filter By Product Description";
            // 
            // ProductFilterTextBox
            // 
            this.ProductFilterTextBox.Location = new System.Drawing.Point(158, 198);
            this.ProductFilterTextBox.Name = "ProductFilterTextBox";
            this.ProductFilterTextBox.Size = new System.Drawing.Size(210, 20);
            this.ProductFilterTextBox.TabIndex = 10;
            this.ProductFilterTextBox.TextChanged += new System.EventHandler(this.ProductFilterTextBox_TextChanged);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(15, 372);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(56, 23);
            this.AddProductButton.TabIndex = 11;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // RemoveProductButton
            // 
            this.RemoveProductButton.Location = new System.Drawing.Point(115, 372);
            this.RemoveProductButton.Name = "RemoveProductButton";
            this.RemoveProductButton.Size = new System.Drawing.Size(56, 23);
            this.RemoveProductButton.TabIndex = 12;
            this.RemoveProductButton.Text = "Remove";
            this.RemoveProductButton.UseVisualStyleBackColor = true;
            this.RemoveProductButton.Click += new System.EventHandler(this.RemoveProductButton_Click);
            // 
            // ProductsGridView
            // 
            this.ProductsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.SalePrice});
            this.ProductsGridView.Location = new System.Drawing.Point(15, 416);
            this.ProductsGridView.Name = "ProductsGridView";
            this.ProductsGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductsGridView.Size = new System.Drawing.Size(235, 150);
            this.ProductsGridView.TabIndex = 13;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "ProductID";
            this.ProductID.Name = "ProductID";
            // 
            // SalePrice
            // 
            this.SalePrice.HeaderText = "SalePrice";
            this.SalePrice.Name = "SalePrice";
            // 
            // CreateLayaway
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 616);
            this.ControlBox = false;
            this.Controls.Add(this.ProductsGridView);
            this.Controls.Add(this.RemoveProductButton);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.ProductFilterTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InventoryGridView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CloseLayawayButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "CreateLayaway";
            this.Text = "Create Layaway";
            this.Load += new System.EventHandler(this.CreateLayaway_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InventoryGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Button AddCustomerButton;
        private System.Windows.Forms.Button RemoveCustomerButton;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Button CloseLayawayButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView InventoryGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductFilterTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.Button RemoveProductButton;
        private System.Windows.Forms.DataGridView ProductsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalePrice;
    }
}