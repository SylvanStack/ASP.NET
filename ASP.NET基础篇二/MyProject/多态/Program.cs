using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 多态
{
    //  多态实现   抽象 接口  虚方法
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Chinese("张三");
            Person p1 = new Korean("赵仁焕");
            Person p2 = new Americans("Mr.One");
            Person[] per = {p,p1,p2,new Chinese("张飞"),new Americans ("Mr.Two")};
            for (int i=0;i<per.Length;i++)
            {
                // 不用虚方法的话
                if(per[i] is Chinese)
                {
                    ((Chinese)per[i]).SayHello();
                }
                else if(per[i] is Korean)
                {
                    ((Korean)per[i]).SayHello();
                }
                else
                {
                    ((Americans)per[i]).SayHello();
                }
               //使用虚方法的情况
                per[i].SayHello();
            }
            Console.ReadKey();
            
        }
    }

    public class Person
    {
        private string name;
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }
        public Person(string name)
        {
            this.Name = name;
        }

        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }
    }
    public class Chinese: Person
    {
        public Chinese(string name):base(name)
        {
            this.Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine("我是一个中国人,我的名字叫"+Name);
        }
    }
    public class Korean : Person
    {
        public Korean(string name):base(name)
        {
            this.Name = name;
        }
        public override void SayHello()
        {
            Console.WriteLine("我是一个韩国人,我的名字叫" + Name);
        }
    }


    public class Americans : Person
    { 
         public Americans(string name):base(name)
       {
         this.Name = name;
       }
    public override void SayHello()
        {
            Console.WriteLine("我是一个美国人,我的名字叫" + Name);
        }
    }
}
