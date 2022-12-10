using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManager.BLL;
using StudentManager.Models;


namespace Stu
{
    public partial class FormRevise : Form
    {
        

        public FormRevise()
        {
            InitializeComponent();
           
        }
        StuManage sm = new StuManage();
        Verification ver = new Verification();
        byte[] bytes;
        private void Clear()
        {
            txt_Number_Revise.Text = "";
            txt_Name_Revise.Text = "";
            label25.Text = "";
            label26.Text = "";
            label27.Text = "";
            label28.Text = "";
            label29.Text = "";
            label30.Text = "";
            label31.Text = "";
            label32.Text = "";
            label33.Text = "";
            pictureBox1.Image = null;
        }

        public void GetAll()
        {
            dataGridView_Revise.DataSource = sm.Select();
        }

       
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ver.IsStudentCode(txt_Number_Revise.Text))//验证手机号是否正确
            {
                MessageBox.Show("请输入4位学号！！！");
                return;
            }
            if (!ver.IsChinese(txt_Name_Revise.Text))//验证手机号是否正确
            {
                MessageBox.Show("姓名为中文哦！！！");
                return;
            }
            if (txt_Name_Revise.Text == "" || txt_Number_Revise.Text == "")
            {
                MessageBox.Show("请输入基本信息！");
                return ;
            }
            Regex regEx = new Regex("");
            if (regEx.Match(txt_Number_Revise.Text).Success)
            {
                //号码符合规范
            }
            else
            {
                //非法号码
            }
            int Fid = int.Parse(txt_Number_Revise.Text);
            string Fname = txt_Name_Revise.Text;
            Students stu = new Students { Mid = Fid, Mname = Fname };
            bool result = sm.Add(stu);
            if (result)
            {
                MessageBox.Show("添加成功");
                GetAll();
            }
            else
            {
                MessageBox.Show("添加失败，学号重复！");
            }
            Clear();
        }

        private void dataGridView_Revise_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Revise.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            txt_Number_Revise.Text = dataGridView_Revise.SelectedRows[0].Cells[0].Value.ToString();
            txt_Name_Revise.Text = dataGridView_Revise.SelectedRows[0].Cells[1].Value.ToString();
            label25.Text = dataGridView_Revise.SelectedRows[0].Cells[2].Value.ToString();
            label26.Text = dataGridView_Revise.SelectedRows[0].Cells[3].Value.ToString();
            label27.Text = dataGridView_Revise.SelectedRows[0].Cells[4].Value.ToString();
            label28.Text = dataGridView_Revise.SelectedRows[0].Cells[5].Value.ToString();
            label29.Text = dataGridView_Revise.SelectedRows[0].Cells[6].Value.ToString();
            label30.Text = dataGridView_Revise.SelectedRows[0].Cells[7].Value.ToString();
            label31.Text = dataGridView_Revise.SelectedRows[0].Cells[8].Value.ToString();
            label32.Text = dataGridView_Revise.SelectedRows[0].Cells[9].Value.ToString();
            label33.Text = dataGridView_Revise.SelectedRows[0].Cells[10].Value.ToString();
            if (dataGridView_Revise.SelectedRows[0].Cells[11].Value.ToString() == "")
            {
                pictureBox1.Image = null;
            }
            else
            {
                bytes = (byte[])dataGridView_Revise.SelectedRows[0].Cells[11].Value;
                pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void FormRevise_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void btn_Find_Revise_Click(object sender, EventArgs e)
        {
            if (!ver.IsStudentCode(txt_Number_Revise.Text))//验证手机号是否正确
            {
                MessageBox.Show("请输入正确学号！！！！");
                return;
            }
            dataGridView_Revise.DataSource = sm.SelectOne(txt_Number_Revise.Text);
            try
            {
                txt_Name_Revise.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["姓名"].ToString();
                label25.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["性别"].ToString();
                label26.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["民族"].ToString();
                label27.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["寝室号"].ToString();
                label28.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["政治面貌"].ToString();
                label29.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["邮政编码"].ToString();
                label30.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["联系电话"].ToString();
                label31.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["身份证号"].ToString();
                label32.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["常住地址"].ToString();
                label33.Text = sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["户籍地址"].ToString();
                if (sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["学生照片"].ToString() == "")
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    bytes = (byte[])sm.SelectOne(txt_Number_Revise.Text).DataSet.Tables[0].Rows[0]["学生照片"];
                    pictureBox1.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                Clear();
            }
            catch
            {
                MessageBox.Show("未找到信息！");
                Clear();
            }
            

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                int Fid = int.Parse(txt_Number_Revise.Text);

                Students stu = new Students { Mid = Fid };
                bool result = sm.Delete(stu);
                bool resultu = sm.Deleteu(stu);
                if (result&&resultu)
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
                GetAll();
                txt_Number_Revise.Text = "";
                txt_Name_Revise.Text = "";
                Clear();
            }
            catch
            {
                MessageBox.Show("删除失败");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAll();
            Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }
    }
}
