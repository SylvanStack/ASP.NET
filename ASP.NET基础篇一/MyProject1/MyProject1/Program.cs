using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MyProject1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person p = new Student();
            if (p is Student)
            {
                ((Student)p).StudentSayHello();
            }
            else
            {
                Console.WriteLine("转化失败");
            }
            
            
            Dictionary<int, string> dc = new Dictionary<int, string>();
            dc.Add(1, "张三");
            dc.Add(2, "李四");
            dc.Add(3, "王五");
            dc.Add(4, "刘六");

            dc[4] = "孙七";

            foreach ( KeyValuePair<int ,string > ke  in dc)
            {
                Console.WriteLine("{0}.......{1}",ke.Key,ke.Value);
            }

            foreach( var i in dc.Keys )
            {
                Console.WriteLine(i+"......."+dc[i].ToString());
            }

            Hashtable ht = new Hashtable();
            ht.Add(1, "张三");
            ht.Add(2, "李四");
            ht.Add(3, "王五");
            ht.Add(4, "刘六");
            dc[4] = "孙七";
            Console.WriteLine(ht[4]);
            foreach (var i in ht.Keys)
            {
                Console.WriteLine(i + "......." + ht[i].ToString());
            }



            ArrayList al = new ArrayList();

            al.Add("123");
            al.Add("345");
            al.Add("165");

            al.AddRange(new string[] {"asdsd","asdsad","asdfaf" });

            foreach (string i in al)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();



            List<int> lst = new List<int>();

            ArrayList alst = new ArrayList();

            Stopwatch sw = new Stopwatch();

            sw.Start();

            for( int  i = 0;i<=10000000;i++)
            {
               lst.Add(i);
               //alst.Add(i);
            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);

            //文件读写
            byte[] bt = File.ReadAllBytes(@"C:\Users\Mr.Seven\Desktop\123.txt");
            string str = Encoding.UTF8.GetString(bt);
            Console.WriteLine(str);

            //文本内容的添加
            string contentadd = "你可能不知道我在添加一些东西";

            byte[] bte= Encoding.UTF8.GetBytes(contentadd);

            File.WriteAllBytes(@"C:\Users\Mr.Seven\Desktop\123.txt", bte);


            int [] i1 = { 1,2,3,4,5,6,7,8,9,};

            List<int> Os = new List<int>();
            List<int> Js = new List<int>();
            for(int i=0; i<i1.Length;i++)
            {
               if(i1[i]%2==0)
                {
                    Os.Add(i1[i]);
                }
               else
                {
                    Js.Add(i1[i]);
                }
            }
            Js.AddRange(Os);

            foreach (int i in Js)
            {
                Console.Write(i+"  ");
            }
            

            string str1="Welcome to bejing"




            Console.ReadKey();


        }

        
    }




   

    class Person
    {
        public  void PersonSayHello()
        {
            Console.WriteLine("我是好人");
        }
    }

    class Student: Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

}
