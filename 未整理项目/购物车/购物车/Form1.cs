using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 购物车
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("确认要删除该行数据吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
            != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==""||textBox2.Text==""||textBox3.Text=="")
            {
                MessageBox.Show("输入格式有误");
            }
            try
            {
                commodity[] a = {};
                shoppingcart b = new shoppingcart(a);
                //b.Add(new commodity((string)textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text)));
                int index = this.dataGridView1.Rows.Add();
                commodity stu = new commodity((string)textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text));
                /* if (b.IsContains(new commodity((string)textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text))))
                {
                    index -= 1;
                    this.dataGridView1.Rows[index].Cells[0].Value = textBox1.Text;
                    this.dataGridView1.Rows[index].Cells[1].Value = textBox2.Text;
                    this.dataGridView1.Rows[index].Cells[2].Value += textBox3.Text;
                }
                else
                {
                    this.dataGridView1.Rows[index].Cells[0].Value = textBox1.Text;
                    this.dataGridView1.Rows[index].Cells[1].Value = textBox2.Text;
                    this.dataGridView1.Rows[index].Cells[2].Value = textBox3.Text;
                }*/
                if (b.Contains(stu.Name))
                {
                    MessageBox.Show("该商品已存在，请在原商品中添加");
                }
                else
                {
                    b.Add(new commodity((string)textBox1.Text, double.Parse(textBox2.Text), int.Parse(textBox3.Text)));
                }
                for (int i=0;i<b.GetLength();i++ )
                {
                   dataGridView1.Rows[i].Cells[0].Value = b[i].Name;
                   dataGridView1.Rows[i].Cells[1].Value = b[i].Price;
                   dataGridView1.Rows[i].Cells[2].Value = b[i].Number;
                }
            }

            catch
            {
                MessageBox.Show("输入格式有误");
            }
           /* DataGridView dgv = (DataGridView)sender;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[0].Value.ToString().Trim() == dgv.Rows[i].Cells[1].Value.ToString().Trim())
                {

                }
            }*/
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text == "" )
            {
                MessageBox.Show("输入格式有误");
            }
            if (int.Parse(dataGridView1[2, 0].Value.ToString()) - int.Parse(textBox7.Text) > 0)
            {
                dataGridView1[2, 0].Value = int.Parse(dataGridView1[2, 0].Value.ToString()) - int.Parse(textBox7.Text);
            }
            else
            {
                MessageBox.Show("删除个数不符");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            double sum=0.0;
            for (int i = 0; i < dataGridView1.RowCount-1; i++)
            {
                sum += double.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString());
            }
            if (sum >= 0 && sum <= 100)
            {
                textBox4.Text = "无折扣";
            }
            else if (sum > 100 && sum < 200)
            {
                textBox4.Text = "九折";
            }
            else if (sum >= 200 && sum < 400)
            {
                textBox4.Text = "八折";
            }
            else 
            {
                textBox4.Text = "七折";
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            double sum=0.0;
            for (int i = 0; i < dataGridView1.RowCount-1;i++ )
            {
                sum += double.Parse(dataGridView1[1, i].Value.ToString()) * int.Parse(dataGridView1[2, i].Value.ToString());
            }

            if (sum >= 0 && sum <= 100)
            {
                textBox5.Text = (sum*1.0).ToString();
            }

            else if (sum > 100 && sum < 200)
            {
                textBox5.Text = (sum * 0.9).ToString();
            }

            else if (sum >= 200 && sum < 400)
            {
                textBox5.Text = (sum * 0.8).ToString();
            }

            else
            {
                textBox5.Text = (sum * 0.7).ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            textBox4_TextChanged(sender,  e);
            textBox5_TextChanged(sender, e);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.SelectedRows)
            {
                if (!r.IsNewRow)
                {
                    if (MessageBox.Show("确认要删除该行数据吗？", "删除确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        dataGridView1.Rows.Remove(r);
                    }
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
