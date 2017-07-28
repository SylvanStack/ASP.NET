using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFMvc.Models;
using System.Linq.Expressions;

namespace EFMvc.Controllers
{
    public class ClassInfoController : BaseController
    {
        // GET: ClassInfo
        StudentEntities dbcontext = DataHelper<ClassInfo>.context as StudentEntities;
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
            var data = DataHelper<ClassInfo>.dbSet.Find(keyValue);
            return ToJsonResult(data);
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="pagination">分页参数</param>
        /// <param name="queryJson">查询参数</param>
        /// <returns>返回分页列表Json</returns>
        public ActionResult GetClassInfoPageListJson(PageParam PageParam, ClassInfo queryParams)
        {
            Expression<Func<ClassInfo, bool>> expression = c => c.DelFlag == true;
            //expression = expression.And(p => p.ClassId==4);
            if (!queryParams.ClassName.IsNullOrEmpty())
            {
                string pp = queryParams.ClassName.ToString();
                expression = expression.And(p => p.ClassName.Contains(pp));
            }
            int cid = 0;
            try
            {
                cid = Convert.ToInt32(queryParams.ClassId);
            }
            catch
            {
                cid = 0;
            }

            if (queryParams.ClassId != 0)
            {

                expression = expression.And(p => p.ClassId.Equals(cid));
            }
            int Records = -1;
            List<ClassInfo> data = new List<ClassInfo>();
            bool SortOrder = PageParam.SortOrder != "asc" ? true : false;// false;           
            data = DataHelper<ClassInfo>.LoadPagerEntities(out Records, (t => t.OrderByMulti(PageParam.OrderName, SortOrder)), expression, PageParam.PageSize, PageParam.PageIndex - 1).ToList();

            var jsonData = new
            {
                rows = data,
                total = Records,
            };
            return ToJsonResult(jsonData);
        }
        #endregion
    }
}