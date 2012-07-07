
namespace POS
{
	partial class Maintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maintenance));
            this.AddProdStatusButton = new System.Windows.Forms.Button();
            this.AddSecondCatButton = new System.Windows.Forms.Button();
            this.AddPrimeCatButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProdStatusButton
            // 
            this.AddProdStatusButton.Location = new System.Drawing.Point(12, 24);
            this.AddProdStatusButton.Name = "AddProdStatusButton";
            this.AddProdStatusButton.Size = new System.Drawing.Size(151, 23);
            this.AddProdStatusButton.TabIndex = 0;
            this.AddProdStatusButton.Text = "Add Product Status";
            this.AddProdStatusButton.UseVisualStyleBackColor = true;
            this.AddProdStatusButton.Click += new System.EventHandler(this.AddProdStatusButtonClick);
            // 
            // AddSecondCatButton
            // 
            this.AddSecondCatButton.Location = new System.Drawing.Point(12, 115);
            this.AddSecondCatButton.Name = "AddSecondCatButton";
            this.AddSecondCatButton.Size = new System.Drawing.Size(151, 23);
            this.AddSecondCatButton.TabIndex = 2;
            this.AddSecondCatButton.Text = "Add Secondary Category";
            this.AddSecondCatButton.UseVisualStyleBackColor = true;
            this.AddSecondCatButton.Click += new System.EventHandler(this.AddSecondCatButtonClick);
            // 
            // AddPrimeCatButton
            // 
            this.AddPrimeCatButton.Location = new System.Drawing.Point(12, 67);
            this.AddPrimeCatButton.Name = "AddPrimeCatButton";
            this.AddPrimeCatButton.Size = new System.Drawing.Size(151, 23);
            this.AddPrimeCatButton.TabIndex = 1;
            this.AddPrimeCatButton.Text = "Add Prime Category";
            this.AddPrimeCatButton.UseVisualStyleBackColor = true;
            this.AddPrimeCatButton.Click += new System.EventHandler(this.AddPrimeCatButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(115, 166);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 33);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(175, 258);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.AddPrimeCatButton);
            this.Controls.Add(this.AddSecondCatButton);
            this.Controls.Add(this.AddProdStatusButton);
            this.Name = "Maintenance";
            this.Text = "Maintenance";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button AddPrimeCatButton;
		private System.Windows.Forms.Button AddSecondCatButton;
		private System.Windows.Forms.Button AddProdStatusButton;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
