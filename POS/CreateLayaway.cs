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
        string createPONumber;

        #endregion

        #region Private Methods

        private void CreateLayaway_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomerData();
                CheckAccountStatus();
                GetAllInventory();
                createPONumber = "L" + CreatePONumber();
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

        #endregion

        

        

        

        

        

    }
}
