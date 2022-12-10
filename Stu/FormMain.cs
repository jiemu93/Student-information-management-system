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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void MenuUpdate_Click(object sender, EventArgs e)
        {
            //this.Close();
            FormRevise mainForm = new FormRevise();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void MenuChoose_Click(object sender, EventArgs e)
        {
            //this.Close();
            FormChoose mainForm = new FormChoose();
            mainForm.StartPosition = FormStartPosition.CenterScreen;
            mainForm.Show();
        }

        private void MenuExit_Click(object sender, EventArgs e)
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

        private void MenuiInfomation_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
}
