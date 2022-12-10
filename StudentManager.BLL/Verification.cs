using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.BLL
{
    public class Verification
    {
        public bool IsHandset(string str_handset)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_handset, @"^[1]+[3,8,5]+\d{9}$");
        }
        public bool IsChinese(string str_chinese)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_chinese, @"^[\u4e00-\u9fa5]{0,}$");
        }

        public bool IsPostalcode(string str_postalcode)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_postalcode, @"^\d{6}$");
        }

        public bool IsCourseCode(string str_postalcode)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_postalcode, @"^\d{7}$");
        }

        public bool IsStudentCode(string str_postalcode)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_postalcode, @"^\d{4}$");
        }

         public bool IsNumber(string str_postalcode)
        {
            return System.Text.RegularExpressions.Regex.
                IsMatch(str_postalcode, @"^[0-9]*$");
        }
    }
}
