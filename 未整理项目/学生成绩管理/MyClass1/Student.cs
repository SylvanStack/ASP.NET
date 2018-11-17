using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClass1
{
    class Student
    {
        private string studentNum;          //主键
        private string name;
        private Score score;

        public string StudentNum
        {
            get { return studentNum; }
            set { studentNum = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Score Score
        {
            get { return score; }
            set { score = new Score(score); }
        }

        public Student(string studentNum, string name, Score score)
        {
            this.studentNum = studentNum;
            this.name = name;
            this.score = new Score(score);
        }

        public Student(Student other)
        {
            this.studentNum = other.studentNum;
            this.name = other.name;
            this.score = other.score;
        }

        public override string ToString()
        {
            return studentNum + " " + name + " " + score.Total; 
        }
    }
}
