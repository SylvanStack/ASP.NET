using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
   public  class Program
    {
        static void Main(string[] args)
        {
            SupperMarket su = new SupperMarket();

            su.ShowPro();
            su.AskBuying();
            Console.ReadKey();
        }
    }
}
