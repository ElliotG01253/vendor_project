using System;
using System.Data;
using System.Data.SqlClient;

namespace VendorProject
{
    internal class DBConnection
    {
        private static DBConnection? _instance;
        private string connectionString;
        private SqlConnection? connectionToDB;

        private DBConnection()
        {
            // Using SQL Server authentication
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=Vendor_Information;User ID=yourUsername;Password=yourPassword;Connect Timeout=30";
        }

        public static DBConnection GetDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }

        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dataSet = new DataSet();
            try
            {
                using (connectionToDB = new SqlConnection(connectionString))
                {
                    connectionToDB.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);
                    dataAdapter.Fill(dataSet);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error accessing the database: " + ex.Message);
            }
            finally
            {
                if (connectionToDB != null && connectionToDB.State == ConnectionState.Open)
                {
                    connectionToDB.Close();
                }
            }
            return dataSet;
        }
    }
}
