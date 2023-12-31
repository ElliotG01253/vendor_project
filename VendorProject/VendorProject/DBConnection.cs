﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace VendorProject
{
    internal class DBConnection
    {
        private static DBConnection? _instance;
        private string connectionStringA;
        private string connectionStringV;
        private SqlConnection? connectionToDB;

        private DBConnection()
        {
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C: \\Users\\eg593\\AppData\\Local\\Development\\vendor_project\\VendorProject\\VendorProject\\accountInfo.mdf";

                connectionStringA = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Madin\\Source\\Repos\\vendor_project\\VendorProject\\VendorProject\\accountInfo.mdf;Integrated Security=True";


                connectionStringV = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Madin\\source\\repos\\vendor_project\\VendorProject\\VendorProject\\Vendor_Information.mdf;Integrated Security=True";

            
            //connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\accountInfo.mdf;Integrated Security=True;";
            //connectionString = Properties.Settings.Default.DBConnectionString;
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

        public DataSet GetDataSet(string db,string sqlStatement)
        {
            string connectionString;
            if (db == "A")
            {
                connectionString = connectionStringA;
            }else if (db == "V") 
            {
                connectionString = connectionStringV;
            }
            else
            {
                connectionString = "";
            }

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
        /// <summary>
        /// creates an account with username and password and sets the group to standard user
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <exception cref="Exception"></exception>
        public void SetAccount(string username, string password)
        {
            // hashing the password
            Hasher hasher = new Hasher();
            password = hasher.HashThis(password);
            try
            {
                if (username != "")
                {
                    if (UNIsUnique(username))
                    {
                        using (connectionToDB = new SqlConnection(connectionStringA))
                        {
                            GetDBConnection();
                            connectionToDB.Open();
                            // insert a row at the bottom of the users table with username and password filled in, id will automatically be filled because it is an identity column
                            string sqlStatement = $"INSERT INTO Users (UserName, Password) VALUES ('{username}', '{password}');";
                            using (var cmd = new SqlCommand(sqlStatement, connectionToDB))
                            {
                                cmd.ExecuteNonQuery();
                            }
                            // finds the last inputed id by ordering by id decending and limiting the results to the top one
                            // then adds it to Groups users table with the default group id 1
                            sqlStatement = "INSERT INTO Groups_Users (Users_Id) SELECT TOP 1 Id From Users ORDER BY ID DESC;";
                            using (var cmd = new SqlCommand(sqlStatement, connectionToDB))
                            {
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("error creating user: Username already in use");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("error creating user: " + ex.Message);
            }
            finally
            {
                if (connectionToDB != null && connectionToDB.State == ConnectionState.Open)
                {
                    connectionToDB.Close();
                }
            }
        }
        /// <summary>
        /// verifies if the given username is already in the user table
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        private bool UNIsUnique(string username)
        {
            bool unique = true;
            DataSet ds = DBConnection.GetDBConnection().GetDataSet("A", $"SELECT Username FROM Users where Username = '{username}'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                unique = false;
            }
            return unique;
        }
        /// <summary>
        /// Changes the group asigned to the user
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="group"></param>
        /// <exception cref="Exception"></exception>
        public void RightsChanger(int userId, int group)
        {
            try
            {
                using (connectionToDB = new SqlConnection(connectionStringA))
                {
                    connectionToDB.Open();
                    string sqlStatement = $"UPDATE Groups_Users SET Groups_Id = '{group}' where Users_Id = '{userId}'";
                    using (var cmd = new SqlCommand(sqlStatement, connectionToDB))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                if (connectionToDB != null && connectionToDB.State == ConnectionState.Open)
                {
                    connectionToDB.Close();
                }
            }
        }
    }
}

