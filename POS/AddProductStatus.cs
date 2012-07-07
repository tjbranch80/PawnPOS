
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{

	public partial class AddProductStatus : Form
	{
		#region Global Components

        string connectionString;
		
		public AddProductStatus()
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
		
		private void AddButtonClick(object sender, EventArgs e)
		{
			AddNewStatus();
		}
		
		private void CancelAddButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		#endregion
		
		#region Public Methods
		
		public void AddNewStatus()
		{
			DataManager dataManager = new DataManager(connectionString);
			string newStatus = GetNewStatus();
			
			if(newStatus != string.Empty)
			{
				dataManager.InsertProductStatus(newStatus);
				MessageBox.Show(string.Format("You Have Just Added: {0}",newStatus));
				this.Close();
			}
		}
		
		public string GetNewStatus()
		{
			string newStatus = string.Empty;
			if(StatusTextBox.Text == string.Empty)
			{
				MessageBox.Show("Please Enter A New Status");
			}
			
			if(StatusTextBox.Text != string.Empty)
			{
				newStatus = StatusTextBox.Text;
			}
			return newStatus;
		}
		
		#endregion
		
		
	}
}
