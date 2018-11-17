using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单反射工厂
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitFactory ff = new FruitFactory();

            //打印（来自父类的）：水果有各种吃法。。。 
            Fruit fA = ff.CreateFruit("Apple");
            fA.Eating();

            //打印（来自子类的）：苹果洗了吃。。。 
            Apple apple = ff.CreateFruit("Apple") as Apple;
            apple.Eating();

            Fruit fB = ff.CreateFruit("Banana");
            fB.Eating();

            Fruit fC = ff.CreateFruit("Orange");
            fC.Eating();
        }
    }
}
