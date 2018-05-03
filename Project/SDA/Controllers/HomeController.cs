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
            var przedmiot = new Przedmiot { NazwaPrzedmiotu = "Bazy", Semestr = 1, Egzaminowany = true };
            db.Przedmiot.Add(przedmiot);
            try
            {
                db.SaveChanges();
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
            return View();
        }
    }
}