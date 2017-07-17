using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap4Demo
{
    /// <summary>
    /// 员工类
    /// </summary>
     public  class SE
    {
         /// <summary>
         /// 员工工号
         /// </summary>
         public  string ID { get;set; }

         /// <summary>
         /// 员工姓名
         /// </summary>
         public string JobName { get; set; }

         /// <summary>
         /// 员工年龄
         /// </summary>
         public int Age { get; set; }


         /// <summary>
         /// 员工性别  true-男，false-女
         /// </summary>
         public bool Gender { get; set; }

         public string GenderText
         {
             get
             {
                 return Gender ? "男" : "女";
             }
         }
    }
}
