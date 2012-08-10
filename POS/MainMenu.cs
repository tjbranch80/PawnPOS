using System;
using System.Net;
using System.Windows.Forms;

namespace POS
{
    public partial class MainMenu : Form
    {
        #region Global Components

        public MainMenu()
        {
            InitializeComponent();
            CenterToScreen();
        }

        #endregion

        #region Private Methods\Events

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CreateNewCustomer createCustomer = null;
            if (createCustomer != null)
            {
                createCustomer.Activate();
            }
            else
            {
                createCustomer = new CreateNewCustomer();
                createCustomer.Show();  
            }
        }

        private void CustomerSearchButton_Click(object sender, EventArgs e)
        {
            CustomerSearch customerSearch = null;
            if (customerSearch != null)
            {
                customerSearch.Activate();
            }
            else
            {
                customerSearch = new CustomerSearch();
                customerSearch.Show();
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CreateSaleButton_Click(object sender, EventArgs e)
        {
            Sales sales = null;
            if (sales != null)
            {
                sales.Activate();
            }
            else
            {
                sales = new Sales();
                sales.Show();
            }
        }
        
        private void AccessStatusButtonClick(object sender, EventArgs e)
        {
            ChangeStatus changeStatus = null;
            if (changeStatus != null)
            {
                changeStatus.Activate();
            }
            else
            {
                changeStatus = new ChangeStatus();
                changeStatus.Show();
            }
        }
        
        private void ReprintButtonClick(object sender, EventArgs e)
        {
            ReprintInvoice reprint = null;
            if (reprint != null)
            {
                reprint.Activate();
            }
            else
            {
                reprint = new ReprintInvoice();
                reprint.Show();
            }
        }
        
        private void MaintButtonClick(object sender, EventArgs e)
        {
            Maintenance maint = null;
            if (maint != null)
            {
                maint.Activate();
            }
            else
            {
                maint = new Maintenance();
                maint.Show();
            }
        }
        
        private void InventoryButtonClick(object sender, EventArgs e)
        {
            AddInventory addInventory = null;
            if (addInventory != null)
            {
                addInventory.Activate();
            }
            else
            {
                addInventory = new AddInventory();
                addInventory.Show();
            }
        }
        
        private void PurchaseButtonClick(object sender, EventArgs e)
        {
            PurchaseItem purchase = null;
            if (purchase != null)
            {
                purchase.Activate();
            }
            else
            {
                purchase = new PurchaseItem();
                purchase.Show();
            }
        }
        
        private void PawnButtonClick(object sender, EventArgs e)
        {
            PawnItem pawn = null;
            if (pawn != null)
            {
                pawn.Activate();
            }
            else
            {
                pawn = new PawnItem();
                pawn.Show();
            }
        }

        private void ToolDefaultPawnReport_Click(object sender, EventArgs e)
        {
            DefaultPawnReport defaultPawnReport = null;
            if (defaultPawnReport != null)
            {
                defaultPawnReport.Activate();
            }
            else
            {
                defaultPawnReport = new DefaultPawnReport();
                defaultPawnReport.Show();
            }
        }

        private void PawnPaymentButton_Click(object sender, EventArgs e)
        {
            PawnPayment pawnPayment = null;
            if (pawnPayment != null)
            {
                pawnPayment.Activate();
            }
            else
            {
                pawnPayment = new PawnPayment();
                pawnPayment.Show();
            }
        }

        private void CreateLayawayButton_Click(object sender, EventArgs e)
        {
            CreateLayaway layaway = null;
            if (layaway != null)
            {
                layaway.Activate();
            }
            else
            {
                layaway = new CreateLayaway();
                layaway.Show();
            }
        }

        private void LayawayPaymentButton_Click(object sender, EventArgs e)
        {
            LayawayPayment layawayPayment = null;
            if (layawayPayment != null)
            {
                layawayPayment.Activate();
            }
            else
            {
                layawayPayment = new LayawayPayment();
                layawayPayment.Show();
            }
        }

        private void CheckForUpdatesButton_Click(object sender, EventArgs e)
        {
            UpdateCheck updateCheck = null;
            if (updateCheck != null)
            {
                updateCheck.Activate();
            }
            else
            {
                updateCheck = new UpdateCheck();
                updateCheck.Show();
            } 
        }

        private void BackUpDatabaseButton_Click(object sender, EventArgs e)
        {
            DataBackUp dataBackUp = null;
            if (dataBackUp != null)
            {
                dataBackUp.Activate();
            }
            else
            {
                dataBackUp = new DataBackUp();
                dataBackUp.Show();
            }
        }

        #endregion
    }
}
