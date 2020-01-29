using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_FCBarcelona.Models;

namespace Website_FCBarcelona.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Team()
        {
            Mannschaft p2 = new Mannschaft(1, "Lionel", "Messi", new DateTime(1987, 6, 24), 152.5m, "FW");
            Mannschaft p3 = new Mannschaft(2, "Ansu", "Fati", new DateTime(2002, 10, 31), 42.5m, "RW");
            Mannschaft p4 = new Mannschaft(3, "Frenkie", "De Jong", new DateTime(1997, 5, 12), 83.5m, "CM");
            Mannschaft p5 = new Mannschaft(4, "Marc-Andre", "Ter Stegen", new DateTime(1992, 4, 30), 94.0m, "GK");

            List<Mannschaft> p1 = new List<Mannschaft>();
            p1.Add(p2);
            p1.Add(p3);
            p1.Add(p4);
            p1.Add(p5);

            return View(p1);
        }
    }
}