
namespace POS
{
	partial class ChangeStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeStatus));
            this.StatusGridView = new System.Windows.Forms.DataGridView();
            this.MakeInactiveButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MakeActiveButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.StatusGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusGridView
            // 
            this.StatusGridView.AllowUserToAddRows = false;
            this.StatusGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StatusGridView.Location = new System.Drawing.Point(12, 27);
            this.StatusGridView.Name = "StatusGridView";
            this.StatusGridView.ReadOnly = true;
            this.StatusGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StatusGridView.Size = new System.Drawing.Size(459, 150);
            this.StatusGridView.TabIndex = 0;
            // 
            // MakeInactiveButton
            // 
            this.MakeInactiveButton.Location = new System.Drawing.Point(477, 27);
            this.MakeInactiveButton.Name = "MakeInactiveButton";
            this.MakeInactiveButton.Size = new System.Drawing.Size(99, 23);
            this.MakeInactiveButton.TabIndex = 1;
            this.MakeInactiveButton.Text = "Make Inactive";
            this.MakeInactiveButton.UseVisualStyleBackColor = true;
            this.MakeInactiveButton.Click += new System.EventHandler(this.MakeInactiveButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Location = new System.Drawing.Point(525, 161);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButtonClick);
            // 
            // MakeActiveButton
            // 
            this.MakeActiveButton.Location = new System.Drawing.Point(477, 83);
            this.MakeActiveButton.Name = "MakeActiveButton";
            this.MakeActiveButton.Size = new System.Drawing.Size(99, 23);
            this.MakeActiveButton.TabIndex = 2;
            this.MakeActiveButton.Text = "Make Active";
            this.MakeActiveButton.UseVisualStyleBackColor = true;
            this.MakeActiveButton.Click += new System.EventHandler(this.MakeActiveButtonClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(589, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ChangeStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 255);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MakeActiveButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.MakeInactiveButton);
            this.Controls.Add(this.StatusGridView);
            this.Name = "ChangeStatus";
            this.Text = "Change Status";
            this.Load += new System.EventHandler(this.ChangeStatusLoad);
            ((System.ComponentModel.ISupportInitialize)(this.StatusGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button MakeActiveButton;
		private System.Windows.Forms.Button CloseButton;
		private System.Windows.Forms.Button MakeInactiveButton;
		private System.Windows.Forms.DataGridView StatusGridView;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
