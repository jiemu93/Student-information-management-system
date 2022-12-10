using StudentManager.BLL;
using StudentManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stu
{
    public partial class login : Form
    {
        public static login mainfrm = null; 
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (rdo_student.Checked)
            {
                if (txt_number.Text.Trim() == "" || txt_password.Text.Trim() == "")
                    MessageBox.Show("用户名或密码为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    User p = new User(txt_number.Text.Trim(), txt_password.Text.Trim());
                    if (UserManage.ValidataUsera(p))
                    {
                        this.Hide();
                        FormStudentMain mainForm = new FormStudentMain(txt_number.Text);
                        mainForm.StartPosition = FormStartPosition.CenterScreen;
                        mainForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_password.Text = "";
                    }

                }
                return;
            }

            if (rdo_teacher.Checked)
            {
                if (txt_number.Text.Trim() == "" || txt_password.Text.Trim() == "")
                    MessageBox.Show("用户名或密码为空！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    User u = new User(txt_number.Text.Trim(), txt_password.Text.Trim());
                    if (UserManage.ValidataUser(u))
                    {
                        this.Hide();
                        FormMain mainForm = new FormMain();
                        mainForm.StartPosition = FormStartPosition.CenterScreen;
                        mainForm.Show();

                    }
                    else
                    {
                        MessageBox.Show("用户名或密码错误！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txt_password.Text = "";
                    }

                }
                return;
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {
            txt_password.PasswordChar = '*';
        }
    }
}
