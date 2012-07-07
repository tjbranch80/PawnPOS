using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;


namespace POS
{
    internal class ReportDataManager
    {
    
        #region Global Components

        string connectionString;

        public ReportDataManager(string connectionString)
        {
            this.connectionString = connectionString;
        }

        #endregion


        #region Report Method Queries

        public DataTable DefaultPawnReport(DateTime date)
        {
            using (System.Data.SqlServerCe.SqlCeConnection connection = new SqlCeConnection(connectionString))
            {
                connection.Open();
                string defaultPawnReportQuery = @"SELECT * 
                                                FROM Pawn p
                                                WHERE p.Status = 'Default'
                                                AND p.DateDefaulted = @date";

                using (SqlCeCommand command = new SqlCeCommand(defaultPawnReportQuery, connection))
                {
                    command.Parameters.AddWithValue("@date", date);


                    using (SqlCeDataAdapter dataAdapter = new SqlCeDataAdapter(command))
                    {
                        DataTable defaultPawnData = new DataTable();
                        dataAdapter.Fill(defaultPawnData);
                        connection.Close();
                        return defaultPawnData;
                    }
                }
            }
        }

        #endregion
    }
}
