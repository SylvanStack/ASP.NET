using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFProject
{
    public partial class LhFind : Form
    {

        StudentEntities dbstudent = (StudentEntities)DBContextFactory.CreateDbContext();
        List<StudentInfo> sin = new List<StudentInfo>();
        List<TeacherInfo> cin = new List<TeacherInfo>();
        List<StudentInfo> cinlinq = new List<StudentInfo>();
        // DataTable dt = new DataTable();
       // DataSet ds = new DataSet ();
        public LhFind()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LHCS_Load(object sender, EventArgs e)
        {
            var linq1 = from c in dbstudent.StudentInfo.ToList()
                        orderby c.Age
                        select new { c };
            foreach (var gg in linq1)
            {
                cinlinq.Add(gg.c);
            }
            //  cinlinq = dbstudent.StudentInfo.Where(x => x.StuId >0).OrderBy(n=>n).ToList();

            
            // cinlinq = linq2.ToList();

            var q = from c in dbstudent.StudentInfo.ToList()
                    join o in dbstudent.ClassInfo
                    on c.ClassId equals o.ClassId
                    select new
                    {
                        Age = c.Age,
                        AddTime = c.AddTime,
                        LoginName = c.LoginName,
                        DelFlag = c.DelFlag == false ? "在校" : "离校",
                        ClassName = o.ClassName,
                        ReMark = o.ReMark,
                        Sex = c.Sex,
                        StuId = c.StuId,
                        LastTime = c.LastTime,
                    };
            dataGridView1.DataSource = q.ToList();
            Updata();
        }

        public void Updata()
        {

            var q = from c in dbstudent.StudentInfo.ToList()
                    join o in dbstudent.ClassInfo
                    on c.ClassId equals o.ClassId
                    select new
                    {
                        Age = c.Age,
                        AddTime = c.AddTime,
                        LoginName = c.LoginName,
                        DelFlag = c.DelFlag == false ? "在校" : "离校",
                        ClassName = o.ClassName,
                        ReMark = o.ReMark,
                        Sex = c.Sex,
                        StuId = c.StuId,
                        LastTime = c.LastTime,
                    };
            dataGridView1.DataSource = q.ToList();
            dataGridView2.DataSource = new BindingList<StudentInfo>(cinlinq);
        }



        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        #region  查询

        /// <summary>
        /// 查询按钮功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (IsString(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.LoginName.Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList();
            }
            else if (IsInt(textBox1.Text))
            {


                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.Age.ToString().Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList(); ;
            }
            else if (IsZm(textBox1.Text))
            {

                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.LoginName.Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList();
            }

        }

        /// <summary>
        /// 查询文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsString(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.LoginName.Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList();
            }
            else if (IsInt(textBox1.Text))
            {


                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.Age.ToString().Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };

                dataGridView1.DataSource = q.ToList(); ;
            }
            else if (IsZm(textBox1.Text))
            {

                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        where c.LoginName.Contains(textBox1.Text)
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList();
            }
            else
            {
                var q = from c in dbstudent.StudentInfo.ToList()
                        join o in dbstudent.ClassInfo
                        on c.ClassId equals o.ClassId
                        select new
                        {
                            Age = c.Age,
                            AddTime = c.AddTime,
                            LoginName = c.LoginName,
                            DelFlag = c.DelFlag == false ? "在校" : "离校",
                            ClassName = o.ClassName,
                            ReMark = o.ReMark,
                            Sex = c.Sex,
                            StuId = c.StuId,
                            LastTime = c.LastTime,
                        };
                dataGridView1.DataSource = q.ToList();
            }

        }

        /// <summary>
        /// 是不是汉字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsString(string value)
        {
            //return Regex.IsMatch(value, @"[\u4e00-\u9fbb]+{1}quot;]");
            int t = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] > 127)
                {
                    t = 1;
                }
            }
            return t == 1;
        }
        /// <summary>
        /// 是不是数字
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public bool IsInt(string value)
        {
            //return Regex.IsMatch(value, @" ^[+-]?/d*$");
            int t = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] > 49 && textBox1.Text[i] <= 57)
                {
                    t = 1;
                }
            }
            return t == 1;
        }
        public bool IsZm(string value)
        {
            int t = 0;
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                if (textBox1.Text[i] > 65 && textBox1.Text[i] <= 122)
                {
                    t = 1;
                }
            }
            return t == 1;
            // return Regex.IsMatch(value, @"^/d*[.]?/d*$");
        }
        #endregion
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
