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
    public partial class LHCS : Form
    {

        StudentEntities dbstudent = (StudentEntities)DBContextFactory.CreateDbContext();
        List<StudentInfo> sin = new List<StudentInfo>();
        List<TeacherInfo> cin = new List<TeacherInfo>();
        public LHCS()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LHCS_Load(object sender, EventArgs e)
        {
            var q = from c in dbstudent.StudentInfo.ToList()
                    join o in dbstudent.TeacherInfo
                    on c.ClassId equals o.ClassID
                    select new
                    {
                        c,
                        o
                    };

            foreach (var gg in q)
            {
                    sin.Add(gg.c);
            }
            cin = dbstudent.TeacherInfo.ToList();
            Updata();
        }

        public void Updata()
        {
            
            dataGridView1.DataSource = new BindingList<StudentInfo>(sin);
            dataGridView2.DataSource = new BindingList<TeacherInfo>(cin);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsString(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.LoginName.Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }
            else if (IsInt(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.Age.ToString().Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }
            else if (IsZm(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.LoginName.Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (IsString(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.LoginName.Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }
            else if (IsInt(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.Age.ToString().Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }
            else if (IsZm(textBox1.Text))
            {
                var q = from c in dbstudent.StudentInfo
                        where c.LoginName.Contains(textBox1.Text)
                        select c;
                List<StudentInfo> lst = new List<StudentInfo>();
                foreach (var i in q)
                {
                    lst.Add(i);
                }
                dataGridView1.DataSource = new BindingList<StudentInfo>(lst);
            }
            else
            {
                Updata();
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
