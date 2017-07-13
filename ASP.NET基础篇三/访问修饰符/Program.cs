using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问修饰符
{
    //   public   internal 用来修饰类
    public class Program
    {
        static void Main(string[] args)
        {

        }



        public class Person
        {
            public int i;  //公开的公共的 
            private int w;  //私有的 只能在当前类内部访问
            protected string str;  //受保护的 在当前类内部访问或者在子类中访问
            internal string www;  //同一项目中可访问    
             //子类访问权限不能高于父类

            public Person(int i)
            {

            }
                

            public void Text()
            {

            }
        }

        public class Student : Person
        {

            public Student(int i):base(i)  //使用父类的i
            {

            }

            public new void Text()
            {
                Console.WriteLine( i + str  +  www);//输出可以访问的字段
            }
        }


    }
}
