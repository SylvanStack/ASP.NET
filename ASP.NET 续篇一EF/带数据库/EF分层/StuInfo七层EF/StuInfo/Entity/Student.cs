using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    /// <summary>
    /// 学生类
    /// </summary>
    public class Student
    {
        /// <summary>
        /// 学生ID
        /// </summary>
        public int StuId { get; set; }

        /// <summary>
        /// 学生所属班级ID
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// 学生姓名
        /// </summary>
        public string StuName { get; set; }

        /// <summary>
        /// 学生登陆名
        /// </summary>
        public string LoginName { get; set; }

        /// <summary>
        /// 登陆密码
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 学生记录被修改时间
        /// </summary>
        public DateTime UpDateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 标记是否删除
        /// </summary>
        public int DelFlag { get; set; } = 0;

        /// <summary>
        /// 学生的评论
        /// </summary>
        public string Remark { get; set; }
    }
}
