using BootStrapTableTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace BootStrapTableTest
{
    public  static class MyExtensions
    {
        public static bool IsNullOrEmpty(this string str)
        {
            return string.IsNullOrWhiteSpace(str);
        }

    }

    public static class  DataHelper<TEntity> where TEntity:class
    {/// <summary>
     /// 保证仓储上下文为统一对象 
     /// </summary>
        public static DbContext context =GetDbContext(); //new ModelFirstDbHmEntities();//
        private static DbContext GetDbContext()
        {
            DbContext dbContext = (DbContext)CallContext.GetData("dbContext");
            if (dbContext == null)
            {
                dbContext = new ModelFirstDbHmEntities();
                CallContext.SetData("dbContext", dbContext);
            }
            return dbContext;
        }

        /// <summary>
        /// 用于指定当前数据集
        /// </summary>
        public static DbSet<TEntity> dbSet=context.Set<TEntity>();

        /// <summary>
        /// 根据id获取
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TEntity GetByID(object id)
        {
            return dbSet.Find(id);
        }

        /// <summary>
        /// 插入对象，未savechanges
        /// </summary>
        /// <param name="entity"></param>
        public static void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// 根据主键删除对象，真删除,未savechanges
        /// </summary>
        /// <param name="id"></param>
        public static void Delete(object id)
        {
            TEntity entityToDelete = dbSet.Find(id);
            Delete(entityToDelete);
        }

        /// <summary>
        /// 根据对象进行remove，-更新前必须先调用DbSet.Find(id)方法获取实体
        /// </summary>
        /// <param name="entityToDelete"></param>
        private static void Delete(TEntity entityToDelete)
        {
            if (context.Entry(entityToDelete).State == EntityState.Detached)
            {
                dbSet.Attach(entityToDelete);
            }
            dbSet.Remove(entityToDelete);
        }

        /// <summary>
        /// 进行更新-更新前必须先调用DbSet.Find(id)方法获取实体未savechanges
        /// </summary>
        /// <param name="entityToUpdate"></param>
        public static void Update(TEntity entityToUpdate)
        {
            //dbSet.Attach(entityToUpdate);
            context.Entry(entityToUpdate).State = EntityState.Modified;
        }




        /// <summary>
        /// 分页排序
        /// </summary>
        /// <param name="total">总行数</param>
        /// <param name="orderBy">排序</param>
        /// <param name="filter">查询</param>
        /// <param name="pageSize">每页数量 默认10</param>
        /// <param name="pageIndex">当前页数 默认0</param>
        /// <returns></returns>
        //public static IEnumerable<TEntity> LoadPagerEntities(out int total
        //     , Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy
        //     , Expression<Func<TEntity, bool>> filter = null
        //     , int pageSize = 10, int pageIndex = 0)
        //{
        //    IQueryable<TEntity> query = dbSet;
        //    if (filter != null)
        //        query = query.AsNoTracking().Where(filter);

        //    total = query.Count();
        //    return orderBy(query).Skip(pageSize * pageIndex).Take(pageSize).ToList();
        //}

        /// <summary>
        /// 分页排序
        /// </summary>
        /// <param name="total">总行数</param>
        /// <param name="orderBy">排序</param>
        /// <param name="filter">查询</param>
        /// <param name="pageSize">每页数量 默认10</param>
        /// <param name="pageIndex">当前页数 默认0</param>
        /// <returns></returns>
        public static IEnumerable<TEntity> LoadPagerEntities(out int total
             , Func<IQueryable<TEntity>, IQueryable<TEntity>> orderBy
             , Expression<Func<TEntity, bool>> filter = null
             , int pageSize = 10, int pageIndex = 0)
        {
            IQueryable<TEntity> query = dbSet;

            if (filter != null)
                query = query.Where(filter);

            total = query.Count();

            return orderBy(query).Skip(pageSize * pageIndex).Take(pageSize).ToList();
        }
        /// <summary>
		/// 单例扩展修改方法：只更新实体中的非空属性
		/// 特性：此方法会去数据库查询一次，但不受Find方法的限制
		/// </summary>
		/// <param name="model">要修改的实体对象</param>
		/// <returns>受影响的行数</returns>
		public static int APFUpdateNotNullProperties(TEntity model)
        {
            var primaryKeyValues = ContextEntityHelper.GetEntityKeys(context, model);
            TEntity originalModel = context.Set<TEntity>().Find(primaryKeyValues);
            if (originalModel == null)//上下文及数据库中不存在时，抛出异常
            {
                throw new Exception("要更新的记录不存在！");
            }
            DbEntityEntry originalEntry = context.Entry<TEntity>(originalModel);
            var propertyNames = originalEntry.OriginalValues.PropertyNames;
            //if (propertyNames.Contains("DELETE_FLAG") && originalEntry.Property("DELETE_FLAG").CurrentValue.ToString() == AppConstant.DeleteFlag.Y)
            //{
            //    throw new Exception("要更新的记录已被删除！");
            //}
            DbEntityEntry newEntry = context.Entry<TEntity>(model);
            foreach (string perPropertyName in originalEntry.OriginalValues.PropertyNames)//遍历所有的列，将非空列的属性改为已修改
            {
                //if (perPropertyName == "LASTUPDATE_DATE" || perPropertyName == "LASTUPDATE_BY" || perPropertyName == "LASTUPDATE_NAME")//设置必须更新列的状态和默认值
                //{
                //    originalEntry.Property(perPropertyName).IsModified = true;
                //    //if (originalEntry.Property(perPropertyName).CurrentValue == null)
                //    //{
                //    //    if (perPropertyName == "LASTUPDATE_BY") originalEntry.Property("LASTUPDATE_BY").CurrentValue = OperatorProvider.Provider.Current().Account;
                //    //    if (perPropertyName == "LASTUPDATE_NAME") originalEntry.Property("LASTUPDATE_NAME").CurrentValue = OperatorProvider.Provider.Current().UserName;
                //    //    if (perPropertyName == "LASTUPDATE_DATE") originalEntry.Property("LASTUPDATE_DATE").CurrentValue = System.DateTime.Now;
                //    //}
                //}
                //else//其他非比填列，非空就需修改
                //{
                    var newValue = newEntry.Property(perPropertyName).CurrentValue;
                    if (newValue != null)
                    {
                        originalEntry.Property(perPropertyName).CurrentValue = newValue;
                        originalEntry.Property(perPropertyName).IsModified = true;
                    }
                    else
                    {
                        originalEntry.Property(perPropertyName).IsModified = false;
                    }
                //}
            }
            return context.SaveChanges();
        }


    }
}