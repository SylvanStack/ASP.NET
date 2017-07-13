using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main(string[] args)
        {
            Student p = new Student();
            p.Koulan();
            p.Say();
            Console.ReadKey();

        }
    }


    public class Person
    {
        public void Say()
        {
            Console.WriteLine("Hello 我是人类");
        }


    }
    public interface IKoulan  //定义接口
    {
        void Koulan();
    }

    public class Student : Person, IKoulan  //父类在前（一个 ）  接口在后 （多个) 
    {
        public void Koulan()
        {
            Console.WriteLine("我是学生我也会扣篮");
        }
    }


    //接口语法特征
    public interface Il
    {
        //不能有字段 
        //string p;

        string Name { get; set; }//可以有字段

        void Pin();//没有方法体和修饰符
    }

}
