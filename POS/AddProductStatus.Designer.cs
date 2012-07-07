
namespace POS
{
	partial class AddProductStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductStatus));
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Location = new System.Drawing.Point(121, 12);
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.Size = new System.Drawing.Size(103, 20);
            this.StatusTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddButton.BackgroundImage")));
            this.AddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddButton.Location = new System.Drawing.Point(121, 70);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(48, 48);
            this.AddButton.TabIndex = 1;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Status To Add";
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelAddButton.BackgroundImage")));
            this.CancelAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelAddButton.Location = new System.Drawing.Point(193, 70);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(48, 48);
            this.CancelAddButton.TabIndex = 2;
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(253, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddProductStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(253, 165);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.StatusTextBox);
            this.Name = "AddProductStatus";
            this.Text = "Add Product Status";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.TextBox StatusTextBox;
	}
}
