
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

        Dictionary<string, DateTime> nonPaymentPawnDictonary = new Dictionary<string, DateTime>();
        List<string> nonPaymentDefaultedPawn = new List<string>();
        //List<string> singleTransactionChargeList = new List<string>();
        //List<string> chargedTransactionIdList = new List<string>();
        //List<string> newChargeTransactionIdList = new List<string>();
        //List<string> paymentTransactionIdList = new List<string>();
        //List<string> newChargePaymentTransactionIdList = new List<string>();
        //List<string> allTypesTransactionIdList = new List<string>();
        //Dictionary<string, DateTime> dateDic = new Dictionary<string, DateTime>();
        //List<string> newChargedAllTypesTransactionIdList = new List<string>();
        //List<string> defaultedPawnsList = new List<string>();
		
        #endregion

        #region Private Methods
		
        private void PawnProcessingLoad(object sender, EventArgs e)
        {
            try
            {
                ProcessCompleteLabel.Text = "Updating Transactions...";
                GetNonPaymentPawnData();
                CheckNonPaymentDate();
        //        CheckOriginalDate();
        //        ApplySinglePawnFinanceCharge();
        //        GetChargedPawnTransactionId();
        //        CheckMaxChargeDate();
        //        ApplyChargedFinanceCharge();
        //        GetPaymentPawnTransactionID();
        //        CheckMaxPaymentDate();
        //        ApplyPaymentCharge();
        //        GetAllTypesTransactionID();
        //        CheckMaxDate();
        //        ApplyAllTypesCharge();
                SetPawnToDefault();
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
		
        //public string GetFinanceCharge()
        //{
        //    string financeChargePercent = ConfigurationManager.AppSettings["FinanceCharge"];
        //    return financeChargePercent;
        //}
		
        public void ShowProcessCompleted()
        {
            ProcessCompleteLabel.Visible = true;
            OpenApplicationButton.Visible = true;
            PawnReportButton.Visible = true;
            ProcessCompleteLabel.Text = "Update Completed";
        }
		
        #endregion
		
        #region Process Non Payment Pawns

        public void GetNonPaymentPawnData()
        {
            DataManager dataManager = new DataManager(connectionString);
            nonPaymentPawnDictonary = dataManager.GetNonPaymentPawnData();
        }

        public void CheckNonPaymentDate()
        {
            foreach (KeyValuePair<string, DateTime> pawn in nonPaymentPawnDictonary)
            {
                DateTime originalDate = pawn.Value;
                DateTime today = DateTime.Today;
                TimeSpan diffDays = today - originalDate;
                double loanDays = diffDays.TotalDays;
                string pawnID = pawn.Key;

                if (loanDays >= 91)
                {
                    nonPaymentDefaultedPawn.Add(pawnID);
                }
            }
        }
        

        //public void CheckOriginalDate()
        //{
        //    if (singleTransactionIdList.Count >= 1)
        //    {
        //        DataManager dataManager = new DataManager(connectionString);

        //        foreach (string pawnID in singleTransactionIdList)
        //        {
        //            DateTime originalDate = dataManager.GetSinglePawnDate(pawnID);
        //            DateTime today = DateTime.Today;
        //            TimeSpan diffDays = today - originalDate;
        //            double loanDays = diffDays.TotalDays;

        //            if (loanDays >= 31)
        //            {
        //                singleTransactionChargeList.Add(pawnID);
        //            }
        //        }
        //    }
        //}

        //public void ApplySinglePawnFinanceCharge()
        //{
        //    if (singleTransactionChargeList.Count >= 1)
        //    {
        //        DataManager dataManager = new DataManager(connectionString);
        //        double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
        //        double newBalance;
        //        double financeCharge;

        //        foreach (string pawnID in singleTransactionIdList)
        //        {
        //            double principalAmount = dataManager.GetSinglePrincipalAmount(pawnID);

        //            financeCharge = principalAmount * financeChargePercent;
        //            newBalance = principalAmount + financeCharge;

        //            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(), 
        //                principalAmount.ToString(), newBalance.ToString());
        //        }
        //    }
        //}
		
        #endregion

        //#region Process Pawns With Charges But No Payments

        //public void GetChargedPawnTransactionId()
        //{
        //    DataManager dataManager = new DataManager(connectionString);
        //    chargedTransactionIdList = dataManager.GetChargedPawnTransactionID();
        //}

        //public void CheckMaxChargeDate()
        //{
        //    DataManager dataManager = new DataManager(connectionString);

        //    foreach (string pawnID in chargedTransactionIdList)
        //    {
        //        DateTime chargeDate = dataManager.GetMaxChargeDate(pawnID);
        //        DateTime originalDate = dataManager.GetSinglePawnDate(pawnID);
        //        DateTime today = DateTime.Today;
        //        TimeSpan diffDays = today - chargeDate;
        //        double loanDays = diffDays.TotalDays;
        //        TimeSpan daySpan = today - originalDate;
        //        double loanSpan = daySpan.TotalDays;

        //        if (loanSpan >= 90)
        //        {
        //            defaultedPawnsList.Add(pawnID);
        //        }
        //        else if(loanDays >= 31)
        //        {
        //            newChargeTransactionIdList.Add(pawnID);
        //        }
        //    }
        //}

        //public void ApplyChargedFinanceCharge()
        //{
        //    if (newChargeTransactionIdList.Count >= 1)
        //    {
        //        DataManager dataManager = new DataManager(connectionString);
        //        double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
        //        double newBalance;
        //        double financeCharge;

        //        foreach (string pawnID in newChargeTransactionIdList)
        //        {
        //            double principalAmount = dataManager.GetMaxChargedNewPrincipal(pawnID);

        //            financeCharge = principalAmount * financeChargePercent;
        //            newBalance = principalAmount + financeCharge;

        //            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
        //                principalAmount.ToString(), newBalance.ToString());
        //        }
        //    }
        //}

        //#endregion

        //#region Process Pawns With No Charges But With Payments

        //public void GetPaymentPawnTransactionID()
        //{
        //    DataManager dataManager = new DataManager(connectionString);
        //    paymentTransactionIdList = dataManager.GetPaymentPawnTransactionID();
        //}

        //public void CheckMaxPaymentDate()
        //{
        //    DataManager dataManager = new DataManager(connectionString);

        //    foreach (string pawnID in paymentTransactionIdList)
        //    {
        //        DateTime chargeDate = dataManager.GetMaxPaymentDate(pawnID);
        //        DateTime today = DateTime.Today;
        //        TimeSpan diffDays = today - chargeDate;
        //        double loanDays = diffDays.TotalDays;

        //        if (loanDays >= 90)
        //        {
        //            defaultedPawnsList.Add(pawnID);
        //        }
        //        else if (loanDays >= 31)
        //        {
        //            newChargePaymentTransactionIdList.Add(pawnID);
        //        }
        //    }
        //}

        //public void ApplyPaymentCharge()
        //{
        //    if (newChargePaymentTransactionIdList.Count >= 1)
        //    {
        //        DataManager dataManager = new DataManager(connectionString);
        //        double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
        //        double newBalance;
        //        double financeCharge;

        //        foreach (string pawnID in newChargePaymentTransactionIdList)
        //        {
        //            double principalAmount = dataManager.GetMaxPaymentPrincipal(pawnID);

        //            financeCharge = principalAmount * financeChargePercent;
        //            newBalance = principalAmount + financeCharge;

        //            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
        //                principalAmount.ToString(), newBalance.ToString());
        //        }
        //    }
        //}

        //#endregion

        //#region Process Pawns With Charges and Payments

        //public void GetAllTypesTransactionID()
        //{
        //    DataManager dataManager = new DataManager(connectionString);
        //    allTypesTransactionIdList = dataManager.GetAllTypesPawnTransactionID();
        //}

        //public void CheckMaxDate()
        //{
        //    DataManager dataManager = new DataManager(connectionString);

        //    foreach (string pawnID in allTypesTransactionIdList)
        //    {
        //        dateDic = dataManager.GetAllTypesMaxDate(pawnID);
        //        DateTime maxDate;
        
        //        foreach (KeyValuePair<string, DateTime> pair in dateDic)
        //        {
        //            maxDate = pair.Value;
        //            DateTime today = DateTime.Today;
        //            TimeSpan diffDays = today - maxDate;
        //            double loanDays = diffDays.TotalDays;
        //            string typeTest = pair.Key.Substring(0, 10);

        //            if (typeTest == "PaymentDat")
        //            {
        //                if (loanDays >= 90)
        //                {
        //                    defaultedPawnsList.Add(pawnID);
        //                }
        //            }

        //            if (typeTest == "ChargeDate")
        //            {
        //                if (loanDays >= 31)
        //                {
        //                    newChargedAllTypesTransactionIdList.Add(pawnID);
        //                }
        //            }
        //        }
        //    }
        //}

        //public void ApplyAllTypesCharge()
        //{
        //    if (newChargedAllTypesTransactionIdList.Count >= 1)
        //    {
        //        DataManager dataManager = new DataManager(connectionString);
        //        double financeChargePercent = Convert.ToDouble(GetFinanceCharge());
        //        double newBalance;
        //        double financeCharge;

        //        foreach (string pawnID in newChargedAllTypesTransactionIdList)
        //        {
        //            double principalAmount = dataManager.GetMaxChargedNewPrincipal(pawnID);

        //            financeCharge = principalAmount * financeChargePercent;
        //            newBalance = principalAmount + financeCharge;

        //            dataManager.UpdatePawnChargesTable(pawnID, DateTime.Today, financeCharge.ToString(),
        //                principalAmount.ToString(), newBalance.ToString());
        //        }
        //    }
        //}

        //#endregion

        public void SetPawnToDefault()
        {
            DataManager dataManager = new DataManager(connectionString);

            string dateDefaulted = DateTime.Today.ToShortDateString();

            foreach (string pawnID in nonPaymentDefaultedPawn)
            {
                dataManager.UpdatePawnToDefault(pawnID, dateDefaulted);
            }  	
        }
    }
}
