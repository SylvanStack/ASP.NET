using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IClassBLL<T>
    {
        #region ClassBll
        /// <summary>
        /// 添加班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        bool AddClass(T stuClass);

        /// <summary>
        /// 删除班级记录
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        bool RemoveClassByPK(T stuClass);

        /// <summary>
        /// 修改班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        bool UpDataClass(T stuClass);

        /// <summary>
        /// 据班级ID查询班级
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        bool SelectClassByPK(T stuClass);

        /// <summary>
        /// 得到指定ID班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        List<T> GetClassByPK(T stuClass);

        /// <summary>
        /// 得到所有班级信息
        /// </summary>
        /// <param name="stuClass">班级信息</param>
        List<T> GetAllClass();
        #endregion
    }
}
