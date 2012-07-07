
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	using System;
	public partial class AddPrimeCategory : Form
	{
		#region Global Components

        string connectionString;
		
		public AddPrimeCategory()
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
		
		private void CancelAddButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void AddCatButtonClick(object sender, EventArgs e)
		{
			AddNewPrimeCat();
		}
		
		#endregion
		
		#region Public Methods
		
		public string GetNewPrimeCat()
		{
			string newPrimeCat = string.Empty;
			if(PrimeCatTextBox.Text == string.Empty)
			{
				MessageBox.Show("Please Enter A New Prime Category");
			}
			
			if(PrimeCatTextBox.Text != string.Empty)
			{
				newPrimeCat = PrimeCatTextBox.Text;
			}
			return newPrimeCat;
		}
		
		public void AddNewPrimeCat()
		{
			DataManager dataManager = new DataManager(connectionString);
			string newPrimeCat = GetNewPrimeCat();
			
			if(newPrimeCat != string.Empty)
			{
				dataManager.InsertPrimeCategory(newPrimeCat);
				MessageBox.Show(string.Format("You Have Just Added: {0}",newPrimeCat));
				this.Close();
			}
		}
		
		
		
		
		
		
		#endregion
	}
}
