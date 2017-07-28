using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDAL
{
    public interface IStuDAL<T>
    {
        /// <summary>
        /// 插入学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        bool InsertStuInfo(T student);

        /// <summary>
        /// 据学生ID删除该条记录
        /// </summary>
        /// <param name="student">学生信息</param>
        bool DeleteStuInfoByPK(T student);


        /// <summary>
        /// 修改学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
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
        bool SelectStuInfoByLoginName(T student);


        /// <summary>
        /// 学生登陆查询
        /// </summary>
        /// <param name="student">学生信息</param>
        bool SelectStuInfoByLoginName_Passwod(T student);

        /// <summary>
        /// 得到指定ID的学生信息
        /// </summary>
        /// <param name="student">查询信息</param>
        List<T> GetStuInfoByPK(T student);

        /// <summary>
        /// 得到所有学生信息
        /// </summary>
        List<T> GetAllStuInfo();
    }
}
