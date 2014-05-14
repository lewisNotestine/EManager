using System;
using System.Collections.Generic;
using EManager.Domain;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EManager.web.Controllers {

    public class HomeController : Controller {

        private IDepartmentDatasource _db;

        public HomeController(IDepartmentDatasource db) {
            _db = db;
        }

        public ActionResult Index() {
            var allDepartments = _db.Departments;

            return View(allDepartments);
        }

        public ActionResult About() {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
