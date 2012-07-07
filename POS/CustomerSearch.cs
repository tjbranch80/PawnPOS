using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
    public partial class CustomerSearch : Form
    {
        #region Global Components

        string connectionString;

        public CustomerSearch()
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

        DataTable customerDataTable;
        DataTable salesHistoryTable;
        DataTable soldHistoryTable;
        DataTable pawnHistoryTable;

        #endregion

        #region Private Methods\Events

        private void CustomerSearch_Load(object sender, EventArgs e)
        {
            try
            {
                GetCustomerData();
                CheckAccountStatus();
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

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ViewHistoryButton_Click(object sender, EventArgs e)
        {
            try
            {
                GetSalesHistory();
                GetSoldData();
                GetPawnHistory();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem displaying the customer's history");
            }
        }
        
        #endregion

        #region public Methods
        
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

        public void GetSalesHistory()
        {
            DataManager dataManager = new DataManager(connectionString);
            string customerID = GetSelectedCustomer();
            salesHistoryTable = dataManager.GetSalesHistory(customerID);
            SalesHistoryGrid.DataSource = salesHistoryTable;
        }

        public string GetSelectedCustomer()
        {
            string selectedCustomerRow = Convert.ToString(CustomerGridView.SelectedRows[0].Cells[0].Value);
            return selectedCustomerRow;  
        }

        public void GetCustomerData()
        {
            DataManager dataManager = new DataManager(connectionString);
             customerDataTable = dataManager.GetCustomerInformation();
            CustomerGridView.DataSource = customerDataTable;
        }

        public void GetSoldData()
        {
            DataManager dataManager = new DataManager(connectionString);
            string customerID = GetSelectedCustomer();
            soldHistoryTable = dataManager.GetSoldHistory(customerID);
            SoldDataGrid.DataSource = soldHistoryTable;
        }

        public void GetPawnHistory()
        {
            DataManager dataManager = new DataManager(connectionString);
            string customerID = GetSelectedCustomer();
            pawnHistoryTable = dataManager.GetPawnHistory(customerID);
            pawnHistoryGrid.DataSource = pawnHistoryTable;
        }
        
        #endregion
    }
}
