using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ref_out
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 55;
            Ref(ref n);
            Console.WriteLine("使用Ref参数方法后的n自身值为：{0}", n);

            int b = 20;
            Add(b);
            Console.WriteLine( "不使用Ref参数方法后的n自身值为：{0}",b);
           

            int c = 1000;
            Console.WriteLine("不使用out参数方法后的n自身值为：{0}", c);
            Out(out c);
            Console.WriteLine("使用out参数方法后的n自身值为：{0}",c);

            Console.ReadKey();
        }
        public static void Ref(ref int n)
        {
            n += 20;
            Console.WriteLine(n);
        }
        public static void Add(int a)
        {
            a = a + 20;
            Console.WriteLine(a);
        }
        public static void Out(out int a)
        {
            a = 20;
            a = a + 20;
          
        }
    }
}
