using System;
using System.Collections.Generic;
using System.Text;

namespace RentalSystem
{
    /// <summary>
    /// 车辆类 描述车辆的一些基本信息
    /// </summary>
    public abstract class Vehicle
    {
        public Vehicle() { }
        public Vehicle(string licenseNO, string name, string color, int yearsOfService, double dailyRent)
        {
            this.LicenseNO = licenseNO;
            this.Name = name;
            this.Color = color;
            this.YearsOfService = yearsOfService;
            this.DailyRent = dailyRent;
        }
        /// <summary>
        /// 车牌号
        /// </summary>
        private string licenseNO;
        public string LicenseNO
        {
            get { return licenseNO; }
            set { licenseNO = value; }
        }
        /// <summary>
        /// 车名
        /// </summary>
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>
        /// 颜色
        /// </summary>
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// 使用年限
        /// </summary>
        private int yearsOfService;
        public int YearsOfService
        {
            get { return yearsOfService; }
            set { yearsOfService = value; }
        }
        /// <summary>
        /// 日租金
        /// </summary>
        private double dailyRent;
        public double DailyRent
        {
            get { return dailyRent; }
            set { dailyRent = value; }
        }
        //租用者
        private string rentUser;
        public string RentUser
        {
            get { return rentUser; }
            set { rentUser = value; }
        }
        //租用日期
        private int rentDate;
        public int RentDate
        {
            get { return rentDate; }
            set { rentDate = value; }
        }
        /// <summary>
        /// 计算价格的方法
        /// </summary>
        /// <returns></returns>
        public abstract double CalcPrice();
    }
}
