using SDAv2.DAL;
using SDAv2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDAv2.Controllers
{
    public class HomeController : Controller
    {

        private SDAv2Context db = new SDAv2Context();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
    }
}