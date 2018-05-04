using SDA.DAL;
using SDA.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SDA.Controllers
{
    public class HomeController : Controller
    {
        private SDAContext db = new SDAContext();

        // GET: Home
        public ActionResult Index()
        {
            var listaStudentow = db.Student.ToList();
            return View(listaStudentow);
        }
    }
}