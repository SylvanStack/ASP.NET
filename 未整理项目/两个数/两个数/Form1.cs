using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 两个数
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不正确");
            }
            try
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);

                TwoNum sum = new TwoNum(n1, n2);
                textBox3.Text = sum.Add().ToString();
            }
            catch
            {
                MessageBox.Show("输入格式不正确");
            }
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不正确");
            }
            try
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);

                TwoNum sum = new TwoNum(n1, n2);


                textBox3.Text = sum.Sub().ToString();
            }
            catch
            {
                MessageBox.Show("输入格式不正确");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不正确");
            }
            try
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);

                TwoNum sum = new TwoNum(n1, n2);
                textBox3.Text = sum.Mul().ToString();
            }
            catch
            {
                MessageBox.Show("输入格式不正确");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("输入格式不正确");
            }
            try
            {
                int n1 = Int32.Parse(textBox1.Text);
                int n2 = Int32.Parse(textBox2.Text);

                TwoNum sum = new TwoNum(n1, n2);
                textBox3.Text = sum.Div().ToString();
            }
            catch
            {
                MessageBox.Show("输入格式不正确");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
