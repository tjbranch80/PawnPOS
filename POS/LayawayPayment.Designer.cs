namespace POS
{
    partial class LayawayPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LayawayPayment));
            this.label1 = new System.Windows.Forms.Label();
            this.LayawayDataGrid = new System.Windows.Forms.DataGridView();
            this.AddTransIDButton = new System.Windows.Forms.Button();
            this.RemoveTransIDButton = new System.Windows.Forms.Button();
            this.TransIDTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CurrentPrincipalLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PrincipalAmountLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LayawayDateLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LayawayStatusLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProdDescLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PaymentHistoryDataGrid = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.PaymentTextBox = new System.Windows.Forms.TextBox();
            this.CreatePaymentButton = new System.Windows.Forms.Button();
            this.PaymentExitButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.LayawayDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select A Layaway Transaction:";
            // 
            // LayawayDataGrid
            // 
            this.LayawayDataGrid.AllowUserToAddRows = false;
            this.LayawayDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LayawayDataGrid.Location = new System.Drawing.Point(12, 25);
            this.LayawayDataGrid.Name = "LayawayDataGrid";
            this.LayawayDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LayawayDataGrid.Size = new System.Drawing.Size(458, 150);
            this.LayawayDataGrid.TabIndex = 6;
            // 
            // AddTransIDButton
            // 
            this.AddTransIDButton.Location = new System.Drawing.Point(12, 181);
            this.AddTransIDButton.Name = "AddTransIDButton";
            this.AddTransIDButton.Size = new System.Drawing.Size(59, 23);
            this.AddTransIDButton.TabIndex = 7;
            this.AddTransIDButton.Text = "Add";
            this.AddTransIDButton.UseVisualStyleBackColor = true;
            this.AddTransIDButton.Click += new System.EventHandler(this.AddTransIDButton_Click);
            // 
            // RemoveTransIDButton
            // 
            this.RemoveTransIDButton.Location = new System.Drawing.Point(189, 181);
            this.RemoveTransIDButton.Name = "RemoveTransIDButton";
            this.RemoveTransIDButton.Size = new System.Drawing.Size(59, 23);
            this.RemoveTransIDButton.TabIndex = 8;
            this.RemoveTransIDButton.Text = "Remove";
            this.RemoveTransIDButton.UseVisualStyleBackColor = true;
            this.RemoveTransIDButton.Click += new System.EventHandler(this.RemoveTransIDButton_Click);
            // 
            // TransIDTextBox
            // 
            this.TransIDTextBox.Location = new System.Drawing.Point(379, 181);
            this.TransIDTextBox.Name = "TransIDTextBox";
            this.TransIDTextBox.Size = new System.Drawing.Size(91, 20);
            this.TransIDTextBox.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CurrentPrincipalLabel);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PrincipalAmountLabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LayawayDateLabel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.LayawayStatusLabel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ProdDescLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 165);
            this.panel1.TabIndex = 10;
            // 
            // CurrentPrincipalLabel
            // 
            this.CurrentPrincipalLabel.Location = new System.Drawing.Point(93, 130);
            this.CurrentPrincipalLabel.Name = "CurrentPrincipalLabel";
            this.CurrentPrincipalLabel.Size = new System.Drawing.Size(234, 23);
            this.CurrentPrincipalLabel.TabIndex = 9;
            this.CurrentPrincipalLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Current Principal";
            // 
            // PrincipalAmountLabel
            // 
            this.PrincipalAmountLabel.Location = new System.Drawing.Point(92, 98);
            this.PrincipalAmountLabel.Name = "PrincipalAmountLabel";
            this.PrincipalAmountLabel.Size = new System.Drawing.Size(235, 23);
            this.PrincipalAmountLabel.TabIndex = 7;
            this.PrincipalAmountLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Original Principal";
            // 
            // LayawayDateLabel
            // 
            this.LayawayDateLabel.Location = new System.Drawing.Point(92, 69);
            this.LayawayDateLabel.Name = "LayawayDateLabel";
            this.LayawayDateLabel.Size = new System.Drawing.Size(235, 23);
            this.LayawayDateLabel.TabIndex = 5;
            this.LayawayDateLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Layaway Date";
            // 
            // LayawayStatusLabel
            // 
            this.LayawayStatusLabel.Location = new System.Drawing.Point(92, 40);
            this.LayawayStatusLabel.Name = "LayawayStatusLabel";
            this.LayawayStatusLabel.Size = new System.Drawing.Size(235, 23);
            this.LayawayStatusLabel.TabIndex = 3;
            this.LayawayStatusLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Layaway Status";
            // 
            // ProdDescLabel
            // 
            this.ProdDescLabel.Location = new System.Drawing.Point(92, 8);
            this.ProdDescLabel.Name = "ProdDescLabel";
            this.ProdDescLabel.Size = new System.Drawing.Size(235, 23);
            this.ProdDescLabel.TabIndex = 1;
            this.ProdDescLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Item Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 407);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Payment History";
            // 
            // PaymentHistoryDataGrid
            // 
            this.PaymentHistoryDataGrid.AllowUserToAddRows = false;
            this.PaymentHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PaymentHistoryDataGrid.Location = new System.Drawing.Point(12, 423);
            this.PaymentHistoryDataGrid.Name = "PaymentHistoryDataGrid";
            this.PaymentHistoryDataGrid.Size = new System.Drawing.Size(236, 150);
            this.PaymentHistoryDataGrid.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enter Payment Amount:";
            // 
            // PaymentTextBox
            // 
            this.PaymentTextBox.Location = new System.Drawing.Point(270, 423);
            this.PaymentTextBox.Name = "PaymentTextBox";
            this.PaymentTextBox.Size = new System.Drawing.Size(115, 20);
            this.PaymentTextBox.TabIndex = 14;
            // 
            // CreatePaymentButton
            // 
            this.CreatePaymentButton.Location = new System.Drawing.Point(270, 486);
            this.CreatePaymentButton.Name = "CreatePaymentButton";
            this.CreatePaymentButton.Size = new System.Drawing.Size(115, 23);
            this.CreatePaymentButton.TabIndex = 15;
            this.CreatePaymentButton.Text = "Create Payment";
            this.CreatePaymentButton.UseVisualStyleBackColor = true;
            this.CreatePaymentButton.Click += new System.EventHandler(this.CreatePaymentButton_Click);
            // 
            // PaymentExitButton
            // 
            this.PaymentExitButton.BackColor = System.Drawing.Color.White;
            this.PaymentExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PaymentExitButton.BackgroundImage")));
            this.PaymentExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PaymentExitButton.Location = new System.Drawing.Point(422, 525);
            this.PaymentExitButton.Name = "PaymentExitButton";
            this.PaymentExitButton.Size = new System.Drawing.Size(48, 48);
            this.PaymentExitButton.TabIndex = 16;
            this.PaymentExitButton.UseVisualStyleBackColor = false;
            this.PaymentExitButton.Click += new System.EventHandler(this.PaymentExitButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 579);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 33);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // LayawayPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PaymentExitButton);
            this.Controls.Add(this.CreatePaymentButton);
            this.Controls.Add(this.PaymentTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PaymentHistoryDataGrid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TransIDTextBox);
            this.Controls.Add(this.RemoveTransIDButton);
            this.Controls.Add(this.AddTransIDButton);
            this.Controls.Add(this.LayawayDataGrid);
            this.Controls.Add(this.label1);
            this.Name = "LayawayPayment";
            this.Text = "LayawayPayment";
            this.Load += new System.EventHandler(this.LayawayPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LayawayDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaymentHistoryDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView LayawayDataGrid;
        private System.Windows.Forms.Button AddTransIDButton;
        private System.Windows.Forms.Button RemoveTransIDButton;
        private System.Windows.Forms.TextBox TransIDTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label CurrentPrincipalLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label PrincipalAmountLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LayawayDateLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LayawayStatusLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ProdDescLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView PaymentHistoryDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox PaymentTextBox;
        private System.Windows.Forms.Button CreatePaymentButton;
        private System.Windows.Forms.Button PaymentExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}