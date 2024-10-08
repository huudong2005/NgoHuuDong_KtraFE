using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgoHuuDong_KtraFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult trangchu()
        {
            return View();
        }

        public ActionResult _MasterLayout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DienForm()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}