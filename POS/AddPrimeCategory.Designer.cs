
namespace POS
{
	partial class AddPrimeCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPrimeCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.PrimeCatTextBox = new System.Windows.Forms.TextBox();
            this.AddCatButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category To Add";
            // 
            // PrimeCatTextBox
            // 
            this.PrimeCatTextBox.Location = new System.Drawing.Point(133, 14);
            this.PrimeCatTextBox.Name = "PrimeCatTextBox";
            this.PrimeCatTextBox.Size = new System.Drawing.Size(111, 20);
            this.PrimeCatTextBox.TabIndex = 0;
            // 
            // AddCatButton
            // 
            this.AddCatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCatButton.BackgroundImage")));
            this.AddCatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCatButton.Location = new System.Drawing.Point(124, 67);
            this.AddCatButton.Name = "AddCatButton";
            this.AddCatButton.Size = new System.Drawing.Size(48, 48);
            this.AddCatButton.TabIndex = 1;
            this.AddCatButton.UseVisualStyleBackColor = true;
            this.AddCatButton.Click += new System.EventHandler(this.AddCatButtonClick);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelAddButton.BackgroundImage")));
            this.CancelAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelAddButton.Location = new System.Drawing.Point(200, 67);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(48, 48);
            this.CancelAddButton.TabIndex = 2;
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // AddPrimeCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(260, 167);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.AddCatButton);
            this.Controls.Add(this.PrimeCatTextBox);
            this.Controls.Add(this.label1);
            this.Name = "AddPrimeCategory";
            this.Text = "Add Prime Category";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Button AddCatButton;
		private System.Windows.Forms.TextBox PrimeCatTextBox;
		private System.Windows.Forms.Label label1;
	}
}
