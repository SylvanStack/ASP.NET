using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    public class HaveZK : CalFather
    {
        /// <summary>
        /// 折扣率
        /// </summary>
        public double ZKL { get; set; }
        public HaveZK(double zkl)
        {
            ZKL = zkl;
        }

        /// <summary>
        /// 返回打折后价格
        /// </summary>
        /// <param name="realMoney"></param>
        /// <returns></returns>
        public override double GetTotalMoney(double realMoney)
        {
            return realMoney * ZKL;
        }
    }
}
