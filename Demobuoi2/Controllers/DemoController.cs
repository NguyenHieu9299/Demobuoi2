using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demobuoi2.Models

namespace Demobuoi2.Controllers
{
    public class DemoController : Controller
    {
        GiaiPhuongTrinh gpt = new GiaiPhuongTrinh();
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Hello()
        { return View();
        }
        public ActionResult GiaiPTB1()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double heSoA, double hSoB)
        {
            double x = gpt.GiaiPhuongTrinh(heSoA, heSoB);
            ViewBag.nghiemPT = X;
            return View()
         }
    }
}