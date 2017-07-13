using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 部分类
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.GetString();

            
        }
    }
    public partial class Person
    {
        public string name ="张三";
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    public partial class Person
    {
        private int age = 19;
        public int  Age
        {
            get{ return age; }
            set{ age = value; }
        }
    }
    public partial class Person
    {
        private string sex = "男";
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        public void GetString()
        {
            Console.WriteLine(Name+"\n"+Age+"\n"+Sex);
            Console.ReadKey();
        }
    }
}
