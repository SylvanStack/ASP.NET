using System;
using System.Collections.Generic;
using System.Text;

namespace ExaminationList
{
    /// <summary>
    /// 体检项目类
    /// 保存一个体检项目包括项目名、描述、单价
    /// 例如：肝功能、用于检察肝功能、60
    /// </summary>
    public class HealthCheckItem
    {
        public HealthCheckItem(string name, int price, string description)
        {
            this.Name = name;
            this.Description = description;
            this.Price = price;
        }
        public HealthCheckItem()
        {
        }
        
        /// <summary>
        /// 项目名称
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// 项目描述
        /// </summary>
        private string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        /// <summary>
        /// 项目价格
        /// </summary>
        private int price;
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
