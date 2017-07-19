using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web.UI;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace 控件
{
    public partial class Form1 : Form
    {
        private bool isPostBack=false;//是不是再次登录

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            if (!isPostBack)
            {
                isPostBack = true;
                comboBox1.Items.Add("学生");
                comboBox1.Items.Add("老师");

                List<string> list = new List<string>();
                list.AddRange(new string []{ "篮球", "足球", "排球", "乒乓球" });
                 listBox1.DataSource = new BindingList<string >(list);
            }
            comboBox2.Enabled = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if(comboBox1.SelectedText!=null)
            {
                comboBox2.Enabled = true;
                 if(comboBox1.Items[comboBox1.SelectedIndex].ToString() == "学生")
                {
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("小学生");
                    comboBox2.Items.Add("初中生");
                    comboBox2.Items.Add("高中中生");
                    comboBox2.Items.Add("大学生");
                }
                else if(comboBox1.Items[comboBox1.SelectedIndex].ToString() == "老师")
                { 
                    comboBox2.Items.Clear();
                    comboBox2.Items.Add("小学老师");
                    comboBox2.Items.Add("初中老师");
                    comboBox2.Items.Add("高中老师");
                    comboBox2.Items.Add("大学老师");
                    //List<string> list = new List<string>();
                    //list.AddRange(new string []{ "小学老师", "初中老师", "高中老师", "大学老师" });
                    //comboBox2.DataSource = new System.ComponentModel.BindingList<string >(list);
                }
                
            }
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label6.Text = "你选择的时间：" + dateTimePicker1.Value.Year + "年" + dateTimePicker1.Value.Month+"月"+ dateTimePicker1.Value.Day + "日";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.baidu.com");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f1 = new Form2();
            f1.ShowDialog();
        }
    }
}
