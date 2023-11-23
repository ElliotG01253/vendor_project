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
        private DBConnection()
        {
            connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Vendor_group_project\\vendor_project\\VendorProject\\VendorProject\\accountInfo.mdf;Integrated Security=True";
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\accountInfo.mdf;Integrated Security=True;";
            //connectionString = Properties.Settings.Default.DBConnectionString;
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
