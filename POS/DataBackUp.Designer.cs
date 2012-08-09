namespace POS
{
    partial class DataBackUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBackUp));
            this.TargetFolderLabel = new System.Windows.Forms.Label();
            this.TargetButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BackUpButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.TotalCopiedLabel = new System.Windows.Forms.Label();
            this.CloseLayawayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TargetFolderLabel
            // 
            this.TargetFolderLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TargetFolderLabel.Location = new System.Drawing.Point(12, 34);
            this.TargetFolderLabel.Name = "TargetFolderLabel";
            this.TargetFolderLabel.Size = new System.Drawing.Size(255, 29);
            this.TargetFolderLabel.TabIndex = 0;
            // 
            // TargetButton
            // 
            this.TargetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TargetButton.Location = new System.Drawing.Point(273, 34);
            this.TargetButton.Name = "TargetButton";
            this.TargetButton.Size = new System.Drawing.Size(39, 29);
            this.TargetButton.TabIndex = 1;
            this.TargetButton.Text = "...";
            this.TargetButton.UseVisualStyleBackColor = true;
            this.TargetButton.Click += new System.EventHandler(this.TargetButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Target Folder\\Drive";
            // 
            // BackUpButton
            // 
            this.BackUpButton.Location = new System.Drawing.Point(12, 90);
            this.BackUpButton.Name = "BackUpButton";
            this.BackUpButton.Size = new System.Drawing.Size(103, 23);
            this.BackUpButton.TabIndex = 3;
            this.BackUpButton.Text = "Start Backup";
            this.BackUpButton.UseVisualStyleBackColor = true;
            this.BackUpButton.Click += new System.EventHandler(this.BackUpButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(12, 148);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(255, 23);
            this.StatusLabel.TabIndex = 4;
            // 
            // TotalCopiedLabel
            // 
            this.TotalCopiedLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalCopiedLabel.Location = new System.Drawing.Point(12, 195);
            this.TotalCopiedLabel.Name = "TotalCopiedLabel";
            this.TotalCopiedLabel.Size = new System.Drawing.Size(103, 23);
            this.TotalCopiedLabel.TabIndex = 5;
            // 
            // CloseLayawayButton
            // 
            this.CloseLayawayButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseLayawayButton.BackgroundImage")));
            this.CloseLayawayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseLayawayButton.Location = new System.Drawing.Point(402, 195);
            this.CloseLayawayButton.Name = "CloseLayawayButton";
            this.CloseLayawayButton.Size = new System.Drawing.Size(48, 48);
            this.CloseLayawayButton.TabIndex = 7;
            this.CloseLayawayButton.UseVisualStyleBackColor = true;
            this.CloseLayawayButton.Click += new System.EventHandler(this.CloseLayawayButton_Click);
            // 
            // DataBackUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 252);
            this.ControlBox = false;
            this.Controls.Add(this.CloseLayawayButton);
            this.Controls.Add(this.TotalCopiedLabel);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.BackUpButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TargetButton);
            this.Controls.Add(this.TargetFolderLabel);
            this.Name = "DataBackUp";
            this.Text = "Data Back Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TargetFolderLabel;
        private System.Windows.Forms.Button TargetButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackUpButton;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label TotalCopiedLabel;
        private System.Windows.Forms.Button CloseLayawayButton;
    }
}