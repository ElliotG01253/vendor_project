using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VendorProject
{
    internal class loginVerify
    {
        private int userID;

        /// <summary>
        /// Take the input username and password and checks they are in the Database then sets the user class
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void LoginVerification(string username, string password)
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet($"SELECT * FROM Users where Username = '{username}'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                Hasher hasher = new Hasher();
                password = hasher.HashThis(password);
                if (hasher.isEqual(password, ds.Tables[0].Rows[0]["Password"].ToString()!))
                {
                    userID = int.Parse(ds.Tables[0].Rows[0]["id"].ToString()!);
                    User.Setter(userID, GetUserGroup());
                }
                else
                {
                    MessageBox.Show("Invalid Login Details");
                }
            }
            else
            {
                MessageBox.Show("Invalid Login Details");
            }
        }
        private string GetUserGroup()
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet($"SELECT g.name FROM groups_users gu , groups g where g.id = gu.groups_id AND gu.users_id = {userID}");

            string groupname = ds.Tables[0].Rows[0]["name"].ToString()!.Trim();
            return groupname;
        }
        public void RegisterUser(string username, string password)
        {
            DBConnection.GetDBConnection().SetAccount(username, password);
        }
    }
}
