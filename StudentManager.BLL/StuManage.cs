using StudentManager.DAL;
using StudentManager.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.BLL
{
    public class StuManage
    {
        StuService ss = new StuService();
        public bool Add(Students stu)
        {
            return ss.Add(stu);
        }
        public bool Update(Students stu)
        {
            return ss.Update(stu);
        }
        public bool Delete(Students stu)
        {
            return ss.Delete(stu);
        }

        public bool Deleteu(Students stu)
        {
            return ss.Deleteu(stu);
        }

        public DataTable Select()
        {
            return ss.getAll();
        }

        public DataTable SelectOne(string str)
        {
            return ss.getOne(str);
        }
    }
}
