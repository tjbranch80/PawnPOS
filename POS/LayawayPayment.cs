using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class LayawayPayment : Form
    {
        #region Global Components

        string connectionString;

        public LayawayPayment()
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

        DataTable layawayInfoTable = new DataTable();
        DataTable layawayPaymentTable = new DataTable();
        double principal;
        double currentPrincipal;
        double newPrincipal;

        #endregion

        #region Private Methods

        private void LayawayPayment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadLayawayTransactionData();
            }
            catch (Exception)
            {
                MessageBox.Show("Could not load transaction details");
            }
        }

        private void AddTransIDButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddSelectedTransactionID();
                GetTransactionDetails();
                GetLayawayPaymentData();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem adding the transaction Or The Transaction Is Closed.");
            }
        }

        private void CreatePaymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (PaymentTextBox.Text == "")
                {
                    MessageBox.Show("Please Enter a Valid Payment Amount");
                }
                else
                {
                    AddPaymentToTransaction();
                    MessageBox.Show("Payment Was Added Successfully");
                    UpdateLayawayStatus();
                    UpdateSaleDate();
                    CreateLayawayPaymentReceipt();
                    ResetForm();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem adding the payment");
            }
        }

        private void RemoveTransIDButton_Click(object sender, EventArgs e)
        {
            if (TransIDTextBox.Text != string.Empty)
            {
                TransIDTextBox.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("There is no transaction to remove");
            }
        }

        private void PaymentExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void LoadLayawayTransactionData()
        {
            DataManager dataManager = new DataManager(connectionString);
            layawayInfoTable = dataManager.GetLayawayTransactions();

            LayawayDataGrid.DataSource = layawayInfoTable;
        }

        public string GetTransactionID()
        {
            string selectedPawnRow = "";
            if (LayawayDataGrid.SelectedRows.Count > 0)
            {
                selectedPawnRow = Convert.ToString(LayawayDataGrid.SelectedRows[0].Cells[0].Value);
            }
            return selectedPawnRow;
        }

        public void AddSelectedTransactionID()
        {
            if (TransIDTextBox.Text == String.Empty)
            {
                string transactionID = GetTransactionID();
                TransIDTextBox.Text = transactionID;
            }
            else if (TransIDTextBox.Text != String.Empty)
            {
                MessageBox.Show("You Can Only Add One Customer");
            }
        }

        public double GetCurrentPrincipal()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            double currentPrincipal = dataManager.GetCurrentLayawayPrincipal(transactionID);
            return currentPrincipal;
        }

        public void GetTransactionDetails()
        {
            string transactionID = TransIDTextBox.Text;
            DataTable layawayDetailTable = new DataTable();
            DataManager dataManager = new DataManager(connectionString);
            layawayDetailTable = dataManager.GetLayawayDetails(transactionID);

            string productDesc = layawayDetailTable.Rows[0]["ProductDescription"].ToString();
            ProdDescLabel.Text = productDesc;

            string status = layawayDetailTable.Rows[0]["Status"].ToString();
            LayawayStatusLabel.Text = status;

            string layawayDate = Convert.ToDateTime(layawayDetailTable.Rows[0]["LayawayDate"]).ToShortDateString();
            LayawayDateLabel.Text = layawayDate;

            principal = Convert.ToDouble(layawayDetailTable.Rows[0]["PrincipalAmount"]);
            string principalAmount = string.Format("{0:C}", principal);
            PrincipalAmountLabel.Text = principalAmount;

            currentPrincipal = GetCurrentPrincipal();
            if (currentPrincipal > 0)
            {
                CurrentPrincipalLabel.Text = principalAmount;
            }
            else
            {
                string newPrincipal = string.Format("{0:C}", currentPrincipal);
                CurrentPrincipalLabel.Text = newPrincipal;
            }
        }

        public void GetLayawayPaymentData()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            layawayPaymentTable = dataManager.GetLayawayPaymentHistory(transactionID);
            PaymentHistoryDataGrid.DataSource = layawayPaymentTable;
        }

        public void AddPaymentToTransaction()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            string paymentDate = DateTime.Today.ToShortDateString();
            double paymentAmount = Convert.ToDouble(PaymentTextBox.Text);
            
            if (currentPrincipal == 0)
            {
                newPrincipal = principal - paymentAmount;
            }
            else
            {
                newPrincipal = currentPrincipal - paymentAmount;
            }

            dataManager.InsertNewLayawayPayment(transactionID, paymentDate, paymentAmount.ToString(), newPrincipal.ToString());

            if (newPrincipal == 0)
            {
                dataManager.UpdateLayawayToClosed(transactionID);
            }
        }

        public void ResetForm()
        {
            TransIDTextBox.Text = string.Empty;
            PaymentTextBox.Text = string.Empty;
            ProdDescLabel.Text = string.Empty;
            LayawayStatusLabel.Text = string.Empty;
            LayawayDateLabel.Text = string.Empty;
            PrincipalAmountLabel.Text = string.Empty;
            CurrentPrincipalLabel.Text = string.Empty;
            GetLayawayPaymentData();
        }

        public void UpdateLayawayStatus()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            dataManager.UpdateLayawayStatus(transactionID);
        }

        public void UpdateSaleDate()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            DateTime saleDate = DateTime.Today;
            dataManager.UpdateLayawaySoldDate(transactionID, saleDate);
        }

        public string GetCustomerID()
        {
            string selectedCustomerRow = "";
            if (LayawayDataGrid.SelectedRows.Count > 0)
            {
                selectedCustomerRow = Convert.ToString(LayawayDataGrid.SelectedRows[0].Cells[1].Value);
            }
            return selectedCustomerRow;
        }

        public void CreateLayawayPaymentReceipt()
        {
            string customerId = GetCustomerID();
            string transactionId = TransIDTextBox.Text;
            string paymentAmount = PaymentTextBox.Text;
            int payment = Convert.ToInt32(paymentAmount);

            LayawayPaymentReceipt layawayPaymentRec = new LayawayPaymentReceipt();
            layawayPaymentRec.CustomerIDValue = customerId;
            layawayPaymentRec.TransactionNumber = transactionId;
            layawayPaymentRec.PaymentDate = DateTime.Now.ToShortDateString();
            layawayPaymentRec.PaymentAmount = paymentAmount;
            layawayPaymentRec.AmountOwed = newPrincipal.ToString();
            layawayPaymentRec.Show();
        }

        #endregion
    }
}
