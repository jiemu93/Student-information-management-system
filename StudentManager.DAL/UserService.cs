using StudentManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.DAL
{
   public class UserService
    {
        public static bool ValidataUser(User u)
        {
            string sqlstr = "select id from[User1]where(id=@id)and(pwd=@pwd)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@id",u.ID),
                new SqlParameter("@pwd",u.Pwd)
            };
            DataTable dt = DBHelper.GetDataTable(sqlstr, param);
            if (dt.Rows.Count != 0)
                return true;
            else
                return false;
        }

        public static bool ValidataUsera(User p)
        {
            string sqlstr2 = "select 学号 from[User2]where(学号=@id)and(pwd=@pwd)";
            SqlParameter[] param2 = new SqlParameter[]
            {
                new SqlParameter("@id",p.ID),
                new SqlParameter("@pwd",p.Pwd)
            };
            DataTable dt2 = DBHelper.GetDataTable(sqlstr2, param2);
            if (dt2.Rows.Count != 0)
                return true;
            else
                return false;
        }
    }
}
