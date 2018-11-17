using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection; 

namespace 简单反射工厂
{
    class FruitFactory
    {
        //生成水果 
        public Fruit CreateFruit(string fruitName)
        {
            /* 不使用反射的做法如下： 
            if (fruitName == "Apple") 
            { 
                return new Apple(); 
            } 
            else if (fruitName == "Banana") 
            { 
                return new Banana(); 
            } 
            else if (fruitName == "Orange") 
            { 
                return new Orange(); 
            } 
            else 
            { 
                throw new Exception("您指定的水果不生产！"); 
            } 
            */

            //获得当前程序的命名空间 
            string strNamespace = Assembly.GetExecutingAssembly().GetName().Name;

            //调用方法一：使用 Type 类 
            //Type type = Type.GetType(strNamespace + "." + fruitName); 
            //ConstructorInfo ctorInfo = type.GetConstructor(System.Type.EmptyTypes); 
            //// Invoke()方法：返回与构造函数关联的类的实例。 
            //Fruit fruitA = (Fruit)ctorInfo.Invoke(new object[0]); 
            //return fruitA; 
           

            //调用方法二：使用 Assembly 类 
            //Assembly myAssembly = Assembly.GetExecutingAssembly();
            //Fruit fruitB = (Fruit)myAssembly.CreateInstance(strNamespace + "." + fruitName);
            //return fruitB; 
           

            //调用方法三：使用 Activator 类 
            Fruit fruitC = (Fruit)Activator.CreateInstance(Type.GetType(strNamespace + "." + fruitName, false, true));
            return fruitC;
        }
    }
}
