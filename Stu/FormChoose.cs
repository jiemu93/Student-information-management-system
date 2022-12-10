using System;
using System.Windows.Forms;
using StudentManager.BLL;
using StudentManager.Models;

namespace Stu
{
    public partial class FormChoose : Form
    {
        CourseManage sm = new CourseManage();
        Verification ver = new Verification();
        public FormChoose()
        {
            InitializeComponent();
        }

        string a = "";
        private void CK()
        {
            if ( txt_test.Text.Trim().Equals("") || txt_teacher.Text.Trim().Equals("")
                || txt_time.Text.Trim().Equals("") || txt_place.Text.Trim().Equals("") || txt_score.Text.Trim().Equals("") || txt_score.Text.Trim().Equals(""))
            {
                MessageBox.Show("请输入信息");
                return;
            }
            
        }

        private void Clear()
        {
           // txt_N.Text = "";
            txt_test.Text = "";
            txt_teacher.Text = "";
            txt_time.Text = "";
            txt_place.Text = "";
            txt_score.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }


        private void FormChoose_Load(object sender, EventArgs e)
        {
            GetAll();
        }

        private void dataGridView_Choose_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_Choose.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            a = dataGridView_Choose.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView_Choose.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView_Choose.SelectedRows[0].Cells[2].Value.ToString();
            txt_test.Text = dataGridView_Choose.SelectedRows[0].Cells[3].Value.ToString();
            txt_teacher.Text = dataGridView_Choose.SelectedRows[0].Cells[4].Value.ToString();
            txt_time.Text = dataGridView_Choose.SelectedRows[0].Cells[5].Value.ToString();
            txt_place.Text = dataGridView_Choose.SelectedRows[0].Cells[6].Value.ToString();
            txt_score.Text = dataGridView_Choose.SelectedRows[0].Cells[7].Value.ToString();
   
        }

        public void GetAll()
        {
            dataGridView_Choose.DataSource = sm.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                if (!ver.IsNumber(txt_score.Text))
                {
                    MessageBox.Show("非法输入");
                    return;
                }
                if (txt_test.Text.Trim().Equals("") || txt_teacher.Text.Trim().Equals("")
                || txt_time.Text.Trim().Equals("") || txt_place.Text.Trim().Equals("") || txt_score.Text.Trim().Equals("") || txt_score.Text.Trim().Equals(""))
                {
                    MessageBox.Show("请输入信息");
                    return;
                }
                else
                {
                    //int Fcourse1 = int.Parse(a);
                    string Funiversity2 = comboBox1.Text;
                    string Fmajor3 = comboBox2.Text;
                    string Fclass4 = txt_test.Text;
                    string Fteacher5 = txt_teacher.Text;
                    string Ftime6 = txt_time.Text;
                    string Fplace7 = txt_place.Text;
                    string Fscore8 = txt_score.Text;
                    Courses stu = new Courses { Munversity2 = Funiversity2, Mmajor3 = Fmajor3, Mclass4 = Fclass4, Mteacher5 = Fteacher5, Mtime6 = Ftime6, Mplace7 = Fplace7, Mscore8 = Fscore8 };
                    bool result = sm.Add(stu);
                    if (result)
                    {
                        MessageBox.Show("添加成功");
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("添加失败，课程编号重复！");
                    }
                    Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("添加失败");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                

                if (!ver.IsNumber(txt_score.Text) )
                {
                    MessageBox.Show("非法输入");
                    return;
                }
                if (txt_test.Text.Trim().Equals("") || txt_teacher.Text.Trim().Equals("")
                || txt_time.Text.Trim().Equals("") || txt_place.Text.Trim().Equals("") || txt_score.Text.Trim().Equals("") || txt_score.Text.Trim().Equals(""))
                {
                    MessageBox.Show("请输入信息");
                    return;
                }
                else
                {
                    int Fcourse1 = int.Parse(a);
                    string Funiversity2 = comboBox1.Text;
                    string Fmajor3 = comboBox2.Text;
                    string Fclass4 = txt_test.Text;
                    string Fteacher5 = txt_teacher.Text;
                    string Ftime6 = txt_time.Text;
                    string Fplace7 = txt_place.Text;
                    string Fscore8 = txt_score.Text;
                    Courses stu = new Courses { Mcourse1 = Fcourse1, Munversity2 = Funiversity2, Mmajor3 = Fmajor3, Mclass4 = Fclass4, Mteacher5 = Fteacher5, Mtime6 = Ftime6, Mplace7 = Fplace7, Mscore8 = Fscore8 };
                    bool result = sm.Update(stu);
                    if (result)
                    {
                        MessageBox.Show("修改成功");
                        GetAll();
                    }
                    else
                    {
                        MessageBox.Show("修改失败，课程编号重复！");
                    }
                    Clear();
                }
                
            }
            catch
            {
                MessageBox.Show("修改失败");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            try
            {
                int Fkcbh = int.Parse(textBox1.Text);
                if (!ver.IsCourseCode(textBox1.Text))
                {
                    MessageBox.Show("课程编号有误");
                    return;
                }
                
                    Courses stu = new Courses { Mcourse1 = Fkcbh };
                    bool result = sm.Delete(stu);
                    if (result)
                    {
                        MessageBox.Show("删除成功");
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                    }
                    GetAll();
                    Clear();
                
                    
               
            }
            catch
            {
                MessageBox.Show("删除失败");
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
