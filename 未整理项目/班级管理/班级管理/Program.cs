using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 班级管理
{
    class Program
    {
        static void Main(string[] args)
        {
            grade[] stuArray = {new grade ("数学", 95),
                              new grade ("英语", 85),
                              new grade ("语文", 75)};
            Class c = new Class(new Student("张三",1,stuArray ));
            c.Add(new Student("张四", 2, stuArray));
            c.AddRange(new Student("张五", 3, stuArray), new Student("张六", 4, stuArray));
            //c.RemoveAt(1);
            Console.WriteLine("班级人数：{0}",c.GetLength());
            c.Contains(new Student("张五", 5, stuArray));
            c.show();
            c.Show();
            

        }
    }
    class grade          // 成绩类
    {
        private string subject;
        private int score;

        public grade(): this("<no name>", 0)
        {
        }

        public grade(string subject, int score)
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
        private int studentnumber = 1;
        private grade[] gra;

        public Student( string name,int studentnumber ,params grade[] c)
        {
            Name = name;
            Studentnumber = studentnumber;
            gra = new grade[c.Length];
            for (int i = 0; i < gra.Length; i++)
            {
                gra[i] = new grade(c[i].Subject, c[i].Score);
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
        public int Studentnumber
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
        public void show()
        {
            Console.WriteLine("姓名：{0}",Name);
            Console.WriteLine("学号:{0}" ,Studentnumber);
            for (int i = 0; i < gra.Length; i++)
            {
                Console.WriteLine( gra[i].ToString());
            }
        }
    }

    class Class					// 班级
    {
        private List<Student> myclass;

        public Class()
        {
        }

        public Class(params Student[] stu)
        {
            myclass = new List<Student>(stu);
           
        }

        public Student this[int index]
        {
            get { return myclass[index]; }
            set
            {
                myclass[index] = value;
            }
        }

        public void Add(Student stu)
        {
            myclass.Add(stu);
        }


        /*public void List<Student>.Add(Student stu)
        {
            myclass.Add(stu);
        }*/

        public void AddRange(params Student[] stu)
        {
            myclass.AddRange(stu);
        }

        /*public void List<Student>.AddRange(params Student[] stu)
        {
            myclass.AddRange(stu);
        }*/

        public void show()
        {
            for (int i=0; i < myclass.Count;i++)
            {
                myclass[i].show();
            }
        }

        public int GetLength()
        {
            return myclass.Count();
        }

        public void Clear()
        {
            myclass.Clear();
        }

        public void Remove(Student stu)
        {
            myclass.Remove(stu);
        }

        public void RemoveAt(int index)
        {
            myclass.RemoveAt(index);
         }

        public void RemoveRange(int index, int count)
        {
            myclass.RemoveRange(index, count);
        }

        public void Show()
        {
            foreach (Student s in myclass)
            {
                s.show();
            }
        }

        public void Contains(Student g)
        {
             if(myclass.Contains(g))
                      Console.WriteLine("g存在列表中");
            else
                 myclass.Add(g);
        }
    }
}
