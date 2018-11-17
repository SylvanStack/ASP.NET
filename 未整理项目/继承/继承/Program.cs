using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 继承
{ 
    /*class Person
    {
        private string name;
        private int age;

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

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value > 0 && value < 200)
                {
                    age = value;
                }
            }
        }

        public void SetPerson(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Student : Person
    {
        private string sNo;
        private int score;

        public void SetStudent(string sNo, string name, int age, int score)
        {
            SetPerson(name, age);
            this.sNo = sNo;
            if (score >= 0 && score <= 100)
            {
                this.score = score;
            }
        }


        public string GetNo()
        {
            return sNo;
        }

        public int GetScore()
        {
            return score;
        }

        public virtual string ConvertToString()
        {
            string str = "学号：" + sNo + "\n" +
                         "姓名：" + Name + "\n" +
                         "年龄：" + Age + "\n" +
                         "成绩：" + score;
            return str;
        }


    }

    public class StudentTest
    {
        public static void Main()
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.SetStudent("0001", "张三", 18, 90);
            s2.SetStudent("0002", "李四", 20, 80);

            float aver = (float)(s1.GetScore() + s2.GetScore()) / 2;

            Console.WriteLine(s1.ConvertToString());
            Console.WriteLine(s2.ConvertToString());
            Console.WriteLine("平均成绩：{0:f3}", aver);
        }
    }*/
}
