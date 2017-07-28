using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class ClassInfoController : Controller
    {
        ModelFirstDbHmEntities dbcontext = new ModelFirstDbHmEntities();
        // GET: ClassInfo
        public ActionResult Index()
        {
            ViewData.Model = dbcontext.ClassInfo.ToList();
            return View();
        }

        // GET: ClassInfo/Details/5
        public ActionResult Details(int id)
        {
            ViewData.Model = dbcontext.ClassInfo.Find(id);
            return View();
        }

        // GET: ClassInfo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassInfo/Create
        [HttpPost]
        public ActionResult Create(ClassInfo data)
        {
            try
            {
                dbcontext.ClassInfo.Add(data);
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassInfo/Edit/5
        public ActionResult Edit(int id)
        {
            //ViewData.Model = dbcontext.ClassInfo.Find(id);
            ViewData.Model = dbcontext.ClassInfo.Where(t => t.ClassId == id).FirstOrDefault();
            return View();
        }

        // POST: ClassInfo/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClassInfo data)
        {
            try
            {
                dbcontext.Entry(data).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassInfo/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData.Model = dbcontext.ClassInfo.Find(id);
            return View();
        }

        // POST: ClassInfo/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, ClassInfo collection)
        {
            try
            {
                ClassInfo cin = dbcontext.ClassInfo.Find(id);                
               // dbcontext.ClassInfo.Remove(cin);
                dbcontext.Entry(cin).State = System.Data.Entity.EntityState.Deleted;

                //ClassInfo cin2 = dbcontext.ClassInfo.Find(4);
                //cin2.Age = 250;
                //dbcontext.Entry(cin2).State = System.Data.Entity.EntityState.Modified;

                //继续增删改
                dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception ee)
            {
                return View();
            }
        }
    }
}
