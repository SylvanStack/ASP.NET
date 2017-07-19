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

    public delegate void RefreshHandler();
    public partial class Form3 : Form
    {

        public List<Student> Lst = new List<Student>();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Lst.Add(new Student
            {
                ID = "01",
                Name = "张三",
                Age = 20,
                Gender = true,


            });

            Lst.Add(new Student
            {
                ID = "02",
                Name = "李四",
                Age = 22,
                Gender = false,

            });
            Lst.Add(new Student
            {
                ID = "03",
                Name = "王五",
                Age = 22,
                Gender = true,


            });
            dataGridView1.DataSource = new BindingList<Student>(Lst);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void MyHandler()
        {
            dataGridView1.DataSource = new BindingList<Student>(Lst);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RefreshHandler myh = new RefreshHandler(MyHandler);
                string xh = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                if (string.IsNullOrEmpty(xh))
                {
                    MessageBox.Show("请选择要修改的数据");
                }
                Form4 f4 = new Form4(myh, Lst, xh);
                f4.ShowDialog();
            }
            catch
            {
                MessageBox.Show("请选择要修改的数据行");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            RefreshHandler myh = new RefreshHandler(MyHandler);
            Form4 f4 = new Form4(myh, Lst, null);
            f4.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string xh = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                DialogResult result = MessageBox.Show("是否确认删除编号为：" + xh + "的记录。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    var s1 = Lst.FirstOrDefault(c => c.ID == xh);
                    Lst.Remove(s1);
                    MyHandler();
                }
            }
            catch
            {
                MessageBox.Show("请选择要修改的数据行");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            //dataGridView1.DataSource = Lst.Where(c => c.ID == textBox1.Text.Trim()).ToList();
           

            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                List<Student> st = Lst.Where(c => c.ID == textBox1.Text.Trim()).ToList();

                dataGridView1.DataSource = new BindingList<Student>(st);

            }

            //List<Student> st = Lst.Where(c => c.ID == textBox1.Text.Trim()).ToList();

            //dataGridView1.DataSource = new BindingList<Student>(st);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
