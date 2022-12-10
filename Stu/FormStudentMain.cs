using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManager.BLL;

namespace Stu
{
    public partial class FormStudentMain : Form
    {
         SqlDataAdapter da;
         string strcon = UserManage.a;
        public FormStudentMain()
        {
            InitializeComponent();
        }
        public string SendNameValue;
        public FormStudentMain(string strName)
        {
            InitializeComponent();
            SendNameValue = strName;
        }

        private void 课程选课ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = SendNameValue;
            //this.Close();
            FormStuchoose mainForm = new FormStuchoose(a);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void 基本信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string a = SendNameValue;
            //this.Hide();
            FormStuBasicInfo mainForm = new FormStuBasicInfo(a);
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        

        private void FormStudentMain_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "当前账号：" + SendNameValue;
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string sql = string.Format("select * from BasicInfomation where 学号='{0}'", SendNameValue);
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int id = (int)reader["学号"];
                string name = (String)reader["姓名"];
                label4.Text = name;
            }
        }


        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("确定要退出吗！！", "退出", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                this.Close();
                login mainForm = new login();
                mainForm.StartPosition = FormStartPosition.CenterScreen;
                mainForm.Show();
            }
        }
    }
}
