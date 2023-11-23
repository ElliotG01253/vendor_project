using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal class DBConnection
    {
        private static DBConnection? _instance;
        private string connectionString;
        private SqlConnection? connectionToDB;
        /// <summary>
        /// gets the connection string from project settings
        /// </summary>
        private DBConnection()
        {

            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C: \\Users\\eg593\\AppData\\Local\\Development\\vendor_project\\VendorProject\\VendorProject\\accountInfo.mdf";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Vendor_group_project\\vendor_project\\VendorProject\\VendorProject\\accountInfo.mdf;Integrated Security=True";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\accountInfo.mdf;Integrated Security=True;";
            connectionString = Properties.Settings.Default.DBConnectionString;
        }
        /// <summary>
        /// method to check if there is allready an instance of the database connection and if there is it just returns the DB connection string
        /// </summary>
        /// <returns>DBConnection</returns>
        public static DBConnection GetDBConnection()
        {
            if (_instance == null)
            {
                _instance = new DBConnection();
            }
            return _instance;
        }
        /// <summary>
        /// method creates a dataset and fills it with data determined by the sql Statement given in the method
        /// </summary>
        /// <param name="sqlStatement"></param>
        /// <returns>DataSet</returns>
        public DataSet GetDataSet(string sqlStatement)
        {
            DataSet dataSet = new DataSet();
            using (connectionToDB = new SqlConnection(connectionString))
            {
                connectionToDB.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

                dataAdapter.Fill(dataSet);
                connectionToDB.Close();
            }
            return dataSet;
        }
    }
}
