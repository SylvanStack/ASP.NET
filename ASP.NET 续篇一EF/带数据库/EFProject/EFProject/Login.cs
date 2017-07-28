using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{

    public partial class Login : Form
    {
        StudentEntities dbStudent = (StudentEntities)DBContextFactory.CreateDbContext();
        StudentInfo sin = new StudentInfo();
        ClassInfo cin = new ClassInfo();
        public Login()
        {
            InitializeComponent();
        }

        #region  控件方法

        /// <summary>
        /// 学生登陆按钮功能实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                sin = dbStudent.StudentInfo.FirstOrDefault(x => x.LoginName == txtUser.Text);
                if (sin == null && sin.DelFlag == true)
                {
                    label4.Text = "用户名不存在或者在班信息被删除";
                }
                else
                {
                    label4.Text = "";
                    if (sin.NicKName == txtPassWord.Text)
                    {
                        label5.Text = "";
                        Operation xj = new Operation(sin.StuId);
                        xj.ShowDialog();

                    }
                    else
                    {
                        label5.Text = "密码不正确";
                    }
                }
            }
            catch
            {
                MessageBox.Show("你不是这个学校的学生或者你的用户名输错");
            }
        }

        /// <summary>
        /// 取消登陆 关闭窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 老师登陆按钮功能实现
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TeacherInfo cin1 = new TeacherInfo();
                cin1 = dbStudent.TeacherInfo.FirstOrDefault(x => x.TeacherName == txtUser.Text);
                if (cin1 == null && cin1.DelFlage == true)
                {
                    label4.Text = "用户名不存在或者你被校长解雇了";
                }
                else
                {
                    label4.Text = "";
                    if (cin1.TeacherPW == txtPassWord.Text)
                    {
                        label5.Text = "";

                        Operation xj = new Operation(cin1.ClassID.ToString());
                        xj.ShowDialog();

                    }
                    else
                    {
                        label5.Text = "密码不正确";
                    }
                }
            }
            catch
            {
                MessageBox.Show("你不是这个学校的老师或者你用户名输错");
            }
        }
        /// <summary>
        ///   校长登陆验证
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtUser.Text != "" && txtPassWord.Text != "" && IsCheckCode())
                {
                    string pass;
                    if (txtUser.TextLength == 18)
                    {
                        pass = txtUser.Text.Substring(12);
                    }
                    else
                    {
                        pass = txtUser.Text.Substring(9);
                    }
                    if (pass == txtPassWord.Text)
                    {
                        Operation xj = new Operation();
                        xj.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("校长你密码是不是记错了");
                    }

                }
                else
                {
                    MessageBox.Show("校长你输入的这是啥东西啊");
                }
            }
            catch
            {
                MessageBox.Show("输入身份证号登陆");
            }
        }
        #endregion


        //// ^[1-9]{1}[0-9]{14}$|^[1-9]{1}[0-9]{16}([0-9]|[xX])$/;

        #region   验证身份证是否合格
        /// <summary>
        /// 身份证验证
        /// </summary>
        /// <returns></returns>
        public bool IsCheckCode()
        {

            int i = 1;
            foreach (char x in txtUser.Text)
            {
                if ((txtUser.Text.Length < 15) || (txtUser.Text.Length > 18))
                {
                    i = 0;
                }
                else if (txtUser.Text.Length == 18)
                {
                    if (!((x >= '0') && (x <= '9') || ((txtUser.Text[17].ToString() == "x") || (txtUser.Text[17].ToString() == "X"))))
                    {
                        i = 1;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else if (txtUser.Text.Length == 15)
                {
                    if (!((x >= '0') && (x <= '9')))
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                }

            }
            int Si = 0;
            int[] Wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string LastCode = "10X98765432";
            for (int j = 0; j < 17; j++)
            {
                Si += int.Parse(txtUser.Text.Substring(j, 1)) * Wi[j];
                Console.WriteLine("{0}", Si);
            }
            int iY = Si % 11;
            if (LastCode[iY] == txtUser.Text[17])
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }

            /*第十八位数字的计算方法为：
           1.将前面的身份证号码17位数分别乘以不同的系数。
            从第一位到第十七位的系数分别为：  7， 9， 10， 5， 8， 4， 2， 1， 6， 3， 7， 9， 10， 5， 8， 4， 2
           2.将这17位数字和系数相乘的结果相加。
          3.用加出来和除以11，看余数是多少？
        4.  0  1  2  3  4  5  6  7  8  9  10 这11个数字。对应
           1  0  X  9  8  7  6  5  4  3  2。
          5.通过上面得知如果余数是2，就会在身份证的第18位数字上出现罗马数字的Ⅹ。如果余数是10，身份证的最后一位号码就是2。*/

        }
        #endregion
    }
}
