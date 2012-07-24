
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	
	public partial class PurchaseItem : Form
	{
		#region Global Components

        string connectionString;
		
		public PurchaseItem()
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
		
		DataTable purchaseItemTable = new DataTable();
		DataTable customerInfoTable = new DataTable();
		DataTable SecCatTable = new DataTable();
		DataTable PrimeCatTable = new DataTable();
		
		string createPONumber;
		
		#endregion
		
		#region Private Methods\Events
		
		private void CancelPurchaseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void FilterTextBoxTextChanged(object sender, EventArgs e)
		{
			BindingSource bindingSource = new BindingSource();
            if (FilterTextBox.TextLength > 0)
            {
                bindingSource.DataSource = customerInfoTable;
                bindingSource.Filter = string.Format("LastName LIKE '%{0}%'", FilterTextBox.Text.Trim().Replace("'", "''"));
                CustomerGridView.DataSource = bindingSource;
            }
		}
		
		private void PurchaseItemLoad(object sender, EventArgs e)
		{
            try
            {
                GetCustomerData();
                CheckAccountStatus();
                GetPrimeCategories();
                GetSecondaryCategories();
                purchaseItemTable.Columns.Add("Product ID");
                purchaseItemTable.Columns.Add("Product Description");
                purchaseItemTable.Columns.Add("Purchase Price");
                createPONumber = "P" + CreatePONumber();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem loading the data");
            }
		}
		
		private void AddCustomerButtonClick(object sender, EventArgs e)
		{
			string status = GetAccountStatus();
        	
        	if(CustomerIDTextBox.Text == String.Empty && status != "NotActive")
        	{
        		string customerID = GetSelectedCustomerID();
            	CustomerIDTextBox.Text = customerID;
        	}
            else if (status == "NotActive") 
        	{ 
        		MessageBox.Show("Account Is Not Active");
        	} 
            else if (CustomerIDTextBox.Text != String.Empty) 
        	{
        		MessageBox.Show("You Can Only Add One Customer");
        	}
		}
		
		private void RemoveCustomerButtonClick(object sender, EventArgs e)
		{
			CustomerIDTextBox.Text = string.Empty;
		}
		
		private void AddNewItemButtonClick(object sender, EventArgs e)
		{
            bool checkTextBoxes = CheckDataInput();

            if (!checkTextBoxes)
            {
                try
                {
                    AddNewPurchaseItem();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex));
                }
            }
		}
		
		private void SavePurchaseButtonClick(object sender, EventArgs e)
		{
            bool checkTextBoxes = CheckDataInput();
            
            try
            {
                CreatePurchaseInvoice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
            
		}
		
		#endregion
		
		#region Public Methods
		
		public void GetCustomerData()
        {
            DataManager dataManager = new DataManager(connectionString);
            customerInfoTable = dataManager.GetCustomerInformation();
            CustomerGridView.DataSource = customerInfoTable;
        }
		
		public void CheckAccountStatus()
        {
        	for(int i = 0; i < CustomerGridView.Rows.Count; i++)
        	{
        		string status = CustomerGridView.Rows[i].Cells[12].Value.ToString();
        		
        		if(status == "NotActive")
        		{
        			for(int x = 0; x < CustomerGridView.Rows[i].Cells.Count; x++)
        			{
        				CustomerGridView.Rows[i].Cells[x].Style.BackColor = Color.Red;
        			}
        			
        		}
        	}
        }
		
		public string GetSelectedCustomerID()
        {
            string selectedCustomerRow = Convert.ToString(CustomerGridView.SelectedRows[0].Cells[0].Value);
            return selectedCustomerRow;
        }
		
		public string GetAccountStatus()
        {
        	string selectedCustomerStatus = Convert.ToString(CustomerGridView.SelectedRows[0].Cells[12].Value);
        	return selectedCustomerStatus;
        }
		
		public void GetPrimeCategories()
		{
			DataManager dataManger = new DataManager(connectionString);
			PrimeCatTable = dataManger.GetPrimaryCategories();
			PrimeCatGridView.DataSource = PrimeCatTable;
		}
		
		public void GetSecondaryCategories()
		{
			DataManager dataManager = new DataManager(connectionString);
			SecCatTable = dataManager.GetSecondaryCategories();
			SecCatGridView.DataSource = SecCatTable;
		}
		
		public string GetSelectedPrimeCategory()
		{
            string selectedPrimeCat = "";
            if (PrimeCatGridView.SelectedRows.Count > 0)
            {
                selectedPrimeCat = Convert.ToString(PrimeCatGridView.SelectedRows[0].Cells[0].Value);
            }
			return selectedPrimeCat;
		}
		
		public string GetSelectedSecCategory()
		{
            string selectedSecCat = "";
            if (SecCatGridView.SelectedRows.Count > 0)
            {
                selectedSecCat = Convert.ToString(SecCatGridView.SelectedRows[0].Cells[0].Value);
            }
			return selectedSecCat;
		}
		
		public void AddNewPurchaseItem()
		{
			string productID = ProductIDTextBox.Text;
			string productDesc = ProductDescTextBox.Text;
			string purchasePrice = PriceTextBox.Text;
			
			purchaseItemTable.Rows.Add(productID,productDesc,purchasePrice);
			PurchaseGridView.DataSource = purchaseItemTable;
			PurchaseGridView.Refresh();
			
			SaveInventoryItem();
			SavePurchaseItem();
			ResetForm();
		}
		
		public string CreatePONumber()
        {
            string minInvoiceNumber = ConfigurationManager.AppSettings["MinInvoice"];
            string maxInvoiceNumber = ConfigurationManager.AppSettings["MaxInvoice"];
            int minNumber = Convert.ToInt32(minInvoiceNumber);
            int maxNumber = Convert.ToInt32(maxInvoiceNumber);
            Random randomNumber = new Random();
            int invoiceNumber = randomNumber.Next(minNumber, maxNumber);
            return invoiceNumber.ToString();
        }
		
		public void SaveInventoryItem()
		{
			string productID = ProductIDTextBox.Text;
			string productDesc = ProductDescTextBox.Text;
			string purchasePrice = PriceTextBox.Text;
			string primeCategory = GetSelectedPrimeCategory();
			string secondaryCategory = GetSelectedSecCategory();
			string productStatus = "Available";
			string serialNumber = SerialNumberTextBox.Text;
			string saleDate = "1/1/1990";
			
			DataManager dataManager = new DataManager(connectionString);
			dataManager.InsertInventoryItem(productID,productDesc,purchasePrice,primeCategory,
			                                secondaryCategory,productStatus,serialNumber,saleDate);
		}
		
		public void SavePurchaseItem()
		{
			string productID = ProductIDTextBox.Text;
			string productDesc = ProductDescTextBox.Text;
			string purchasePrice = PriceTextBox.Text;
			string primeCategory = GetSelectedPrimeCategory();
			string secondaryCategory = GetSelectedSecCategory();
			string customerID = GetSelectedCustomerID();
			string purchaseDate = GetDate();
			string poNumber = "PR" + createPONumber;
			
			DataManager dataManager = new DataManager(connectionString);
			dataManager.InsertPurchaseItem(productID,productDesc,purchasePrice,primeCategory,
			                               secondaryCategory,customerID,purchaseDate,poNumber);
		}
		
		public void CreatePurchaseInvoice()
		{
			string customerID = CustomerIDTextBox.Text;
			string productID = ProductIDTextBox.Text;
			
			PurchaseInvoice purchaseInvoice = new PurchaseInvoice();
			purchaseInvoice.CustomerIDValue = customerID;
			purchaseInvoice.PONumber = createPONumber;
			purchaseInvoice.Show();
		}
		
		public void ResetForm()
		{
			CustomerIDTextBox.Text = string.Empty;
			ProductIDTextBox.Text = string.Empty;
			ProductDescTextBox.Text = string.Empty;
			PriceTextBox.Text = string.Empty;
			SerialNumberTextBox.Text = string.Empty;
		}
		
		public string GetDate()
        {
            string date = DateTime.Now.ToString("d");
            return date;
        }

        public bool CheckDataInput()
        {
            DataVerification dataCheck = new DataVerification();
            string primeCategory = GetSelectedPrimeCategory();
            string secondaryCategory = GetSelectedSecCategory();
            bool result = false;

            bool checkCustomerNum = dataCheck.IsEmpty(CustomerIDTextBox, CustomerIDTextBox.Text, ErrorProvider);
            bool checkProductId = dataCheck.IsEmpty(ProductIDTextBox, ProductIDTextBox.Text, ErrorProvider);
            bool checkProductDesc = dataCheck.IsEmpty(ProductDescTextBox, ProductDescTextBox.Text, ErrorProvider);
            bool checkPrice = dataCheck.IsEmpty(PriceTextBox, PriceTextBox.Text, ErrorProvider);
            bool checkSerialNum = dataCheck.IsEmpty(SerialNumberTextBox, SerialNumberTextBox.Text, ErrorProvider);
            bool checkPrimeCat = dataCheck.IsEmpty(PrimeCatGridView, primeCategory, ErrorProvider);
            bool checkSecCat = dataCheck.IsEmpty(SecCatGridView, secondaryCategory, ErrorProvider);

            if (checkCustomerNum || checkProductId || checkProductDesc || checkPrice ||
                checkSerialNum || checkPrimeCat || checkSecCat)
            {
                result = true;
            }
            else
            {
                ErrorProvider.Clear();
                return false;
            }
            return result;
        }
		
		#endregion
	}
}
