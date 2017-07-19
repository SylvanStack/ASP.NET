using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    public class Car:Vehicle
    {
        public Car(string licenseNO, string name, string color, int yearsOfService, double dailyRent)
            : base(licenseNO, name, color, yearsOfService, dailyRent)
        {
            ;
        }

        /// <summary>
        /// 轿车的价格计算方法：
        /// 30天以内(含30)按日租金计算
        /// 30天以上超出部分:每天增加日租金10%
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
                totalPrice = basicPrice + (this.RentDate - 30) * this.DailyRent * 0.1;
            }
            return totalPrice;
        }
    }
}
