using StudentManager.Models;
using StudentManager.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.BLL
{
    public class UserManage
    {
        public static string a = DBHelper.connString;
        public static bool ValidataUser(User u)
        {
            return UserService.ValidataUser(u);
        }

        public static bool ValidataUsera(User p)
        {
            return UserService.ValidataUsera(p);
        }
    }
}
