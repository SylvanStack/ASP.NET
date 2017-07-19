using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 委托
{
    public delegate void Wt();//无参无返回值委托
    public delegate void WtStr(string str);//有参无返回值委托
    public delegate string StrWt();//无参有返回值委托
    public delegate string StrWtStr(string str);//有参有返回值委托
    public delegate T  StrFXwt<T>(T i, T j);//带返回值的泛型委托

    public  class Program
    {
        
       // public static Action Get { get; set; }
        static void Main(string[] args)
        {
            
        //StrChange(StrChangeD,"sadfsdfsdFGUUTFTYFYThgjutftyf");//大写
        //StrChange(StrChangeX, "sadfsdfsdFGUUTFTYFYThgjutftyf");//小写
        //StrChange(StrChangeS, "sadfsdfsdFGUUTFTYFYThgjutftyf");//双引

        //StrFXwt<string> str = Showstring;
        //Console.WriteLine( str("你还要怎样，","不咋样"));

        // StrFXwt<int> i = Showint;
        // Console.WriteLine(i(20, 20));

            Wt wt = ShowSting;
            wt();
            Action ac = ShowSting;
            ac();


            Console.ReadKey();
        }

        #region  Action 无参委托
        public static void ShowAc(Action Get)
        {

        }
         public static void ShowWt(Wt Get)
        {

        }
    

        public static void ShowSting()
        {
            Console.WriteLine("随便输出一段字符串");
        }
        public static void ShowInt()
        {
            Console.WriteLine(123324);
        }
        public static void ShowDouble()
        {
            Console.WriteLine(2312.1321);
        }
        #endregion

        #region  泛型委托
        public static string Showstring(string str, string str1)
        {
            return str + str1;
        }
        public static int Showint(int i, int j)
        {
            return i + j;
        }

        public static double Show(double f, double f2)
        {
            return f + f2;
        }
        #endregion

        #region  改变字符串

        public static void StrChange(WtStr strWtStr, string str)
        {
            strWtStr(str);
        }


        public static void StrChangeD(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        public static void StrChangeX(string str)
        {
            Console.WriteLine(str.ToLower());
        }

        public static void StrChangeS(string str)
        {
            Console.WriteLine("\"" + str + "\"");
        }
        #endregion


    }
}
