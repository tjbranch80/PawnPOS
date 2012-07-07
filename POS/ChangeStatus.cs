
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{

	public partial class ChangeStatus : Form
	{
		#region Global Components

        string connectionString;

        public ChangeStatus()
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
        
        #endregion
		
        #region Private Methods\Events
         
		private void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void ChangeStatusLoad(object sender, EventArgs e)
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
		
		private void MakeInactiveButtonClick(object sender, EventArgs e)
		{
            try
            {
                MakeAccountInactive();
                GetCustomerData();
                CheckAccountStatus();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem making this account inactive");
            }
		}
		
		private void MakeActiveButtonClick(object sender, EventArgs e)
		{
            try
            {
                MakeAccountActive();
                GetCustomerData();
                CheckAccountStatus();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem making this account active");
            }
		}
		
		#endregion
		
		#region public Methods
		
		public void GetCustomerData()
        {
            DataManager dataManager = new DataManager(connectionString);
            customerDataTable = dataManager.ChangeAccountStatusInformation();
            StatusGridView.DataSource = customerDataTable;
        }
		
		public void CheckAccountStatus()
        {
        	for(int i = 0; i < StatusGridView.Rows.Count; i++)
        	{
        		string status = StatusGridView.Rows[i].Cells[3].Value.ToString();
        		
        		if(status == "NotActive")
        		{
        			for(int x = 0; x < StatusGridView.Rows[i].Cells.Count; x++)
        			{
        				StatusGridView.Rows[i].Cells[x].Style.BackColor = Color.Red;
        			}
        			
        		}
        	}
        }
		
		public string GetSelectedCustomer()
        {
            string selectedCustomerRow = Convert.ToString(StatusGridView.SelectedRows[0].Cells[0].Value);
            return selectedCustomerRow;  
        }
		
		public void MakeAccountInactive()
		{
			DataManager dataManager = new DataManager(connectionString);
			string customerID = GetSelectedCustomer();
            if (customerID != string.Empty)
            {
                dataManager.UpdateToInactiveStatus(customerID);
            }
            else
            {
                MessageBox.Show("No customer has been selected");
            }
		}
		
		public void MakeAccountActive()
		{
			DataManager dataManager = new DataManager(connectionString);
			string customerID = GetSelectedCustomer();
            if (customerID != string.Empty)
            {
                dataManager.UpdateToActiveStatus(customerID);
            }
            else
            {
                MessageBox.Show("No customer has been selected");
            }

		}
		
		#endregion
	}
}
