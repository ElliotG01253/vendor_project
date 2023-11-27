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
        public void loginVerification(string username, string password)
        {
            // to help me :https://learn.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-8.0
            DataSet ds = DBConnection.GetDBConnection().GetDataSet("SELECT * FROM loginInfo");
            DataTable dt = ds.Tables[0];
            DataRow[] dr = dt.Select();
            foreach (DataRow dataRow in dr)
            {
                if (dataRow[1].ToString() == username)
                {
                    if (dataRow[2].ToString() == password)
                    {
                        //set a class "user" account info 
                    }
                }
            }
        }
    }
}
