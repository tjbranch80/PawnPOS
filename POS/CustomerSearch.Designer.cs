namespace POS
{
    partial class CustomerSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerSearch));
            this.CustomerGridView = new System.Windows.Forms.DataGridView();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseButton = new System.Windows.Forms.Button();
            this.SalesHistoryGrid = new System.Windows.Forms.DataGridView();
            this.ViewHistoryButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SoldDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pawnHistoryGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoldDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnHistoryGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerGridView.Location = new System.Drawing.Point(12, 50);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.ReadOnly = true;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.Size = new System.Drawing.Size(657, 150);
            this.CustomerGridView.TabIndex = 1;
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(110, 13);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.Size = new System.Drawing.Size(157, 20);
            this.FilterTextBox.TabIndex = 0;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter Customer List";
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Gainsboro;
            this.CloseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseButton.BackgroundImage")));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseButton.Location = new System.Drawing.Point(621, 531);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(48, 48);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SalesHistoryGrid
            // 
            this.SalesHistoryGrid.AllowUserToAddRows = false;
            this.SalesHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SalesHistoryGrid.Location = new System.Drawing.Point(12, 277);
            this.SalesHistoryGrid.Name = "SalesHistoryGrid";
            this.SalesHistoryGrid.ReadOnly = true;
            this.SalesHistoryGrid.Size = new System.Drawing.Size(317, 121);
            this.SalesHistoryGrid.TabIndex = 3;
            // 
            // ViewHistoryButton
            // 
            this.ViewHistoryButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ViewHistoryButton.Location = new System.Drawing.Point(12, 221);
            this.ViewHistoryButton.Name = "ViewHistoryButton";
            this.ViewHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.ViewHistoryButton.TabIndex = 2;
            this.ViewHistoryButton.Text = "View History";
            this.ViewHistoryButton.UseVisualStyleBackColor = false;
            this.ViewHistoryButton.Click += new System.EventHandler(this.ViewHistoryButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sales History";
            // 
            // SoldDataGrid
            // 
            this.SoldDataGrid.AllowUserToAddRows = false;
            this.SoldDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SoldDataGrid.Location = new System.Drawing.Point(347, 277);
            this.SoldDataGrid.Name = "SoldDataGrid";
            this.SoldDataGrid.ReadOnly = true;
            this.SoldDataGrid.Size = new System.Drawing.Size(322, 121);
            this.SoldDataGrid.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Items Purchased From";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 585);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pawnHistoryGrid
            // 
            this.pawnHistoryGrid.AllowUserToAddRows = false;
            this.pawnHistoryGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pawnHistoryGrid.Location = new System.Drawing.Point(12, 433);
            this.pawnHistoryGrid.Name = "pawnHistoryGrid";
            this.pawnHistoryGrid.Size = new System.Drawing.Size(317, 121);
            this.pawnHistoryGrid.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 417);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Pawn Transaction History";
            // 
            // CustomerSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(681, 617);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pawnHistoryGrid);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SoldDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ViewHistoryButton);
            this.Controls.Add(this.SalesHistoryGrid);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.CustomerGridView);
            this.Name = "CustomerSearch";
            this.Text = "Customer Search";
            this.Load += new System.EventHandler(this.CustomerSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesHistoryGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SoldDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pawnHistoryGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomerGridView;
        private System.Windows.Forms.TextBox FilterTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.DataGridView SalesHistoryGrid;
        private System.Windows.Forms.Button ViewHistoryButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView SoldDataGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView pawnHistoryGrid;
        private System.Windows.Forms.Label label4;
    }
}