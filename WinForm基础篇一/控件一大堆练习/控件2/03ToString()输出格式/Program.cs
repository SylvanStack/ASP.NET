using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03ToString__输出格式
{
    class Program
    {
        static void Main(string[] args)
        {

//            日期格式模式 说明
//d 月中的某一天。一位数的日期没有前导零。
//dd 月中的某一天。一位数的日期有一个前导零。
//ddd 周中某天的缩写名称，在 AbbreviatedDayNames 中定义。
//dddd 周中某天的完整名称，在 DayNames 中定义。
//M 月份数字。一位数的月份没有前导零。
//MM 月份数字。一位数的月份有一个前导零。
//MMM 月份的缩写名称，在 AbbreviatedMonthNames 中定义。
//MMMM 月份的完整名称，在 MonthNames 中定义。
//y 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示不具有前导零的年份。
//yy 不包含纪元的年份。如果不包含纪元的年份小于 10，则显示具有前导零的年份。
//yyyy 包括纪元的四位数的年份。
//gg 时期或纪元。如果要设置格式的日期不具有关联的时期或纪元字符串，则忽略该模式。
//h 12 小时制的小时。一位数的小时数没有前导零。
//hh 12 小时制的小时。一位数的小时数有前导零。
//H 24 小时制的小时。一位数的小时数没有前导零。
//HH 24 小时制的小时。一位数的小时数有前导零。
//m 分钟。一位数的分钟数没有前导零。
//mm 分钟。一位数的分钟数有一个前导零。
//s 秒。一位数的秒数没有前导零。
//ss 秒。一位数的秒数有一个前导零。
//f 秒的小数精度为一位。其余数字被截断。
//ff 秒的小数精度为两位。其余数字被截断。
//fff 秒的小数精度为三位。其余数字被截断。
//ffff 秒的小数精度为四位。其余数字被截断。
//fffff 秒的小数精度为五位。其余数字被截断。
//ffffff 秒的小数精度为六位。其余数字被截断。
//fffffff 秒的小数精度为七位。其余数字被截断。
//t 在 AMDesignator 或 PMDesignator 中定义的 AM / PM 指示项的第一个字符（如果存在）。
//tt 在 AMDesignator 或 PMDesignator 中定义的 AM / PM 指示项（如果存在）。
//z 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数没有前导零。例如，太平洋标准时间是“-8”。
//zz 时区偏移量（“+”或“-”后面仅跟小时）。一位数的小时数有前导零。例如，太平洋标准时间是“-08”。
//zzz 完整时区偏移量（“+”或“-”后面跟有小时和分钟）。一位数的小时数和分钟数有前导零。例如，太平洋标准时间是“-08:00”。
//: 在 TimeSeparator 中定义的默认时间分隔符。
/// 在 DateSeparator 中定义的默认日期分隔符。
//% c 其中 c 是格式模式（如果单独使用）。如果格式模式与原义字符或其他格式模式合并，则可以省略“%”字符。
/// c 其中 c 是任意字符。照原义显示字符。若要显示反斜杠字符，请使用“//”。

            string str = "fymdt";
            Console.WriteLine(DateTime.Now.ToString());
            Console.WriteLine("不同的中文时间显示：");
            foreach (char item in str)
            {
                Console.WriteLine(DateTime.Now.ToString(item+"")+" ");
            }
            Console.WriteLine(DateTime.Now.ToString("yy-MM-dd"));
            Console.WriteLine(DateTime.Now.ToString("yy月MM月dd日"));
            Console.WriteLine("数字的显示");
            Console.WriteLine(1234.ToString("d5"));    //十进制
            Console.WriteLine(1234.ToString("n"));     //数字
            Console.WriteLine(1234.ToString("c"));     //货币
            Console.WriteLine(1234.ToString("e"));     //科学数
            Console.WriteLine(1234.ToString("f4"));    //固定点
            Console.WriteLine(1234.ToString("x"));     //十六进制
            Console.WriteLine(1234.ToString("p"));     //百分数
            Console.ReadKey();
        }
    }
}
