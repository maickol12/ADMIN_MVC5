using ADMIN.helper;
using ADMIN.Models;
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
                return View(result);
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
        public ActionResult saveMenu()
        {
            var result = dbContext.tblMenu.ToList();
            return View("listMenu",result);
        }

    }
}