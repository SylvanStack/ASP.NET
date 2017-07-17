using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chap5Demo
{
     public class SE
    {
         /// <summary>
         /// 员工工号
         /// </summary>
         public string ID { get; set; }

         /// <summary>
         /// 员工姓名
         /// </summary>
         public string Name { get; set; }

         /// <summary>
         /// 员工年龄
         /// </summary>
         public int Age { get; set; }



         /// <summary>
         /// 员工性别 true-男，false-女
         /// </summary>
         public bool Gender { get; set; }


         /// <summary>
         /// 员工性别  
         /// </summary>
         public string  GenderText
         { 
             get
             {
                 return Gender ? "男" : "女";
             }
         }
    }
}
