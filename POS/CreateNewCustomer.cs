using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlServerCe;
using System.Text;
using System.Windows.Forms;

namespace POS
{
    public partial class CreateNewCustomer : Form
    {
        #region Global Components

        string connectionString;

        public CreateNewCustomer()
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

        #region Private Functions\Events

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveCustomerButton_Click(object sender, EventArgs e)
        {
            bool checkTextBoxes = CheckDataInput();

            if (!checkTextBoxes)
            {
                try
                {
                    SaveNewCustomer();
                    ShowSuccessMessage(FirstNameTextBox.Text, LastNameTextBox.Text);
                    ResetForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("Error: {0}", ex));
                }
            }
        }
        	

        #endregion

        #region Public Functions

        public bool CheckDataInput()
        {
            DataVerification dataCheck = new DataVerification();
            bool result = false;
            
            var checkLicenseNum = dataCheck.IsEmpty(LicenseNumTextBox, LicenseNumTextBox.Text, ErrorProvider);
            var checkFirstName = dataCheck.IsEmpty(FirstNameTextBox, FirstNameTextBox.Text, ErrorProvider);
            var checkLastName = dataCheck.IsEmpty(LastNameTextBox, LastNameTextBox.Text, ErrorProvider);
            var checkMiddleName = dataCheck.IsEmpty(MiddleTextBox, MiddleTextBox.Text, ErrorProvider);
            var checkAddress = dataCheck.IsEmpty(AddressTextBox, AddressTextBox.Text, ErrorProvider);
            var checkCity = dataCheck.IsEmpty(CityTextBox, CityTextBox.Text, ErrorProvider);
            var checkState = dataCheck.IsEmpty(StateTextBox, StateTextBox.Text, ErrorProvider);
            var checkZip = dataCheck.IsEmpty(ZipCodeTextBox, ZipCodeTextBox.Text, ErrorProvider);
            var checkPhone = dataCheck.IsEmpty(PhoneNumTextBox, PhoneNumTextBox.Text, ErrorProvider);
            var checkSecondPhone = dataCheck.IsEmpty(SecondaryPhoneTextBox, SecondaryPhoneTextBox.Text, ErrorProvider);

            if (checkLicenseNum || checkFirstName || checkLastName || checkMiddleName || checkAddress ||
                checkCity || checkState || checkZip || checkPhone || checkSecondPhone)
            {
                result = true;
            }
            else
            {
                ErrorProvider.Clear();
                result = false;
            }
            return result;
        }

        public void SaveNewCustomer()
        {
            string customerNumber = LicenseNumTextBox.Text;
        	string customerID = customerNumber.Substring(1, 9);
        	string firstName = FirstNameTextBox.Text;
        	string lastName = LastNameTextBox.Text;
        	string middle = MiddleTextBox.Text;
        	string address = AddressTextBox.Text;
        	string city = CityTextBox.Text;
        	string state = StateTextBox.Text;
        	string zipCode = ZipCodeTextBox.Text;
        	string phoneNumber = PhoneNumTextBox.Text;
        	string secondPhoneNumber = SecondaryPhoneTextBox.Text;
        	string licenseNumber = LicenseNumTextBox.Text;
        	string entryDate = DateTime.Now.ToString("d");
        	string accountStatus = "Active";

        	DataManager saveCustomer = new DataManager(connectionString);

        	saveCustomer.SaveCustomerData(customerID, firstName, lastName, middle, address, city,
        		                          state, zipCode, phoneNumber, secondPhoneNumber, licenseNumber, 
        		                          entryDate, accountStatus);
        }

        public void ShowSuccessMessage(string firstName, string lastName)
        {
            MessageBox.Show(string.Format("You Have Added {0} {1} To The Database", firstName, lastName));
        }

        public void ResetForm()
        {
            FirstNameTextBox.Text = string.Empty;
            LastNameTextBox.Text = string.Empty;
            MiddleTextBox.Text = string.Empty;
            AddressTextBox.Text = string.Empty;
            CityTextBox.Text = string.Empty;
            StateTextBox.Text = string.Empty;
            ZipCodeTextBox.Text = string.Empty;
            PhoneNumTextBox.Text = string.Empty;
            SecondaryPhoneTextBox.Text = string.Empty;
            LicenseNumTextBox.Text = string.Empty;
            FirstNameTextBox.Focus();
        }

        #endregion
    }
}
