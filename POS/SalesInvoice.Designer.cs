namespace POS
{
    partial class SalesInvoice
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
            this.TopLine = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductIDListBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DescriptionListBox = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PriceListBox = new System.Windows.Forms.ListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalSaleLabel = new System.Windows.Forms.Label();
            this.SalesTaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.printDocument = new System.Drawing.Printing.PrintDocument();
            this.label15 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TopLine
            // 
            this.TopLine.BackColor = System.Drawing.Color.Black;
            this.TopLine.Location = new System.Drawing.Point(2, 84);
            this.TopLine.Name = "TopLine";
            this.TopLine.Size = new System.Drawing.Size(598, 2);
            this.TopLine.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(369, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Invoice #";
            // 
            // InvoiceNumberLabel
            // 
            this.InvoiceNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InvoiceNumberLabel.Location = new System.Drawing.Point(444, 63);
            this.InvoiceNumberLabel.Name = "InvoiceNumberLabel";
            this.InvoiceNumberLabel.Size = new System.Drawing.Size(148, 18);
            this.InvoiceNumberLabel.TabIndex = 2;
            this.InvoiceNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductIDListBox
            // 
            this.ProductIDListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ProductIDListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIDListBox.FormattingEnabled = true;
            this.ProductIDListBox.ItemHeight = 18;
            this.ProductIDListBox.Location = new System.Drawing.Point(12, 127);
            this.ProductIDListBox.Name = "ProductIDListBox";
            this.ProductIDListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.ProductIDListBox.Size = new System.Drawing.Size(101, 468);
            this.ProductIDListBox.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(119, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 510);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(461, 87);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 510);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Description";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DescriptionListBox
            // 
            this.DescriptionListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionListBox.FormattingEnabled = true;
            this.DescriptionListBox.ItemHeight = 18;
            this.DescriptionListBox.Location = new System.Drawing.Point(127, 127);
            this.DescriptionListBox.Name = "DescriptionListBox";
            this.DescriptionListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.DescriptionListBox.Size = new System.Drawing.Size(328, 468);
            this.DescriptionListBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(469, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Sale Price";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PriceListBox
            // 
            this.PriceListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PriceListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceListBox.FormatString = "C2";
            this.PriceListBox.FormattingEnabled = true;
            this.PriceListBox.ItemHeight = 18;
            this.PriceListBox.Location = new System.Drawing.Point(469, 127);
            this.PriceListBox.Name = "PriceListBox";
            this.PriceListBox.Size = new System.Drawing.Size(123, 468);
            this.PriceListBox.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(2, 595);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(599, 2);
            this.panel3.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(422, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 641);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Sales Tax";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(377, 679);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Grand Total";
            // 
            // TotalSaleLabel
            // 
            this.TotalSaleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSaleLabel.Location = new System.Drawing.Point(469, 609);
            this.TotalSaleLabel.Name = "TotalSaleLabel";
            this.TotalSaleLabel.Size = new System.Drawing.Size(132, 18);
            this.TotalSaleLabel.TabIndex = 15;
            // 
            // SalesTaxLabel
            // 
            this.SalesTaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesTaxLabel.Location = new System.Drawing.Point(469, 641);
            this.SalesTaxLabel.Name = "SalesTaxLabel";
            this.SalesTaxLabel.Size = new System.Drawing.Size(132, 18);
            this.SalesTaxLabel.TabIndex = 16;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(469, 679);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(132, 18);
            this.GrandTotalLabel.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(345, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 18;
            this.label8.Text = "Customer ID";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDLabel.Location = new System.Drawing.Point(441, 9);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(151, 23);
            this.CustomerIDLabel.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Customer Name";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(444, 32);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(148, 18);
            this.CustomerNameLabel.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(395, 743);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Invoice Date";
            // 
            // DateLabel
            // 
            this.DateLabel.Location = new System.Drawing.Point(469, 743);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(111, 13);
            this.DateLabel.TabIndex = 23;
            // 
            // PrintButton
            // 
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Location = new System.Drawing.Point(388, 717);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(213, 23);
            this.PrintButton.TabIndex = 24;
            this.PrintButton.Text = "Thanks For Your Business";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(598, 87);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(2, 510);
            this.panel4.TabIndex = 25;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(2, 87);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 510);
            this.panel5.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 13);
            this.label11.TabIndex = 27;
            this.label11.Text = "G.I. Joe\'s Gun and Pawn LLC";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "109 B West 5th Street";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Fulton, MO 65251";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "(573) 592-0200";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(2, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(2, 85);
            this.panel6.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(598, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 85);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Black;
            this.panel8.Location = new System.Drawing.Point(2, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(598, 2);
            this.panel8.TabIndex = 33;
            // 
            // printDialog
            // 
            this.printDialog.UseEXDialog = true;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 629);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(314, 127);
            this.label15.TabIndex = 71;
            this.label15.Text = "We Are Not Responsible For Theft Or Fire. Owner Carries No Insurance On Pawned It" +
                "ems.";
            // 
            // SalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 765);
            this.ControlBox = false;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.SalesTaxLabel);
            this.Controls.Add(this.TotalSaleLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PriceListBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DescriptionListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ProductIDListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvoiceNumberLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLine);
            this.Name = "SalesInvoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Drawing.Printing.PrintDocument printDocument;
        private System.Windows.Forms.PrintDialog printDialog;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;

        #endregion

        private System.Windows.Forms.Panel TopLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InvoiceNumberLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ProductIDListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox DescriptionListBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox PriceListBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalSaleLabel;
        private System.Windows.Forms.Label SalesTaxLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label label15;
    }
}