using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 通讯录
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text=="")
            {
                MessageBox.Show("用户名或密码不能为空！","登录失败",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            try
            {

                int i = 1;
                foreach (char x in textBox1.Text)
                {
                    if ((textBox1.Text.Length < 15) || (textBox1.Text.Length > 18))
                    {
                        i = 0;
                    }
                    else if (textBox1.Text.Length == 18)
                    {
                        if (!((x >= '0') && (x <= '9') || ((textBox1.Text[17].ToString() == "x") || (textBox1.Text[17].ToString() == "X"))))
                        {
                            i = 1;
                        }
                        else
                        {
                            i = 0;
                        }
                    }
                    else if (textBox1.Text.Length == 15)
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
                    Si += int.Parse(textBox1.Text.Substring(j, 1)) * Wi[j];
                    Console.WriteLine("{0}", Si);
                }
                int iY = Si % 11;
                if (LastCode[iY] == textBox1.Text[17])
                {
                    i = 1;
                }
                else
                {
                    i = 0;
                }
                if (i == 1 && textBox2.Text == textBox1.Text.Substring(12, 6))
                {
                    frmMain fo = new frmMain();
                    fo.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("输入帐号或密码错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("输入帐号格式错误！", "登录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
