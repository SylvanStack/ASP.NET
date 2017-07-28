using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public delegate void Wt();
    public partial class GLY : Form
    {
        StudentEntities dbStudent = (StudentEntities)DBContextFactory.CreateDbContext();
        TeacherInfo tin = new TeacherInfo();
        public string Str { get; set; }
        public int Istuid { get; set; }
        /// <summary>
        /// 无参构造函数
        /// </summary>
        public GLY()
        {
            InitializeComponent();
            groupBox3.Enabled = false;
            Str = null;
            Istuid = -1;
        }
        /// <summary>
        /// 老师登陆
        /// </summary>
        /// <param name="str"></param>
        public GLY(string str)
        {
            InitializeComponent();
            Str = str;
            Istuid = -1;
        }
        /// <summary>
        /// 学生登陆
        /// </summary>
        /// <param name="istuid"></param>
        public GLY(int istuid)
        {
            InitializeComponent();
            Str = null;
            Istuid = istuid;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GLY_Load(object sender, EventArgs e)
        {
            if (Str != null)
            {
                groupBox2.Enabled = false;
                List<StudentInfo> listsin = dbStudent.StudentInfo.Where(x => x.ClassId.ToString() ==Str).ToList();
                TeacherInfo tin = new TeacherInfo();
                tin = dbStudent.TeacherInfo.FirstOrDefault(x => x.ClassID.ToString() == Str);
                dataGridView1.DataSource = new BindingList<StudentInfo>(listsin);
                labName.Text = tin.TeacherName + ":老师你好";
                string s = dbStudent.ClassInfo.FirstOrDefault(x => x.ClassId == tin.ClassID).ClassName;
                labClass.Text = "你所管理的班级:" + s;
            }
            else if (Istuid >= 0)
            {
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                textBox1.Enabled = false;
                List<StudentInfo> lis = dbStudent.StudentInfo.Where(x => x.StuId == Istuid).ToList();
                dataGridView1.DataSource = new BindingList<StudentInfo>(lis);
            }
            else
            {
                groupBox1.Enabled = false;
                List<StudentInfo> listsin111 = dbStudent.StudentInfo.ToList();
                dataGridView1.DataSource = new BindingList<StudentInfo>(listsin111);
            }
        }

        /// <summary>
        /// 数据库更新
        /// </summary>
        public void UpdataGridView1()
        {
            //ClassInfo cls = new ClassInfo();
            //cls = dbStudent.ClassInfo.FirstOrDefault(x => x.ClassId.ToString() == Str);
           List<StudentInfo> listsin = dbStudent.StudentInfo.Where(x => x.ClassId.ToString() == Str).ToList();
           dataGridView1.DataSource = new BindingList<StudentInfo>(listsin);

        }
        /// <summary>
        /// linq 多表查询 更新数据
        /// </summary>
        public  void UpdataGridView11()
        {
            tin = dbStudent.TeacherInfo.FirstOrDefault(x => x.ClassID.ToString() == Str);
            List<StudentInfo> listsin = dbStudent.StudentInfo.Where(x => x.ClassId == tin.ClassID).ToList();
            List<StudentInfo> sin111 = new List<StudentInfo>();
            List<ClassInfo> cin111 = new List<ClassInfo>();
            var q = from c in listsin
                    join o in dbStudent.ClassInfo
                    on c.ClassId equals o.ClassId
                    select new
                    {
                        c,
                        o
                    };

            foreach (var gg in q)
            {
                sin111.Add(gg.c);
                cin111.Add(gg.o);
            }
;
            dataGridView1.DataSource = new BindingList<StudentInfo>(sin111);
        }

        /// <summary>
        /// 学生登陆更新数据
        /// </summary>
        public void UpdataGridView12()
        {
            List<StudentInfo> lis = dbStudent.StudentInfo.Where(x => x.StuId == Istuid).ToList();
            dataGridView1.DataSource = new BindingList<StudentInfo>(lis);

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void labName_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            XJGLYM f = new XJGLYM(UpdataGridView11, null);
            f.ShowDialog();
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                int selectId = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                DialogResult dig = MessageBox.Show("是否确认删除学生编号为：" + selectId + "的记录。", "询问", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
                if (DialogResult.Yes == dig)
                {
                    dbStudent.StudentInfo.Remove(dbStudent.StudentInfo.FirstOrDefault(x => x.StuId == selectId));
                    dbStudent.SaveChanges();
                }

            }
            catch
            {
                MessageBox.Show("请删除选中行");
            }
            finally
            {
                UpdataGridView11();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 老师修改学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Istuid >= 0)
                {
                    XJGLYM fin = new XJGLYM(UpdataGridView12, Istuid);
                    fin.ShowDialog();
                }
                else if (Str != null)
                {
                    string selectId = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    XJGLYM f = new XJGLYM(UpdataGridView1, selectId);
                    f.ShowDialog();
                }
            }
            catch
            {
                MessageBox.Show("选择要修改的行");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        /// <summary>
        /// 性别查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            
            TeacherInfo tinj = new TeacherInfo();
            tinj = dbStudent.TeacherInfo.FirstOrDefault(x => x.ClassID.ToString() == Str);
            List<StudentInfo> listsin = dbStudent.StudentInfo.Where(x => x.Sex == textBox1.Text).ToList();
            List<StudentInfo> listsin111 = listsin.Where(x => x.ClassId == tinj.ClassID).ToList();
            dataGridView1.DataSource = new BindingList<StudentInfo>(listsin111);
        }


        /// <summary>
        /// 老师添加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            TeacherAdd teaf = new TeacherAdd();
            teaf.ShowDialog();
        }

        /// <summary>
        /// 多表查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            LHCS xxcx = new LHCS();
            xxcx.ShowDialog();
        }
    }
}
