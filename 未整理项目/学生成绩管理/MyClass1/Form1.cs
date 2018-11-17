using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyClass1
{
    public partial class Form1 : Form
    {
        private Class myclass = new Class();
        private Class selectList = new Class();
        bool sort = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonMax_Click(object sender, EventArgs e)
        {
            try
            {
                textMax.Text = myclass.MaxScoreOfStudent().Score.Total.ToString();
            }
            catch
            {
                MessageBox.Show("列表里还什么都没有！");
            }
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            try
            {
                Class listSave = new Class(selectList);
                selectList = new Class();
                if (listBox.Text == "学号")
                {
                    foreach (Student stu in listSave.Myclass)
                    {
                        if (stu.StudentNum.Equals(textTest.Text))
                        {
                            selectList.AddStudent(stu);
                        }
                    }
                }
                if (listBox.Text == "名字")
                {
                    foreach (Student stu in listSave.Myclass)
                    {
                        if (stu.Name.Equals(textTest.Text))
                        {
                            selectList.AddStudent(stu);
                        }
                    }
                }
                if (listBox.Text == "分数")
                {
                    foreach (Student stu in listSave.Myclass)
                    {
                        if (stu.Score.InTotal().Equals(new Score(textTest.Text).InTotal()))
                        {
                            selectList.AddStudent(stu);
                        }
                    }
                }
                dataGridView1.DataSource = selectList.Myclass;
            }
            catch 
            {
                MessageBox.Show("列表里还什么都没有！");
            }
        }

        private void MyUpdate_Click(object sender, EventArgs e)
        {
            PlayUpdate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

      

        private void ADD_Click(object sender, EventArgs e)
        {
            try
            {
                myclass.AddStudent(new Student(textNum.Text.Trim(), textName.Text.Trim(), new Score(textScore.Text)));
                PlayUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void PlayUpdate()
        {
           // dataGridView1.DataSource = new DataGridView();
            dataGridView1.DataSource = myclass.Myclass;
            selectList = new Class(myclass);
            textAve.Text = "";
            textMax.Text = "";
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            try
            {
                myclass.RemoveStudent(new Student(textNum.Text.Trim(), textName.Text.Trim(), new Score(textScore.Text)));
                PlayUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
        }

        private void textNum_TextChanged(object sender, EventArgs e)
        {
        }

        private void textScore_TextChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int currRow = dataGridView1.CurrentRow.Index;
            int currCol = dataGridView1.CurrentCell.ColumnIndex;

            //if (currCol == 0)
            //    myclass[currRow].StudentNum = (dataGridView1[currRow, currCol].Value as string).Trim();
            //if (currCol == 1)
            //    myclass[currRow].Name = (dataGridView1[currRow, currCol].Value as string).Trim();
            //if (currCol == 2)
            //    myclass[currRow].Score = new Score(dataGridView1[currRow, currCol].ToString());
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //myclass.SortByScore();
        }

        private void SortByNum_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                myclass.SortByNumDesc();
                sort = false;
            }
            else
            {
                myclass.SortByNum();
                sort = true;
            }
            
            PlayUpdate();
        }

        private void SortByScore_Click(object sender, EventArgs e)
        {
            if (sort)
            {
                myclass.SortByScore();
                sort = false;
            }
            else
            {
                myclass.SortByScoreAsc();
                sort = true;
            }

            PlayUpdate();
        }

        private void buttonAve_Click(object sender, EventArgs e)
        {
            double i = (double)(int)(myclass.GetAve() * 100) / 100;

            if (i < 0)
            {
                textAve.Text = "";
                return;
            }

            textAve.Text = i.ToString();
        }

        private void textNum_MouseLeave(object sender, EventArgs e)
        {
        }

        private void textNum_Validated(object sender, EventArgs e)
        {
            if (textNum.Text.Length < 5)
            {
                MessageBox.Show("请输入固定五位长度的学号");
                textNum.Text = "";
            }
        }

        private void textName_Validating(object sender, CancelEventArgs e)
        {
        }

        private void textScore_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Score score = new Score(textScore.Text);

                if (score.Total > 700 || score.Total < 0)
                {
                    MessageBox.Show("请输入真实成绩");
                    textScore.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void textName_Validated(object sender, EventArgs e)
        {
            if (textName.Text.Length > 18 || textName.Text.Length < 2)
            {
                MessageBox.Show("请输入真实姓名");
                textName.Text = "";
                return;
            }

            foreach (char i in textName.Text)
            {
                if (i <= '9')
                {
                    MessageBox.Show("请输入真实姓名");
                    textName.Text = "";
                    break;
                }
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            PlayUpdate();
        }

    }
}
