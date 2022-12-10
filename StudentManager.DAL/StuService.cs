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
    public class StuService
    {
        public bool Add(Students stu)
        {
            string sqlStr = "insert into BasicInfomation (学号,姓名) values(@学号,@姓名)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@学号",stu.Mid),
                new SqlParameter("@姓名",stu.Mname),
                

            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Update(Students stu)
        {
            string sqlStr = "update StudentInfo set 姓名=@姓名,性别=@性别,身份证号=@身份证号,班级=@班级,联系电话=@联系电话,户籍地址=@户籍地址 where 学号=@学号";

            SqlParameter[] param = new SqlParameter[]
            {
               
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Delete(Students stu)
        {

            string str = "delete From BasicInfomation where 学号 = @学号";
            string str2 = "delete From User2 where 学号 = @学号";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@学号",stu.Mid)
            };

            return DBHelper.ExcuteCommand(str, param);
        }

        public bool Deleteu(Students stu)
        {
            string str = "delete From User2 where 学号 = @学号";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@学号",stu.Mid)
            };

            return DBHelper.ExcuteCommand(str, param);
        }

        public DataTable getOne(string a)
        {
            string strsql =string.Format("select * from BasicInfomation where 学号='{0}'", a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }


        public DataTable getAll()
        {
            string strsql = "select * from BasicInfomation";
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }
    }
}
