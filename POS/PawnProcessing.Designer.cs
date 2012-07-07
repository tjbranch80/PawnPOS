
namespace POS
{
	partial class PawnProcessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PawnProcessing));
            this.ProcessCompleteLabel = new System.Windows.Forms.Label();
            this.PawnReportButton = new System.Windows.Forms.Button();
            this.OpenApplicationButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProcessCompleteLabel
            // 
            this.ProcessCompleteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProcessCompleteLabel.Location = new System.Drawing.Point(12, 21);
            this.ProcessCompleteLabel.Name = "ProcessCompleteLabel";
            this.ProcessCompleteLabel.Size = new System.Drawing.Size(361, 23);
            this.ProcessCompleteLabel.TabIndex = 1;
            this.ProcessCompleteLabel.Visible = false;
            // 
            // PawnReportButton
            // 
            this.PawnReportButton.Location = new System.Drawing.Point(12, 70);
            this.PawnReportButton.Name = "PawnReportButton";
            this.PawnReportButton.Size = new System.Drawing.Size(151, 23);
            this.PawnReportButton.TabIndex = 6;
            this.PawnReportButton.Text = "View Pawn Default Report";
            this.PawnReportButton.UseVisualStyleBackColor = true;
            this.PawnReportButton.Visible = false;
            this.PawnReportButton.Click += new System.EventHandler(this.PawnReportButton_Click);
            // 
            // OpenApplicationButton
            // 
            this.OpenApplicationButton.Location = new System.Drawing.Point(253, 70);
            this.OpenApplicationButton.Name = "OpenApplicationButton";
            this.OpenApplicationButton.Size = new System.Drawing.Size(120, 23);
            this.OpenApplicationButton.TabIndex = 7;
            this.OpenApplicationButton.Text = "Open Application";
            this.OpenApplicationButton.UseVisualStyleBackColor = true;
            this.OpenApplicationButton.Visible = false;
            this.OpenApplicationButton.Click += new System.EventHandler(this.OpenApplicationButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(388, 33);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // PawnProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 155);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OpenApplicationButton);
            this.Controls.Add(this.PawnReportButton);
            this.Controls.Add(this.ProcessCompleteLabel);
            this.Name = "PawnProcessing";
            this.Text = "Processing Pawns";
            this.Load += new System.EventHandler(this.PawnProcessingLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button OpenApplicationButton;
        private System.Windows.Forms.Button PawnReportButton;
		private System.Windows.Forms.Label ProcessCompleteLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
	}
}
