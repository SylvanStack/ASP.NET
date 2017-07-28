using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IBLL
{
    public interface IStuBLL<T>
    {
        #region StuBll
        /// <summary>
        /// 添加学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        bool AddStuInfo(T student);

        /// <summary>
        /// 据学生ID移除该条记录
        /// </summary>
        /// <param name="student">学生信息</param>

        bool RemoveStuInfoByPK(T student);

        /// <summary>
        /// 修改学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>修改成功返回布尔值true,反之false</returns>
        bool UpdateStuInfo(T student);


        /// <summary>
        /// 据学生ID查询学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        bool SelectStuInfoByPK(T student);


        /// <summary>
        /// 学生登陆名查询
        /// </summary>
        /// <param name="student">学生信息</param>
        bool CheckLoginName(T student);

        /// <summary>
        /// 学生登陆查询
        /// </summary>
        /// <param name="student">学生信息</param>
        bool Login(T student);

        /// <summary>
        /// 得到指定ID的学生信息
        /// </summary>
        /// <param name="student">查询信息</param>
        List<T> GetStuInfoByPK(T student);

        /// <summary>
        /// 得到所有学生信息
        /// </summary>
        List<T> GetAllStuInfo();
        #endregion
    }
}
