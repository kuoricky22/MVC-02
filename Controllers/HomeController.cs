using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_03_公司練習.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SKLI_DBConn.DBConn data = new SKLI_DBConn.DBConn(10);
            List<string> iParams = new List<string>();

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