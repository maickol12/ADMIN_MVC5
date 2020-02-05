using ADMIN.Models;
using System.Linq;
using System.Web.Mvc;

namespace ADMIN.Controllers
{
    public class UserController : Controller
    {
        private quinielaEntities dbContext = new quinielaEntities();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index([Bind(Include = "UserName,Password")] tblUser user)
        {
            var result = dbContext.tblUser.Where(
                    a => a.UserName.Equals(user.UserName) && a.Password.Equals(user.Password)
                ).FirstOrDefault();
            if (result == null)
            {
                ModelState.AddModelError("Password", "Usuario/Contaseña incorrecta");
                return View();
            }
            else
            {
                Session["isLogin"]  = true;
                Session["User"]     = result;
                Session["UserName"] = result.UserName;
                var res = dbContext.tblMenu.ToList();
                Session["menu"] = res;
                return RedirectToAction("Index", "Dashboard");
            }
        }
  
    }
}