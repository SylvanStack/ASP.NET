using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Web;

namespace _7_15作业
{
    class Program
    {


        static void Main(string[] args)
        {
            string a = "sdfdsf";
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            string b = BitConverter.ToString(md5.ComputeHash(UTF8Encoding.Default.GetBytes(a)), 4, 8);
            Console.WriteLine(b);
            Console.WriteLine(b.Replace("-", ""));
            Console.WriteLine();

            Console.ReadKey();


            //string abc = "sdsdsddf564212SSDCF";
            //Console.WriteLine(MD5Encrypt(abc));
            //Console.ReadKey();
        }
        public static string MD5Encrypt(string strText)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] result = md5.ComputeHash(Encoding.Default.GetBytes(strText));
            return System.Text.Encoding.Default.GetString(result);
        }
    }
}
