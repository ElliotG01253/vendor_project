using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendorProject
{
    internal static class User
    {
        private static int id;
        private static string group;

        public static void Setter(int userId, string userGroup)
        {
            id = userId;
            group = userGroup;
        }
        public static int GetUserId() { return id; }
        public static string GetGroup() { return group; }
    }
}
