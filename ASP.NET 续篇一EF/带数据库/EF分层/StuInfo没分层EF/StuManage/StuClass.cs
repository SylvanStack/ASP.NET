using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuManage
{
    /// <summary>
    /// 学生班级类
    /// </summary>
    public class StuClass
    {
        /// <summary>
        /// 班级ID
        /// </summary>
        public int ClassId { get; set; }

        /// <summary>
        /// 班级名
        /// </summary>
        public string ClassName { get; set; }


        /// <summary>
        /// 班级记录被修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 标记是否删除
        /// </summary>
        public int DelFlag { get; set; } = 0;

        /// <summary>
        /// 班级描述
        /// </summary>
        public string Remark { get; set; }
    }
}
