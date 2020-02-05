using ADMIN.helper;
using ADMIN.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADMIN.Controllers
{
    [SessionTimeout]
    public class AdminController : Controller
    {
        private quinielaEntities dbContext = new quinielaEntities();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult listUser()
        {
            return View();
        }
        public ActionResult listRoles()
        {
            return View();
        }
        public ActionResult listMenu()
        {
            try
            {
                var result = dbContext.tblMenu.ToList();
                ViewData["listMenu"] = result;
                return View();
            }
            catch (Exception)
            {

            }
            return View();
        }
        public ActionResult newModule()
        {
            return View();
        }
        public ActionResult listSubMenu()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult saveMenu([Bind(Include = "idMenu,NameEs,NameEn,Active,Controller")]tblMenu menu)
        {
            if (ModelState.IsValid)
            {
                if (menu.idMenu > 0)
                {
                    menu.UpdateUser = Session["UserName"].ToString();
                    menu.UpdateDate = DateTime.Now;
                    dbContext.Entry(menu).State = System.Data.Entity.EntityState.Modified;
                }
                else
                {
                    menu.CreateUser = Session["UserName"].ToString();
                    menu.CreateDate = DateTime.Now;
                    dbContext.tblMenu.Add(menu);
                }
                dbContext.SaveChanges();

            }
            var result = dbContext.tblMenu.ToList();
            ViewData["listMenu"] = result;

            return View("listMenu");
        }
        [HttpGet]
        public JsonResult getMenu(Int32 id)
        {
            return Json(dbContext.tblMenu.Where(m => m.idMenu == id).Select(s => new { s.idMenu, s.NameEs, s.NameEn, s.Controller, s.Active }).FirstOrDefault(), JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult desactivateMenu(Int32 id) {
            var result = dbContext.tblMenu.Where(m => m.idMenu == id).FirstOrDefault();
            if(result != null)
            {
                result.Active = false;
                dbContext.Entry(result).State = System.Data.Entity.EntityState.Modified;
                dbContext.SaveChanges();
            }
            var toJson = dbContext.tblMenu.Where(m => m.idMenu == id).Select
                (
                    m => new
                    {
                        m.idMenu,
                        m.NameEn,
                        m.NameEs,
                        m.Controller,
                        m.Active
                    }
                ).FirstOrDefault();
            return Json(toJson, JsonRequestBehavior.AllowGet);
        }
    }
}