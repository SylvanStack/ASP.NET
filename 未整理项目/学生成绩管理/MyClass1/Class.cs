using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass1
{
    class Class
    {
        private List<Student> myclass;
        private string className;

        internal List<Student> Myclass
        {
            get { return new List<Student>(myclass); }
            set { myclass = new List<Student>(value); }
        }

        public Student this[int index]
        {
            get { return myclass[index]; }
            set { myclass[index] = value; } 
        }

        public Class(List<Student> myclass, string className, bool sortType = true)
        {
            if (CheckStuNum(myclass))
            {
                this.myclass = new List<Student>(myclass);
                this.className = className;
                if (sortType)
                    SortByNum();
                else
                    SortByScore();
            }
        }

        public Class(string className, params Student[] myclass)
            : this(new List<Student>(myclass), className)
        {

        }

        public Class()
            : this("noName") 
        {

        }

        public Class(string className)
            : this(new List<Student>(), className)
        {
            
        }

        public Class(Class other)
            : this(new List<Student>(other.myclass), other.className)
        {

        }

        public void SortByNum()
        {
            myclass = myclass.OrderBy(i => i.StudentNum).ToList();
        }

        public void SortByNumDesc()
        {
            myclass = myclass.OrderByDescending(i => i.StudentNum).ToList();
        }

        public void SortByScore()
        {
            myclass = myclass.OrderByDescending(i => i.Score.InTotal()).ToList();
        }

        public void SortByScoreAsc()
        {
            myclass = myclass.OrderBy(i => i.Score.InTotal()).ToList();
        }

        public void AddStudent(Student student)
        {
            if (!Contains(student))
            {
                myclass.Add(student);
            }
        }

        public void AddStudents(List<Student> students)
        {
            for (int i = 0; i < students.Count; i++)
            {
                AddStudent(students[i]);
            }
        }

        public void AddStudents(Student[] students)
        {
            AddStudents(students);
        }

        public bool Contains(Student student)
        {
            for (int i = 0; i < myclass.Count; i++)
            {
                if (student.StudentNum.Equals(myclass[i].StudentNum))
                {
                    return true;
                }
            }
            return false;
        }

        public Student MaxScoreOfStudent()
        {
            Student max = myclass[0];

            foreach (Student member in myclass)
            {
                if (max.Score.Total < member.Score.Total)
                {
                    max = member;
                }
            }

            return max;
        }

        public void RemoveStudent(Student student)
        {
            for (int i = 0; i < myclass.Count; i++)
            {
                if (student.StudentNum.Equals(myclass[i].StudentNum))
                {
                    myclass.RemoveAt(i);
                }
            }
        }

        public int GetSum()
        {
            int sum = 0;

            foreach (Student stu in myclass)
            {
                sum += stu.Score.Total;
            }

            return sum;
        }

        public double GetAve()
        {
            return (double)GetSum() / myclass.Count;
        }


        public Array ConvertToArray()
        {
            return myclass.ToArray();
        }

        public override string ToString()
        {
            string str = "学号 " + "姓名 " + "总分\n";

            foreach (Student stu in myclass)
            {
                str += stu.ToString() + "\n";
            }

            return str;
        }

        public static bool CheckStuNum(List<Student> myclass, string StuNum)
        {
            for (int j = 0; j < myclass.Count; j++)
            {
                if (StuNum.Equals(myclass[j].StudentNum))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool CheckStuNum(List<Student> myclass)
        {
            for (int i = 0; i < myclass.Count; i++)
            {
                int count = 0;

                for (int j = i; j < myclass.Count; j++)
                {
                    if (myclass[i].StudentNum.Equals(myclass[j].StudentNum))
                    {
                        count++;
                        if (count == 2)
                        {
                            return false;
                        }
                    }
                }
            }

            return true;
        }

    }
}
