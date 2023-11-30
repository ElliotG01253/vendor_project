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
        /// <summary>
        /// Take the input username and password and checks they are in the Database then sets the user class
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        public void loginVerification(string username, string password)
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet("SELECT * FROM Users");
            DataTable dt = ds.Tables[0];
            DataRow[] dr = dt.Select();
            foreach (DataRow dataRow in dr)
            {
                if (dataRow[1].ToString()!.Trim() == username)
                {
                    if (dataRow[2].ToString()!.Trim() == password)
                    {
                        //set a class "user" account info 
                        setUser(username, int.Parse(dataRow[0].ToString()!));
                    }
                }
            }
        }

        private void setUser(string username, int userId)
        {
            DataSet ds = DBConnection.GetDBConnection().GetDataSet($"SELECT g.name FROM groups_users gu , groups g where g.id = gu.groups_id AND gu.users_id = {userId}");
             User user = new User();
            user.setter(userId, ds.Tables[0].Rows[0]["group"].ToString()!);

        }   
    }
}
