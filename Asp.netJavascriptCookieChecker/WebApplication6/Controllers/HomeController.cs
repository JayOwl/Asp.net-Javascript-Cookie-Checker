using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.BusinessLogic;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult SetCookie(string txtName, string bgColor)
        {
            CookieHelper cookieHelper = new CookieHelper();
            cookieHelper.SetUserName(txtName);
            cookieHelper.SetUserColor(bgColor);
            return RedirectToAction("Index");
        }

        public ActionResult ClearCookie()
        {
            CookieHelper cookieHelper = new CookieHelper();
            cookieHelper.ClearCookie();
            return RedirectToAction("Index");
        }

        public ActionResult ClearBGCookie()
        {
            CookieHelper cookieHelper = new CookieHelper();
            cookieHelper.ClearCookie();
            return RedirectToAction("Index");
        }

        public ActionResult Index()
        {
            CookieHelper cookieHelper = new CookieHelper();
            ViewBag.UserName = cookieHelper.GetUserName();
            ViewBag.UserColor = cookieHelper.GetUserColor();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}