using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 身份证号码验证
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox6_MaskInputRejected(object sender, EventArgs e)
        {
                  IDCard id = new IDCard(maskedTextBox1.Text);
                 if (id.IsCheckCode())
                {
                    maskedTextBox6.Text = id.GetAge();
                }
                else
                {
                    maskedTextBox6.Text = "";
                }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void maskedTextBox1_MaskInputRejected(object sender, EventArgs e)
        {
            //IDCard id = new IDCard(maskedTextBox1.Text);
            //return maskedTextBox1.Text;
        }

        private void maskedTextBox2_MaskInputRejected(object sender, EventArgs e)
        {

                IDCard id = new IDCard(maskedTextBox1.Text);
                if (id.IsCheckCode())
                {
                    maskedTextBox2.Text = "合法";
                }
                else
                {
                    maskedTextBox2.Text = "不合法";
                }
            
        }

        private void maskedTextBox3_MaskInputRejected(object sender, EventArgs e)
        {

                IDCard id = new IDCard(maskedTextBox1.Text);
                if (id.IsCheckCode())
                {
                    maskedTextBox3.Text = id.GetAdress();
                }
                else
                {
                    maskedTextBox3.Text = "";
                }
            

            
        }

        private void maskedTextBox4_MaskInputRejected(object sender, EventArgs e)
        {
                 IDCard id = new IDCard(maskedTextBox1.Text);
                if (id.IsCheckCode())
                {
                    maskedTextBox4.Text = id.GetSex();
                }
                else
                {
                    maskedTextBox4.Text = "";
                }
            
        }

        private void maskedTextBox5_MaskInputRejected(object sender, EventArgs e)
        {
                IDCard id = new IDCard(maskedTextBox1.Text);
                if (id.IsCheckCode())
                {
                    maskedTextBox5.Text = id.GetYear() + "/" + id.GetMonth() + "/" + id.GetDay();
                }
                else
                {

                    maskedTextBox5.Text = "";
                 }
         }  
        private void maskedTextBox7_MaskInputRejected(object sender, EventArgs e)
        {
                IDCard id = new IDCard(maskedTextBox1.Text);
                if (id.IsCheckCode())
                {
                    maskedTextBox7.Text = id.GetMonth() + "月" + id.GetDay() + "日";
                }
                else
                {

                    maskedTextBox7.Text = "";
                }
            
        }

        private void maskedTextBox8_MaskInputRejected(object sender, EventArgs e)
        {
            IDCard id = new IDCard(maskedTextBox1.Text);
            if (id.IsCheckCode())
            {
                maskedTextBox8.Text = id.JudgeStarSign(maskedTextBox1.Text);
            }
            else
            {

                maskedTextBox8.Text = "";
            }
           
        }

        private void maskedTextBox9_MaskInputRejected(object sender, EventArgs e)
        {
            IDCard id = new IDCard(maskedTextBox1.Text);
            if (id.IsCheckCode())
            {
                maskedTextBox9.Text = id.GetZodiac(maskedTextBox1.Text);
            }
            else
            {

                maskedTextBox9.Text = "";
            }
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不对");
            }
            try
            {
                maskedTextBox2_MaskInputRejected(sender, e);
                maskedTextBox3_MaskInputRejected(sender, e);
                maskedTextBox4_MaskInputRejected(sender, e);
                maskedTextBox5_MaskInputRejected(sender, e);
                maskedTextBox6_MaskInputRejected(sender, e);
                maskedTextBox7_MaskInputRejected(sender, e);
                maskedTextBox8_MaskInputRejected(sender, e);
                maskedTextBox9_MaskInputRejected(sender, e);
            }
            catch
            {
                MessageBox.Show("输入格式有误");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不对");
            }
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox6.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = ""; 
            maskedTextBox9.Text = "";
        }
    }

}
    