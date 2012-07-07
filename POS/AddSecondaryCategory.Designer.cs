
namespace POS
{
	partial class AddSecondaryCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSecondaryCategory));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondaryTextBox = new System.Windows.Forms.TextBox();
            this.AddCatButton = new System.Windows.Forms.Button();
            this.CancelAddButton = new System.Windows.Forms.Button();
            this.PrimeCatGridView = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Category To Add";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select A Primary Category";
            // 
            // SecondaryTextBox
            // 
            this.SecondaryTextBox.Location = new System.Drawing.Point(147, 142);
            this.SecondaryTextBox.Name = "SecondaryTextBox";
            this.SecondaryTextBox.Size = new System.Drawing.Size(129, 20);
            this.SecondaryTextBox.TabIndex = 1;
            // 
            // AddCatButton
            // 
            this.AddCatButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddCatButton.BackgroundImage")));
            this.AddCatButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddCatButton.Location = new System.Drawing.Point(189, 185);
            this.AddCatButton.Name = "AddCatButton";
            this.AddCatButton.Size = new System.Drawing.Size(48, 48);
            this.AddCatButton.TabIndex = 2;
            this.AddCatButton.UseVisualStyleBackColor = true;
            this.AddCatButton.Click += new System.EventHandler(this.AddCatButtonClick);
            // 
            // CancelAddButton
            // 
            this.CancelAddButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelAddButton.BackgroundImage")));
            this.CancelAddButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelAddButton.Location = new System.Drawing.Point(261, 185);
            this.CancelAddButton.Name = "CancelAddButton";
            this.CancelAddButton.Size = new System.Drawing.Size(48, 48);
            this.CancelAddButton.TabIndex = 3;
            this.CancelAddButton.UseVisualStyleBackColor = true;
            this.CancelAddButton.Click += new System.EventHandler(this.CancelAddButtonClick);
            // 
            // PrimeCatGridView
            // 
            this.PrimeCatGridView.AllowUserToAddRows = false;
            this.PrimeCatGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PrimeCatGridView.Location = new System.Drawing.Point(147, 19);
            this.PrimeCatGridView.Name = "PrimeCatGridView";
            this.PrimeCatGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PrimeCatGridView.Size = new System.Drawing.Size(162, 105);
            this.PrimeCatGridView.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 242);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 33);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // AddSecondaryCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(321, 273);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PrimeCatGridView);
            this.Controls.Add(this.CancelAddButton);
            this.Controls.Add(this.AddCatButton);
            this.Controls.Add(this.SecondaryTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddSecondaryCategory";
            this.Text = "Add Secondary Category";
            this.Load += new System.EventHandler(this.AddSecondaryCategoryLoad);
            ((System.ComponentModel.ISupportInitialize)(this.PrimeCatGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.DataGridView PrimeCatGridView;
		private System.Windows.Forms.Button CancelAddButton;
		private System.Windows.Forms.Button AddCatButton;
		private System.Windows.Forms.TextBox SecondaryTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
