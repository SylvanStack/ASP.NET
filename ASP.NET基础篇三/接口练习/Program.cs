using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口练习
{
    class Program
    {
        static void Main(string[] args)
        {
            IFly yw = new Yw();
            yw.Fly();
            Bird bd = new Bird();//调用自己的方法
            bd.Fly();
            IFly bd1 = new Bird();//调用接口的方法
            bd1.Fly();


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



    public class Bird : IFly
    {
        void IFly.Fly()
        {
            Console.WriteLine("我是鸟   我会飞");
        }
        public void Fly()
        {
            Console.WriteLine("我是鸟   我会飞");
        }
    }

    public class Yw : Bird, IFly, ISay
    {
        public void Fly()
        {
            Console.WriteLine("我是鹦鹉   我会飞");
        }

        public void Say()
        {
            Console.WriteLine("我是鹦鹉    我会学人类    说话");
        }
    }
}
