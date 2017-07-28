using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using IDAL;
using Factory;
using IBLL;

namespace BLL
{
    public class ClassBLL:IClassBLL<StuClass>
    {
        IClassDAL<StuClass> dal = DALFactory.GetClassDALInstance<StuClass>();

        #region ClassBll
        /// <summary>
        /// 添加班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>插入成功返回布尔值true，反之false</returns>
        public bool AddClass(StuClass stuClass)
        {
            if (dal.InsertClass(stuClass))
            {
                return true;

            }
            return false;
        }

        /// <summary>
        /// 删除班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>插入成功返回布尔值true，反之false</returns>
        public bool RemoveClassByPK(StuClass stuClass)
        {
            if (dal.DeleteClassByPK(stuClass))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>修改成功返回布尔值true，反之false</returns>
        public bool UpDataClass(StuClass stuClass)
        {
            if (dal.UpDataClass(stuClass))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 据班级ID查询班级
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns>查询成功返回布尔值true，反之false</returns>
        public bool SelectClassByPK(StuClass stuClass)
        {
            if (dal.SelectClassByPK(stuClass))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 得到指定ID班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns></returns>
        public List<StuClass> GetClassByPK(StuClass stuClass)
        {
            return dal.GetClassByPK(stuClass);
        }

        /// <summary>
        /// 得到所有班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        /// <returns></returns>
        public List<StuClass> GetAllClass()
        {
            return dal.GetAllClass();
        }
        #endregion
    }
}
