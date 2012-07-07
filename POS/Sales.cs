using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class Sales : Form
    {
        #region Global Components

        string connectionString;
        
        public Sales()
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

        DataTable customerDataTable = new DataTable();
        DataTable allInventoryTable = new DataTable();

        #endregion

        #region Private Methods\Events

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Sales_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomerData();
                CheckAccountStatus();
                GetAllInventory();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem loading the data");
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            if (FilterTextBox.TextLength > 0)
            {
                bindingSource.DataSource = customerDataTable;
                bindingSource.Filter = string.Format("LastName LIKE '%{0}%'", FilterTextBox.Text.Trim().Replace("'", "''"));
                CustomerGridView.DataSource = bindingSource;
            }
        }

        private void AddCustomerIDButton_Click(object sender, EventArgs e)
        {
        	string status = GetAccountStatus();
        	
        	if(CustomerIDTextBox.Text == String.Empty && status != "NotActive")
        	{
        		string customerID = GetSelectedCustomerID();
            	CustomerIDTextBox.Text = customerID;
        	}else if (status == "NotActive") 
        	{ 
        		MessageBox.Show("Account Is Not Active");
        	} else if (CustomerIDTextBox.Text != String.Empty) 
        	{
        		MessageBox.Show("You Can Only Add One Customer");
        	}
        }

        private void RemoveCustomerIDButton_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = string.Empty;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string selectedProductID = GetSelectedProductID();
            ProductAddedGridView.Rows.Add(selectedProductID);
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            var selectedRow = ProductAddedGridView.SelectedRows;
            ProductAddedGridView.Rows.Remove(selectedRow[0]);
        }

        private void CreateSaleButton_Click(object sender, EventArgs e)
        {
            try
            {
                CreateSalesTransaction();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}", ex));
            }
        }

        private void TotalSalesButton_Click(object sender, EventArgs e)
        {
            try
            {
                double totalSalesPrice = AddSalesPrice();
                double salesTax = AddSalesTax();
                double salesTaxAmount = Math.Round(totalSalesPrice / salesTax, 2);
                double grandTotal = totalSalesPrice + salesTaxAmount;
                TotalLabel.Text = totalSalesPrice.ToString();
                TaxLabel.Text = salesTaxAmount.ToString();
                GrandTotalLabel.Text = grandTotal.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem calculating the total");
            }
        }

        private void PrimCatFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            if (PrimCatFilterTextBox.TextLength > 0)
            {
                bindingSource.DataSource = allInventoryTable;
                bindingSource.Filter = string.Format("PrimaryCategory LIKE '%{0}%'", PrimCatFilterTextBox.Text.Trim().Replace("'", "''"));
                ProductsGridView.DataSource = bindingSource;
            }
        }

        #endregion

        #region Public Methods

        public void GetCustomerData()
        {
            DataManager dataManager = new DataManager(connectionString);
            customerDataTable = dataManager.GetCustomerInformation();
            CustomerGridView.DataSource = customerDataTable;
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

        public void GetAllInventory()
        {
            DataManager dataManager = new DataManager(connectionString);
            allInventoryTable = dataManager.GetAllInventory();
            ProductsGridView.DataSource = allInventoryTable;
        }

        public string GetSelectedProductID()
        {
            string selectedProductRow = Convert.ToString(ProductsGridView.SelectedRows[0].Cells[0].Value);
            return selectedProductRow;
        }

        public string CreateInvoiceNumber()
        {
            string minInvoiceNumber = ConfigurationManager.AppSettings["MinInvoice"];
            string maxInvoiceNumber = ConfigurationManager.AppSettings["MaxInvoice"];
            int minNumber = Convert.ToInt32(minInvoiceNumber);
            int maxNumber = Convert.ToInt32(maxInvoiceNumber);
            Random randomNumber = new Random();
            int invoiceNumber = randomNumber.Next(minNumber, maxNumber);
            return invoiceNumber.ToString();
        }

        public double AddSalesPrice()
        {
            double totalSalePrice = 0;
            for (int i = 0; i < ProductAddedGridView.Rows.Count; i++)
            {
                totalSalePrice += Convert.ToDouble(ProductAddedGridView.Rows[i].Cells[1].Value);
            }
            return totalSalePrice;
        }

        public Dictionary<int, double> GetSalesInformation()
        {
            int productID;
            double salePrice;
            Dictionary<int, double> soldProducts = new Dictionary<int, double>();
            for (int i = 0; i < ProductAddedGridView.Rows.Count; i++)
            {
                    productID = Convert.ToInt32(ProductAddedGridView.Rows[i].Cells[0].Value);
                    salePrice = Convert.ToDouble(ProductAddedGridView.Rows[i].Cells[1].Value);
                    if (productID > 0)
                    {
                        soldProducts.Add(productID, salePrice);
                    }
            }
            return soldProducts;
        }

        public double AddSalesTax()
        {
            string salesTaxSetting = ConfigurationManager.AppSettings["SalesTax"];
            double salesTax = Convert.ToDouble(salesTaxSetting);
            return salesTax;
        }

        public string GetSalesDate()
        {
            string saleDate = DateTime.Now.ToString("d");
            return saleDate;
        }

        public void CreateSalesTransaction()
        {
            if (!CheckData())
            {
                string customerID = CustomerIDTextBox.Text;
                string saleDate = GetSalesDate();
                string invoiceNumber = CreateInvoiceNumber();
                Dictionary<int, double> soldProducts = GetSalesInformation();
                DataManager dataManager = new DataManager(connectionString);
                foreach (KeyValuePair<int, double> pair in soldProducts)
                {
                    dataManager.SaveSaleData(customerID, pair.Key.ToString(), pair.Value.ToString(), saleDate, invoiceNumber);
                    dataManager.UpdateProductStatus(pair.Key.ToString(), saleDate);
                }

                string totalSale = TotalLabel.Text;
                string salesTax = TaxLabel.Text;
                string grandTotal = GrandTotalLabel.Text;
                dataManager.SaveInvoiceData(invoiceNumber, totalSale, salesTax, saleDate, customerID, grandTotal);
                SalesInvoice salesInvoice = new SalesInvoice();
                salesInvoice.InvoiceNumberValue = invoiceNumber;
                salesInvoice.CustomerIDValue = customerID;
                salesInvoice.InvoiceDollarValue = invoiceNumber;
                salesInvoice.Show();
            }
            else
            {
                MessageBox.Show("Either the customer ID is blank, you did not select a product, or there is no total");
            }
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

        public bool CheckData()
        {
            string customerId = CustomerIDTextBox.Text;
            int  productId = Convert.ToInt32(ProductAddedGridView.Rows[0].Cells[0].Value);
            string grandTotal = GrandTotalLabel.Text;

            if (customerId == string.Empty)
            {
                return true;
            }
            else if (productId <=0)
            {
                return true;
            }
            else if (grandTotal == string.Empty)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}

