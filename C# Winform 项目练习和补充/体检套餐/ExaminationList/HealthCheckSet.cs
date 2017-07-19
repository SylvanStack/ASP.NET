using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationList
{
    /// <summary>
    /// 体检套餐类
    /// 每个套餐包括要检查的项目、套餐名称、总价
    /// </summary>
    public class HealthCheckSet
    {
        public HealthCheckSet()
        {
            items = new Dictionary<string, HealthCheckItem>();
        }
        public HealthCheckSet(string name, Dictionary<string, HealthCheckItem> items)
        {
            this.Name = name;
            this.items = items;
        }

        /// <summary>
        /// 套餐名称
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 检查项目
        /// </summary>
        private Dictionary<string, HealthCheckItem> items;
        public Dictionary<string, HealthCheckItem> Items
        {
            get { return items; }
            set { items = value; }
        }
        /// <summary>
        /// 套餐价格
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
        }
        /// <summary>
        /// 套餐计算方法
        /// </summary>
        public void CalcPrice()
        {
            int totalPrice = 0;
            foreach (HealthCheckItem item in items.Values)
            {
                totalPrice += item.Price;
            }
            this.price = totalPrice;
        }
    }
}
