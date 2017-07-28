using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFMvc
{
    /// <summary>
    /// 分页参数
    /// </summary>
    public class PageParam
    {/// <summary>
     /// 当前页行数默认10
     /// </summary>
        public int PageSize { get; set; } = 10;

        /// <summary>
        /// 当前页码默认0
        /// </summary>
        public int PageIndex { get; set; } = 0;

        /// <summary>
        /// 当前排序列名称 
        /// </summary>
        public string OrderName { get; set; } = "CREATE_DATE";

        /// <summary>
        /// 当前排序方式 desc asc
        /// </summary>
        public string SortOrder { get; set; } = "desc";

        /// <summary>
        /// 返回数据总行数
        /// </summary>
        public int Total { get; set; }
    }
}