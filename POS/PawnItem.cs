
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{

	public partial class PawnItem : Form
	{
		#region Global Components

        string connectionString;
		
		public PawnItem()
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
		
		string createPONumber;
		DataTable customerInfoTable = new DataTable();
		
		#endregion
		
		#region Private Methods\Events
		
		private void PawnItemLoad(object sender, EventArgs e)
		{
            try
            {
                GetCustomerData();
                CheckAccountStatus();
                GetFinanceCharge();
                createPONumber = "L" + CreatePONumber();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem loading the data");
            }
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
		
		private void AddCustomerIDButtonClick(object sender, EventArgs e)
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
		
		private void RemoveCustomerIDButtonClick(object sender, EventArgs e)
		{
			CustomerIDTextBox.Text = string.Empty;
		}
		
		private void TotalCalcButtonClick(object sender, EventArgs e)
		{
            try
            {
                double financeCharge = CreateFinanceCharge();
                double principalAmount = Convert.ToDouble(PrincipalTextBox.Text);
                double totalAmount = principalAmount + financeCharge;
                ChargeLabel.Text = "$" + financeCharge.ToString();
                TotalOwedLabel.Text = "$" + totalAmount.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem getting the total");
            }
		}
		
		private void CreatePawnButtonClick(object sender, EventArgs e)
		{
            bool checkTextBoxes = CheckDataInput();

            if (!checkTextBoxes)
            {
                try
                {
                    CreatePawn();
                    CreatePawnReceipt();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex));
                }
            }
		}

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
		
		public string GetAccountStatus()
        {
        	string selectedCustomerStatus = Convert.ToString(CustomerGridView.SelectedRows[0].Cells[12].Value);
        	return selectedCustomerStatus;
        }
		
		public string GetSelectedCustomerID()
        {
            string selectedCustomerRow = Convert.ToString(CustomerGridView.SelectedRows[0].Cells[0].Value);
            return selectedCustomerRow;
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
		
		public string GetFinanceCharge()
		{
			string financeChargePercent = ConfigurationManager.AppSettings["FinanceCharge"];
			return financeChargePercent;
		}
		
		public double CreateFinanceCharge()
		{
			double principalAmount = Convert.ToDouble(PrincipalTextBox.Text);
			double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
			double financeCharge = principalAmount * financeChargePercent;
			return financeCharge;
		}
		
		public string GetDate()
        {
            string date = DateTime.Now.ToString("d");
            return date;
        }
		
		public string GetDefaultDate()
		{
			string defaultDate = DateTime.Today.AddDays(90).ToShortDateString();
			return defaultDate;
		}
		
		public void CreatePawn()
		{
			double financeCharge = CreateFinanceCharge();
			double principal = Convert.ToDouble(PrincipalTextBox.Text);
			double totalAmount = principal + financeCharge;
			
			string transactionID = createPONumber;
			string customerID = GetSelectedCustomerID();
			string productDesc = ProductDescTextBox.Text;
			string principalAmount = totalAmount.ToString();
			string pawnDate = GetDate();
			string status = "Open";
			string defaultedDate = "1/1/1900";
			
			DataManager dataManager = new DataManager(connectionString);
			dataManager.InsertPawn(transactionID,customerID,productDesc,principalAmount,
			                       pawnDate,status,defaultedDate);
		}
		
        public bool CheckDataInput()
        {
            DataVerification dataCheck = new DataVerification();

            var checkCustomerNum = dataCheck.IsEmpty(CustomerIDTextBox, CustomerIDTextBox.Text, ErrorProvider);
            var checkProductDesc = dataCheck.IsEmpty(ProductDescTextBox, ProductDescTextBox.Text, ErrorProvider);
            var checkPrice = dataCheck.IsEmpty(PrincipalTextBox, PrincipalTextBox.Text, ErrorProvider);

            if (!checkCustomerNum || !checkProductDesc || !checkPrice)
            {
                ErrorProvider.Clear();
                return false;
            }
            return true;
        }
		
		public void ResetForm()
		{
			CustomerIDTextBox.Text = string.Empty;
			ProductDescTextBox.Text = string.Empty;
			PrincipalTextBox.Text = string.Empty;
			createPONumber = string.Empty;
			ChargeLabel.Text = string.Empty;
			TotalOwedLabel.Text = string.Empty;
			FilterTextBox.Text = string.Empty;
			CustomerGridView.DataSource = customerInfoTable;
			createPONumber = "L" + CreatePONumber();
		}

        public void CreatePawnReceipt()
        {
            string customerId = CustomerIDTextBox.Text;
            string transactionId = createPONumber;

            PawnReceipt pawnReceipt = new PawnReceipt();
            pawnReceipt.CustomerIDValue = customerId;
            pawnReceipt.TransactionNumber = transactionId;
            pawnReceipt.Show();
        }
		
		#endregion
	}
}
