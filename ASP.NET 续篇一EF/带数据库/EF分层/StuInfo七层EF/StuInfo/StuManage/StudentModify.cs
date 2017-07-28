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
    public partial class StudentModify : Form
    {
        /// <summary>
        /// 更新数据的委托
        /// </summary>
        private UpData upData;

        /// <summary>
        /// 判断窗体增改的标记
        /// </summary>
        string flag;

        /// <summary>
        /// 学生实体对象
        /// </summary>
        Student stu = new Student();

        /// <summary>
        /// 学生信息逻辑操作对象
        /// </summary>
        IStuBLL<Student> stuBll = BLLFactory.GetStuBLLInstance<Student>();


        public StudentModify(Student s, UpData upData,string flag)
        {
            stu = s;
            this.flag = flag;
            this.upData = upData;
            InitializeComponent();
        }

        /// <summary>
        /// 主窗体加载事件，首先判断增改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StudentModify_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(flag))//不为空则执行修改
            {
                textBox2.Focus();
                textBox1.ReadOnly = true;
                textBox1.Enabled = false;

                textBox1.Text = stu.StuId.ToString();
                textBox2.Text = stu.ClassId.ToString();
                textBox3.Text = stu.StuName;
                textBox4.Text = stu.LoginName;
                textBox5.Text = stu.Password;
                textBox6.Text = stu.Remark;
            }
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(flag))
                {
                    #region 修改学生记录
                    int n;
                    if (!int.TryParse(textBox2.Text.Trim(), out n))
                    {
                        MessageBox.Show("ClassId请输入整形数据", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    stu.ClassId = Convert.ToInt32(textBox2.Text);
                    stu.StuName = textBox3.Text.Trim();
                    stu.LoginName = textBox4.Text.Trim();
                    stu.Password = textBox5.Text.Trim();
                    stu.Remark = textBox6.Text.Trim();

                    if (!stuBll.UpdateStuInfo(stu))
                    {
                        MessageBox.Show("修改失败");
                        return;
                    }
                    textBox1.ReadOnly = false;
                    upData();
                    MessageBox.Show("修改成功");
                    this.Close(); 
                    #endregion
                }

                else
                {
                    #region 添加学生记录
                    if (!CheckData())
                    {
                        return;
                    }
                    stu.ClassId = Convert.ToInt32(textBox2.Text);
                    stu.StuName = textBox3.Text.Trim();
                    stu.LoginName = textBox4.Text.Trim();
                    stu.Password = textBox5.Text.Trim();
                    stu.Remark = textBox6.Text.Trim();

                    if (!stuBll.AddStuInfo(stu))
                    {
                        MessageBox.Show("添加失败");
                        return;
                    }
                    upData();
                    MessageBox.Show("添加成功");
                    this.Close(); 
                    #endregion
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 检查文本框数据
        /// </summary>
        /// <returns></returns>
        private bool CheckData()
        {
            bool f = true;
            int n;
            if (textBox1.Text != "")
            {
                if (!int.TryParse(textBox1.Text.Trim(), out n))
                {
                    MessageBox.Show("StuId请输入整形数据", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    f = false;
                }
            }
            if (!int.TryParse(textBox2.Text.Trim(), out n))
            {
                MessageBox.Show("ClassId请输入整形数据", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f = false;
            }

            if (textBox2.Text == ""|| textBox3.Text == ""|| textBox4.Text == ""|| textBox5.Text == "")
            {
                MessageBox.Show("ClassId、StuName、LoginName、Password不能为空", "提示：", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                f = false;
            }

            return f;
        }
    }
}
