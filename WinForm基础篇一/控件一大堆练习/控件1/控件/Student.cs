using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 控件
{
    public class Student
    {

        /// <summary>
        /// 学号
        /// </summary>
        public string ID { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 学生年龄
        /// </summary>
        public int Age { get; set; }



        /// <summary>
        /// 学生性别 true-男，false-女
        /// </summary>
        public bool Gender { get; set; }


        /// <summary>
        /// 学生性别  
        /// </summary>
        public string GenderText
        {
            get
            {
                return Gender ? "男" : "女";
            }
            set
            {

            }
        }

    }
}
