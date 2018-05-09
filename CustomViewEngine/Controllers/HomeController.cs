using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomViewEngine.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Dynamic(string id)
        {
            return View(id);
        }

        [HttpPost]
        public ActionResult Dynamic(string id, FormCollection collection)
        {
            return View(id);
        }
    }
}