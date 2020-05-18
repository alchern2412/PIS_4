using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace lab3_1_new.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            HttpContextBase context = HttpContext;
            HttpRequestBase req = context.Request;
            ViewBag.Request = req;
            return View();
        }
    }
}