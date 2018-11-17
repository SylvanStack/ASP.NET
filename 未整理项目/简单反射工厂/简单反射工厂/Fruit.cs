using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单反射工厂
{
    class Fruit             // 水果类
    {
        //定义虚方法 
        public virtual void Eating()
        {
            Console.WriteLine("水果有各种吃法。。。");
        }
    }

    class Banana : Fruit 	// 香蕉类
    {
        public override void Eating()
        {
            Console.WriteLine("香蕉扒皮吃。。。");
        }
    }

    class Orange : Fruit 	// 橘子类
    {
        public override void Eating()
        {
            Console.WriteLine("橘子剥皮吃。。。");
        }
    }

    class Apple : Fruit 	// 苹果类
    {
        public new void Eating()
        {
            Console.WriteLine("苹果洗了吃。。。");
        }

        //public override void Eating()
        //{
        //    Console.WriteLine("苹果洗了吃。。。");
        //} 
    }
}
