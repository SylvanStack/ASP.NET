using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 拉姆达
{
    public class Program
    {

        public delegate void Wt();
        public delegate void WtStr(List<string> list);
        static void Main(string[] args)
        {
            List<string > list = new List<string>();
            list.Add("你");
            list.Add("你怎么这样");
            list.Add("你还要怎样");
            list.Add("你猜啊");
            list.Add("不猜");
            list.Add("好吧");
            list.Add("你怎么这样1111");

            Console.WriteLine(list.FirstOrDefault(x => x == "你怎么这样"));

            list.RemoveAll(x => x == "好吧");     //Predicate 

            foreach(var str in list)
            {
                Console.WriteLine(str);
            }

            string str1 = "Welcome To Tianjin Electronic  Information  College";
            List<char> t = str1.Where(x => x >= 'A').ToList();
            foreach(char i in t)
            {
                Console.Write(i);
            }

            Console.WriteLine();




            Wt e =() => { Console.WriteLine("欢迎来到大电子"); };//局部变量和参数
            e();




            WtStr li = (str) => {

                List<string> lis = list.Where(x => x.Contains(str[0])).ToList();
                foreach( string i in lis)
                {
                    Console.WriteLine(i);
                }

            };
            
            li(list);

            Console.ReadKey();
        }
    }
}
