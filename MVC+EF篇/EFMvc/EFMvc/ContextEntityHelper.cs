using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace EFMvc
{
    public static class ContextEntityHelper
    {
        #region 获取传入实体类型的主键
        public static string[] GetEntityKeyNames<TEntity>(this DbContext context) where TEntity : class
        {
            if (context == null)
                throw new ArgumentNullException("context");

            var set = ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<TEntity>();
            var entitySet = set.EntitySet;
            return entitySet.ElementType.KeyMembers.Select(k => k.Name).ToArray();
        }

        public static object[] GetEntityKeys<TEntity>(this DbContext context, TEntity entity) where TEntity : class
        {
            if (context == null)
                throw new NullReferenceException("context");

            var type = typeof(TEntity);

            var set = ((IObjectContextAdapter)context).ObjectContext.CreateObjectSet<TEntity>();
            var entitySet = set.EntitySet;
            var keys = entitySet.ElementType.KeyMembers;
            var props = keys.Select(k => type.GetProperty(k.Name));
            return props.Select(p => p.GetValue(entity)).ToArray();
        }

        //如果上面的方法对于派生类出错，则采用下面的方法
        public static string[] GetEntityKeyNames_DerivedType<TEntity>(this DbContext context) where TEntity : class
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            var objectContext = ((IObjectContextAdapter)context).ObjectContext;
            //We must use the namespace of the context and the type name of the entity
            string entityTypeName = context.GetType().Namespace + '.' + typeof(TEntity).Name;
            var entityType = objectContext.MetadataWorkspace.GetItem<EntityType>(entityTypeName, DataSpace.CSpace);
            return entityType.KeyProperties.Select(k => k.Name).ToArray();
        }
        #endregion
    }
}