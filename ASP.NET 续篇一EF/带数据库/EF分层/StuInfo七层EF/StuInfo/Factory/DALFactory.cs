using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Reflection;
using IDAL;

namespace Factory
{
    public class DALFactory
    {
        private static string spaceName = ConfigurationManager.AppSettings["dal"].ToString();

        /// <summary>
        /// 反射出StuDAL类，得到StuDAL实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IStuDAL<T> GetStuDALInstance<T>()
        {
            string className = spaceName + "." + ConfigurationManager.AppSettings["stuDAL"].ToString();

            return (IStuDAL<T>)Assembly.Load(spaceName).CreateInstance(className);
        }

        /// <summary>
        /// 反射出ClassDAL类，得到ClassDAL实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static IClassDAL<T> GetClassDALInstance<T>()
        {
            string className = spaceName + "." + ConfigurationManager.AppSettings["classDAL"].ToString();

            return (IClassDAL<T>)Assembly.Load(spaceName).CreateInstance(className);
        }
    }
}
