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
    public class CourseManage
    {
        CoursesService cs = new CoursesService();
        public bool Add(Courses stu)
        {
            return cs.cAdd(stu);
        }
        public bool Update(Courses stu)
        {
            return cs.cUpdate(stu);
        }
        public bool TestAdd(Courses stu)
        {
            return cs.testAdd(stu);
        }

        public bool Delete(Courses stu)
        {
            return cs.Delete(stu);
        }

        public int DDY(int a)
        {
            return cs.DDy(a);
        }
        public DataTable Select()
        {
            return cs.getAll();
        }

        public DataTable SelectOne(string str)
        {
            return cs.getOne(str);
        }
    }
}
