using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee_CRUD_Scaffolding.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            TutorialsCS _context = new TutorialsCS();


            var listofData = _context.Employees.ToList();
            return View(listofData);
        }


    }
}