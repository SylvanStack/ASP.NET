using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BootStrapTableTest
{
    /// <summary>
    /// 表示Ajax操作结果 
    /// </summary>
    public class AjaxResult
    {
        /// <summary>
        /// 获取 Ajax操作结果类型
        /// </summary>
        public ResultType type { get; set; }

        /// <summary>
        /// 获取 Ajax操作结果编码
        /// </summary>
        public int errorcode { get; set; }

        private string _message;
        /// <summary>
        /// 获取 消息内容
        /// </summary>
        public string message
        {
            get { return _message == null ? string.Empty : _message; }
            set { _message = value; }
        }

        /// <summary>
        /// 获取 返回数据
        /// </summary>
        public object resultdata { get; set; }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="resultType"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="resultData"></param>
        public AjaxResult()
        {
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="resultType"></param>
        /// <param name="errorCode"></param>
        /// <param name="message"></param>
        /// <param name="resultData"></param>
        public AjaxResult(ResultType resultType, string message, object resultData)
        {
            this.type = resultType;
            this.message = message;
            this.resultdata = resultData;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="resultType"></param>
        /// <param name="errorCode"></param>
        /// <param name="resultMessage"></param>
        /// <param name="resultData"></param>
        public AjaxResult(ResultType resultType, int errorCode, string resultMessage, object resultData)
        {
            this.type = resultType;
            this.errorcode = errorCode;
            this.message = resultMessage;
            this.resultdata = resultdata;
        }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="ex"></param>
        public AjaxResult(Exception ex)
        {
            this.type = ResultType.error;
            this.message = ex.Message;
        }
    }
    /// <summary>
    /// 表示 ajax 操作结果类型的枚举
    /// </summary>
    public enum ResultType
    {
        /// <summary>
        /// 消息结果类型
        /// </summary>
        info = 0,

        /// <summary>
        /// 成功结果类型
        /// </summary>
        success = 1,

        /// <summary>
        /// 警告结果类型
        /// </summary>
        warning = 2,

        /// <summary>
        /// 异常结果类型
        /// </summary>
        error = 3
    }
}
