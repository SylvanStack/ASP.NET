using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _02MD5格式
{
    class Program
    {

        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string MD5Str;
            MD5Str = MD5ncrypt(str);
            Console.WriteLine("MD5加密后：");
            Console.WriteLine(MD5Str);
            Console.ReadKey();
            string filePath = "123.txt";
            string MD5file;
            MD5file = MD5FileNcrypt(filePath);
            Console.WriteLine(MD5file);
            Console.ReadKey();
        }
        /// <summary>
        /// 字符串加密
        /// </summary>
        /// <param name="input">需加密字符串</param>
        /// <returns></returns>
        public static string MD5ncrypt(string input)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] byts = Encoding.UTF8.GetBytes(input);
            byts = md5.ComputeHash(byts);
            StringBuilder s = new StringBuilder();
            foreach (byte b in byts)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            return s.ToString();
        }
        /// <summary>
        /// 计算文件MD5值
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns></returns>
        public static string MD5FileNcrypt(string filePath)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] md5ch;
            using (FileStream fs=File.OpenRead(filePath))
            {
                md5ch = md5.ComputeHash(fs);
            }
            md5.Clear();
            string strMd5 = "";
            for (int i = 0; i < md5ch.Length; i++)
            {
                strMd5 += md5ch[i].ToString("x").PadLeft(2,'0');
            }
            return strMd5;
        }
    }
}
