using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01引用参数与输出参数
{
    class Program
    {
        static void Main(string[] args)
        {

            //ref 参数与 out 参数的区别
            //ref 与 out 参数，传递的都是实参变量的引用（即地址）（无区别）
            //ref 参数，其实参变量必须已赋值，out 参数，其实参变量不必赋值
            //ref 形参，在方法内可以不被赋值，out 形参，在方法内必须赋值
            //ref 形参，在方法内即可以作左值也可以作右值，
            //out 形参，在方法内首次被赋值前只能作左值


            int[] array = { 1,2,3};
            Console.WriteLine("引用参数实例");
            Console.Write("数组array = ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine("\n经过引用参数后：");
            GetNewArray(ref array);
            Console.Write("数组array = ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.ReadKey();

            int x = 2;
            int y = 3;
            int z;
            Add(x,y,out z);
            Console.WriteLine("输出参数实例");
            Console.WriteLine("z = " + z);
            Console.ReadKey();
        }
        /// <summary>
        /// 引用参数的应用
        /// </summary>
        /// <param name="newArray">整数数组</param>
        public static void GetNewArray(ref int[] newArray)
        {
            newArray = new int[] { 2,4,6,8};
        }
        /// <summary>
        /// 输出参数的应用
        /// </summary>
        /// <param name="a">整数a</param>
        /// <param name="b">整数b</param>
        /// <param name="result">两个整数的和</param>
        public static void Add(int a, int b, out int result)
        {
            result = a + b;
        }
    }
}
