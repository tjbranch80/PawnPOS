using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Data;
using System.IO;
using System.Linq;

namespace POS
{
    internal class DataManager
    {
        #region Global Components

        string connectionString;

        public DataManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #endregion

        #region Create New Customer

        public void SaveCustomerData(string customerID, string firstName, string lastName, 
                                     string middle, string address, string city, 
                                     string state, string zipCode, string phoneNumber, 
                                     string secondPhoneNumber, string licenseNumber, 
                                     string entryDate, string accountStatus)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string customerSaveQuery = @"INSERT INTO Customers(CustomerID,FirstName,LastName,Middle,Address,City,State,
                ZipCode,PhoneNum,SecondaryPhoneNum,LicenseNum,EntryDate,AccountStatus)VALUES(@customerID,@firstName,@lastName,@middle,
                @address,@city,@state,@zipCode,@phoneNumber,@secondPhoneNumber,@licenseNumber,@entryDate,@accountStatus)";

                using (SqlCeCommand command = new SqlCeCommand(customerSaveQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@middle", middle);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@zipCode", zipCode);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@secondPhoneNumber", secondPhoneNumber);
                    command.Parameters.AddWithValue("@licenseNumber", licenseNumber);
                    command.Parameters.AddWithValue("@entryDate", entryDate);
                    command.Parameters.AddWithValue("@accountStatus", accountStatus);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Create a Sales Transaction

        public void SaveSaleData(string customerID, string ProductID, string salePrice, string saleDate, 
                                 string invoiceNumber)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string saveSalesDataQuery = @"INSERT INTO Sales VALUES(@customerID,@productID,
                                              @salePrice,@saleDate,@invoiceNumber)";
                using (SqlCeCommand command = new SqlCeCommand(saveSalesDataQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@productID", ProductID);
                    command.Parameters.AddWithValue("@salePrice", salePrice);
                    command.Parameters.AddWithValue("@saleDate", saleDate);
                    command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void UpdateProductStatus(string productID, string saleDate)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string updateStatusQuery = @"UPDATE Inventory
                                            SET ProductStatus = 'Sold',
                                            SaleDate = @saleDate
                                            WHERE ProductID = @productID";
                using (SqlCeCommand command = new SqlCeCommand(updateStatusQuery, connection))
                {
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@saleDate", saleDate);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void SaveInvoiceData(string invoiceNumber, string totalSale, string salesTax, string saleDate,
                                    string customerID, string grandTotal)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string saveInvoiceData = @"INSERT INTO Invoice VALUES(@invoiceNumber,
                                           @totalSale,@salesTax,@saleDate,@customerID,@grandTotal)";
                using (SqlCeCommand command = new SqlCeCommand(saveInvoiceData, connection))
                {
                    command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);
                    command.Parameters.AddWithValue("@totalSale", totalSale);
                    command.Parameters.AddWithValue("@salesTax", salesTax);
                    command.Parameters.AddWithValue("@saleDate", saleDate);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@grandTotal", grandTotal);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Program Maintenance

        public void UpdateToInactiveStatus(string customerID)
        {
        	using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                
                string updateToInactive = @"Update Customers
											SET AccountStatus = 'NotActive'
											WHERE CustomerID = @customerID";
                using (SqlCeCommand command = new SqlCeCommand(updateToInactive, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
        	}
        }

        public void UpdateToActiveStatus(string customerID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string updateToActive = @"Update Customers
											SET AccountStatus = 'Active'
											WHERE CustomerID = @customerID";
                using (SqlCeCommand command = new SqlCeCommand(updateToActive, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void InsertProductStatus(string newStatus)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string saveProductStatus = @"INSERT INTO ProductStatus
											VALUES(@newStatus)";

                using (SqlCeCommand command = new SqlCeCommand(saveProductStatus, connection))
                {
                    command.Parameters.AddWithValue("@newStatus", newStatus);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void InsertPrimeCategory(string newPrimeCat)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string savePrimeCategory = @"INSERT INTO PrimaryCategory
											VALUES(@newPrimeCat)";

                using (SqlCeCommand command = new SqlCeCommand(savePrimeCategory, connection))
                {
                    command.Parameters.AddWithValue("@newPrimeCat", newPrimeCat);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void InsertSecondaryCategory(string newSecCat, string selectedPrimeCat)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string saveSecondaryCategory = @"INSERT INTO SecondaryCategory
											VALUES(@newSecCat,@selectedPrimeCat)";

                using (SqlCeCommand command = new SqlCeCommand(saveSecondaryCategory, connection))
                {
                    command.Parameters.AddWithValue("@newSecCat", newSecCat);
                    command.Parameters.AddWithValue("@selectedPrimeCat", selectedPrimeCat);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public DataTable ChangeAccountStatusInformation()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string statusCustomerQuery = @"SELECT 
												c.CustomerID,
												c.FirstName,
												c.LastName,
												c.AccountStatus
											FROM
												Customers c";
                connection.Open();

                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(statusCustomerQuery, connection))
                {
                    DataTable statusInfoTable = new DataTable();
                    dataAdapter.Fill(statusInfoTable);
                    connection.Close();
                    return statusInfoTable;
                }
            }
        }

        #endregion

        #region Create Purchase Transaction

        public void InsertInventoryItem(string productID, string productDesc, string purchasePrice
                                        , string primaryCategory, string secondaryCategory, string
                                        productStatus, string serialNumber, string saleDate)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string saveInventoryItem = @"INSERT INTO Inventory
											VALUES(@productID,@productDesc,@purchasePrice,
													@primaryCategory,@secondaryCategory,
													@productStatus,@serialNumber,@saleDate)";

                using (SqlCeCommand command = new SqlCeCommand(saveInventoryItem, connection))
                {
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@productDesc", productDesc);
                    command.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    command.Parameters.AddWithValue("@primaryCategory", primaryCategory);
                    command.Parameters.AddWithValue("@secondaryCategory", secondaryCategory);
                    command.Parameters.AddWithValue("@productStatus", productStatus);
                    command.Parameters.AddWithValue("@serialNumber", serialNumber);
                    command.Parameters.AddWithValue("@saleDate", saleDate);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void InsertPurchaseItem(string productID, string productDesc, string purchasePrice,
                                       string primaryCategory, string secondaryCategory,
                                       string customerID, string purchaseDate, string poNumber)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string savePurchaseItem = @"INSERT INTO Purchase
											VALUES(@productID,@productDesc,@purchasePrice,
													@primaryCategory,@secondaryCategory,
													@customerID,@purchaseDate,@poNumber)";

                using (SqlCeCommand command = new SqlCeCommand(savePurchaseItem, connection))
                {
                    command.Parameters.AddWithValue("@productID", productID);
                    command.Parameters.AddWithValue("@productDesc", productDesc);
                    command.Parameters.AddWithValue("@purchasePrice", purchasePrice);
                    command.Parameters.AddWithValue("@primaryCategory", primaryCategory);
                    command.Parameters.AddWithValue("@secondaryCategory", secondaryCategory);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@purchaseDate", purchaseDate);
                    command.Parameters.AddWithValue("@poNumber", poNumber);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Create Pawn Transaction

        public void InsertPawn(string transactionID, string customerID, string productDesc
                                        , string principalAmount, string pawnDate, string status 
                                        , string defaultedDate, string defaultDate)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string savePawn = @"INSERT INTO Pawn
									VALUES(@transactionID,@customerID,@productDesc,
									@principalAmount,@pawnDate,@status,@defaultedDate,@defaultDate)";

                using (SqlCeCommand command = new SqlCeCommand(savePawn, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@productDesc", productDesc);
                    command.Parameters.AddWithValue("@principalAmount", principalAmount);
                    command.Parameters.AddWithValue("@pawnDate", pawnDate);
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@defaultedDate", defaultedDate);
                    command.Parameters.AddWithValue("@defaultDate", defaultDate);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Multi Use Queries

        public DataTable GetAllInventory()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string allInventoryQuery = @"SELECT * 
                                             FROM Inventory i
                                             WHERE i.ProductStatus = 'Available'";
                connection.Open();

                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(allInventoryQuery, connection))
                {
                    DataTable allInventoryTable = new DataTable();
                    dataAdapter.Fill(allInventoryTable);
                    connection.Close();
                    return allInventoryTable;
                }
            }
        }

        public DataTable GetCustomerInformation()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string customerInfoQuery = @"SELECT * FROM Customers";
                connection.Open();

                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(customerInfoQuery, connection))
                {
                    DataTable customerInfoTable = new DataTable();
                    dataAdapter.Fill(customerInfoTable);
                    connection.Close();
                    return customerInfoTable;
                }
            }
        }

        public DataTable GetPrimaryCategories()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string primaryCategoryQuery = @"SELECT *
												FROM
												PrimaryCategory";
                connection.Open();

                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(primaryCategoryQuery, connection))
                {
                    DataTable primeCatInfoTable = new DataTable();
                    dataAdapter.Fill(primeCatInfoTable);
                    connection.Close();
                    return primeCatInfoTable;
                }
            }
        }

        public DataTable GetSecondaryCategories()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                string secCategoryQuery = @"SELECT *
											FROM
											SecondaryCategory";
                connection.Open();

                using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(secCategoryQuery, connection))
                {
                    DataTable secCatInfoTable = new DataTable();
                    dataAdapter.Fill(secCatInfoTable);
                    connection.Close();
                    return secCatInfoTable;
                }
            }
        }

        public DataTable GetCustomerInvoiceData(string customerID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string customerInvoiceQuery = @"SELECT
                                                  c.FirstName,
                                                  c.LastName
                                                FROM
                                                  Customers c
                                                WHERE
                                                  c.CustomerID = @customerID";
                using (SqlCeCommand command = new SqlCeCommand(customerInvoiceQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable customerInvoiceTable = new DataTable();
                        dataadapter.Fill(customerInvoiceTable);
                        connection.Close();
                        return customerInvoiceTable;
                    }
                }
            }
        }

        #endregion

        #region Reprint Sales Invoice

        public DataTable GetReprintInvoiceData()
        {
            string invoicePath = ConfigurationManager.AppSettings["InvoicePath"];
            string[] invoiceNumbers = Directory.GetFiles(invoicePath, "*.jpg");

            DataTable invoiceInfoTable = new DataTable();
            invoiceInfoTable.Columns.Add("InvoiceNumber");
            invoiceInfoTable.Columns.Add("InvoiceDate");

            foreach (string name in invoiceNumbers)
            {
                var fileName = Path.GetFileNameWithoutExtension(name);
                FileInfo info = new FileInfo(name);
                string date = info.LastWriteTime.ToShortDateString();
                invoiceInfoTable.Rows.Add(fileName, date);
            }
            return invoiceInfoTable;
        }

        #endregion

        #region Customer Search

        public DataTable GetSalesHistory(string customerID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string salesHistoryQuery = @"SELECT
                                                s.ProductID,
                                                s.SalePrice,
                                                i.ProductDescription,
                                                s.SaleDate
                                             FROM 
                                                Sales s 
                                                JOIN Inventory i ON s.ProductID=i.ProductID
                                             WHERE 
                                                s.CustomerID = @customerID";

                using (SqlCeCommand command = new SqlCeCommand(salesHistoryQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable salesInfoTable = new DataTable();
                        dataadapter.Fill(salesInfoTable);
                        connection.Close();
                        return salesInfoTable;
                    }
                }
            }
        }

        public DataTable GetPawnHistory(string customerID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnHistoryQuery = @"SELECT
                                               p.TransactionID,
                                               p.ProductDescription,
                                               p.PrincipalAmount,
                                               p.PawnDate,
                                               p.Status,
                                               p.DateDefaulted
                                           FROM
                                               Pawn p
                                           WHERE
                                               p.CustomerID = @customerID";
                using (SqlCeCommand command = new SqlCeCommand(pawnHistoryQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnHistoryTable = new DataTable();
                        dataadapter.Fill(pawnHistoryTable);
                        connection.Close();
                        return pawnHistoryTable;
                    }
                }
            }
        }

        public DataTable GetSoldHistory(string customerID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string soldHistoryQuery = @"SELECT
                                                p.ProductID,
                                                p.ProductDescription,
                                                p.PurchasePrice
                                            FROM
                                                Purchase p
                                            WHERE
                                                p.CustomerID = @customerID";
                using (SqlCeCommand command = new SqlCeCommand(soldHistoryQuery, connection))
                {
                    command.Parameters.AddWithValue("@customerID", customerID);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable soldInfoTable = new DataTable();
                        dataadapter.Fill(soldInfoTable);
                        connection.Close();
                        return soldInfoTable;
                    }
                }
            }
        }

        #endregion

        #region Create Sales Invoice

        public DataTable GetSalesInvoiceData(string invoiceNumber)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string createInvoiceQuery = @"SELECT
                                                s.ProductID,
                                                s.SalePrice,
                                                inv.ProductDescription
                                             FROM
                                                Sales s
                                                JOIN Invoice i ON s.InvoiceNumber = i.InvoiceNumber
                                                JOIN Inventory inv ON s.ProductID = inv.ProductID
                                             WHERE
                                                i.InvoiceNumber = @invoiceNumber";
                using (SqlCeCommand command = new SqlCeCommand(createInvoiceQuery, connection))
                {
                    command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable createInvoiceTable = new DataTable();
                        dataadapter.Fill(createInvoiceTable);
                        connection.Close();
                        return createInvoiceTable;
                    }
                }
            }
        }

        public DataTable GetFinalDollarInvoiceData(string invoiceNumber)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string finalDollarInvoiceQuery = @"SELECT
                                                    i.TotalSale,
                                                    i.SalesTax,
                                                    i.SaleDate,
                                                    i.GrandTotal
                                                  FROM
                                                    Invoice i
                                                  WHERE
                                                    i.InvoiceNumber = @invoiceNumber";
                using (SqlCeCommand command = new SqlCeCommand(finalDollarInvoiceQuery, connection))
                {
                    command.Parameters.AddWithValue("@invoiceNumber", invoiceNumber);

                    using (SqlCeDataAdapter dataadapter = new SqlCeDataAdapter(command))
                    {
                        DataTable finalDollarInvoiceTable = new DataTable();
                        dataadapter.Fill(finalDollarInvoiceTable);
                        connection.Close();
                        return finalDollarInvoiceTable;
                    }
                }
            }
        }

        #endregion

        #region Create Purchase Invoice

        public DataTable GetPurchaseInfo(string poNumber)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string purchaseInfoQuery = @"SELECT * 
                                             FROM Purchase p
                                             WHERE p.PONumber = @poNumber";
                using (SqlCeCommand command = new SqlCeCommand(purchaseInfoQuery, connection))
                {
                    command.Parameters.AddWithValue("@poNumber", poNumber);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable purchaseInfoTable = new DataTable();
                        dataAdapter.Fill(purchaseInfoTable);
                        connection.Close();
                        return purchaseInfoTable;
                    }
                }
            }
        }

        #endregion

        #region Create a Pawn Receipt

        public DataTable GetPawnTransactionData(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnInfoQuery = @"SELECT
                                            p.PrincipalAmount,
                                            p.PawnDate,
                                            p.ProductDescription 
                                         FROM 
                                            Pawn p
                                         WHERE 
                                            p.TransactionID = @transactionId";
                using (SqlCeCommand command = new SqlCeCommand(pawnInfoQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionId", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnInfoTable = new DataTable();
                        dataAdapter.Fill(pawnInfoTable);
                        connection.Close();
                        return pawnInfoTable;
                    }
                }
            }
        }

        #endregion

        #region Pawn Processing

        #region Single Pawns

        public Dictionary<string,DateTime> GetSinglePawnData()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getNonPaymentPawnIdQuery = @"SELECT
													    p.TransactionID,
                                                        p.PawnDate
													FROM 
                                                        Pawn p
													WHERE 
                                                        p.Status = 'Open'
                                                    AND 
                                                        p.TransactionID NOT IN (SELECT TransactionID
                                                        FROM PawnPayments)
                                                    AND
                                                        p.TransactionID NOT IN (SELECT TransactionID
                                                        FROM PawnCharges)";
                using (SqlCeCommand command = new SqlCeCommand(getNonPaymentPawnIdQuery, connection))
                {
                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable nonPaymentTable = new DataTable();
                        Dictionary<string, DateTime> nonPaymentDictonary = new Dictionary<string, DateTime>();
                        dataAdapter.Fill(nonPaymentTable);
                        connection.Close();
                        string pawnId = string.Empty;
                        DateTime pawnDate = Convert.ToDateTime("1/1/1900");

                        for (int i = 0; i < nonPaymentTable.Rows.Count; i++)
                        {
                            pawnId = nonPaymentTable.Rows[i]["TransactionID"].ToString();
                            pawnDate = Convert.ToDateTime(nonPaymentTable.Rows[i]["PawnDate"]);
                            nonPaymentDictonary.Add(pawnId, pawnDate);
                        }

                        return nonPaymentDictonary;
                    }
                }
            }
        }

        public double GetSinglePrincipalAmount(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getPrincipalAmountQuery = @"SELECT
												  p.PrincipalAmount
												  FROM Pawn p
												  WHERE p.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getPrincipalAmountQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable principalTable = new DataTable();
                        dataAdapter.Fill(principalTable);
                        connection.Close();
                        double principalAmount = 0;

                        for (int i = 0; i < principalTable.Rows.Count; i++)
                        {
                            principalAmount = Convert.ToDouble(principalTable.Rows[i]["PrincipalAmount"]);
                        }

                        return principalAmount;
                    }
                }
            }
        }

        #endregion

        #region Pawns With Charges and No Payments

        public List<string> GetChargedPawnTransactionID()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getPawnTransactionIdQuery = @"SELECT
													    p.TransactionID
													FROM 
                                                        Pawn p
													WHERE 
                                                        p.Status = 'Open'
                                                    AND 
                                                        p.TransactionID IN (SELECT TransactionID
                                                        FROM PawnCharges)
                                                    AND 
                                                        p.TransactionID NOT IN (SELECT TransactionID
                                                        FROM PawnPayments)";
                using (SqlCeCommand command = new SqlCeCommand(getPawnTransactionIdQuery, connection))
                {
                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable transactionIdTable = new DataTable();
                        dataAdapter.Fill(transactionIdTable);
                        connection.Close();
                        List<string> transactionIdList = new List<string>();
                        string transactionId = string.Empty;

                        for (int i = 0; i < transactionIdTable.Rows.Count; i++)
                        {
                            transactionId = transactionIdTable.Rows[i]["TransactionID"].ToString();
                            transactionIdList.Add(transactionId);
                        }

                        return transactionIdList;
                    }
                }
            }
        }

        public DateTime GetMaxChargeDate(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getMaxDateQuery = @"SELECT
										    pc.ChargeDate
									     FROM 
                                            PawnCharges pc
										 WHERE 
                                            pc.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getMaxDateQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable maxDateTable = new DataTable();
                        dataAdapter.Fill(maxDateTable);
                        connection.Close();
                        List<DateTime> dateList = new List<DateTime>();
                        DateTime maxDate;
                        DateTime date;

                        for (int i = 0; i < maxDateTable.Rows.Count; i++)
                        {
                            maxDate = Convert.ToDateTime(maxDateTable.Rows[i]["ChargeDate"]);
                            dateList.Add(maxDate);
                        }
                        if (dateList.Count >= 1)
                        {
                            date = dateList.Max();
                        }
                        else
                        {
                            string dateString = "1/1/1900";
                            date = DateTime.Parse(dateString);
                        }
                        return date;
                    }

                }
            }
        }

        public double GetMaxChargedNewPrincipal(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getMaxDateQuery = @"SELECT
										    pc.NewPrincipal
									     FROM 
                                            PawnCharges pc
										 WHERE 
                                            pc.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getMaxDateQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable maxPrincipalTable = new DataTable();
                        dataAdapter.Fill(maxPrincipalTable);
                        connection.Close();
                        List<double> newPrincipalList = new List<double>();
                        double maxNewPrincipal;
                        double maxPrincipalAmount;

                        for (int i = 0; i < maxPrincipalTable.Rows.Count; i++)
                        {
                            maxNewPrincipal = Convert.ToDouble(maxPrincipalTable.Rows[i]["NewPrincipal"]);
                            newPrincipalList.Add(maxNewPrincipal);
                        }
                        if (newPrincipalList.Count >= 1)
                        {
                            maxPrincipalAmount = newPrincipalList.Max();
                        }
                        else
                        {
                            maxPrincipalAmount = 0;
                        }
                        return maxPrincipalAmount;
                    }

                }
            }
        }

        #endregion

        #region Pawns With Payments and No Charges

        public List<string> GetPaymentPawnTransactionID()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getPawnTransactionIdQuery = @"SELECT
													    p.TransactionID
													FROM 
                                                        Pawn p
													WHERE 
                                                        p.Status = 'Open'
                                                    AND 
                                                        p.TransactionID IN (SELECT TransactionID
                                                        FROM PawnPayments)
                                                    AND 
                                                        p.TransactionID NOT IN (SELECT TransactionID
                                                        FROM PawnCharges)";
                using (SqlCeCommand command = new SqlCeCommand(getPawnTransactionIdQuery, connection))
                {
                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable transactionIdTable = new DataTable();
                        dataAdapter.Fill(transactionIdTable);
                        connection.Close();
                        List<string> transactionIdList = new List<string>();
                        string transactionId = string.Empty;

                        for (int i = 0; i < transactionIdTable.Rows.Count; i++)
                        {
                            transactionId = transactionIdTable.Rows[i]["TransactionID"].ToString();
                            transactionIdList.Add(transactionId);
                        }

                        return transactionIdList;
                    }
                }
            }
        }

        public DateTime GetMaxPaymentDate(string transactionId)
        {
           using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getMaxDateQuery = @"SELECT
										    pp.PaymentDate
									     FROM 
                                            PawnPayments pp
										 WHERE 
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getMaxDateQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable maxDateTable = new DataTable();
                        dataAdapter.Fill(maxDateTable);
                        connection.Close();
                        List<DateTime> dateList = new List<DateTime>();
                        DateTime maxDate;
                        DateTime date;

                        for (int i = 0; i < maxDateTable.Rows.Count; i++)
                        {
                            maxDate = Convert.ToDateTime(maxDateTable.Rows[i]["PaymentDate"]);
                            dateList.Add(maxDate);
                        }
                        if (dateList.Count >= 1)
                        {
                            date = dateList.Max();
                        }
                        else
                        {
                            string dateString = "1/1/1900";
                            date = DateTime.Parse(dateString);
                        }
                        return date;
                    }

                }
            } 
        }

        public double GetMaxPaymentPrincipal(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getMaxDateQuery = @"SELECT
										    pp.NewPrincipal
									     FROM 
                                            PawnPayments pp
										 WHERE 
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getMaxDateQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable maxPrincipalTable = new DataTable();
                        dataAdapter.Fill(maxPrincipalTable);
                        connection.Close();
                        List<double> newPrincipalList = new List<double>();
                        double maxNewPrincipal;
                        double maxPrincipalAmount;

                        for (int i = 0; i < maxPrincipalTable.Rows.Count; i++)
                        {
                            maxNewPrincipal = Convert.ToDouble(maxPrincipalTable.Rows[i]["NewPrincipal"]);
                            newPrincipalList.Add(maxNewPrincipal);
                        }
                        if (newPrincipalList.Count >= 1)
                        {
                            maxPrincipalAmount = newPrincipalList.Max();
                        }
                        else
                        {
                            maxPrincipalAmount = 0;
                        }
                        return maxPrincipalAmount;
                    }

                }
            }
        }

        #endregion

        #region Pawns With Payments and Charges

        public List<string> GetAllTypesPawnTransactionID()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getPawnTransactionIdQuery = @"SELECT
													    p.TransactionID
													FROM 
                                                        Pawn p
													WHERE 
                                                        p.Status = 'Open'
                                                    AND 
                                                        p.TransactionID IN (SELECT TransactionID
                                                        FROM PawnPayments)
                                                    AND 
                                                        p.TransactionID IN (SELECT TransactionID
                                                        FROM PawnCharges)";
                using (SqlCeCommand command = new SqlCeCommand(getPawnTransactionIdQuery, connection))
                {
                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable transactionIdTable = new DataTable();
                        dataAdapter.Fill(transactionIdTable);
                        connection.Close();
                        List<string> transactionIdList = new List<string>();
                        string transactionId = string.Empty;

                        for (int i = 0; i < transactionIdTable.Rows.Count; i++)
                        {
                            transactionId = transactionIdTable.Rows[i]["TransactionID"].ToString();
                            transactionIdList.Add(transactionId);
                        }

                        return transactionIdList;
                    }
                }
            }
        }

        public Dictionary<string,DateTime> GetAllTypesMaxDate(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getMaxDateQuery = @"SELECT
                                            pp.PaymentDate,
                                            pc.ChargeDate 
									     FROM 
                                            PawnPayments pp
                                            JOIN PawnCharges pc ON pp.TransactionID=pc.TransactionID 
										 WHERE 
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getMaxDateQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable maxDateTable = new DataTable();
                        dataAdapter.Fill(maxDateTable);
                        connection.Close();
                        Dictionary<string, DateTime> dateDic = new Dictionary<string, DateTime>();
                        DateTime maxPaymentDate;
                        DateTime maxChargeDate;
                        int counter = 0;

                        for (int i = 0; i < maxDateTable.Rows.Count; i++)
                        {
                            counter = counter + 1;
                            maxPaymentDate = Convert.ToDateTime(maxDateTable.Rows[i]["PaymentDate"]);
                            dateDic.Add("PaymentDate" + counter.ToString(),maxPaymentDate);
                            maxChargeDate = Convert.ToDateTime(maxDateTable.Rows[i]["ChargeDate"]);
                            dateDic.Add("ChargeDate" + counter.ToString(),maxChargeDate);
                        }

                        return dateDic;
                    }

                }
            }
        }

        #endregion

        #region Update a Pawn To Default

        public void UpdatePawnToDefault(string transactionID, string defaultedDate)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string updateToDefault =    @"Update Pawn
											SET Status = 'Default',
                                            DateDefaulted = @defaultedDate
											WHERE TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(updateToDefault, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);
                    command.Parameters.AddWithValue("@defaultedDate", defaultedDate);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        public void UpdatePawnChargesTable(string transactionID, DateTime chargeDate, string
            chargeAmount, string originalPrincipal, string newPrincipal)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string insertNewCharge = @"INSERT INTO PawnCharges 
                                           VALUES(@transactionID,@chargeDate,
                                                  @chargeAmount,@originalPrincipal,
                                                  @newPrincipal)";
                using (SqlCeCommand command = new SqlCeCommand(insertNewCharge, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);
                    command.Parameters.AddWithValue("@chargeDate", chargeDate);
                    command.Parameters.AddWithValue("@chargeAmount", chargeAmount);
                    command.Parameters.AddWithValue("@originalPrincipal", originalPrincipal);
                    command.Parameters.AddWithValue("@newPrincipal", newPrincipal);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Create a Pawn Payment

        public DataTable GetPawnTransactions()
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnInfoQuery = @"SELECT
                                            p.TransactionID,
                                            p.CustomerID,
                                            c.FirstName,
                                            c.LastName 
                                         FROM 
                                            Pawn p
                                            JOIN Customers c ON p.CustomerID = c.CustomerID";
                using (SqlCeCommand command = new SqlCeCommand(pawnInfoQuery, connection))
                {
                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnInfoTable = new DataTable();
                        dataAdapter.Fill(pawnInfoTable);
                        connection.Close();
                        return pawnInfoTable;
                    }
                }
            }
        }

        public DataTable GetPawnDetails(string transactionID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnDetailQuery = @"SELECT
                                            p.ProductDescription,
                                            p.Status,
                                            p.PawnDate,
                                            p.PrincipalAmount
                                         FROM 
                                            Pawn p
                                         WHERE
                                            p.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(pawnDetailQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnDetailTable = new DataTable();
                        dataAdapter.Fill(pawnDetailTable);
                        connection.Close();
                        return pawnDetailTable;
                    }
                }
            }
        }

        public DataTable GetPawnPaymentHistory(string transactionID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnPaymentQuery = @"SELECT
                                            pp.PaymentDate,
                                            pp.PaymentAmount
                                         FROM 
                                            PawnPayments pp
                                         WHERE
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(pawnPaymentQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnPaymentTable = new DataTable();
                        dataAdapter.Fill(pawnPaymentTable);
                        connection.Close();
                        return pawnPaymentTable;
                    }
                }
            }
        }

        public DataTable GetPawnChargeHistory(string transactionID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string getPawnChargeQuery = @"SELECT
											    pc.ChargeDate,
                                                pc.ChargeAmount
											FROM 
                                                PawnCharges pc
											WHERE
												pc.TransactionID = @transactionID";

                using (SqlCeCommand command = new SqlCeCommand(getPawnChargeQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable transactionChargeTable = new DataTable();
                        dataAdapter.Fill(transactionChargeTable);
                        connection.Close();
                        return transactionChargeTable;
                    }
                }
            }
        }

        public double GetCurrentPrincipal(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                DataTable chargePrincipalTable = new DataTable();
                DataTable paymentPrincipalTable = new DataTable();
                Dictionary<DateTime, double> currentPrincipalDic = new Dictionary<DateTime, double>();
                DateTime transactionDate;
                double currentPrincipal;
                double maxPrincipalAmount;

                connection.Open();

                string getChargePrincipalQuery = @"SELECT
                                                    pc.ChargeDate,
										            pc.NewPrincipal
									            FROM 
                                                    PawnCharges pc
										        WHERE 
                                                    pc.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getChargePrincipalQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {

                        dataAdapter.Fill(chargePrincipalTable);
                        connection.Close();

                        for (int i = 0; i < chargePrincipalTable.Rows.Count; i++)
                        {
                            transactionDate = Convert.ToDateTime(chargePrincipalTable.Rows[i]["ChargeDate"]);
                            currentPrincipal = Convert.ToDouble(chargePrincipalTable.Rows[i]["NewPrincipal"]);
                            currentPrincipalDic.Add(transactionDate, currentPrincipal);
                        }
                    }
                }

                connection.Open();

                string getPaymentPrincipalQuery = @"SELECT
                                                          pp.PaymentDate,
										                  pp.NewPrincipal
									                   FROM 
                                                          PawnPayments pp
										               WHERE 
                                                          pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(getPaymentPrincipalQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {

                        dataAdapter.Fill(paymentPrincipalTable);
                        connection.Close();

                        for (int i = 0; i < paymentPrincipalTable.Rows.Count; i++)
                        {
                            transactionDate = Convert.ToDateTime(paymentPrincipalTable.Rows[i]["PaymentDate"]);
                            currentPrincipal = Convert.ToDouble(paymentPrincipalTable.Rows[i]["NewPrincipal"]);
                            currentPrincipalDic.Add(transactionDate, currentPrincipal);
                        }
                    }
                }

                KeyValuePair<DateTime,double> max = new KeyValuePair<DateTime,double>();
                foreach (var kvp in currentPrincipalDic)
                {
                    if (kvp.Key > max.Key)
                    {
                        max = kvp;
                    }
                }

                maxPrincipalAmount = max.Value;

                return maxPrincipalAmount;
            }
        }

        public void InsertNewPayment(string transactionID, string paymentDate, string paymentAmount,
                                       string newPrincipal)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string insertNewPaymentQuery = @"INSERT INTO PawnPayments VALUES(@transactionID,@paymentDate,
                                                 @paymentAmount,@newPrincipal)";
                using (SqlCeCommand command = new SqlCeCommand(insertNewPaymentQuery, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);
                    command.Parameters.AddWithValue("@paymentDate", paymentDate);
                    command.Parameters.AddWithValue("@paymentAmount", paymentAmount);
                    command.Parameters.AddWithValue("@newPrincipal", newPrincipal);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        public void UpdatePawnToClosed(string transactionID)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string updateToDefault = @"Update Pawn
											SET Status = 'Closed'
											WHERE TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(updateToDefault, connection))
                {
                    command.Parameters.AddWithValue("@transactionID", transactionID);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        #endregion

        #region Create a Pawn Payment Receipt

        public DataTable GetPawnPaymentReceiptData(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnPaymentInfoQuery = @"SELECT
                                            pp.TransactionID,
                                            pp.PaymentDate,
                                            pp.PaymentAmount
                                         FROM 
                                            PawnPayments pp
                                         WHERE
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(pawnPaymentInfoQuery, connection))
                {

                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnPaymentInfoTable = new DataTable();
                        dataAdapter.Fill(pawnPaymentInfoTable);
                        connection.Close();
                        return pawnPaymentInfoTable;
                    }
                }
            }
        }

        public DataTable GetPawnCurrentPrincipal(string transactionId)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();

                string pawnPaymentInfoQuery = @"SELECT
                                            MIN(pp.NewPrincipal) AS CurrentPrincipal
                                         FROM 
                                            PawnPayments pp
                                         WHERE
                                            pp.TransactionID = @transactionID";
                using (SqlCeCommand command = new SqlCeCommand(pawnPaymentInfoQuery, connection))
                {

                    command.Parameters.AddWithValue("@transactionID", transactionId);

                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable pawnPaymentInfoTable = new DataTable();
                        dataAdapter.Fill(pawnPaymentInfoTable);
                        connection.Close();
                        return pawnPaymentInfoTable;
                    }
                }
            }
        }

        #endregion

        #region Create a Layaway Transaction




        #endregion
    }
}
