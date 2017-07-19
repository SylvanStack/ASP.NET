using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    public class NoZK : CalFather
    {
        /// <summary>
        /// 无折扣
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney;
        }
    }
}
