using System.Web;
using System.Web.Mvc;

namespace ADMIN.helper
{
    public class SessionTimeoutAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (HttpContext.Current.Session["isLogin"] == null)
            {
                filterContext.Result = new RedirectResult("~/User");
                return;
            }
            base.OnActionExecuting(filterContext);
        }
    }
}