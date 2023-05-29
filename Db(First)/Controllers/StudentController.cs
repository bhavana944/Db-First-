using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Db_First_.Models;

namespace Db_First_.Controllers
{
    public class StudentController : Controller
    {
        BhavanaEntities1 bhavanaEntities1 = new BhavanaEntities1();
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }
    }
}