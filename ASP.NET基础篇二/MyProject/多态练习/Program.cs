using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态练习
{
    class Program
    {
        static void Main(string[] args)
        {

            //Duck d = new Duck();
            //d.Jiao();
            //DuckFather df = new DuckFather();
            //df.Jiao();
            //DuckSonOne dso = new DuckSonOne();
            //dso.Jiao();
            //DuckSonTwo dst = new DuckSonTwo();
            //dst.Jiao();


            Duck df = new DuckFather();
            Duck dso = new DuckSonOne();
            Duck dst = new DuckSonTwo();

            Duck[] d = {df,dso,dst };
            for(int i=0;i <d.Length;i++)
            {
                d[i].Jiao();
            }

            Console.ReadKey();
        }
    }
    public class Duck
    {
        public virtual void Jiao()
        {
            Console.WriteLine("鸭子叫");
        }
    }


    public class DuckFather : Duck
    {
        public override void Jiao()
        {
            Console.WriteLine("鸭子爸爸叫");
        }
    }
    public class DuckSonOne : Duck
    {
        public override void Jiao()
        {
            Console.WriteLine("大鸭子儿子叫");
        }
    }

    public class DuckSonTwo : Duck
    {
        public override void Jiao()
        {
            Console.WriteLine("二鸭子儿子叫");
        }
    }
}
