using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FindJob.Web.Controllers.Home
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
	}
}