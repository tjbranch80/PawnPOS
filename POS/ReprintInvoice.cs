
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;

namespace POS
{

	public partial class ReprintInvoice : Form
	{
		#region Global Components

        string connectionString;
        
		public ReprintInvoice()
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
		
		DataTable invoiceDataTable = new DataTable();
		
		#endregion
		
		#region Private Methods\Events
		
		private void ReprintInvoiceLoad(object sender, EventArgs e)
		{
            try
            {
                GetInvoiceData();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem getting the invoice data");
            }
		}
		
		private void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void LoadButtonClick(object sender, EventArgs e)
		{
            try
            {
                LoadInvoice();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem loading the invoice");
            }
		}
		
		#endregion
		
		#region Public Methods
		
		public void GetInvoiceData()
		{
			DataManager dataManager = new DataManager(connectionString);
			invoiceDataTable = dataManager.GetReprintInvoiceData();
			InvoiceGridView.DataSource = invoiceDataTable;
		}
		
		public string GetInvoiceNumber()
		{
			string selectedInvoiceNumber = Convert.ToString(InvoiceGridView.SelectedRows[0].Cells[0].Value);
			return selectedInvoiceNumber;
		}
		
		public void LoadInvoice()
		{
			string invoiceNumber = GetInvoiceNumber();
			var invoicePath = ConfigurationManager.AppSettings["InvoicePath"];
			
			Process.Start(invoicePath + invoiceNumber + ".jpg");
		}
		
		#endregion
	}
}
