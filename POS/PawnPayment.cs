using System;
using System.Collections.Generic;
using System.Configuration;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class PawnPayment : Form
    {
        #region Global Components

        string connectionString;
        
        public PawnPayment()
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

        DataTable pawnInfoData = new DataTable();
        DataTable pawnPaymentTable = new DataTable();
        DataTable pawnChargeTable = new DataTable();
        Dictionary<string, DateTime> maxDate = new Dictionary<string, DateTime>();
        int principal;
        double currentPrincipal;

        #endregion

        #region Private Methods

        private void PawnPayment_Load(object sender, EventArgs e)
        {
            try
            {
                LoadTransactionData();
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
                GetPawnPaymentData();
                GetPawnChargeData();
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem adding the transaction");
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
                    CreatePawnPaymentReceipt();
                    ResetForm();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("There was a problem adding the payment");
            }
        }

        private void PaymentExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region Public Methods

        public void LoadTransactionData()
        {
            DataManager dataManager = new DataManager(connectionString);
            pawnInfoData = dataManager.GetPawnTransactions();

            PawnDataGrid.DataSource = pawnInfoData;
        }

        public string GetTransactionID()
        {
            string selectedPawnRow = Convert.ToString(PawnDataGrid.SelectedRows[0].Cells[0].Value);
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

        public void GetTransactionDetails()
        {
            string transactionID = TransIDTextBox.Text;
            DataTable pawnDetailTable = new DataTable();
            DataManager dataManager = new DataManager(connectionString);
            pawnDetailTable = dataManager.GetPawnDetails(transactionID);

            string productDesc = pawnDetailTable.Rows[0]["ProductDescription"].ToString();
            ProdDescLabel.Text = productDesc;

            string status = pawnDetailTable.Rows[0]["Status"].ToString();
            PawnStatusLabel.Text = status;

            string pawnDate = Convert.ToDateTime(pawnDetailTable.Rows[0]["PawnDate"]).ToShortDateString();
            PawnDateLabel.Text = pawnDate;

            principal = Convert.ToInt32(pawnDetailTable.Rows[0]["PrincipalAmount"]);
            string principalAmount = string.Format("{0:C}", principal);
            PrincipalAmountLabel.Text = principalAmount;

            currentPrincipal = GetCurrentPrincipal();
            if (currentPrincipal == 0)
            {
                CurrentPrincipalLabel.Text = principalAmount;
            }
            else
            {
                string newPrincipal = string.Format("{0:C}", currentPrincipal);
                CurrentPrincipalLabel.Text = newPrincipal;
            }
        }

        public void GetPawnPaymentData()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            pawnPaymentTable = dataManager.GetPawnPaymentHistory(transactionID);
            PaymentHistoryDataGrid.DataSource = pawnPaymentTable;
        }

        public void GetPawnChargeData()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            pawnChargeTable = dataManager.GetPawnChargeHistory(transactionID);
            ChargeDataGrid.DataSource = pawnChargeTable;
        }

        public double GetCurrentPrincipal()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            double currentPrincipal = dataManager.GetCurrentPrincipal(transactionID);
            return currentPrincipal;
        }

        public void AddPaymentToTransaction()
        {
            DataManager dataManager = new DataManager(connectionString);
            string transactionID = TransIDTextBox.Text;
            string paymentDate = DateTime.Today.ToShortDateString();
            double paymentAmount = Convert.ToDouble(PaymentTextBox.Text);
            double newPrincipal;
            if (currentPrincipal == 0)
            {
                newPrincipal = principal - paymentAmount;
            }
            else
            {
                newPrincipal = currentPrincipal - paymentAmount;
            }
            
            dataManager.InsertNewPayment(transactionID, paymentDate, paymentAmount.ToString(), newPrincipal.ToString());

            if (newPrincipal == 0)
            {
                dataManager.UpdatePawnToClosed(transactionID);
            }
        }

        public void ResetForm()
        {
            TransIDTextBox.Text = string.Empty;
            PaymentTextBox.Text = string.Empty;
            ProdDescLabel.Text = string.Empty;
            PawnStatusLabel.Text = string.Empty;
            PawnDateLabel.Text = string.Empty;
            PrincipalAmountLabel.Text = string.Empty;
            CurrentPrincipalLabel.Text = string.Empty;
            GetPawnPaymentData();
            GetPawnChargeData();
        }

        public string GetCustomerID()
        {
            string selectedCustomerRow = Convert.ToString(PawnDataGrid.SelectedRows[0].Cells[1].Value);
            return selectedCustomerRow;
        }

        public void CreatePawnPaymentReceipt()
        {
            string customerId = GetCustomerID();
            string transactionId = TransIDTextBox.Text;
            string paymentAmount = PaymentTextBox.Text;
            int payment = Convert.ToInt32(paymentAmount);

            PawnPaymentReceipt pawnPaymentReceipt = new PawnPaymentReceipt();
            pawnPaymentReceipt.CustomerIDValue = customerId;
            pawnPaymentReceipt.TransactionNumber = transactionId;
            pawnPaymentReceipt.PaymentAmount = paymentAmount;
            pawnPaymentReceipt.Show();
        }

        #endregion
    }
}
