using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal class User
    {
        private int id;
        private string group;

        public void Setter(int userId, string userGroup)
        {
            id = userId;
            group = userGroup;
        }
        public int GetUserId() { return id; }
        public string GetGroup() { return group; }
    }
}
