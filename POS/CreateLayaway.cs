using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class CreateLayaway : Form
    {
        #region Global Components

        string connectionString;
        
        public CreateLayaway()
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

        DataTable customerInfoTable = new DataTable();
        DataTable inventoryTable = new DataTable();
        string pONumber;

        #endregion

        #region Private Methods

        private void CreateLayaway_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomerData();
                CheckAccountStatus();
                GetAllInventory();
                pONumber = "L" + CreatePONumber();
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
                bindingSource.DataSource = customerInfoTable;
                bindingSource.Filter = string.Format("LastName LIKE '%{0}%'", FilterTextBox.Text.Trim().Replace("'", "''"));
                CustomerGridView.DataSource = bindingSource;
            }
        }

        private void ProductFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            BindingSource bindingSource = new BindingSource();
            if (ProductFilterTextBox.TextLength > 0)
            {
                bindingSource.DataSource = inventoryTable;
                bindingSource.Filter = string.Format("ProductDescription LIKE '%{0}%'", ProductFilterTextBox.Text.Trim().Replace("'", "''"));
                InventoryGridView.DataSource = bindingSource;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            string status = GetAccountStatus();

            if (CustomerIDTextBox.Text == String.Empty && status != "NotActive")
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

        private void RemoveCustomerButton_Click(object sender, EventArgs e)
        {
            CustomerIDTextBox.Text = string.Empty;
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            string selectedProductID = GetSelectedProductID();
            ProductsGridView.Rows.Add(selectedProductID);
        }

        private void RemoveProductButton_Click(object sender, EventArgs e)
        {
            var selectedRow = ProductsGridView.SelectedRows;
            ProductsGridView.Rows.Remove(selectedRow[0]);
        }

        private void CloseLayawayButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TotalButton_Click(object sender, EventArgs e)
        {
            try
            {
                double totalSalesPrice = AddSalesPrice();
                double downPayment = GetDownPayment();
                double salesTax = AddSalesTax();
                double salesTaxAmount = Math.Round(totalSalesPrice / salesTax, 2);
                double todayTotal = downPayment + salesTaxAmount;
                double stillOwed = totalSalesPrice - downPayment;
                DownPaymentLabel.Text = downPayment.ToString();
                TotalLabel.Text = totalSalesPrice.ToString();
                SalesTaxLabel.Text = salesTaxAmount.ToString();
                TotalLabel.Text = todayTotal.ToString();
                StillOwedLabel.Text = stillOwed.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem calculating the total");
            }
        }

        private void LayawyReceiptButton_Click(object sender, EventArgs e)
        {
            CreateLayawayTransaction();
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
            for (int i = 0; i < CustomerGridView.Rows.Count; i++)
            {
                string status = CustomerGridView.Rows[i].Cells[12].Value.ToString();

                if (status == "NotActive")
                {
                    for (int x = 0; x < CustomerGridView.Rows[i].Cells.Count; x++)
                    {
                        CustomerGridView.Rows[i].Cells[x].Style.BackColor = Color.Red;
                    }

                }
            }
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

        public void GetAllInventory()
        {
            DataManager dataManager = new DataManager(connectionString);
            inventoryTable = dataManager.GetAllInventory();
            InventoryGridView.DataSource = inventoryTable;
        }

        public string GetSelectedProductID()
        {
            string selectedProductRow = Convert.ToString(InventoryGridView.SelectedRows[0].Cells[0].Value);
            return selectedProductRow;
        }

        public double AddSalesPrice()
        {
            double totalSalePrice = 0;
            for (int i = 0; i < ProductsGridView.Rows.Count; i++)
            {
                totalSalePrice += Convert.ToDouble(ProductsGridView.Rows[i].Cells[1].Value);
            }
            return totalSalePrice;
        }

        public double GetDownPayment()
        {
            double salesTotal = AddSalesPrice();
            double downPayment = salesTotal * .20;
            return downPayment;
        }

        public double AddSalesTax()
        {
            string salesTaxSetting = ConfigurationManager.AppSettings["SalesTax"];
            double salesTax = Convert.ToDouble(salesTaxSetting);
            return salesTax;
        }

        public string GetLayawayDate()
        {
            string saleDate = DateTime.Now.ToString("d");
            return saleDate;
        }

        public Dictionary<int, double> GetSalesInformation()
        {
            int productID;
            double salePrice;
            Dictionary<int, double> products = new Dictionary<int, double>();
            for (int i = 0; i < ProductsGridView.Rows.Count; i++)
            {
                productID = Convert.ToInt32(ProductsGridView.Rows[i].Cells[0].Value);
                salePrice = Convert.ToDouble(ProductsGridView.Rows[i].Cells[1].Value);
                if (productID > 0)
                {
                    products.Add(productID, salePrice);
                }
            }
            return products;
        }

        public void CreateLayawayTransaction()
        {
            if (!CheckData())
            {
                string productID = GetSelectedProductID();
                double downPayment = Convert.ToDouble(DownPaymentLabel.Text);
                double salesTax = Convert.ToDouble(SalesTaxLabel.Text);
                double owed = Convert.ToDouble(StillOwedLabel.Text);
                double principal = owed + salesTax + downPayment;
                double totalSale = downPayment + owed;
                DataManager dataManager = new DataManager(connectionString);

                string invoiceNumber = pONumber;
                string customerID = CustomerIDTextBox.Text;
                
                string principalAmount = principal.ToString();
                string owedAmount = StillOwedLabel.Text;
                string layawayDate = GetLayawayDate();
                string status = "Open";
                string dateDefaulted = DateTime.MinValue.ToShortDateString();
                string defaultDate = DateTime.Today.AddDays(90).ToShortDateString();

                Dictionary<int, double> products = GetSalesInformation();
                
                foreach (KeyValuePair<int, double> pair in products)
                {
                    string productDescription = dataManager.GetProductDescription(pair.Key.ToString());
                    
                    dataManager.InsertLayaway(invoiceNumber, customerID, productDescription, principalAmount,
                     owedAmount, layawayDate, status, dateDefaulted, defaultDate);

                    dataManager.SaveInvoiceData(invoiceNumber, totalSale.ToString(), salesTax.ToString(),
                    layawayDate, customerID, principal.ToString());

                    dataManager.UpdateStatusLayaway(pair.Key.ToString());
                }

                LayawayReceipt layawayReceipt = new LayawayReceipt();
                layawayReceipt.InvoiceNumberValue = invoiceNumber;
                layawayReceipt.ProductData = products;
                layawayReceipt.CustomerIDValue = customerID;
                layawayReceipt.TotalSale = totalSale.ToString();
                layawayReceipt.SalesTax = salesTax.ToString();
                layawayReceipt.GrandTotal = principalAmount;
                layawayReceipt.SaleDate = layawayDate;
                layawayReceipt.Show();
            }
            else
            {
                MessageBox.Show("Either the customer ID is blank, you did not select a product, or there is no total");
            }
        }

        public bool CheckData()
        {
            string customerId = CustomerIDTextBox.Text;
            int productId = Convert.ToInt32(ProductsGridView.Rows[0].Cells[0].Value);
            string owed = StillOwedLabel.Text;

            if (customerId == string.Empty)
            {
                return true;
            }
            else if (productId <= 0)
            {
                return true;
            }
            else if (owed == string.Empty)
            {
                return true;
            }
            return false;
        }

        #endregion
    }
}
