using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chap5Demo
{

    public delegate void RefreshHandler();


    public partial class FrmMain : Form
    {

       public   List<SE> Engineers =new List<SE>(); 


        //  public  List<SE> Engineers { get; set; } = 
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {


            Engineers.Add(new SE
                {
                    ID = "01",
                    Name = "孙悟空",
                    Age = 20,
                    Gender = true,
                   

                });

            Engineers.Add(new SE
            {
                ID = "02",
                Name = "猪八戒",
                Age = 22,
                Gender = false,

            });
            dataGridView1.DataSource = new BindingList<SE>(Engineers);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            RefreshHandler handler = new RefreshHandler(MyHandler);
            new FrmModify(Engineers, handler, null).ShowDialog();

        }

        public void MyHandler()
        {
            dataGridView1.DataSource = new BindingList<SE>(Engineers);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {

                string selectedId = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
                DialogResult result = MessageBox.Show("是否确认修改编号为：" + selectedId + "的记录。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result==DialogResult.Yes )
                {
                    
                 RefreshHandler handler = new RefreshHandler(MyHandler);
                new FrmModify(Engineers, handler, selectedId).ShowDialog();
                }


                
            }
            catch
            {
                MessageBox.Show("请选择正确的行");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            string selectedId = (string)dataGridView1.SelectedRows[0].Cells[0].Value;
            DialogResult result = MessageBox.Show("是否确认删除编号为：" + selectedId + "的记录。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var se = Engineers.FirstOrDefault(c => c.ID == selectedId);
                Engineers.Remove(se);
                MyHandler();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new BindingList<SE>
               (Engineers.Where(c =>
               c.ID.Contains(textBox1.Text.Trim()))
               .ToList());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
