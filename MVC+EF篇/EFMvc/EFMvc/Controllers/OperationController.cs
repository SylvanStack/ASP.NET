using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFMvc.Models;
using System.Linq.Expressions;

namespace EFMvc.Controllers
{
    public class OperationController : BaseController
    {
        StudentEntities dbcontext = DataHelper<StudentInfo>.context as StudentEntities;
        // GET: Operation
        #region 视图功能
        /// <summary>
        /// 列表页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 表单页面
        /// </summary>
        /// <returns></returns>
        public ActionResult StudentInfoForm()
        {
            return View();
        }
        #endregion
        #region 获取数据
        /// <summary>
        /// 获取实体 
        /// </summary>
        /// <param name="keyValue">主键值</param>
        /// <returns>返回对象Json</returns>
        public ActionResult GetFormJson(int keyValue)//把此处的int 改称为string 会报错
        {
            //var data = DataHelper<ClassInfo>.context.Set<ClassInfo>().Find(keyValue);
            var data = DataHelper<StudentInfo>.dbSet.Find(keyValue);
            return ToJsonResult(data);
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表Json</returns>
        public ActionResult GetClassInfoPageListJson(PageParam PageParam, StudentInfo queryParams)
        {
            Expression<Func<StudentInfo, bool>> expression = c => c.DelFlag == false;
            //expression = expression.And(p => p.ClassId==4);
            if (!queryParams.LoginName.IsNullOrEmpty())
            {
                string pp = queryParams.LoginName.ToString();
                expression = expression.And(p => p.LoginName.Contains(pp));
            }
            int cid = 0;
            try
            {
                cid = Convert.ToInt32(queryParams.StuId);
            }
            catch
            {
                cid = 0;
            }

            if (queryParams.StuId != 0)
            {

                expression = expression.And(p => p.StuId.Equals(cid));
            }
            int Records = -1;
            List<StudentInfo> data = new List<StudentInfo>();
            bool SortOrder = PageParam.SortOrder != "asc" ? true : false;// false;           
            data = DataHelper<StudentInfo>.LoadPagerEntities(out Records, (t => t.OrderByMulti(PageParam.OrderName, SortOrder)), expression, PageParam.PageSize, PageParam.PageIndex - 1).ToList();

            var jsonData = new
            {
                rows = data,
                total = Records,
            };
            return ToJsonResult(jsonData);
        }
        #endregion
        #region 提交数据
        /// <summary> 
        /// 删除数据 
        /// </summary> 
        /// <param name="keyValue">主键值</param> 
        /// <returns></returns> 
        public ActionResult RemoveForm(int keyValue)
        {
            DataHelper<StudentInfo>.Delete(keyValue);
            return Success("删除成功");
        }
        /// <summary> 
        /// 保存表单（新增、修改） 
        /// </summary> 
        /// <param name="keyValue">主键值</param> 
        /// <param name="entity">实体对象</param> 
        /// <returns></returns> 
        public ActionResult SaveForm(string    keyValue, StudentInfo Entity)
        {
            try
            {

                int n = 0;
                // ClassInfo _entity = Entity.ToObject<ClassInfo>();
                if ( !keyValue.IsNullOrEmpty())
                {
                    //ClassInfo cin = dbcontext.ClassInfo.Where(t => t.ClassId == Entity.ClassId).FirstOrDefault();// DataHelper<ClassInfo>.GetByID(Convert.ToInt32( keyValue));
                    //cin.AddTime = Entity.AddTime;
                    //cin.Age = Entity.Age;
                    //cin.ClassName = Entity.ClassName;
                    //dbcontext.Entry(cin).State = System.Data.Entity.EntityState.Modified;
                    n = DataHelper<StudentInfo>.APFUpdateNotNullProperties(Entity);
                }
                else
                {
                    DataHelper<StudentInfo>.Insert(Entity);
                    n = dbcontext.SaveChanges();
                }
                //unit.SaveTEMP_STUDENTForm(keyValue, _entity);
                if (n > 0)
                {
                    return Success("操作成功。");
                }
            }
            catch (Exception ee)

            { return Error(ee.Message);}

            return Success("操作成功。");
        }
        #endregion
    }
}