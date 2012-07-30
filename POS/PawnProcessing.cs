
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace POS
{

	public partial class PawnProcessing : Form
	{
		#region Global Components

        //makenna

        string connectionString;
		
		public PawnProcessing()
		{
		
			InitializeComponent();
			CenterToScreen();
            ProcessCompleteLabel.Visible = false;
            OpenApplicationButton.Visible = false;
            PawnReportButton.Visible = false;

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

        Dictionary<string, DateTime> allPawnDataDictionary = new Dictionary<string, DateTime>();
        Dictionary<string, DateTime> singlePawnDataDictionary = new Dictionary<string, DateTime>();
        Dictionary<string, DateTime> dateDictionary = new Dictionary<string, DateTime>();
        List<string> chargedPawnIdList = new List<string>();
        List<string> defaultedPawnList = new List<string>();
        List<string> paymentTransactionIdList = new List<string>();
        List<string> allTypesTransactionIdList = new List<string>();
        
        #endregion

        #region Private Methods
		
        private void PawnProcessingLoad(object sender, EventArgs e)
        {
            try
            {
                ProcessCompleteLabel.Text = "Updating Transactions...";
                GetSinglePawnData();
                CheckSinglePawnDate();
                GetChargedPawnId();
                CheckMaxChargeDate();
                GetPaymentPawnTransactionID();
                CheckMaxPaymentDate();
                GetAllTypesTransactionID();
                CheckMaxDate();
                GetAllPawnData();
                CheckPawnDefaultDate();
                ShowProcessCompleted();
            }
            catch(Exception ex)
            {
                MessageBox.Show(string.Format("Error: {0}",ex));
            }
        }

        private void OpenApplicationButton_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = null;
            if (mainMenu != null)
            {
                mainMenu.Activate();
            }
            else
            {
                mainMenu = new MainMenu();
                mainMenu.Show();
                this.Hide();
            }
        }

        private void PawnReportButton_Click(object sender, EventArgs e)
        {
            DefaultPawnReport report = null;
            if (report != null)
            {
                report.Activate();
            }
            else
            {
                report = new DefaultPawnReport();
                report.Show();
            }
        }
		
        #endregion
		
        #region Public Methods
		
        public string GetFinanceCharge()
        {
            string financeChargePercent = ConfigurationManager.AppSettings["FinanceCharge"];
            return financeChargePercent;
        }
		
        public void ShowProcessCompleted()
        {
            ProcessCompleteLabel.Visible = true;
            OpenApplicationButton.Visible = true;
            PawnReportButton.Visible = true;
            ProcessCompleteLabel.Text = "Update Completed";
        }
		
        #endregion

        #region Check If A Finance Charge Needs To Be Applied

        public void GetSinglePawnData()
        {
            DataManager dataManager = new DataManager(connectionString);
            singlePawnDataDictionary = dataManager.GetSinglePawnData();
        }

        public void CheckSinglePawnDate()
        {
            if (singlePawnDataDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, DateTime> pawn in singlePawnDataDictionary)
                {
                    DateTime originalDate = pawn.Value;
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - originalDate;
                    double loanDays = diffDays.TotalDays;
                    string pawnID = pawn.Key;

                    if (loanDays >= 31)
                    {
                        ApplySinglePawnFinanceCharge(pawnID);
                    }
                }
            }
        }

        public void ApplySinglePawnFinanceCharge(string pawnID)
        {
            DataManager dataManager = new DataManager(connectionString);
            double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
            double newBalance;
            double financeCharge;

            double principalAmount = dataManager.GetSinglePrincipalAmount(pawnID);

            financeCharge = principalAmount * financeChargePercent;
            newBalance = principalAmount + financeCharge;

            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
                principalAmount.ToString(), newBalance.ToString());

        }

        public void GetChargedPawnId()
        {
            DataManager dataManager = new DataManager(connectionString);
            chargedPawnIdList = dataManager.GetChargedPawnId();
        }

        public void CheckMaxChargeDate()
        {
            DataManager dataManager = new DataManager(connectionString);

            if (chargedPawnIdList.Count >= 1)
            {
                foreach (string pawnID in chargedPawnIdList)
                {
                    DateTime chargeDate = dataManager.GetMaxChargeDate(pawnID);
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - chargeDate;
                    double loanDays = diffDays.TotalDays;

                    if (loanDays >= 31)
                    {
                        ApplyChargedFinanceCharge(pawnID);
                    }
                }
            }
        }

        public void ApplyChargedFinanceCharge(string pawnID)
        {
            DataManager dataManager = new DataManager(connectionString);
            double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
            double newBalance;
            double financeCharge;

            double principalAmount = dataManager.GetMaxChargedNewPrincipal(pawnID);

            financeCharge = principalAmount * financeChargePercent;
            newBalance = principalAmount + financeCharge;

            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
            principalAmount.ToString(), newBalance.ToString());
        }

        public void GetPaymentPawnTransactionID()
        {
            DataManager dataManager = new DataManager(connectionString);
            paymentTransactionIdList = dataManager.GetPaymentPawnTransactionID();
        }

        public void CheckMaxPaymentDate()
        {
            DataManager dataManager = new DataManager(connectionString);

            if (paymentTransactionIdList.Count >= 1)
            {
                foreach (string pawnID in paymentTransactionIdList)
                {
                    DateTime chargeDate = dataManager.GetMaxPaymentDate(pawnID);
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - chargeDate;
                    double loanDays = diffDays.TotalDays;

                    if (loanDays >= 31)
                    {
                        ApplyPaymentCharge(pawnID);
                    }
                }
            }
        }

        public void ApplyPaymentCharge(string pawnID)
        {
            DataManager dataManager = new DataManager(connectionString);
            double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
            double newBalance;
            double financeCharge;

            double principalAmount = dataManager.GetMaxPaymentPrincipal(pawnID);

            financeCharge = principalAmount * financeChargePercent;
            newBalance = principalAmount + financeCharge;

            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
                principalAmount.ToString(), newBalance.ToString());

        }

        public void GetAllTypesTransactionID()
        {
            DataManager dataManager = new DataManager(connectionString);
            allTypesTransactionIdList = dataManager.GetAllTypesPawnTransactionID();
        }

        public void CheckMaxDate()
        {
            DataManager dataManager = new DataManager(connectionString);

            foreach (string pawnID in allTypesTransactionIdList)
            {
                dateDictionary = dataManager.GetAllTypesMaxDate(pawnID);
                DateTime maxDate;

                foreach (KeyValuePair<string, DateTime> pair in dateDictionary)
                {
                    maxDate = pair.Value;
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - maxDate;
                    double loanDays = diffDays.TotalDays;
                    string typeTest = pair.Key.Substring(0, 10);

                    if (typeTest == "PaymentDat")
                    {
                        if (loanDays >= 31)
                        {
                            ApplyPaymentCharge(pawnID);
                        }
                    }

                    if (typeTest == "ChargeDate")
                    {
                        if (loanDays >= 31)
                        {
                            ApplyChargedFinanceCharge(pawnID);
                        }
                    }
                }
            }
        }

        #endregion

        #region Check If Pawn Is Defaulted

        public void GetAllPawnData()
        {
            DataManager dataManager = new DataManager(connectionString);
            allPawnDataDictionary = dataManager.GetAllPawnData();
        }

        public void CheckPawnDefaultDate()
        {
            if (allPawnDataDictionary.Count > 0)
            {
                foreach (KeyValuePair<string, DateTime> pawn in allPawnDataDictionary)
                {
                    DateTime defaultDate = pawn.Value;
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - defaultDate;
                    double defaultTest = diffDays.TotalDays;
                    string pawnID = pawn.Key;

                    if (defaultTest >= 0)
                    {
                        SetPawnToDefault(pawnID);
                    }
                }
            }
        }

        public void SetPawnToDefault(string pawnID)
        {
            DataManager dataManager = new DataManager(connectionString);

            string dateDefaulted = DateTime.Today.ToShortDateString();

            dataManager.UpdatePawnToDefault(pawnID, dateDefaulted);	
        }

        #endregion
    }
}
