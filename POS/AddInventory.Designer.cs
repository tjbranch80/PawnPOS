
namespace POS
{
	partial class AddInventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInventory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ProductIDTextBox = new System.Windows.Forms.TextBox();
            this.ProductDescTextBox = new System.Windows.Forms.TextBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.SerialNumTextBox = new System.Windows.Forms.TextBox();
            this.PrimeCatGridView = new System.Windows.Forms.DataGridView();
            this.SecCatGridView = new System.Windows.Forms.DataGridView();
            this.CancelInvButton = new System.Windows.Forms.Button();
            this.SaveInvButton = new System.Windows.Forms.Button();
            this.BottomBorder = new System.Windows.Forms.PictureBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Product ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Product Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Purchase Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Select Primary Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Select Secondary Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Enter Serial Number";
            // 
            // ProductIDTextBox
            // 
            this.ProductIDTextBox.Location = new System.Drawing.Point(104, 12);
            this.ProductIDTextBox.Name = "ProductIDTextBox";
            this.ProductIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductIDTextBox.TabIndex = 0;
            // 
            // ProductDescTextBox
            // 
            this.ProductDescTextBox.Location = new System.Drawing.Point(146, 44);
            this.ProductDescTextBox.Name = "ProductDescTextBox";
            this.ProductDescTextBox.Size = new System.Drawing.Size(282, 20);
            this.ProductDescTextBox.TabIndex = 1;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(125, 83);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(100, 20);
            this.PriceTextBox.TabIndex = 2;
            // 
            // SerialNumTextBox
            // 
            this.SerialNumTextBox.Location = new System.Drawing.Point(119, 283);
            this.SerialNumTextBox.Name = "SerialNumTextBox";
            this.SerialNumTextBox.Size = new System.Drawing.Size(142, 20);
            this.SerialNumTextBox.TabIndex = 5;
            // 
            // PrimeCatGridView
            // 
            this.PrimeCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrimeCatGridView.Location = new System.Drawing.Point(12, 152);
            this.PrimeCatGridView.Name = "PrimeCatGridView";
            this.PrimeCatGridView.Size = new System.Drawing.Size(139, 100);
            this.PrimeCatGridView.TabIndex = 3;
            // 
            // SecCatGridView
            // 
            this.SecCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SecCatGridView.Location = new System.Drawing.Point(219, 152);
            this.SecCatGridView.Name = "SecCatGridView";
            this.SecCatGridView.Size = new System.Drawing.Size(136, 100);
            this.SecCatGridView.TabIndex = 4;
            // 
            // CancelInvButton
            // 
            this.CancelInvButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelInvButton.BackgroundImage")));
            this.CancelInvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelInvButton.Location = new System.Drawing.Point(382, 268);
            this.CancelInvButton.Name = "CancelInvButton";
            this.CancelInvButton.Size = new System.Drawing.Size(48, 48);
            this.CancelInvButton.TabIndex = 7;
            this.CancelInvButton.UseVisualStyleBackColor = true;
            this.CancelInvButton.Click += new System.EventHandler(this.CancelInvButtonClick);
            // 
            // SaveInvButton
            // 
            this.SaveInvButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveInvButton.BackgroundImage")));
            this.SaveInvButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SaveInvButton.Location = new System.Drawing.Point(307, 268);
            this.SaveInvButton.Name = "SaveInvButton";
            this.SaveInvButton.Size = new System.Drawing.Size(48, 48);
            this.SaveInvButton.TabIndex = 6;
            this.SaveInvButton.UseVisualStyleBackColor = true;
            this.SaveInvButton.Click += new System.EventHandler(this.SaveInvButtonClick);
            // 
            // BottomBorder
            // 
            this.BottomBorder.Image = ((System.Drawing.Image)(resources.GetObject("BottomBorder.Image")));
            this.BottomBorder.Location = new System.Drawing.Point(-3, 344);
            this.BottomBorder.Name = "BottomBorder";
            this.BottomBorder.Size = new System.Drawing.Size(450, 33);
            this.BottomBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BottomBorder.TabIndex = 8;
            this.BottomBorder.TabStop = false;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(442, 376);
            this.ControlBox = false;
            this.Controls.Add(this.BottomBorder);
            this.Controls.Add(this.SaveInvButton);
            this.Controls.Add(this.CancelInvButton);
            this.Controls.Add(this.SecCatGridView);
            this.Controls.Add(this.PrimeCatGridView);
            this.Controls.Add(this.SerialNumTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.ProductDescTextBox);
            this.Controls.Add(this.ProductIDTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddInventory";
            this.Text = "Add New Inventory";
            this.Load += new System.EventHandler(this.AddInventoryLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox BottomBorder;
		private System.Windows.Forms.Button SaveInvButton;
		private System.Windows.Forms.Button CancelInvButton;
		private System.Windows.Forms.DataGridView SecCatGridView;
		private System.Windows.Forms.DataGridView PrimeCatGridView;
		private System.Windows.Forms.TextBox SerialNumTextBox;
		private System.Windows.Forms.TextBox PriceTextBox;
		private System.Windows.Forms.TextBox ProductDescTextBox;
		private System.Windows.Forms.TextBox ProductIDTextBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
	}
}
