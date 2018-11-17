using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 日期
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text),int.Parse( textBox1.Text),int.Parse( textBox3.Text));
            if (date.IsLeapYear())
            {
                textBox4.Text = "闰年";
            }
            else
            {
                textBox4.Text = "平年";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            if (date.ISDate(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text)))
            {
                textBox6.Text = "合法";
            }
            else
            {
                textBox6.Text = "不合法";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox5.Text = date.NowDate();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox5_TextChanged(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.AddDay().Year + "年" + date.AddDay().Month + "月" + date.AddDay().Day+ "日" ;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.SubDay().Year + "年" + date.SubDay().Month + "月" + date.SubDay().Day + "日";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.Addyear().Year + "年" + date.Addyear().Month + "月" + date.Addyear().Day + "日";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.Subyear().Year + "年" + date.Subyear().Month + "月" + date.Subyear().Day + "日";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("输入格式不对");
            }
            try
            {
                textBox6_TextChanged(sender, e);
                textBox4_TextChanged(sender, e);
                textBox7_TextChanged(sender, e);
            }
            catch
            {
                MessageBox.Show("输入格式不对");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";
            textBox7.Text = "";

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.Add7Day().Year + "年" + date.Add7Day().Month + "月" + date.Add7Day().Day + "日";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Date date = new Date(int.Parse(textBox2.Text), int.Parse(textBox1.Text), int.Parse(textBox3.Text));
            textBox7.Text = date.Sub7Day().Year + "年" + date.Sub7Day().Month + "月" + date.Sub7Day().Day + "日";
        }
    }
}
