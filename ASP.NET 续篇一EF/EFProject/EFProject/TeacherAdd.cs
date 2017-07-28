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
    public partial class TeacherAdd : Form
    {

        StudentEntities dbStudent = (StudentEntities)DBContextFactory.CreateDbContext();
        //StudentEntities dbStudent = new StudentEntities();
        public TeacherAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TeacherAdd_Load(object sender, EventArgs e)
        {

            List<ClassInfo> cls = dbStudent.ClassInfo.Where(x => x.ClassId != 0).ToList();
            List<string> list = new List<string>();
            foreach (ClassInfo cin in cls)
            {
                comboBox2.Items.Add(cin.ClassName.ToString());
            }
           // comboBox2.DataSource = new BindingList<string>(list);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TeacherInfo teacher = new TeacherInfo();
            ClassInfo clsin = new ClassInfo();
            teacher.Addtime = DateTime.Now.ToString();
            teacher.ReMark = textBox3.Text;
            teacher.TeacherPW = textBox2.Text;
            teacher.TeacherName = textBox1.Text;
            teacher.DelFlage = comboBox1.SelectedItem.ToString() == "是" ? true : false;
            teacher.ClassID = dbStudent.ClassInfo.FirstOrDefault(x => x.ClassName == comboBox2.SelectedItem.ToString()).ClassId;
            dbStudent.TeacherInfo.Add(teacher);
            dbStudent.SaveChanges();
            MessageBox.Show("添加成功");
        }
    }
}
