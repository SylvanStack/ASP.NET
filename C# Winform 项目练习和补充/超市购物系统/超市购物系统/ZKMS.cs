using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    
    public   class ZKMS :CalFather  //折扣买..送..
    {
        /// <summary>
        /// 买的钱数
        /// </summary>
        public double M { get; set; }
        /// <summary>
        /// 送的钱数
        /// </summary>
        public double N { get; set; }
        public ZKMS(double m, double n)
        {
            M = m;
            N = n;
        }
        public override double GetTotalMoney(double realMoney)
        {
            if(realMoney>=M)
            {
                return realMoney - (int)(realMoney / M) * N;
            }
            else
            {
                return realMoney;
            }

        }
    }
}
