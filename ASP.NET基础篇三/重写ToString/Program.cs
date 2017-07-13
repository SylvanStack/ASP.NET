using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 重写ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person(); 
            Console.WriteLine( p.ToString());
            ToString();


            


        }


        public static new void ToString()
        {
            Console.WriteLine("重写ToString");
            Console.ReadKey();
        }
    }

    public class Person
    {

    }
}
