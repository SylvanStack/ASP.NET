using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace EFProject
{
    public  class DBContextFactory
    {
        /// <summary>
        /// 保证在一次请求过程中只创建一次EF上下文实例.  返回一个数据模型箱
        /// </summary>
        /// <returns></returns>
        public static DbContext CreateDbContext()  
        {
            DbContext dbContext = CallContext.GetData("DbContext") as DbContext; //CallContext得到与执行代码路径的属性值  此类不能被继承
            if (dbContext == null)                                               //一次请求使用一个实例  上下文可以做到切换
            {
                dbContext = new StudentEntities(); //如果找不到数据模型箱  就new一个新的数据模型箱
                CallContext.SetData("DbContext", dbContext);//储存给指定对象 并与其关联
            }
            
            return dbContext;//返回一个数据模型箱
        }
    }
}
