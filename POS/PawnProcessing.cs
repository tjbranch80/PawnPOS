﻿
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

        Dictionary<string, DateTime> allPawnDataDictonary = new Dictionary<string, DateTime>();
        Dictionary<string, DateTime> singlePawnDataDictionary = new Dictionary<string, DateTime>();
        List<string> defaultedPawnList = new List<string>();
        //List<string> chargedTransactionIdList = new List<string>();
        //List<string> newChargeTransactionIdList = new List<string>();
        //List<string> paymentTransactionIdList = new List<string>();
        //List<string> newChargePaymentTransactionIdList = new List<string>();
        //List<string> allTypesTransactionIdList = new List<string>();
        //Dictionary<string, DateTime> dateDic = new Dictionary<string, DateTime>();
        //List<string> newChargedAllTypesTransactionIdList = new List<string>();
        
        #endregion

        #region Private Methods
		
        private void PawnProcessingLoad(object sender, EventArgs e)
        {
            try
            {
                ProcessCompleteLabel.Text = "Updating Transactions...";
                GetSinglePawnData();
                CheckSinglePawnDate();
                //GetAllPawnData();
                //CheckPawnDefaultDate();
        //        GetChargedPawnTransactionId();
        //        CheckMaxChargeDate();
        //        ApplyChargedFinanceCharge();
        //        GetPaymentPawnTransactionID();
        //        CheckMaxPaymentDate();
        //        ApplyPaymentCharge();
        //        GetAllTypesTransactionID();
        //        CheckMaxDate();
        //        ApplyAllTypesCharge();
        //        SetPawnToDefault();
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

        #endregion

        #region Check If Pawn Is Defaulted

        public void GetAllPawnData()
        {
            DataManager dataManager = new DataManager(connectionString);
            allPawnDataDictonary = dataManager.GetAllPawnData();
        }

        public void CheckPawnDefaultDate()
        {
            if (allPawnDataDictonary.Count > 0)
            {
                foreach (KeyValuePair<string, DateTime> pawn in allPawnDataDictonary)
                {
                    DateTime defaultDate = pawn.Value;
                    DateTime today = DateTime.Today;
                    TimeSpan diffDays = today - defaultDate;
                    double defaultTest = diffDays.TotalDays;
                    string pawnID = pawn.Key;

                    if (defaultTest >= 0)
                    {
                        defaultedPawnList.Add(pawnID);
                    }
                }
            }
        }

        public void GetChargedPawnTransactionId()
        {
            DataManager dataManager = new DataManager(connectionString);
            chargedTransactionIdList = dataManager.GetChargedPawnTransactionID();
        }

        #endregion

        

        #region Process Pawns With Charges But No Payments

        

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

        #endregion

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

            //foreach (string pawnID in defaultedSinglePawn)
            //{
                //dataManager.UpdatePawnToDefault(pawnID, dateDefaulted);
            //}  	
        }
    }
}
