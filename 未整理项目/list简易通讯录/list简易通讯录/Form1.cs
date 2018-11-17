using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list简易通讯录
{
    public partial class Form1 : Form
    {
        private Addperson mypersons = new Addperson();
        private Addperson mypersons1 = new Addperson();


        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PlayUpdate();
        }
        private void PlayUpdate()
        {
            //dataGridView1.Name = mypersons.Myperson.ToString();
            //mypersons1 = new Addperson(mypersons);
            this.dataGridView1.DataSource = mypersons;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                mypersons.Add(new Persons(textBox1.Text.Trim(), textBox2.Text.Trim(), listBox1.Text.Trim()));
                PlayUpdate();
            }
            catch
            {
                MessageBox.Show("输入格式有误");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
