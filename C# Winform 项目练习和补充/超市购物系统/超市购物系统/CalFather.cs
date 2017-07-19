using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
     public abstract  class CalFather
    {
        /// <summary>
        /// 得到打折后的商品价格
        /// </summary>
        /// <param name="realMoney">商品打折前价格</param>
        /// <returns></returns>
        public abstract double GetTotalMoney(double realMoney);
    }
}
