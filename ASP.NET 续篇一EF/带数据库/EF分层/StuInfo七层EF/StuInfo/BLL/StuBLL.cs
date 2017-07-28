using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Factory;
using IDAL;
using IBLL;

namespace BLL
{
    public class StuBLL:IStuBLL<Student>
    {
        IStuDAL<Student> dal = DALFactory.GetStuDALInstance<Student>();

        #region StuBll
        /// <summary>
        /// 添加学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>添加成功返回布尔值true，反之false</returns>
        public bool AddStuInfo(Student student)
        {
            if (dal.InsertStuInfo(student))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 据学生ID移除该条记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>移除成功返回布尔值true,反之false</returns>
        public bool RemoveStuInfoByPK(Student student)
        {
            if (dal.DeleteStuInfoByPK(student))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 修改学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>修改成功返回布尔值true,反之false</returns>
        public bool UpdateStuInfo(Student student)
        {
            if (dal.UpdateStuInfo(student))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// 据学生ID查询学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>查询有此条记录则返回一个布尔值true，反之返回false</returns>
        public bool SelectStuInfoByPK(Student student)
        {
            if (dal.SelectStuInfoByPK(student))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 学生登陆名查询
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>返回布尔值，查询成功返回true,否则返回false</returns>
        public bool CheckLoginName(Student student)//SelectByLoginName
        {
            if (dal.SelectStuInfoByLoginName(student))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 学生登陆查询
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>返回布尔值，查询成功返回true,否则返回false</returns>
        public bool Login(Student student)//SelectByLoginName_Passwod
        {
            if (dal.SelectStuInfoByLoginName_Passwod(student))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// 得到指定ID的学生信息
        /// </summary>
        /// <param name="student">查询信息</param>
        /// <returns>返回学生记录</returns>
        public List<Student> GetStuInfoByPK(Student student)
        {
            return dal.GetStuInfoByPK(student);
        }

        /// <summary>
        /// 得到所有学生信息
        /// </summary>
        /// <returns>返回所有学生记录</returns>
        public List<Student> GetAllStuInfo()
        {
            return dal.GetAllStuInfo();
        }
        #endregion
    }
}
