using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 身份证号码验证
{
    class IDCard
    {
        private string id;

        public IDCard(string id)
        {
            this.id = id;
        }

        public string GetYear()
        {
            return id.Substring(6, 4);
        }

        public string GetMonth()
        {
            return id.Substring(10, 2);
        }

        public string GetDay()
        {
            return id.Substring(12, 2);
        }

        public string GetBirDay()
        {
            return GetYear() + GetMonth() + GetDay();
        }

        public string GetSex()
        {
            return int.Parse(id.Substring(16, 1)) % 2 == 0 ? "女" : "男";
        }

        private bool IsIDCard()
        {
            return id.Length == 18;
        }

        public  string GetAdress()
        {
            string[] adressid = { "11", "12", "13", "14", "15", "21", "22", "23", "31", "32", "33", "34", "35", "36", "37", "41", "42", "43", "44", "45", "46", "50", "51", "52", "53", "54", "61", "62", "63", "64", "65", "71", "81", "82" };
            string[] adressname = { "北京", "天津", "河北", "山西", "内蒙古", "辽宁", "吉林", "黑龙江", "上海", "江苏", "浙江", "安徽", "福建", "江西", "山东", "河南", "湖北", "湖南", "广东", "广西", "海南", "重庆", "四川", "贵州", "云南", "西藏", "陕西", "甘肃", "青海", "宁夏", "新疆", "台湾", "香港", "澳门" };

            for (int i = 0; i < adressid.Length; i++)
            {
                if (id.Substring(0, 2) == adressid[i])
                {
                    return adressname[i];
                }
            }
            return "";
        }

        private bool CheckAdress()
        {
            return GetAdress() != "";
        }

        private bool IsLeapYear()
        {
            int year = int.Parse(GetYear());
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }

        private int DaysOfMonth()
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days;
            int month = int.Parse(GetMonth());

            days = mon[month];
            if (month == 2 && IsLeapYear())
            {
                days += 1;
            }
            return days;
        }

        public string GetAge()
        {
            int day = int.Parse(GetDay());
            int year = int.Parse(GetYear());
            int month = int.Parse(GetMonth());

            if (year > 0 && year < DateTime.Now.Year && month > 0 && month <= 12 && day > 0 && day <= DaysOfMonth())
            {
                int age = DateTime.Now.Year - year;
                if (DateTime.Now.Month < month)
                {
                    age = age - 1;
                }
                if (DateTime.Now.Month == month && DateTime.Now.Day < day)
                {
                    age = age - 1;
                }
                return Convert.ToString(age);
            }
            else return "";
        }

        private bool CheckAge()
        {
            return GetAge() != "";
        }

        public bool IsCheckCode()
        {

            int i = 1;
            foreach (char x in id)
            {
                if ((id.Length < 15) || (id.Length > 18))
                {
                    i = 0;
                }
                else if (id.Length == 18)
                {
                    if (!((x >= '0') && (x <= '9') || ((id[17].ToString() == "x") || (id[17].ToString() == "X"))))
                    {
                        i = 1;
                    }
                    else
                    {
                        i = 0;
                    }
                }
                else if (id.Length == 15)
                {
                    if (!((x >= '0') && (x <= '9')))
                    {
                        i = 0;
                    }
                    else
                    {
                        i = 1;
                    }
                }

            }
            int Si = 0;
            int[] Wi = new int[] { 7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2 };
            string LastCode = "10X98765432";
            for (int j = 0; j < 17; j++)
            {
                Si += int.Parse(id.Substring(j, 1)) * Wi[j];
                Console.WriteLine("{0}", Si);
            }
            int iY = Si % 11;
            if (LastCode[iY] == id[17])
            {
                i = 1;
            }
            else
            {
                i = 0;
            }
            if (i == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        private bool CheckIdCard()
        {
            return (IsCheckCode() && CheckAdress() && CheckAge());
        }

        public  string JudgeStarSign(string id)
        {
            string[] startdate = { "0101", "0120", "0219", "0321", "0420", "0521", "0622", "0723", "0823", "0923", "1023", "1122", "1222" };
            string[] enddate = { "0119", "0218", "0318", "0419", "0520", "0621", "0722", "0822", "0922", "1022", "1121", "1221", "1301" };
            string[] startsign = { "摩羯座", "水瓶座", "双鱼座", "白羊座", "金牛座", "双子座", "巨蟹座", "狮子座", "处女座", "天秤座", "天蝎座", "射手座", "摩羯座" };
            string date = id.Substring(10, 4); ;

            for (int i = 0; i < startdate.Length; i++)
            {
                if (date.CompareTo(startdate[i]) >= 0 && date.CompareTo(enddate[i]) <= 0)
                    return startsign[i];
            }
            return "无法检验";
        }

        public string GetZodiac(string id)
        {
            int x = Int32.Parse(id.Substring(6, 4));
            x = x % 12;
            string[] shengxiao = { "鸡", "狗", "猪", "老鼠", "牛", "老虎", "兔子", "龙", "蛇", "马", "羊", "猴子" };
            return  shengxiao[x-1];
        }
    }
}
