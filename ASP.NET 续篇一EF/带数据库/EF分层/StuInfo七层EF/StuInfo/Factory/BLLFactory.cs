using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using IBLL;

namespace Factory
{
    public class BLLFactory
    {
        private static string spaceName = ConfigurationManager.AppSettings["bll"].ToString();

        /// <summary>
        /// 反射出StuBLL类，得到StuBLL实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IStuBLL<T> GetStuBLLInstance<T>()
        {
            string className = spaceName + "." + ConfigurationManager.AppSettings["stuBLL"].ToString();

            return (IStuBLL<T>)Assembly.Load(spaceName).CreateInstance(className);
        }

        /// <summary>
        /// 反射出ClassBLL类，得到ClassBLL实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IClassBLL<T> GetClassBLLInstance<T>()
        {
            string className = spaceName + "." + ConfigurationManager.AppSettings["classBLL"].ToString();

            return (IClassBLL<T>)Assembly.Load(spaceName).CreateInstance(className);
        }
    }
}
