using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Factory;
using IBLL;

namespace StuManage
{
    public partial class LoginForm : Form
    {
        /// <summary>
        /// 登陆者
        /// </summary>
        Student lander = new Student();
        
        /// <summary>
        /// 学生信息逻辑操作对象
        /// </summary>
        IStuBLL<Student> stuBll = BLLFactory.GetStuBLLInstance<Student>();

        public LoginForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            #region 登陆
            try
            {
                lander.LoginName = LoginNameTxt.Text.Trim();
                lander.Password = PasswordTxt.Text.Trim();

                if (LoginNameTxt.Text == "" || PasswordTxt.Text == "")
                {
                    MessageBox.Show("用户名和密码不能为空.", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    return;
                }

                if (stuBll.CheckLoginName(lander))
                {
                    if (stuBll.Login(lander))
                    {
                        new MianForm(lander).Show();
                        this.Hide();
                    }

                    else
                    {
                        MessageBox.Show("用户密码错误！请重新输入.", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        return;
                    }
                }

                else
                {
                    MessageBox.Show("用户名不存在！请重新输入.", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        /// <summary>
        /// 关闭整个程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
