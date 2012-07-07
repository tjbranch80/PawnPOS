
using System;
using System.Drawing;
using System.Windows.Forms;

namespace POS
{
	
	public partial class Maintenance : Form
	{
		public Maintenance()
		{
			
			InitializeComponent();
			CenterToScreen();
		}
		
		#region Private Methods\Events
		
		private void CloseButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		private void AddProdStatusButtonClick(object sender, EventArgs e)
		{
            AddProductStatus addStatus = null;
            if (addStatus != null)
            {
                addStatus.Activate();
            }
            else
            {
                addStatus = new AddProductStatus();
                addStatus.Show();
            }
		}
		
		private void AddPrimeCatButtonClick(object sender, EventArgs e)
		{
            AddPrimeCategory addPriceCat = null;
            if (addPriceCat != null)
            {
                addPriceCat.Activate();
            }
            else
            {
                addPriceCat = new AddPrimeCategory();
                addPriceCat.Show();
            }
		}
		
		private void AddSecondCatButtonClick(object sender, EventArgs e)
		{
            AddSecondaryCategory addSecCat = null;
            if (addSecCat != null)
            {
                addSecCat.Activate();
            }
            else
            {
                addSecCat = new AddSecondaryCategory();
                addSecCat.Show();
            }
		}
		
		#endregion
	}
}
