using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StuManage
{
    public delegate void UpData();

    public partial class MianForm : Form
    {
        Student lander = new Student();//登陆者
        EFDemo ef = new EFDemo();
        Student student = new Student();
        StuClass clas = new StuClass();

        public MianForm(Student stu)
        {
            lander = stu;
            InitializeComponent();
        }

        private void MianForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "登陆名：" + lander.LoginName;
            toolStripStatusLabel3.Text = "权限：普通学生";
            UpdataDataGridView();

        }

        private void UpdataDataGridView()
        {
            dataGridView1.DataSource = ef.GetAllStuInfo();
            dataGridView2.DataSource = ef.GetAllClass();
        }

        private void 新增学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new StudentModify(student, upData,null).Show();
        }

        private void 修改学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new StudentModify(student, upData, "Updata").Show();
        }

        /// <summary>
        /// dataGridView1单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    student.StuId =Int32.Parse( dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                    student.ClassId = Int32.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
                    student.StuName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                    student.LoginName = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                    student.Password = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                    student.Remark = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void 新增班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new ClassModify(clas, upData, null).Show();
        }

        /// <summary>
        /// dataGridView2单击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex > -1)
                {
                    clas.ClassId = Int32.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
                    clas.ClassName = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
                    clas.Remark = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void 修改班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new ClassModify(clas, upData, "Updata").Show();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStuInfo();
        }

        /// <summary>
        /// 删除选中学生信息
        /// </summary>
        private void RemoveStuInfo()
        {
            try
            {
                if ((MessageBox.Show("请问确定要删除此条记录吗？", "询问：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    if (ef.RemoveStuInfoByPK(student))
                    {
                        UpdataDataGridView();
                        MessageBox.Show("删除成功");
                        return;
                    }

                    MessageBox.Show("删除失败！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void 删除班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveClassInfo();
        }

        /// <summary>
        /// 删除选中班级信息
        /// </summary>
        private void RemoveClassInfo()
        {
            try
            {
                if ((MessageBox.Show("请问确定要删除此条记录吗？", "询问：", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK))
                {
                    if (ef.DeleteByPK(clas))
                    {
                        UpdataDataGridView();
                        MessageBox.Show("删除成功");
                        return;
                    }
                    MessageBox.Show("删除失败！", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void 删除选中学生记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStuInfo();
        }

        private void 删除选中班级记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveClassInfo();
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            int id;
            #region 学生查询
            if (radioButton1.Checked)
            {
                Student s = new Student();

                if (Int32.TryParse(textBox1.Text.Trim(), out id))
                {
                    s.StuId = id;

                    if (ef.SelectStuInfoByPK(s))
                    {
                        dataGridView1.DataSource = ef.GetStuInfoByPK(s);
                        MessageBox.Show("查询成功");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("无此条记录");
                        return;
                    }

                }
                else
                {
                    MessageBox.Show("请输入整形数据！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } 
            #endregion

            #region 班级查询
            if (radioButton2.Checked)
            {
                
                StuClass c = new StuClass();

                if (Int32.TryParse(textBox1.Text.Trim(), out id))
                {
                    c.ClassId = id;
                    if (ef.SelectByPK(c))
                    {
                        dataGridView2.DataSource = ef.GetClassByPK(c);
                        MessageBox.Show("查询成功");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("无此条记录");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("请输入整形数据！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            } 
            #endregion
            MessageBox.Show("请选择查询对象");
        }

        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new LoginForm().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 学生权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 普通学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "权限：普通学生";
            新增ToolStripMenuItem.Enabled = false;
            修改ToolStripMenuItem.Enabled = false;
            删除ToolStripMenuItem1.Enabled = false;
            contextMenuStrip1.Enabled = false;
            删除ToolStripMenuItem.Enabled = false;
            删除班级信息ToolStripMenuItem.Enabled = false;
        }

        /// <summary>
        /// 管理权限
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel3.Text = "权限：班干部";
            新增ToolStripMenuItem.Enabled = true;
            修改ToolStripMenuItem.Enabled = true;
            删除ToolStripMenuItem1.Enabled = true;
            contextMenuStrip1.Enabled = true;
            删除ToolStripMenuItem.Enabled = true;
            删除班级信息ToolStripMenuItem.Enabled = true;
        }
    }
}
