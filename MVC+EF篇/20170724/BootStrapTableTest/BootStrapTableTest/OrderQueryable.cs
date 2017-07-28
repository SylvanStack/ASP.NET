using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Web;

namespace BootStrapTableTest
{

// *	排序方法扩展									* //
// *	创建者：尚国睿								* //
// *	创建时间：2017-6-19							* //
// * ------------------------------------ * //
// *	查询表达式举例：								* //
// *	O.OrderByMulti("A,B", true)			* //
// *	对应order by O.A desc, O.B desc		* //
// *	O.OrderByMulti("A,B", false)			* //
// *	对应order by O.A asc, O.B asc			* //
// *	O.OrderByMulti("A asc,B", true)		* //
// *	对应order by O.A asc, O.B desc			* //
// *	O.OrderByMulti("A asc,B", false)		* //
// *	对应order by O.A asc, O.B asc			* //
// *	O.OrderByMulti("!A,B", true)			* //
//	*	对应order by O.A asc,O.B	desc			* //
// *	O.OrderByMulti("!A,B", false)			* //
//	*	对应order by O.A desc,O.B asc			* //
// *	O.OrderByMulti("!A desc,B", true)	* //
// *	对应order by O.A asc,O.B desc			* //
//	*	如果!和后边的desc同时存在时将忽略desc	* //
//	*   注意：逗号前面一定不要有空格，否则将会抛出错误
    public static class OrderedQueryable
    {
        /// <summary>
        /// 对可查询对象源根据传入排序表达示及是否倒序标记进行排序
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">可查询对象</param>
        /// <param name="propertiesName">排序表达式</param>
        /// <param name="isDesc">是否倒序，默认正序</param>
        /// <returns>排序后的结果</returns>
        public static IOrderedQueryable<T> OrderByMulti<T>(this IQueryable<T> source, string propertiesName, bool isDesc = false)
        {
            KeyValuePair<string, string>? orderby = null;
            var thenby = new List<KeyValuePair<string, string>>();
            if (!propertiesName.IsNullOrEmpty())
            {
                var properties = propertiesName.Split(',');
                foreach (var property in properties)
                {
                    var prop = property.Split(' ');
                    if (prop[0].StartsWith("!"))
                    {
                        if (orderby.HasValue)
                        {
                            thenby.Add(new KeyValuePair<string, string>(prop[0].Substring(1), (isDesc ? "ThenByDescending" : "ThenBy")));
                        }
                        else
                        {
                            orderby = new KeyValuePair<string, string>(prop[0].Substring(1), (isDesc ? "OrderByDescending" : "OrderBy"));
                        }
                    }
                    else
                    {
                        if (orderby.HasValue)
                        {
                            thenby.Add(new KeyValuePair<string, string>(prop[0], (prop.Length == 2 ? (prop[1].ToLower() == "desc" ? "ThenByDescending" : "ThenBy") : (isDesc ? "ThenByDescending" : "ThenBy"))));
                        }
                        else
                        {
                            orderby = new KeyValuePair<string, string>(prop[0], (prop.Length == 2 ? (prop[1].ToLower() == "desc" ? "OrderByDescending" : "OrderBy") : (isDesc ? "OrderByDescending" : "OrderBy")));
                        }
                    }
                }
            }
            if (!orderby.HasValue)
            {
                throw new Exception("排序表达式解析错误！");
            }
            var rtn = InternalOrder(source, orderby.Value.Key, orderby.Value.Value);
            foreach (var then in thenby)
            {
                rtn = InternalOrder(rtn, then.Key, then.Value);
            }
            return rtn;
        }

        /// <summary>
        /// 对可查询对象执行特定方法
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">可查询对象</param>
        /// <param name="propertyName">对象属性</param>
        /// <param name="methodName">方法</param>
        /// <returns></returns>
        private static IOrderedQueryable<T> InternalOrder<T>(IQueryable<T> source, String propertyName, String methodName)
        {
            Type type = typeof(T);
            ParameterExpression arg = Expression.Parameter(type, "p");
            PropertyInfo property = type.GetProperty(propertyName);
            Expression expr = Expression.Property(arg, property);
            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), property.PropertyType);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            return ((IOrderedQueryable<T>)(typeof(Queryable).GetMethods().Single(
                 p => String.Equals(p.Name, methodName, StringComparison.Ordinal)
                      && p.IsGenericMethodDefinition
                      && p.GetGenericArguments().Length == 2
                      && p.GetParameters().Length == 2)
                 .MakeGenericMethod(typeof(T), property.PropertyType)
                 .Invoke(null, new Object[] { source, lambda })));
        }
        /// <summary>
        /// 对可查询对象执行特定方法
        /// </summary>
        /// <typeparam name="T">类型</typeparam>
        /// <param name="source">可查询对象</param>
        /// <param name="propertyName">对象属性</param>
        /// <param name="methodName">方法</param>
        /// <returns></returns>
        private static IOrderedQueryable<T> InternalOrder<T>(IOrderedQueryable<T> source, String propertyName, String methodName)
        {
            Type type = typeof(T);
            ParameterExpression arg = Expression.Parameter(type, "p");
            PropertyInfo property = type.GetProperty(propertyName);
            Expression expr = Expression.Property(arg, property);
            Type delegateType = typeof(Func<,>).MakeGenericType(typeof(T), property.PropertyType);
            LambdaExpression lambda = Expression.Lambda(delegateType, expr, arg);

            return ((IOrderedQueryable<T>)(typeof(Queryable).GetMethods().Single(
                 p => String.Equals(p.Name, methodName, StringComparison.Ordinal)
                      && p.IsGenericMethodDefinition
                      && p.GetGenericArguments().Length == 2
                      && p.GetParameters().Length == 2)
                 .MakeGenericMethod(typeof(T), property.PropertyType)
                 .Invoke(null, new Object[] { source, lambda })));
        }

    }
}