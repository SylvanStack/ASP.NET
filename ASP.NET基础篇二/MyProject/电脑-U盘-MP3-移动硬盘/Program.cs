using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 电脑_U盘_MP3_移动硬盘
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer a = new Computer();
            a.Cup = new MP3();
            a.Read();
            a.Write();
            a.Read(new MoblieDisk());
            a.Write(new MoblieDisk());
            Console.ReadKey();
        }
    }

    #region  计算机类
    public  class Computer
    {
        public Moblie Cup { get; set; }

        public void Write()
        {
            Cup.Write();
        }

        public void Write(Moblie a)
        {
            a.Write();
        }

        public void Read()
        {
            Cup.Read();
        }
        public void Read(Moblie a)
        {
            a.Read();
        }
    }
    #endregion


    #region U盘  MP3  移动硬盘  Moblie抽象类
    public abstract class Moblie
    {
        public abstract void Write();
        public abstract void Read();
        
    }

    public class MP3: Moblie
    {
        public override  void Write()
        {
            Console.WriteLine("MP3正在写入内容");
        }
        public override void Read()
        {
            Console.WriteLine("MP3正在读取内容");
        }
        public void PlayMulic()
        {
            Console.WriteLine("MP3正在播放音乐");
        }
    }
    public class MoblieDisk : Moblie
    {
        public override void Write()
        {
            Console.WriteLine("移动硬盘正在写入内容");
        }
        public override void Read()
        {
            Console.WriteLine("移动硬盘正在读取内容");
        }
    }

    public class UDisk : Moblie
    {
        public override void Write()
        {
            Console.WriteLine("U盘正在写入内容");
        }
        public override void Read()
        {
            Console.WriteLine("移U盘正在读取内容");
        }
    }
    #endregion
}
