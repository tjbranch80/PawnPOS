
using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	
	public partial class AddSecondaryCategory : Form
	{
		#region Global Components

        string connectionString;
        DataTable primeCatTable = new DataTable();
		
		public AddSecondaryCategory()
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
		
		private void AddSecondaryCategoryLoad(object sender, EventArgs e)
		{
			LoadPrimaryDataGrid();
		}
		
		private void CancelAddButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void AddCatButtonClick(object sender, EventArgs e)
		{
			AddNewSecondaryCategory();
		}
		
		#endregion
		
		#region Public Methods
		
		public void LoadPrimaryDataGrid()
		{
			DataManager dataManager = new DataManager(connectionString);
			primeCatTable = dataManager.GetPrimaryCategories();
			PrimeCatGridView.DataSource = primeCatTable;
		}
		
		public string GetNewSecCat()
		{
			string newSecCat = string.Empty;
			if(SecondaryTextBox.Text == string.Empty)
			{
				MessageBox.Show("Please Enter A New Secondary Category");
			}
			
			if(SecondaryTextBox.Text != string.Empty)
			{
				newSecCat = SecondaryTextBox.Text;
			}
			return newSecCat;
		}
		
		public string GetSelectedPrimeCat()
		{
			string selectedPrimeCat = string.Empty;
			selectedPrimeCat = Convert.ToString(PrimeCatGridView.SelectedRows[0].Cells[0].Value);
			return selectedPrimeCat;
		}
		
		public void AddNewSecondaryCategory()
		{
			DataManager dataManager = new DataManager(connectionString);
			string newSecCat = GetNewSecCat();
			string selectedPrimeCat = GetSelectedPrimeCat();
			
			if(newSecCat != string.Empty && selectedPrimeCat != string.Empty)
			{
				dataManager.InsertSecondaryCategory(newSecCat,selectedPrimeCat);
				MessageBox.Show(string.Format("You Have Just Added: {0}",newSecCat));
				this.Close();
			}
		}
		
		#endregion	
	}
}