using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;

using IBLL;
using Factory;

namespace StuManage
{
    public delegate void UpData();

    public partial class MianForm : Form
    {
        /// <summary>
        /// 登陆者
        /// </summary>
        Student lander = new Student();

        /// <summary>
        /// 学生信息逻辑操作对象
        /// </summary>
        IStuBLL<Student> stuBll = BLLFactory.GetStuBLLInstance<Student>();
        
        /// <summary>
        /// 班级信息逻辑操作对象
        /// </summary>
        IClassBLL<StuClass> classBll = BLLFactory.GetClassBLLInstance<StuClass>();

        /// <summary>
        /// 学生实体对象
        /// </summary>
        Student student = new Student();

        /// <summary>
        /// 班级实体对象
        /// </summary>
        StuClass clas = new StuClass();

        public MianForm(Student stu)
        {
            lander = stu;
            InitializeComponent();
        }

        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MianForm_Load(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "登陆名：" + lander.LoginName;

            #region 窗体加载，权限设为普通学生
            toolStripStatusLabel3.Text = "权限：普通学生";
            新增ToolStripMenuItem.Enabled = false;
            修改ToolStripMenuItem.Enabled = false;
            删除ToolStripMenuItem1.Enabled = false;
            contextMenuStrip1.Enabled = false;
            删除ToolStripMenuItem.Enabled = false;
            删除班级信息ToolStripMenuItem.Enabled = false; 
            #endregion

            UpdataDataGridView();

        }

        /// <summary>
        /// 刷新DataGridView数据
        /// </summary>
        private void UpdataDataGridView()
        {
            dataGridView1.DataSource = stuBll.GetAllStuInfo();
            dataGridView2.DataSource = classBll.GetAllClass();
        }

        /// <summary>
        /// 工具栏新增学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 新增学生ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new StudentModify(student, upData,null).Show();
        }

        /// <summary>
        /// 工具栏修改学生
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 工具栏新增班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 工具栏修改班级
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 修改班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpData upData = new UpData(UpdataDataGridView);
            new ClassModify(clas, upData, "Updata").Show();
        }

        /// <summary>
        /// 右键删除选中学生记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (stuBll.RemoveStuInfoByPK(student))
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

        /// <summary>
        /// 右键删除班级信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                    if (classBll.RemoveClassByPK(clas))
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

        /// <summary>
        /// 工具栏删除选中学生记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除选中学生记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStuInfo();
        }

        /// <summary>
        /// 工具栏删除选中班级记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 删除选中班级记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveClassInfo();
        }

        /// <summary>
        /// Id查询
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

                    if (stuBll.SelectStuInfoByPK(s))
                    {
                        dataGridView1.DataSource = stuBll.GetStuInfoByPK(s);
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
                    if (classBll.SelectClassByPK(c))
                    {
                        dataGridView2.DataSource = classBll.GetClassByPK(c);
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

        /// <summary>
        /// 重新登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void 重新登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            new LoginForm().Show();
            this.Close();
        }

        /// <summary>
        /// 退出程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 显示所有数据
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowAllDataBtn_Click(object sender, EventArgs e)
        {
            UpdataDataGridView();
        }

        private void 权限ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
