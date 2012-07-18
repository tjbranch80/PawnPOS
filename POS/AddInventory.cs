
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	
	public partial class AddInventory : Form
	{
		#region Global Components

        string connectionString;
        DataTable PrimeCatTable = new DataTable();
        DataTable SecCatTable = new DataTable();
		
		public AddInventory()
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
		
		#endregion
		
		#region Private Methods\Events
		
		private void CancelInvButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void SaveInvButtonClick(object sender, EventArgs e)
		{
            bool checkTextBoxes = CheckDataInput();

            if (!checkTextBoxes)
            {
                try
                {
                    SaveInventoryItem();
                    ShowSuccessMessage();
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex));
                }
            }
		}
		
		private void AddInventoryLoad(object sender, EventArgs e)
		{
			GetPrimeCategories();
			GetSecondaryCategories();
		}
		
		#endregion
		
		#region Public Methods
		
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
		
		public void SaveInventoryItem()
		{
			string productID = ProductIDTextBox.Text;
			string productDesc = ProductDescTextBox.Text;
			string purchasePrice = PriceTextBox.Text;
			string primeCategory = GetSelectedPrimeCategory();
			string secondaryCategory = GetSelectedSecCategory();
			string productStatus = "Available";
			string serialNumber = SerialNumTextBox.Text;
			string saleDate = "1/1/1990";
			
			DataManager dataManager = new DataManager(connectionString);
			dataManager.InsertInventoryItem(productID,productDesc,purchasePrice,primeCategory,
			                                secondaryCategory,productStatus,serialNumber,saleDate);
		}
		
		public void ResetForm()
		{
			ProductIDTextBox.Text = string.Empty;
			ProductDescTextBox.Text = string.Empty;
			PriceTextBox.Text = string.Empty;
			SerialNumTextBox.Text = string.Empty;
		}
		
		public void ShowSuccessMessage()
		{
			string productDesc = ProductDescTextBox.Text;
			MessageBox.Show(string.Format("You Have Successfully Added: {0}",productDesc));
		}

        public bool CheckDataInput()
        {
            DataVerification dataCheck = new DataVerification();
            string primeCategory = GetSelectedPrimeCategory();
            string secondaryCategory = GetSelectedSecCategory();
            bool result = false;
            
            bool checkProductId = dataCheck.IsEmpty(ProductIDTextBox, ProductIDTextBox.Text, ErrorProvider);
            bool checkProductDesc = dataCheck.IsEmpty(ProductDescTextBox, ProductDescTextBox.Text, ErrorProvider);
            bool checkPrice = dataCheck.IsEmpty(PriceTextBox, PriceTextBox.Text, ErrorProvider);
            bool checkSerialNum = dataCheck.IsEmpty(SerialNumTextBox, SerialNumTextBox.Text, ErrorProvider);
            bool checkPrimeCat = dataCheck.IsEmpty(PrimeCatGridView, primeCategory, ErrorProvider);
            bool checkSecCat = dataCheck.IsEmpty(SecCatGridView, secondaryCategory, ErrorProvider);

            if (checkProductId || checkProductDesc || checkPrice || checkSerialNum || checkPrimeCat
                || checkSecCat)
            {
                result = true;
            }
            else
            {
                ErrorProvider.Clear();
                result = false;
            }
            return result;
        }

		#endregion
	}
}
