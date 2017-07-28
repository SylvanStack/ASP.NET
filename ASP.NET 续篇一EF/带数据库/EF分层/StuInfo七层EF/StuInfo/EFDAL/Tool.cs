using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDAL
{
    /// <summary>
    /// 工具类
    /// </summary>
    public static class Tool
    {
        /// <summary>
        /// 上下文
        /// </summary>
        private static StuInfo_Entities context { get; } = new StuInfo_Entities();

        /// <summary>
        /// 获取上下文
        /// </summary>
        /// <returns></returns>
        public static StuInfo_Entities GetContext()
        {
            return context;
        }
    }
}
