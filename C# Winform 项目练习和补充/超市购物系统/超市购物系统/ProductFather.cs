using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    public  abstract class ProductFather
    {
        /// <summary>
        /// 商品名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 商品单价
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// 商品Guid
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        /// <param name="id"></param>
        public ProductFather(string name, double price, string id)
        {
            Name = name;
            price = Price;
            ID = id;
        }

    }
}
