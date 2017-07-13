using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 简单的工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            GetNoteBook(Console.ReadLine()).SayHello();
            Console.ReadKey();
        }
        //设计模式
        //四要素 模式名称、问题、解决方案、效果
        //基本模式 工厂模式、建造者模式、单例模式  设计模式是软件工程的基石脉络，如同大厦的结构一样
        //创建型模式：单例模式、抽象工厂模式、建造者模式、工厂模式、原型模式。
        //结构型模式：适配器模式、桥接模式、装饰模式、组合模式、外观模式、享元模式、代理模式。
       // 行为型模式：模版方法模式、命令模式、迭代器模式、观察者模式、中介者模式、备忘录模式、解释器模式（Interpreter模式）、状态模式、策略模式、职责链模式(责任链模式)、访问者模式。
        //
        //
        //
        //



        public static NoteBook GetNoteBook(string NoteBookName)
        {
            NoteBook nb = null;
            switch (NoteBookName)
            {
                case "LX":
                    {
                        nb = new LX();
                        break;
                    }
                case "DR":
                    {
                        nb = new DR();
                        break;
                    }
                case "XXX":
                    {
                        nb = new XXX();
                        break;
                    }
            }
            return nb;
        }
    }

    public abstract class NoteBook
    {
        public abstract void SayHello();
    }

    public class LX: NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是联想笔记本");
        }
    }
    public class DR : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是戴尔笔记本");
        }
    }
    public class XXX : NoteBook
    {
        public override void SayHello()
        {
            Console.WriteLine("我是XXX笔记本");
        }
    }
}
