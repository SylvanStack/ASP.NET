using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 控件
{

    
    public partial class Form4 : Form
    {


        private List<Student> Lst { get; set; }
        private RefreshHandler Handler { get; set; }
        private string Xh { get; set; }

        public Form4()
        {
            InitializeComponent();

        }
        public Form4(RefreshHandler handler, List<Student> lst ,string xh)
        {
            InitializeComponent();

            Lst = lst;
            Handler = handler;
            Xh = xh;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(YZ())
            {
                if(string.IsNullOrEmpty(Xh))
                {
                    Lst.Add(new Student()
                    {
                        ID = textBox1.Text.Trim(),
                        Name = textBox2.Text.Trim(),
                        Age = int.Parse(textBox3.Text.Trim()),
                        GenderText = textBox4.Text.Trim()
                    });
                }
                else
                {
                    Student st1 = Lst.FirstOrDefault(c => c.ID == textBox1.Text);
                    st1.Name = textBox2.Text.Trim();
                    st1.Age = int.Parse(textBox3.Text.Trim());
                    st1.GenderText = textBox4.Text.Trim();
                }
                if (Handler != null)
                {
                    Handler();
                }


            }
            Close();
        }

        private bool YZ()
        {      
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("请输入学号");
                textBox1.Focus();
                return false;
            }
             else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("请输入姓名");
                textBox2.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("请输入年龄");
                textBox3.Focus();
                return false;
            }
            else if(string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("请输入性别");
                textBox4.Focus();
                return false;
            }

            return true;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Xh))
            {
                textBox1.ReadOnly = true;
                //Student s= Lst.FirstOrDefault(c => c.ID == Xh);
                Student s = null;
                foreach (var item in Lst)
                {
                    if (item.ID == Xh)
                    {
                        s = item;
                        break;
                    }
                }

                if (s != null)
                {
                    textBox1.Text = s.ID;
                    textBox2.Text = s.Name;
                    textBox3.Text = s.Age.ToString();
                    textBox4.Text = s.GenderText;
                }
            }
        }
    }
}
