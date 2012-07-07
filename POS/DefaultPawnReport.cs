using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using System.Windows.Forms;
using fyiReporting.RdlViewer;
using fyiReporting.RDL; 



namespace POS
{
    public partial class DefaultPawnReport : Form
    {
        #region Global Components

        string connectionString;
        
        public DefaultPawnReport()
        {
            InitializeComponent();
            CenterToScreen();

            var connectionStringSettings = ConfigurationManager.ConnectionStrings["PawnShopDB"];
            if (connectionStringSettings == null)
            {
                MessageBox.Show("Unable to connect to database.");
            }
            else
            {
                connectionString = connectionStringSettings.ConnectionString;
            }
        }

        DataTable reportData = new DataTable();

        #endregion

        #region Private Methods

        private void CloseReportButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefaultPawnReport_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }

        private void PrintReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAsPDF();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }

        #endregion

        #region Public Methods

        public void DisplayReport()
        {
            ReportDataManager reportDataManager = new ReportDataManager(connectionString);
            string reportPath = ConfigurationManager.AppSettings["ReportPath"];
            DateTime date = DateTime.Today;
            reportData = reportDataManager.DefaultPawnReport(date);
            reportViewer.SourceFile = reportPath + "PawnDefaultReport.rdl";
            reportViewer.Report.DataSets["Data"].SetData(reportData);
            reportViewer.Rebuild();
        }

        public void PrintReport()
        {
            PrintDocument.DocumentName = this.Text;
            PrintDocument.PrinterSettings.FromPage = 1;
            PrintDocument.PrinterSettings.ToPage = reportViewer.PageCount;
            PrintDocument.PrinterSettings.MaximumPage = reportViewer.PageCount;
            PrintDocument.PrinterSettings.MinimumPage = 1;
            if (reportViewer.PageHeight < reportViewer.PageWidth)
            {
                PrintDocument.DefaultPageSettings.Landscape = true;
            }
            else
            {
                PrintDocument.DefaultPageSettings.Landscape = false;
            }

            PrintDialog.Document = PrintDocument;
            PrintDialog.AllowSelection = true;
            PrintDialog.AllowSomePages = true;

            if (PrintDialog.ShowDialog() == DialogResult.OK)
            {
                if (PrintDocument.PrinterSettings.PrintRange == PrintRange.Selection)
                {
                    PrintDocument.PrinterSettings.FromPage = reportViewer.PageCurrent;
                }
         
                reportViewer.Print(PrintDocument);
            }
        }

        public void SaveAsPDF()
        {
            SaveFileDialog.DefaultExt = "pdf";
            SaveFileDialog.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            SaveFileDialog.ShowDialog();
            if (!(SaveFileDialog.FileName == string.Empty))
            {
                reportViewer.SaveAs(SaveFileDialog.FileName, "pdf");
            } 

        }

        #endregion
    }
}
