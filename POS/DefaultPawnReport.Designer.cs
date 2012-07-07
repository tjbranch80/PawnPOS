namespace POS
{
    partial class DefaultPawnReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private fyiReporting.RdlViewer.RdlViewer reportViewer;
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
            this.reportViewer = new fyiReporting.RdlViewer.RdlViewer();
            this.PrintReportButton = new System.Windows.Forms.Button();
            this.PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.CloseReportButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reportViewer
            // 
            this.reportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportViewer.Folder = null;
            this.reportViewer.HighlightAll = false;
            this.reportViewer.HighlightAllColor = System.Drawing.Color.Fuchsia;
            this.reportViewer.HighlightCaseSensitive = false;
            this.reportViewer.HighlightItemColor = System.Drawing.Color.Aqua;
            this.reportViewer.HighlightPageItem = null;
            this.reportViewer.HighlightText = null;
            this.reportViewer.Location = new System.Drawing.Point(8, 8);
            this.reportViewer.Name = "reportViewer";
            this.reportViewer.PageCurrent = 1;
            this.reportViewer.Parameters = null;
            this.reportViewer.ReportName = null;
            this.reportViewer.ScrollMode = fyiReporting.RdlViewer.ScrollModeEnum.Continuous;
            this.reportViewer.SelectTool = false;
            this.reportViewer.ShowFindPanel = false;
            this.reportViewer.ShowParameterPanel = false;
            this.reportViewer.ShowWaitDialog = true;
            this.reportViewer.Size = new System.Drawing.Size(806, 641);
            this.reportViewer.SourceFile = null;
            this.reportViewer.SourceRdl = null;
            this.reportViewer.TabIndex = 1;
            this.reportViewer.UseTrueMargins = true;
            this.reportViewer.Zoom = 0.9376109F;
            this.reportViewer.ZoomMode = fyiReporting.RdlViewer.ZoomEnum.FitWidth;
            // 
            // PrintReportButton
            // 
            this.PrintReportButton.Location = new System.Drawing.Point(12, 686);
            this.PrintReportButton.Name = "PrintReportButton";
            this.PrintReportButton.Size = new System.Drawing.Size(98, 23);
            this.PrintReportButton.TabIndex = 2;
            this.PrintReportButton.Text = "Print Report";
            this.PrintReportButton.UseVisualStyleBackColor = true;
            this.PrintReportButton.Click += new System.EventHandler(this.PrintReportButton_Click);
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(140, 686);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(98, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save As PDF";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseReportButton
            // 
            this.CloseReportButton.Location = new System.Drawing.Point(722, 686);
            this.CloseReportButton.Name = "CloseReportButton";
            this.CloseReportButton.Size = new System.Drawing.Size(92, 23);
            this.CloseReportButton.TabIndex = 4;
            this.CloseReportButton.Text = "Close Report";
            this.CloseReportButton.UseVisualStyleBackColor = true;
            this.CloseReportButton.Click += new System.EventHandler(this.CloseReportButton_Click);
            // 
            // DefaultPawnReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 721);
            this.ControlBox = false;
            this.Controls.Add(this.CloseReportButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PrintReportButton);
            this.Controls.Add(this.reportViewer);
            this.Name = "DefaultPawnReport";
            this.Text = "DefaultPawnReport";
            this.Load += new System.EventHandler(this.DefaultPawnReport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PrintReportButton;
        private System.Drawing.Printing.PrintDocument PrintDocument;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.SaveFileDialog SaveFileDialog;
        private System.Windows.Forms.Button CloseReportButton;

       
    }
}