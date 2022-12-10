using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManager.Models
{
    public class User
    {
        public string ID { get; set; }
        public string Pwd { get; set; }
        public string Mname { get; set; }

        public User() { }
        public User(string userID, string userPwd)
        {
            this.ID = userID;
            this.Pwd = userPwd;
        }
    }
}
