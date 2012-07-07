
namespace POS
{
	partial class PawnItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PawnItem));
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.AddCustomerIDButton = new System.Windows.Forms.Button();
            this.RemoveCustomerIDButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductDescTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PrincipalTextBox = new System.Windows.Forms.TextBox();
            this.TotalOwedTextBox = new System.Windows.Forms.Label();
            this.TotalCalcButton = new System.Windows.Forms.Button();
            this.ChargeLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TotalOwedLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CreatePawnButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 56);
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(393, 150);
            this.CustomerGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer:";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(86, 256);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(91, 20);
            this.CustomerIDTextBox.TabIndex = 4;
            // 
            // AddCustomerIDButton
            // 
            this.AddCustomerIDButton.Location = new System.Drawing.Point(15, 212);
            this.AddCustomerIDButton.Name = "AddCustomerIDButton";
            this.AddCustomerIDButton.Size = new System.Drawing.Size(59, 23);
            this.AddCustomerIDButton.TabIndex = 2;
            this.AddCustomerIDButton.Text = "Add";
            this.AddCustomerIDButton.UseVisualStyleBackColor = true;
            this.AddCustomerIDButton.Click += new System.EventHandler(this.AddCustomerIDButtonClick);
            // 
            // RemoveCustomerIDButton
            // 
            this.RemoveCustomerIDButton.Location = new System.Drawing.Point(86, 212);
            this.RemoveCustomerIDButton.Name = "RemoveCustomerIDButton";
            this.RemoveCustomerIDButton.Size = new System.Drawing.Size(59, 23);
            this.RemoveCustomerIDButton.TabIndex = 3;
            this.RemoveCustomerIDButton.Text = "Remove";
            this.RemoveCustomerIDButton.UseVisualStyleBackColor = true;
            this.RemoveCustomerIDButton.Click += new System.EventHandler(this.RemoveCustomerIDButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filter By Last Name:";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(119, 30);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(100, 20);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBoxTextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Enter Product Description:";
            // 
            // ProductDescTextBox
            // 
            this.ProductDescTextBox.Location = new System.Drawing.Point(149, 291);
            this.ProductDescTextBox.Name = "ProductDescTextBox";
            this.ProductDescTextBox.Size = new System.Drawing.Size(256, 20);
            this.ProductDescTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enter Pawn Cash Amount:";
            // 
            // PrincipalTextBox
            // 
            this.PrincipalTextBox.Location = new System.Drawing.Point(149, 331);
            this.PrincipalTextBox.Name = "PrincipalTextBox";
            this.PrincipalTextBox.Size = new System.Drawing.Size(100, 20);
            this.PrincipalTextBox.TabIndex = 6;
            // 
            // TotalOwedTextBox
            // 
            this.TotalOwedTextBox.AutoSize = true;
            this.TotalOwedTextBox.Location = new System.Drawing.Point(58, 421);
            this.TotalOwedTextBox.Name = "TotalOwedTextBox";
            this.TotalOwedTextBox.Size = new System.Drawing.Size(85, 13);
            this.TotalOwedTextBox.TabIndex = 11;
            this.TotalOwedTextBox.Text = "Finance Charge:";
            // 
            // TotalCalcButton
            // 
            this.TotalCalcButton.Location = new System.Drawing.Point(149, 373);
            this.TotalCalcButton.Name = "TotalCalcButton";
            this.TotalCalcButton.Size = new System.Drawing.Size(100, 23);
            this.TotalCalcButton.TabIndex = 7;
            this.TotalCalcButton.Text = "Generate Info";
            this.TotalCalcButton.UseVisualStyleBackColor = true;
            this.TotalCalcButton.Click += new System.EventHandler(this.TotalCalcButtonClick);
            // 
            // ChargeLabel
            // 
            this.ChargeLabel.Location = new System.Drawing.Point(149, 421);
            this.ChargeLabel.Name = "ChargeLabel";
            this.ChargeLabel.Size = new System.Drawing.Size(100, 13);
            this.ChargeLabel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 460);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Total Amount Owed:";
            // 
            // TotalOwedLabel
            // 
            this.TotalOwedLabel.Location = new System.Drawing.Point(149, 460);
            this.TotalOwedLabel.Name = "TotalOwedLabel";
            this.TotalOwedLabel.Size = new System.Drawing.Size(100, 13);
            this.TotalOwedLabel.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Customer ID:";
            // 
            // CreatePawnButton
            // 
            this.CreatePawnButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreatePawnButton.BackgroundImage")));
            this.CreatePawnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CreatePawnButton.Location = new System.Drawing.Point(268, 442);
            this.CreatePawnButton.Name = "CreatePawnButton";
            this.CreatePawnButton.Size = new System.Drawing.Size(48, 48);
            this.CreatePawnButton.TabIndex = 8;
            this.CreatePawnButton.UseVisualStyleBackColor = true;
            this.CreatePawnButton.Click += new System.EventHandler(this.CreatePawnButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(357, 442);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 17;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(426, 33);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // PawnItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 538);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.CreatePawnButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TotalOwedLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ChargeLabel);
            this.Controls.Add(this.TotalCalcButton);
            this.Controls.Add(this.TotalOwedTextBox);
            this.Controls.Add(this.PrincipalTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductDescTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveCustomerIDButton);
            this.Controls.Add(this.AddCustomerIDButton);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "PawnItem";
            this.Text = "Pawn Item";
            this.Load += new System.EventHandler(this.PawnItemLoad);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button CreatePawnButton;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label TotalOwedLabel;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label ChargeLabel;
		private System.Windows.Forms.Button TotalCalcButton;
		private System.Windows.Forms.Label TotalOwedTextBox;
		private System.Windows.Forms.TextBox PrincipalTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox ProductDescTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox FilterTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button RemoveCustomerIDButton;
		private System.Windows.Forms.Button AddCustomerIDButton;
		private System.Windows.Forms.TextBox CustomerIDTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
	}
}
