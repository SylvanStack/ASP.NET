using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFMvc.Models
{
    public class Student
    {

        /// <summary>
        /// 学生编号 主键
        /// </summary>
        public int StuId { get; set; }
        /// <summary>
        /// 学生性别
        /// </summary>
        public string Sex { get; set; }
        /// <summary>
        /// 学生年龄
        /// </summary>
        public Nullable<int> Age { get; set; }
        /// <summary>
        /// 班级id
        /// </summary>
        public int ClassId { get; set; }
        /// <summary>
        /// 登陆名
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 密码
        /// </summary>
        public string NicKName { get; set; }
        /// <summary>
        /// 信息录入时间   或者入学时间
        /// </summary>
        public string AddTime { get; set; } = DateTime.Now.ToString();
        /// <summary>
        /// 学籍是否被移除
        /// </summary>
        public Nullable<bool> DelFlag { get; set; } = false;
        /// <summary>
        /// 自我评价
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 最后一次修改时间
        /// </summary>
        public string LastTime { get; set; } = DateTime.Now.ToString();
    }
}