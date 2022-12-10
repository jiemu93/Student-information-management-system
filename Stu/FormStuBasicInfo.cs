using System;
using StudentManager.BLL;
using StudentManager.Models;
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
    public partial class FormStuBasicInfo : Form
    {
        byte[] bytes;
        string strcon = UserManage.a;
        IDCardValidation card = new IDCardValidation();
        Verification ver = new Verification();
        public string SendNameValue1;
        public FormStuBasicInfo(string strName)
        {
            InitializeComponent();
            SendNameValue1 = strName;
        }

        private void FormStuBasicInfo_Load(object sender, EventArgs e)
        {
            string a = SendNameValue1;
            txtStuNo.Text = a;
            int b = int.Parse(a);
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            string sql = string.Format("select * from BasicInfomation where 学号='{0}'", b);
            SqlCommand command = new SqlCommand(sql, con);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string name = (String)reader["姓名"];
                txtStuName.Text += String.Format("{0}", name);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           

            SqlConnection conn = new SqlConnection(strcon);
            try
            {
                if (cboxStuNation.Text.Trim().Equals("") || textBox2.Text.Trim().Equals("")
                || comboBox1.Text.Trim().Equals("") || txtStuContact.Text.Trim().Equals("") 
                || txtStuPostCode.Text.Trim().Equals("") || textBox3.Text.Trim().Equals("")
                || txtStuFamilyAddress.Text.Trim().Equals("") || textBox1.Text.Trim().Equals("")
                )
                {
                    MessageBox.Show("请输入完整信息");
                    return;
                }
                if (!ver.IsHandset(txtStuContact.Text))//验证手机号是否正确
                {
                    MessageBox.Show("手机号不正确!!!");
                    return;
                }

                
                bool result = card.CheckIDCard(textBox3.Text);  //验证身份证
                if (result)
                {

                }
                else
                {
                    MessageBox.Show("身份证号不正确!!!");
                    return;
                }
   
                if (!ver.IsChinese(txtStuFamilyAddress.Text.Trim())|| !ver.IsChinese(textBox1.Text.Trim()))//验证字符串是否为汉字
                {
                    MessageBox.Show("地址输入的不是中文!!!", "提示");
                    return;
                }

                if (!ver.IsPostalcode(txtStuPostCode.Text))//验证邮编格式是否正确
                {
                    MessageBox.Show("邮政编号不正确!!!");
                    return;
                }

                string sex = "";
                if(radioButton1.Checked)
                {
                    sex = radioButton1.Text;
                }
                else
                {
                    sex = radioButton2.Text;
                }

                string str1 = "update BasicInfomation set 姓名=@a,性别=@s,民族=@d,寝室号=@f,政治面貌=@g,联系电话=@h,邮政编码=@j,身份证号=@k,常住地址=@l,户籍地址=@z,学生照片=@x where 学号=@q";
                SqlCommand cmd = new SqlCommand(str1, conn);
                cmd.Parameters.Add(new SqlParameter("@q", txtStuNo.Text));
                cmd.Parameters.Add(new SqlParameter("@a", txtStuName.Text));
                cmd.Parameters.Add(new SqlParameter("@s", sex));
                cmd.Parameters.Add(new SqlParameter("@d", cboxStuNation.Text));
                cmd.Parameters.Add(new SqlParameter("@f", textBox2.Text));
                cmd.Parameters.Add(new SqlParameter("@g", comboBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@h", txtStuContact.Text));
                cmd.Parameters.Add(new SqlParameter("@j", txtStuPostCode.Text));
                cmd.Parameters.Add(new SqlParameter("@k", textBox3.Text));
                cmd.Parameters.Add(new SqlParameter("@l", txtStuFamilyAddress.Text));
                cmd.Parameters.Add(new SqlParameter("@z", textBox1.Text));
                cmd.Parameters.Add(new SqlParameter("@x", bytes));
                conn.Open();
                if (cmd.ExecuteNonQuery() > 0)
                    MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("失败");
                //MessageBox.Show(ex.Message);
                MessageBox.Show("请上传照片");
            }
            finally
            {
                conn.Close();
            } 
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "请选择客户端longin的图片";
            openfile.Filter = "Login图片(*.jpg;*.bmp;*png)|*.jpeg;*.jpg;*.bmp;*.png|AllFiles(*.*)|*.*";
            if (DialogResult.OK == openfile.ShowDialog())
            {
                try
                {
                    //读成二进制
                    bytes = File.ReadAllBytes(openfile.FileName);
                    //直接返这个存储到数据就行了cmd.Parameters.Add("@image", SqlDbType.Image).Value = bytes;
                    //输出二进制 在这里把数据中取到的值放在这里byte[] bytes=(byte[])model.image;
                    picBoxStuPhoto.Image = System.Drawing.Image.FromStream(new MemoryStream(bytes));
                    picBoxStuPhoto.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch { }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
