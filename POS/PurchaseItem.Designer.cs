
namespace POS
{
	partial class PurchaseItem
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseItem));
            this.label1 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.AddCustomerButton = new System.Windows.Forms.Button();
            this.RemoveCustomerButton = new System.Windows.Forms.Button();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDescTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.PrimeCatGridView = new System.Windows.Forms.DataGridView();
            this.SecCatGridView = new System.Windows.Forms.DataGridView();
            this.SavePurchaseButton = new System.Windows.Forms.Button();
            this.CancelPurchaseButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PurchaseGridView = new System.Windows.Forms.DataGridView();
            this.AddNewItemButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter By Last Name";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(116, 18);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBoxTextChanged);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 44);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(400, 150);
            this.CustomerGridView.TabIndex = 1;
            // 
            // AddCustomerButton
            // 
            this.AddCustomerButton.Location = new System.Drawing.Point(418, 79);
            this.AddCustomerButton.Name = "AddCustomerButton";
            this.AddCustomerButton.Size = new System.Drawing.Size(56, 23);
            this.AddCustomerButton.TabIndex = 2;
            this.AddCustomerButton.Text = "Add";
            this.AddCustomerButton.UseVisualStyleBackColor = true;
            this.AddCustomerButton.Click += new System.EventHandler(this.AddCustomerButtonClick);
            // 
            // RemoveCustomerButton
            // 
            this.RemoveCustomerButton.Location = new System.Drawing.Point(418, 140);
            this.RemoveCustomerButton.Name = "RemoveCustomerButton";
            this.RemoveCustomerButton.Size = new System.Drawing.Size(56, 23);
            this.RemoveCustomerButton.TabIndex = 3;
            this.RemoveCustomerButton.Text = "Remove";
            this.RemoveCustomerButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerButton.Click += new System.EventHandler(this.RemoveCustomerButtonClick);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(494, 79);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Product ID";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(116, 223);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Product Description";
            // 
            // ProductDescTextBox
            // 
            this.ProductDescTextBox.Location = new System.Drawing.Point(364, 223);
            this.ProductDescTextBox.Name = "ProductDescTextBox";
            this.ProductDescTextBox.Size = new System.Drawing.Size(230, 20);
            this.ProductDescTextBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Enter Purchase Price";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(125, 261);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 7;
            // 
            // PrimeCatGridView
            // 
            this.PrimeCatGridView.AllowUserToAddRows = false;
            this.PrimeCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrimeCatGridView.Location = new System.Drawing.Point(12, 334);
            this.PrimeCatGridView.Name = "PrimeCatGridView";
            this.PrimeCatGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrimeCatGridView.Size = new System.Drawing.Size(139, 100);
            this.PrimeCatGridView.TabIndex = 9;
            // 
            // SecCatGridView
            // 
            this.SecCatGridView.AllowUserToAddRows = false;
            this.SecCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecCatGridView.Location = new System.Drawing.Point(202, 334);
            this.SecCatGridView.Name = "SecCatGridView";
            this.SecCatGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SecCatGridView.Size = new System.Drawing.Size(139, 100);
            this.SecCatGridView.TabIndex = 10;
            // 
            // SavePurchaseButton
            // 
            this.SavePurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SavePurchaseButton.Location = new System.Drawing.Point(364, 483);
            this.SavePurchaseButton.Name = "SavePurchaseButton";
            this.SavePurchaseButton.Size = new System.Drawing.Size(127, 23);
            this.SavePurchaseButton.TabIndex = 12;
            this.SavePurchaseButton.Text = "Create Invoice";
            this.SavePurchaseButton.UseVisualStyleBackColor = true;
            this.SavePurchaseButton.Click += new System.EventHandler(this.SavePurchaseButtonClick);
            // 
            // CancelPurchaseButton
            // 
            this.CancelPurchaseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelPurchaseButton.BackgroundImage")));
            this.CancelPurchaseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelPurchaseButton.Location = new System.Drawing.Point(573, 535);
            this.CancelPurchaseButton.Name = "CancelPurchaseButton";
            this.CancelPurchaseButton.Size = new System.Drawing.Size(48, 48);
            this.CancelPurchaseButton.TabIndex = 13;
            this.CancelPurchaseButton.UseVisualStyleBackColor = true;
            this.CancelPurchaseButton.Click += new System.EventHandler(this.CancelPurchaseButtonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(240, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Enter Serial Number";
            // 
            // SerialNumberTextBox
            // 
            this.SerialNumberTextBox.Location = new System.Drawing.Point(364, 261);
            this.SerialNumberTextBox.Name = "SerialNumberTextBox";
            this.SerialNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.SerialNumberTextBox.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 309);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Select Primary Category";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(202, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Select Secondary Category";
            // 
            // PurchaseGridView
            // 
            this.PurchaseGridView.AllowUserToAddRows = false;
            this.PurchaseGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PurchaseGridView.Location = new System.Drawing.Point(12, 453);
            this.PurchaseGridView.Name = "PurchaseGridView";
            this.PurchaseGridView.RowTemplate.ReadOnly = true;
            this.PurchaseGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PurchaseGridView.Size = new System.Drawing.Size(329, 130);
            this.PurchaseGridView.TabIndex = 20;
            // 
            // AddNewItemButton
            // 
            this.AddNewItemButton.Location = new System.Drawing.Point(364, 411);
            this.AddNewItemButton.Name = "AddNewItemButton";
            this.AddNewItemButton.Size = new System.Drawing.Size(127, 23);
            this.AddNewItemButton.TabIndex = 11;
            this.AddNewItemButton.Text = "Add Purchased Item";
            this.AddNewItemButton.UseVisualStyleBackColor = true;
            this.AddNewItemButton.Click += new System.EventHandler(this.AddNewItemButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 589);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(637, 33);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PurchaseItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(633, 621);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AddNewItemButton);
            this.Controls.Add(this.PurchaseGridView);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SerialNumberTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CancelPurchaseButton);
            this.Controls.Add(this.SavePurchaseButton);
            this.Controls.Add(this.SecCatGridView);
            this.Controls.Add(this.PrimeCatGridView);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductDescTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.RemoveCustomerButton);
            this.Controls.Add(this.AddCustomerButton);
            this.Controls.Add(this.CustomerGridView);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label1);
            this.Name = "PurchaseItem";
            this.Text = "Purchase Item";
            this.Load += new System.EventHandler(this.PurchaseItemLoad);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PurchaseGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button AddNewItemButton;
		private System.Windows.Forms.DataGridView PurchaseGridView;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox SerialNumberTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button CancelPurchaseButton;
		private System.Windows.Forms.Button SavePurchaseButton;
		private System.Windows.Forms.DataGridView SecCatGridView;
		private System.Windows.Forms.DataGridView PrimeCatGridView;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProductDescTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox ProductIDTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox CustomerIDTextBox;
		private System.Windows.Forms.Button RemoveCustomerButton;
		private System.Windows.Forms.Button AddCustomerButton;
		private System.Windows.Forms.DataGridView CustomerGridView;
		private System.Windows.Forms.TextBox FilterTextBox;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
	}
}
