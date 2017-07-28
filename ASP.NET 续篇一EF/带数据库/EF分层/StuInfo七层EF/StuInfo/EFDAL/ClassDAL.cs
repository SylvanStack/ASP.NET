using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entity;
using System.Threading.Tasks;
using IDAL;

namespace EFDAL
{
    public class ClassDAL:IClassDAL<StuClass>
    {
        #region 班级数据操作

        /// <summary>
        /// 上下文字段
        /// </summary>
        private static StuInfo_Entities context = Tool.GetContext();

        /// <summary>
        /// 插入班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>插入成功返回布尔值true，反之false</returns>
        public bool InsertClass(StuClass stuClass)
        {
            try
            {
                TClass stuc = new TClass
                {
                    ClassName = stuClass.ClassName,
                    UpdateTime = (DateTime)stuClass.UpdateTime,
                    Remark = stuClass.Remark
                };

                context.TClass.Add(stuc);
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 删除班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>插入成功返回布尔值true，反之false</returns>
        public bool DeleteClassByPK(StuClass stuClass)
        {
            try
            {
                var query = context.TClass.Single(c => c.ClassId == stuClass.ClassId);

                query.DelFlag = 1;
                context.SaveChanges();

                return true;
            }
            catch
            {

                throw;
            }
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>修改成功返回布尔值true，反之false</returns>
        public bool UpDataClass(StuClass stuClass)
        {
            try
            {
                var query = context.TClass.Single(c => c.ClassId == stuClass.ClassId);

                query.ClassId = stuClass.ClassId;
                query.ClassName = stuClass.ClassName;
                query.UpdateTime = stuClass.UpdateTime;
                query.Remark = stuClass.Remark;

                context.SaveChanges();

                return true;
            }
            catch
            {

                throw;
            }
        }

        /// <summary>
        /// 据班级ID查询班级
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>查询成功返回布尔值true，反之false</returns>
        public bool SelectClassByPK(StuClass stuClass)
        {
            try
            {
                var query = context.TClass.Single(c => c.ClassId == stuClass.ClassId && c.DelFlag != 1);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 得到指定ID班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns></returns>
        public List<StuClass> GetClassByPK(StuClass stuClass)
        {
            try
            {
                var stuc = from c in context.TClass.Where(c => c.ClassId == stuClass.ClassId && c.DelFlag != 1)
                           select new StuClass
                           {
                               ClassId = c.ClassId,
                               ClassName = c.ClassName,
                               UpdateTime = (DateTime)c.UpdateTime,
                               Remark = c.Remark
                           };

                return stuc.ToList();
            }
            catch
            {

                return null;
            }
        }

        /// <summary>
        /// 得到所有班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns></returns>
        public List<StuClass> GetAllClass()
        {
            try
            {
                var stuc = from c in context.TClass.Where(c => c.DelFlag != 1)
                           select new StuClass
                           {
                               ClassId = c.ClassId,
                               ClassName = c.ClassName,
                               UpdateTime = (DateTime)c.UpdateTime,
                               Remark = c.Remark
                           };

                return stuc.ToList();
            }
            catch
            {

                return null;
            }
        }
        #endregion
    }
}
