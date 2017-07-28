using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class ClassInfo1Controller : Controller
    {
        // GET: ClassInfo1
        ModelFirstDbHmEntities dbcontext = new ModelFirstDbHmEntities();
        public ActionResult Index()
        {
            ViewData.Model = dbcontext.ClassInfo.ToList();
            return View();
        }

        // GET: ClassInfo1/Details/5
        public ActionResult Details(int id)
        {
            ViewData.Model = dbcontext.ClassInfo.Where(t => t.ClassId == id).FirstOrDefault();
            return View();
        }

        // GET: ClassInfo1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClassInfo1/Create
        [HttpPost]
        public ActionResult Create(ClassInfo data)
        {
            try
            {
                // TODO: Add insert logic here

                dbcontext.ClassInfo.Add(data);
                dbcontext.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassInfo1/Edit/5
        public ActionResult Edit(int id)

        {
            ViewData.Model = dbcontext.ClassInfo.Where(t => t.ClassId == id).FirstOrDefault();
            return View();
        }

        // POST: ClassInfo1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, ClassInfo data)
        {
            try
            {
                // TODO: Add update logic here
                dbcontext.ClassInfo.Attach(data);
                dbcontext.Entry(data).State = System.Data.Entity.EntityState.Modified;
                dbcontext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: ClassInfo1/Delete/5
        public ActionResult Delete(int id)
        {
            ViewData.Model = dbcontext.ClassInfo.Where(t => t.ClassId == id).FirstOrDefault();
            return View();
        }

        // POST: ClassInfo1/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
