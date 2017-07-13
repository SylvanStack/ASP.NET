using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            IFly ifly = new Yw();
            ifly.Fly();


            ISay ifly1 = new Student();
            ifly1.Say();


            Console.ReadKey();
        }
    }

    public interface IFly
    {
        void Fly();
    }
    public interface ISay
    {
        void Say();
    }
    public class Person : IFly, ISay
    {
        public void Fly()
        {
            Console.WriteLine("我是人类    我会飞");
        }

        public void Say()
        {
            Console.WriteLine("我是人类    我会说话");
        }
    }

    public class Student : Person ,IFly, ISay
    {
        public new  void Fly()
        {
            Console.WriteLine("我是人类    我会飞");
        }

        public new void Say()
        {
            Console.WriteLine("我是学生    我会说话");
        }
    }


    public class Bird : IFly
    {
        public void Fly()
        {
            Console.WriteLine("我是鸟   我会飞");
        }

       
    }

    public class Yw : Bird ,IFly,ISay
    {
        public new void Fly()
        {
            Console.WriteLine("我是鹦鹉   我会飞");
        }

        public void Say()
        {
            Console.WriteLine("我是鹦鹉    我会学人类    说话");
        }
    }
}
