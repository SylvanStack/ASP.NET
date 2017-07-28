using BootStrapTableTest;
using BootStrapTableTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;

namespace BootStrapTableTest.Controllers
{
    public class ClassInfoController : BaseController
    {
        ModelFirstDbHmEntities dbcontext = DataHelper<ClassInfo>.context as ModelFirstDbHmEntities;

       // DataHelper<ClassInfo> dbhelp = new DataHelper<ClassInfo>();
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
        public ActionResult ClassInfoForm()
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
            Expression<Func<ClassInfo, bool>> expression = c =>c.delFlag==1;
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

            if (queryParams.ClassId!=0)
            {
                
                expression = expression.And(p => p.ClassId.Equals(cid));
            }
            int Records = -1;
            List<ClassInfo> data = new List<ClassInfo>();
            bool SortOrder = PageParam.SortOrder != "asc" ? true : false;// false;           
            data = DataHelper<ClassInfo>.LoadPagerEntities(out Records, (t => t.OrderByMulti(PageParam.OrderName, SortOrder)), expression, PageParam.PageSize, PageParam.PageIndex-1).ToList();            
              
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
        public ActionResult RemoveForm(string keyValue)
        {
            DataHelper<ClassInfo>.Delete(keyValue);
            return Success("删除成功");
        }
        /// <summary> 
        /// 保存表单（新增、修改） 
        /// </summary> 
        /// <param name="keyValue">主键值</param> 
        /// <param name="entity">实体对象</param> 
        /// <returns></returns> 
        public ActionResult SaveForm(string keyValue, ClassInfo Entity)
        {
            int n = 0;
           // ClassInfo _entity = Entity.ToObject<ClassInfo>();
            if (!keyValue.IsNullOrEmpty())
            {
                //ClassInfo cin = dbcontext.ClassInfo.Where(t => t.ClassId == Entity.ClassId).FirstOrDefault();// DataHelper<ClassInfo>.GetByID(Convert.ToInt32( keyValue));
                //cin.AddTime = Entity.AddTime;
                //cin.Age = Entity.Age;
                //cin.ClassName = Entity.ClassName;
                //dbcontext.Entry(cin).State = System.Data.Entity.EntityState.Modified;
               n=DataHelper<ClassInfo>.APFUpdateNotNullProperties(Entity);
            }
            else
            {
                DataHelper<ClassInfo>.Insert(Entity);
                n=dbcontext.SaveChanges();
            }
            //unit.SaveTEMP_STUDENTForm(keyValue, _entity);
           if(n>0)
            {
                return Success("操作成功。");
            }
           
            return Error("操作失败。");
        }
        #endregion
    }
}