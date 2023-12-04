using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal class loginVerify
    {
        private int userID;
        bool verified;
        /// <summary>
        /// Take the input username and password and checks they are in the Database then sets the user class
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public bool LoginVerification(string username, string password)
        {
            verified = false;
            DataSet ds = DBConnection.GetDBConnection().GetDataSet("SELECT * FROM Users");
            DataTable dt = ds.Tables[0];
            DataRow[] dr = dt.Select();
            foreach (DataRow dataRow in dr)
            {
                if (dataRow[1].ToString()!.Trim() == username)
                {
                    if (dataRow[2].ToString()!.Trim() == password)
                    {
                        string tempstr = dataRow[0].ToString();
                        //set a class "user" account info 
                        userID = int.Parse(dataRow[0].ToString());
                        GetUserGroup();
                        verified = true;
                    }
                }
            }
            return verified;
        }

        public string GetUserGroup()
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet($"SELECT g.name FROM groups_users gu , groups g where g.id = gu.groups_id AND gu.users_id = {userID}");

            string groupname = ds.Tables[0].Rows[0]["name"].ToString()!.Trim();
            return groupname;
        }
        public int GetUserId()
        {
            return userID;
        }
    }
}
