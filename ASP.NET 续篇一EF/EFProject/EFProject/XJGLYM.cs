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
    public partial class XJGLYM : Form
    {

        StudentEntities dbStudent = (StudentEntities)DBContextFactory.CreateDbContext();
        //StudentEntities dbStudent = new StudentEntities();
        StudentInfo sin = new StudentInfo();
        ClassInfo cin = new ClassInfo();



        #region  字段构造函数
        public string Str { get; set; }
        public Wt Fun { get; set; }
        public string SelectID { get; set; }

        public int Istuid { get; set; }

        public XJGLYM(Wt fun, string selectID)
        {
            Str = null;
            InitializeComponent();
            Fun = fun;
            SelectID = selectID;
            Istuid = -1;
           // sin = dbStudent.StudentInfo.Where();
        }

        public XJGLYM(Wt fun, int istuid)
        {
            Str = null;
            InitializeComponent();
            Fun = fun;
            Istuid = istuid;
            XGym();
            txtName.ReadOnly = true;
        }
        public XJGLYM(string str)
        {
            InitializeComponent();
            Str = str;
            Istuid = -1;
        }

        public XJGLYM()
        {
            InitializeComponent();
        }
        #endregion

        #region   方法

        ///// <summary>
        ///// 存在该班级
        ///// </summary>
        ///// <returns></returns>
        //public string IsBj()
        //{
        //    List<ClassInfo> stur = dbStudent.ClassInfo.Where(x => x.ClassId != null).ToList();
        //    List<string> lst = new List<string>();
        //    foreach (ClassInfo i in stur)
        //    {
        //        lst.Add(i.ClassName);
        //    }
        //    return lst.FirstOrDefault(x => x == txtClass.Text);
        //}


        /// <summary>
        /// 控件验证方法
        /// </summary>
        /// <returns></returns>
        public bool YZ()
        {
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("请输入姓名");
                txtName.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("请输入密码");
                txtPass.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtPass2.Text))
            {
                MessageBox.Show("请再次输入密码");
                txtPass2.Focus();
                return false;
            }
            else if (txtPass2.Text != txtPass.Text)
            {
                MessageBox.Show("请再次输入密码");
                txtPass2.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(txtAge.Text))
            {
                MessageBox.Show("请输入年龄");
                txtAge.Focus();
                return false;
            }
            else if (comboBox1.SelectedText == null)
            {
                MessageBox.Show("请选择性别");

            }

            else if (comboBox3.Text == null)
            {
                MessageBox.Show("班级选择");
                comboBox3.Focus();
                return false;
            }

            return true;
        }
        //学生登陆重置
        public void XGym()
        {
            txtlasttime.ReadOnly = true;
            txtClass.ReadOnly = true;
            txtClassPj.ReadOnly = true;
            txttime.ReadOnly = true;
            comboBox1.Enabled = false;
            comboBox3.Enabled = false;

        }
        //老师添加学生账号控件重置
        public void LsKJ()
        {
            txtlasttime.ReadOnly = true;
            txttime.ReadOnly = true;
            txtClassPj.ReadOnly = true;
            txtClass.ReadOnly = true;
        }

        //老师修改学生账号控件重置
        public void Xgcz()
        {
            txtlasttime.ReadOnly = true;
            txttime.ReadOnly = true;
            txtClassPj.ReadOnly = true;
        }
        #endregion

        #region  控件方法
        private void XJGLYM_Load(object sender, EventArgs e)
        {
           
            //学生登陆
            if (Istuid >= 0)
            {
                sin = dbStudent.StudentInfo.FirstOrDefault(x => x.StuId == Istuid);
                txtName.Text = sin.LoginName;
                txtlasttime.Text = sin.LastTime;
                txtPj.Text = sin.Remark;
                txttime.Text = sin.AddTime.ToString();
                cin = dbStudent.ClassInfo.FirstOrDefault(x => x.ClassId == sin.ClassId);
                txtClass.Text = cin.ClassName;
                txtClassPj.Text = cin.ReMark;
                txtAge.Text = sin.Age.ToString();
                txtPass.Text = sin.NicKName;
                txtPass2.Text = sin.NicKName;
                comboBox2.Text = sin.Sex.Equals("男") ? "男" : "女";
                Str = "";
            }
            else if (SelectID != null)//老师修改学生信息
            {
                List<ClassInfo> cls = dbStudent.ClassInfo.Where(x => x.ClassId != 0).ToList();
                List<string> list = new List<string>();
                foreach (ClassInfo cin in cls)
                {
                    comboBox3.Items.Add(cin.ClassName.ToString());
                }
                Xgcz();
                sin = dbStudent.StudentInfo.FirstOrDefault(x => x.StuId.ToString() == SelectID);
                txtName.Text = sin.LoginName;
                txtlasttime.Text = sin.LastTime;
                txtPj.Text = sin.Remark;
                txttime.Text = sin.AddTime.ToString();
                cin = dbStudent.ClassInfo.FirstOrDefault(x => x.ClassId == sin.ClassId);
                txtClass.Text = cin.ClassName;
                txtClassPj.Text = cin.ReMark;
                txtAge.Text = sin.Age.ToString();
                txtPass.Text = sin.NicKName;
                txtPass2.Text = sin.NicKName;
                comboBox2.Text = sin.Sex.ToString() == "男" ? "男" : "女";
                comboBox3.Text = cin.ClassName.ToString();
                comboBox1.Text = cin.DelFlag == true ? "是" : "否";
                Str = "";
            }
            else
            {
                List<ClassInfo> cls = dbStudent.ClassInfo.Where(x => x.ClassId != 0).ToList();
                List<string> list = new List<string>();
                foreach (ClassInfo cin in cls)
                {
                    comboBox3.Items.Add(cin.ClassName.ToString());
                }
                LsKJ();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 保存或新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (Istuid >= 0)
            {
                txtName.ReadOnly = true;
                if (txtPass2.Text == txtPass.Text)
                {
                    sin.NicKName = txtPass2.Text;
                }
                else
                {
                    MessageBox.Show("输入密码不一致");
                }
                sin.Age = int.Parse(txtAge.Text);
                sin.LastTime = DateTime.Now.ToString();
                sin.Sex = comboBox2.SelectedItem.ToString();
                sin.Remark = txtPj.Text;
                dbStudent.StudentInfo.Attach(sin);
                dbStudent.Entry<StudentInfo>(sin).State = System.Data.Entity.EntityState.Modified;
                dbStudent.SaveChanges();
                Fun();
                MessageBox.Show("学生信息修改成功");
                Close();
            }
            else
            {
                if (YZ())
                {
                    if (SelectID != null)
                    {
                        sin.LoginName = txtName.Text;
                        sin.NicKName = txtPass2.Text;
                        sin.Age = int.Parse(txtAge.Text);
                        sin.Sex = comboBox2.SelectedItem.ToString();
                        sin.Remark = txtPj.Text;
                        sin.DelFlag = comboBox1.SelectedText.ToString() == "是";
                        sin.LastTime = DateTime.Now.ToString();
                        sin.ClassId = dbStudent.ClassInfo.Where(x => x.ClassId != 0).ToList().FirstOrDefault(y => y.ClassName == comboBox3.SelectedItem.ToString()).ClassId;
                        dbStudent.StudentInfo.Attach(sin);
                        dbStudent.Entry<StudentInfo>(sin).State = System.Data.Entity.EntityState.Modified;
                        dbStudent.SaveChanges();
                        Fun();
                        MessageBox.Show("学生信息修改成功");
                        Close();
                    }
                    else
                    {
                        StudentInfo stu = new StudentInfo();
                        stu.LoginName = txtName.Text;
                        stu.NicKName = txtPass2.Text;
                        stu.Age = int.Parse(txtAge.Text);
                        stu.Sex = comboBox2.SelectedItem.ToString();
                        stu.Remark = txtPj.Text;
                        stu.DelFlag = comboBox1.SelectedText.ToString() == "是";
                        stu.AddTime = DateTime.Now.ToString();
                        stu.LastTime = DateTime.Now.ToString();
                        stu.ClassId = dbStudent.ClassInfo.Where(x => x.ClassId != 0).ToList().FirstOrDefault(y => y.ClassName == comboBox3.SelectedItem.ToString()).ClassId;
                        dbStudent.StudentInfo.Add(stu);
                        dbStudent.SaveChanges();
                        Fun();
                        MessageBox.Show("添加学生信息成功");
                    }
                }
            }

        }

        private void txtSex_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

