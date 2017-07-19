//using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    public  class Jiangyou : ProductFather
    {
    
        /// <summary>
        /// 酱油类构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="id"></param>
        public Jiangyou(string name, double price, string id) :base(name,price, id)
        {

        }
    }
}
