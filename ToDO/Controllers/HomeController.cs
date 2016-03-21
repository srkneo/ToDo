using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ToDO.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult ToDo()
        {
            return View();
        }
    }
}