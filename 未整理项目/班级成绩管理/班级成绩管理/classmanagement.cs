using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 班级成绩管理
{
    class classmanagement
    {
        public static int MaxScore(Student c)
        {
            int max = c[0].Score;

            for (int i = 1; i < c.GetgradeLength(); i++)
            {
                if (c[i].Score > max)
                {
                    max = c[i].Score;
                }
            }
            return max;
        }

    }
    class grade          // 成绩类
    {
        private string subject;
        private int  score;

        public grade() : this("<no name>", 0)
        {
        }

        public  grade(string subject, int score)
        {

            Subject = subject;
            Score = score;
        }

        public string Subject
        {
            get
            {
                return subject;
            }
            set
            {
                subject = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                if (value >= 0)
                {
                    score = value;
                }
            }
        }

        public override string ToString()
        {
            return "科目 ： " + subject + " , 成绩 ： " + score;
        }
    }
    class Student                // 学生类
    {
        private string name;
        private  int studentnumber=1;
        private grade[] gra;

        public Student(): this("<no name>",0)
        {
        }

        public Student(params grade[] c)
        {
            gra = new grade[c.Length];
            for (int i = 0; i < gra.Length; i++)
            {
                gra[i] = new grade(c[i].Subject, c[i].Score);  // 深拷贝
            }
        }

        public Student(int n)
        {
            gra = new grade[n];
            for (int i = 0; i < gra.Length; i++)
            {
                gra[i] = new grade();  // 深拷贝
            }
        }

        public grade this[int index]
        {
            get
            {
                return gra[index];
            }
            set
            {
                gra[index] = value;
            }
        }

        public int GetgradeLength()		// 学生科目总数
        {
            return gra.Length;
        }

        public void Show()
        {
            foreach (grade stu in gra)
            {
                Console.WriteLine(stu);
            }
        }

        public Student(string name,int studentnumber)
        {
            Name = name;
            Studentnumber=studentnumber;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int  Studentnumber
        {
            get
            {
                return studentnumber;
            }
            set
            {
                if (studentnumber > 0)
                {
                    studentnumber = value;
                }
            }
        }


        public override string ToString()
        {
            return "姓名 ： " + name + "   学号：" + studentnumber;
        }
    }

    class Class					// 班级类
    {
        private Student[] cls;

        public Class()
            : this(100)
        {
        }

        public Class(params Student[] c)
        {
            cls = new Student[c.Length];
            for (int i = 0; i < cls.Length; i++)
            {
                cls[i] = new Student(c[i].Name,c[i].Studentnumber);  // 深拷贝
            }
        }

        public Class(int n)
        {
            cls = new Student[n];
            for (int i = 0; i < cls.Length; i++)
            {
                cls[i] = new Student();  // 深拷贝
            }
        }

        public Student this[int index]
        {
            get
            {
                return cls[index];
            }
            set
            {
                cls[index] = value;
            }
        }

        public int GetLength()		// 班级学生总数
        {
            return cls.Length;
        }

        public void Show()
        {
            foreach (Student stu in cls)
            {
                Console.WriteLine(stu);
            }
        }
    }
}
