using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 超市购物系统
{
    public  class CangKu
    {
        //仓库可取可存可展示商品库存



        List<List<ProductFather>> list = new List<List<ProductFather>>();  //定义泛型嵌套泛型集合



        /// <summary>
        /// 展示商品库存
        /// </summary>
        public void  ShowProduct()
        {
            string str="我们超市有的商品";
            foreach(var item in list)
            {
                str += string.Format("商品名称：{0，-7}，商品个数：{1，-7}，商品价格：{2，-7} ",item[0].Name,item.Count,item[0].Price);
            }
            Console.WriteLine(str);
        }



        /// <summary>
        /// 仓库进货
        /// </summary>
        /// <param name="type">进货产品类型</param>
        /// <param name="number">进货产品数量</param>
        public void JinProduct(string type,int number)
        {
            for (int i = 0; i < number; i++)
            {
                switch (type)
                {
                    case "Honor":
                        list[0].Add(new Honor("Honor", 4342, Guid.NewGuid().ToString()));
                        break;
                    case "Jiangyou":
                        list[1].Add(new Jiangyou("Jiangyou", 4332, Guid.NewGuid().ToString()));
                        break;
                    case "Pen":
                        list[2].Add(new Pen("Pen", 1223, Guid.NewGuid().ToString()));
                        break;
                    case "Apple":
                        list[3].Add(new Apple("Apple", 31000, Guid.NewGuid().ToString()));
                        break;
                }
            }
        }

        /// <summary>
        /// 取出货物
        /// </summary>
        /// <param name="type">取出货物类型</param>
        /// <param name="number">取出货物数量</param>
        /// <returns></returns>
        public ProductFather[] QuProduct(string type, int number)
        {
            ProductFather[] pro = new ProductFather[number];

            for(int i=0;i<pro.Length;i++)
            {
                switch (type)
                {
                    case "Honor":
                        pro[0] = list[0][0];
                        list.RemoveAt(0);
                        break;
                    case "Jiangyou":
                        pro[1] = list[1][0];
                        list.RemoveAt(0);
                        break;
                    case "Pen":
                        pro[2] = list[2][0];
                        list.RemoveAt(0);
                        break;
                    case "Apple":
                        pro[3] = list[3][0];
                        list.RemoveAt(0);
                        break;
                }
            }
            return pro;
        }
    }
}
