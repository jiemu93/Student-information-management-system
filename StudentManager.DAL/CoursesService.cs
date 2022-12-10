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
    public class CoursesService
    {
        public bool cAdd(Courses stu)
        {
            string sqlStr = "insert into Test (学院,专业,课程名称,授课教师,上课时间,教室,学分) values(@学院,@专业,@课程名称,@授课教师,@上课时间,@教室,@学分)";
            SqlParameter[] param = new SqlParameter[]
            {
                //new SqlParameter("@课程编号",stu.Mcourse1),
                new SqlParameter("@学院",stu.Munversity2),
                new SqlParameter("@专业",stu.Mmajor3),
                new SqlParameter("@课程名称",stu.Mclass4),
                new SqlParameter("@授课教师",stu.Mteacher5),
                new SqlParameter("@上课时间",stu.Mtime6),
                new SqlParameter("@教室",stu.Mplace7),
                new SqlParameter("@学分",stu.Mscore8),

            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }


        public bool testAdd(Courses stu)
        {
            string sqlStr = "insert into Test (课程编号) values(@课程编号)";
            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@课程编号",stu.Mcourse1),
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }


        public bool cUpdate(Courses stu)
        {
            string sqlStr = "update Test set 学院=@学院,专业=@专业,课程名称=@课程名称,授课教师=@授课教师,上课时间=@上课时间,教室=@教室,学分=@学分 where 课程编号=@课程编号";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@课程编号",stu.Mcourse1),
                new SqlParameter("@学院",stu.Munversity2),
                new SqlParameter("@专业",stu.Mmajor3),
                new SqlParameter("@课程名称",stu.Mclass4),
                new SqlParameter("@授课教师",stu.Mteacher5),
                new SqlParameter("@上课时间",stu.Mtime6),
                new SqlParameter("@教室",stu.Mplace7),
                new SqlParameter("@学分",stu.Mscore8),
            };
            return DBHelper.ExcuteCommand(sqlStr, param);
        }

        public bool Delete(Courses stu)
        {

            string str = "delete From test where  课程编号= @课程编号";

            SqlParameter[] param = new SqlParameter[]
            {
                new SqlParameter("@课程编号",stu.Mcourse1)
            };

            return DBHelper.ExcuteCommand(str, param);
        }


        public int DDy(int a)
        {
            SqlConnection conn1 = new SqlConnection(DBHelper.connString);
            string str1 = "select count(*) from Test where 课程编号=@课程编号";
            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            cmd1.Parameters.Add(new SqlParameter("@课程编号", a));
            conn1.Open();

            if ((int)cmd1.ExecuteScalar() < 0)
            {
                a = 0;
            }
            return a;
        }

        public DataTable getOne(string a)
        {
            string strsql = string.Format("select * from test where 课程编号='{0}'", a);
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }

        public DataTable getAll()
        {
            string strsql = "select * from Test";
            SqlDataAdapter da = new SqlDataAdapter(strsql, DBHelper.connString);
            DataSet dt = new DataSet();
            da.Fill(dt);
            return dt.Tables[0];
        }
    }
}
