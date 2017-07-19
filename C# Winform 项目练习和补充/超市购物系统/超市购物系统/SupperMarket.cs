using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
     public   class SupperMarket
    {
        CangKu ck = new CangKu();//创建仓库类


        /// <summary>
        /// 创建超市的时候并给仓库上货
        /// </summary>
        public SupperMarket()
        {
            ck.JinProduct("Honor",100);
            ck.JinProduct("Apple",1000);
            ck.JinProduct("Pen",1000);
            ck.JinProduct("Jiangyou", 1000);
        }


        public void  AskBuying()
        {
            Console.WriteLine("老铁  你要点嘛");
            Console.WriteLine("Honor  Apple  Pen   Jiangyou");
            string str = Console.ReadLine();
            string[] str1 = { "Honor", "Apple", "Pen", "Jiangyou" };
            if(!str1.Contains(str))
            {
                Console.WriteLine("没货");
                str = Console.ReadLine();
            }

            Console.WriteLine("要多少");
            try
            {
                int i = int.Parse(Console.ReadLine());

                while (i .ToString() != Console.ReadLine())
                {
                    Console.WriteLine("请输入整数");
                }
                ProductFather[] pro = ck.QuProduct(str,i);

                double realMoney=GetMoney(pro);
                Console.WriteLine("你总共应付{0}元", realMoney);
                Console.WriteLine("打折方式 1-不打折  2-九折  3-八五折 4-买300送50 5-买500送100 ");
                string input = Console.ReadLine();
                CalFather c = GetCal(input);
                double result = c.GetTotalMoney(realMoney);
                Console.WriteLine("你打折后应付{0}元", result);
                Console.WriteLine("你所购产品信息");
                foreach(var xpro in pro)
                {
                    Console.WriteLine("{0}---{1}---{2}",xpro.Name,xpro.Price,xpro.ID);
                }




            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void ShowPro()
        {
            CangKu cang = new CangKu();
            cang.ShowProduct();
        }

        private CalFather GetCal(string input)
        {
            CalFather c = null;
            switch (input)
            {

                case "1":
                    c = new NoZK();
                    break;
                case "2":
                    c = new HaveZK(0.9);
                    break;
                case "3":
                    c = new HaveZK(0.85);
                    break;
                case "4":
                    c = new ZKMS(300,50);
                    break;
                case "5":
                    c = new ZKMS(500, 100);
                    break;
            }
            return c;
        }

        private double GetMoney(ProductFather[] pro)
        {
            double realMoney = 0;
            for(int i=0;i<pro.Length;i++)
            {
                realMoney += pro[i].Price;
            }
            return realMoney;
        }
    }
}
