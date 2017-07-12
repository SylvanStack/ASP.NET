using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 抽象类
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal qw = new Dog();//new Dog(); new Cat();new Qw();
            qw.Jiao();


            Console.ReadKey();
        }
    }

    public abstract class Animal    //抽象类  没有方法体  继承者必须实现抽象方法 
    {
        private int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public Animal(int age)
        {
            this.Age = age;
        }

        public Animal()
        {
        }
        public abstract void Jiao();  //没有方法体  有抽象方法的一定是抽象类  但是抽象类不一定有抽象方法
        //虚方法 有方法体 在子类中可以被实现也可以不被实现
        public abstract string Name { get; set; } //在子类中必须实现
    }

    public  class  Cat: Animal
    {
        

        public override void  Jiao ()
        {
            Console.WriteLine("小猫    喵喵叫");
        }
        public override string Name
        {
            get;
            set;
        }
    }

    public class Dog : Animal
    {  
        public override void Jiao()
        {
            Console.WriteLine("小狗    汪汪叫");
        }
        public override string Name
        {
            get;
            set;
        }
    }

    public class Qw : Animal
    {
       
        public override void Jiao()
        {
            Console.WriteLine("青蛙    呱呱叫");
        }
        public override string Name
        {
            get;
            set;
        }
    }

}
