using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 日期
{
    class Date
    {
        private int year;
        private int month;
        private int day;

        public int Year
        {
            get
            {
                 return year;
            }
            set 
            {
                if(year>0)
                {
                    value = year;
                }
            }
        }

        public bool IsLeapYear()
        {
            return (year % 4 == 0 && year % 100 != 0 || year % 400 == 0);
        }

        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                if (month > 0 && month<13)
                {
                    value = month;
                }
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int days;
                 days = mon[month];
                  if (month == 2 && IsLeapYear())
                 {
                      days += 1;
                  }
            
                if(day>0&&day<=days)
                {
                    value = day;
                }
            }
        }

        public  Date(int year, int month, int day)
        {
            this.year = year;	
            this.month = month;	
            this.day = day;	
        }

        public string ConvertToString()
        {
            string str = year + "年" + month + "月" + day + "日";

            return str;
        }

        public bool ISDate(int year, int month, int day)
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
                int days;
                 days = mon[month];
                  if (month == 2 && IsLeapYear())
                 {
                      days += 1;
                  }
                  return ((year > 0) && (month > 0 && month <= 12) && (day > 0 && day <= days));
        }

        public string NowDate()
        {
            return DateTime.Now.Date.ToShortDateString();
        }

        public Date AddDay()
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
             int days;
             days = mon[month];
             if (month == 2 && IsLeapYear())
             {
                 days += 1;
             }
             else
             {
                 days = mon[month];
             }
            day=day+1;
            if(day>days)
            {
                month=month+1;
                day = 1;
            }
             if(month>12)
            {
                year=year+1;
                month = 1;
            }
            return new Date(year, month, day);
        }

        public Date Add7Day()
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days;
            days = mon[month];
            if (month == 2 && IsLeapYear())
            {
                days += 1;
            }
            int i;
            if (days - day < 7)
            {
                i = 7 - (days - day);
                day = i;
                month=month + 1;
            }
            else
            {
                day = day + 7;
            }
            if (month > 12)
            {
                year = year + 1;
                month = 1;
            }
            return new Date(year, month, day-2);
        }

           public Date Sub7Day()
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days;
            days = mon[month];
            if (month == 2 && IsLeapYear())
            {
                days += 1;
            }
            int i;
            if (day-7 <0 )
            {
                i = days-(7-day);
                day = i;
                month = month -1;
            }
            else
            {
                day = day - 7;
            }
            if (month < 1)
            {
                year = year - 1;
                month = 12;
            }
            return new Date(year, month, day);
        }

        public Date SubDay()
        {
            int[] mon = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            int days;
            days = mon[month];
            if (month == 2 && IsLeapYear())
            {
                days += 1;
            }
            day = day - 1;
            if (day<0)
            {
                day = days;
                month = month - 1;
            }
            if (month < 1)
            {
                year = year - 1;
                month = 12;
            }
            return new Date(year, month, day-2);
        }

        public Date Subyear()
        {
             year = year - 1;
             return new Date(year, month, day);
        }

        public Date Addyear()
        {
            year = year + 1;
            return new Date(year, month, day);
        }
    }
}
