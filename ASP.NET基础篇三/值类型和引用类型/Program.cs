using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {

            //值类型 int double char bool enum struct  decimal
            //引用类型 类 抽象类 接口 string 数组 集合 object
            //值类型在栈中 复制的是本身

            int i1 = 10;
            int i2 = i1;
            Console.WriteLine("输出值  " + i1 + "---------- " + i2);
            i2 += 10;
            Console.WriteLine("i2+10后  " + i1 + "---------- " + i2);  //i2改变时两值的变化
            Jh(i1, i2);
            Console.WriteLine("无ref交换  " + i1 + "---------- " + i2);
            Jh(ref i1, ref i2);
            Console.WriteLine("有ref交换  " + i1 + "---------- " + i2);
            Jh(i1, i2);
            Console.WriteLine("字符串直接交换不需要ref  " + i1 + "---------- " + i2);

            //数组
            Person p1 = new Person();
            p1.Name = "张三";
            Person p2 = p1;
            p2.Name = "李四";
            Console.WriteLine("输出值  " + p1.Name + "---------- " + p2.Name);

            //字符串
            int[] i = { 32131 };
            int[] i3 = i;
            i3[0] = 21313;
            Console.WriteLine("输出值  " + i[0] + "---------- " + i3[0]);//输出首地址       



        }

        public static void Jh(int i3, int i4)   //方法重载
        {
            int i;
            i = i3;
            i3 = i4;
            i4 = i;
        }
        public static void Jh(string i3, string i4)
        {
            string i;
            i = i3;
            i3 = i4;
            i4 = i;
        }
        public static void Jh(ref int i3, ref int i4)
        {
            int i;
            i = i3;
            i3 = i4;
            i4 = i;
        }
    }
    public class Person
    {
        public string Name { get; set; }
    }
}
