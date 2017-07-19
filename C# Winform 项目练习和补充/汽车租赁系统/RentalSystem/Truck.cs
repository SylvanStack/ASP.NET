using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    public class Truck:Vehicle
    {
        public Truck(string licenseNO, string name, string color, int yearsOfService, double dailyRent, int load)
            : base(licenseNO, name, color, yearsOfService, dailyRent)
        {
            this.Load = load;
        }
        
        private int load;
        public int Load
        {
            get { return load; }
            set { load = value; }
        }

        /// <summary>
        /// 卡车费用计算方法
        /// 30天以内(含30)按日租金计算
        /// 30天以上超出部分:每天，每吨（载重量）增加日租金10%
        /// </summary>
        public override double CalcPrice()
        {
            double totalPrice = 0;
            double basicPrice = this.RentDate * this.DailyRent;
            if (this.RentDate <= 30)
            {
                totalPrice = basicPrice;
            }
            else
            { 
                //30天以上超出部分:每天，每吨（载重量）增加日租金10%
                totalPrice = basicPrice + (this.RentDate - 30) * this.Load * this.DailyRent * 0.1;
            }
            return totalPrice;
        }
    }
}
