using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal class User
    {
        public int id;
        public string? group;

        public void setter(int userId, string userGroup)
        {
            id = userId;
            group = userGroup;
        }
        public int getUserId() { return id; }
        public string getGroup() { return group!; }
    }
}
