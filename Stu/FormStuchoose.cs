using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentManager.BLL;

namespace Stu
{
    public partial class FormStuchoose : Form
    {
        SqlDataAdapter da;
        string strcon = UserManage.a;
        string strsql = "select * from Test";
        public string SendNameValue;
        public FormStuchoose(string strName)
        {
            InitializeComponent();
            da = new SqlDataAdapter(strsql, strcon);
            SendNameValue = strName;
        }

        private DataTable getData()
        {
            DataSet dt = new DataSet(); 
            da.Fill(dt);
            return dt.Tables[0];
        }


       
        private void btn_sure_Click(object sender, EventArgs e)
        {
            if (txt_N.Text.Trim().Equals(""))
            {
                MessageBox.Show("请先选择课程");
                return;
            }


            SqlConnection conn1 = new SqlConnection(strcon);
            string str1 = "select count(*) from Stuchoose where 课程编号=@课程编号";
            SqlCommand cmd1 = new SqlCommand(str1, conn1);
            cmd1.Parameters.Add(new SqlParameter("@课程编号", txt_N.Text));
            conn1.Open();

            if ((int)cmd1.ExecuteScalar() > 0)
            {
                MessageBox.Show("课程已选");
                return;
            }

            try
            {
               
                string sql = @"insert into Stuchoose (学号,课程编号,学院,专业,课程名称,授课教师,上课时间,教室,学分) values(@学号,@课程编号,@学院,@专业,@课程名称,@授课教师,@上课时间,@教室,@学分)";
                using (SqlConnection conn = new SqlConnection(strcon))
                {
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //cmd.Parameters.Add(new SqlParameter("@学号", b));
                    //cmd.Parameters.Add(new SqlParameter("@姓名", c));
                    cmd.Parameters.Add(new SqlParameter("@学号", SendNameValue));
                    cmd.Parameters.Add(new SqlParameter("@学院", textBox34.Text));
                    cmd.Parameters.Add(new SqlParameter("@专业", textBox33.Text));
                    cmd.Parameters.Add(new SqlParameter("@课程名称", txt_classna.Text));
                    cmd.Parameters.Add(new SqlParameter("@课程编号", txt_N.Text));
                    cmd.Parameters.Add(new SqlParameter("@学分", textBox28.Text));
                    cmd.Parameters.Add(new SqlParameter("@授课教师", textBox31.Text));
                    cmd.Parameters.Add(new SqlParameter("@上课时间", textBox30.Text));
                    cmd.Parameters.Add(new SqlParameter("@教室", textBox29.Text));
                    conn.Open();
                    if (cmd.ExecuteNonQuery() > 0)
                        MessageBox.Show("选课成功");
                    this.FormStuchoose_Load(sender, e);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void FormStuchoose_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = getData();
            string a = SendNameValue;
            string strsq = string.Format("select * from Stuchoose where 学号={0}",a);
            SqlDataAdapter d = new SqlDataAdapter(strsq, strcon);
            DataSet dv = new DataSet();
            d.Fill(dv);
            dataGridView2.DataSource = dv.Tables[0];
            this.toolStripStatusLabel1.Text = "当前账号："+a;
           

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)		//用于判断是否选中了DataGridView中的一行
            {
                MessageBox.Show("请选中一行进行操作");
                return;
            }
            DataSet dt = new DataSet(); ;
            da.Fill(dt);

            txt_N.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox34.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox33.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txt_classna.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox31.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox30.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox29.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox28.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }



        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int i = dataGridView2.CurrentRow.Index;
                string sqlDel = string.Format("delete from Stuchoose where 课程编号={0}", textBox1.Text);
                SqlConnection conn1 = new SqlConnection(strcon);
                SqlCommand cmd1 = new SqlCommand(sqlDel, conn1);
                cmd1.Parameters.Add(new SqlParameter("@id", txt_classna.Text));
                conn1.Open();
                if ((int)cmd1.ExecuteNonQuery() > 0)
                    MessageBox.Show("退课成功");
                this.FormStuchoose_Load(sender,e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("退课失败");

            }
        }

    }
}
