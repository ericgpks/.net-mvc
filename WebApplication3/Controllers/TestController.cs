using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.BC;

namespace WebApplication3.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            Test test = new Test();
            test.Name = "名前";
            test.Address = "住所";
            TestBC bc = new TestBC();

            return View(test);
        }
    }
}