using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace 序列化和反序列化
{
    class Program
    {
        static void Main(string[] args)
        {

            //将对象传输给对方电脑
            //Person p = new Person();
            //p.Age = 21;
            //p.Gerder = "男";
            //p.Name = "张三";
            //using (FileStream fil = new FileStream(@"123.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    BinaryFormatter bf = new BinaryFormatter();
            //    bf.Serialize(fil, p);
            //}
            //Console.WriteLine("序列化成功");
            //Console.ReadKey();

            using (FileStream fil = new FileStream(@"123.txt", FileMode.OpenOrCreate, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                Person p1 =new Person ((Person)bf.Deserialize(fil));
                Console.WriteLine(p1.Name+"\n"+p1.Age+ "\n"+p1.Gerder);
            }
            Console.WriteLine("反序列化成功");
            Console.ReadKey();


        }
    }

    [Serializable]
    public class Person
    {
        public Person(Person p)
        {
            this.Name = p.Name;
            this.Age = p.Age;
            this.Gerder = p.Gerder;
        }
        public Person()
        {
           
        }

        public string Name { get; set; }
        public int Age { get; set; }
        public string Gerder { get; set; }
    }
}
