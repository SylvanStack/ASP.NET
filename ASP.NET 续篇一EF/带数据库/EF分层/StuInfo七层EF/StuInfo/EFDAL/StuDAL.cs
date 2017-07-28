using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using IDAL;

namespace EFDAL
{
    public class StuDAL:IStuDAL<Student>
    {
        #region 学生数据操作
        /// <summary>
        /// 上下文字段
        /// </summary>
        private static StuInfo_Entities context = Tool.GetContext();

        /// <summary>
        /// 插入学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>添加成功返回布尔值true，反之false</returns>
        public bool InsertStuInfo(Student student)
        {
            try
            {
                TStudent stu = new TStudent
                {
                    ClassId = student.ClassId,
                    StuName = student.StuName,
                    LoginName = student.LoginName,
                    Password = student.Password,
                    UpdateTime = student.UpDateTime,
                    Remark = student.Remark
                };

                context.TStudent.Add(stu);
                context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 据学生ID删除该条记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>移除成功返回布尔值true,反之false</returns>
        public bool DeleteStuInfoByPK(Student student)
        {
            try
            {
                var query = context.TStudent.Single(s => s.StuId == student.StuId);

                query.DelFlag = 1;
                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 修改学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>修改成功返回布尔值true,反之false</returns>
        public bool UpdateStuInfo(Student student)
        {
            try
            {
                var query = context.TStudent.Single(s => s.StuId == student.StuId);

                query.ClassId = student.ClassId;
                query.StuName = student.StuName;
                query.LoginName = student.LoginName;
                query.Password = student.Password;
                query.UpdateTime = student.UpDateTime;
                query.Remark = student.Remark;

                context.SaveChanges();

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 据学生ID查询学生记录
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>查询有此条记录则返回一个布尔值true，反之返回false</returns>
        public bool SelectStuInfoByPK(Student student)
        {
            try
            {
                var query = context.TStudent.Single(s => s.StuId == student.StuId & s.DelFlag != 1);

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 学生登陆名查询
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>返回布尔值，查询成功返回true,否则返回false</returns>
        public bool SelectStuInfoByLoginName(Student student)
        {
            try
            {
                var query = context.TStudent.Single(s => s.LoginName == student.LoginName && s.DelFlag != 1);

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 学生登陆查询
        /// </summary>
        /// <param name="student">学生信息</param>
        /// <returns>返回布尔值，查询成功返回true,否则返回false</returns>
        public bool SelectStuInfoByLoginName_Passwod(Student student)
        {
            try
            {
                var query = context.TStudent.Single(s => s.LoginName == student.LoginName && s.Password == student.Password && s.DelFlag != 1);

                return true;
            }
            catch
            {

                return false;
            }
        }

        /// <summary>
        /// 得到指定ID的学生信息
        /// </summary>
        /// <param name="student">查询信息</param>
        /// <returns>返回学生记录</returns>
        public List<Student> GetStuInfoByPK(Student student)
        {
            try
            {
                var stu = from s in context.TStudent.Where(st => st.StuId == student.StuId && st.DelFlag != 1)
                          select new Student
                          {
                              StuId = s.StuId,
                              ClassId = s.ClassId,
                              StuName = s.StuName,
                              LoginName = s.LoginName,
                              Password = s.Password,
                              UpDateTime = (DateTime)s.UpdateTime,
                              Remark = s.Remark
                          };
                return stu.ToList();
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// 得到所有学生信息
        /// </summary>
        /// <returns>返回所有学生记录</returns>
        public List<Student> GetAllStuInfo()
        {
            try
            {
                var stu = from s in context.TStudent.Where(ss => ss.DelFlag != 1)
                          select new Student
                          {
                              StuId = s.StuId,
                              ClassId = s.ClassId,
                              StuName = s.StuName,
                              LoginName = s.LoginName,
                              Password = s.Password,
                              UpDateTime = (DateTime)s.UpdateTime,
                              Remark = s.Remark
                          };
                return stu.ToList();
            }
            catch
            {

                return null;
            }
        }
        #endregion
    }
}
