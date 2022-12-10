namespace Stu
{
    partial class login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdo_student = new System.Windows.Forms.RadioButton();
            this.rdo_teacher = new System.Windows.Forms.RadioButton();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_number = new System.Windows.Forms.TextBox();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdo_student);
            this.panel1.Controls.Add(this.rdo_teacher);
            this.panel1.Location = new System.Drawing.Point(84, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 31);
            this.panel1.TabIndex = 31;
            // 
            // rdo_student
            // 
            this.rdo_student.AutoSize = true;
            this.rdo_student.Location = new System.Drawing.Point(148, 12);
            this.rdo_student.Name = "rdo_student";
            this.rdo_student.Size = new System.Drawing.Size(47, 16);
            this.rdo_student.TabIndex = 1;
            this.rdo_student.TabStop = true;
            this.rdo_student.Text = "学生";
            this.rdo_student.UseVisualStyleBackColor = true;
            // 
            // rdo_teacher
            // 
            this.rdo_teacher.AutoSize = true;
            this.rdo_teacher.Checked = true;
            this.rdo_teacher.Location = new System.Drawing.Point(38, 12);
            this.rdo_teacher.Name = "rdo_teacher";
            this.rdo_teacher.Size = new System.Drawing.Size(47, 16);
            this.rdo_teacher.TabIndex = 0;
            this.rdo_teacher.TabStop = true;
            this.rdo_teacher.Text = "教师";
            this.rdo_teacher.UseVisualStyleBackColor = true;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(122, 136);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(157, 21);
            this.txt_password.TabIndex = 30;
            // 
            // txt_number
            // 
            this.txt_number.Location = new System.Drawing.Point(122, 97);
            this.txt_number.Name = "txt_number";
            this.txt_number.Size = new System.Drawing.Size(157, 21);
            this.txt_number.TabIndex = 29;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(210, 214);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(69, 33);
            this.btn_exit.TabIndex = 28;
            this.btn_exit.Text = "退出";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(122, 214);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(70, 33);
            this.btn_login.TabIndex = 27;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 25;
            this.label2.Text = "账号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(146, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "学生管理";
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(388, 318);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_number);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdo_student;
        private System.Windows.Forms.RadioButton rdo_teacher;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_number;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_login;
    }
}

