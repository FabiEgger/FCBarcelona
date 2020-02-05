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
        public ActionResult Attack()
        {
            Mannschaft p2 = new Mannschaft(1, "Lionel", "Messi", new DateTime(1987, 6, 24), 152.5m, "RW");
            Mannschaft p3 = new Mannschaft(2, "Ansu", "Fati", new DateTime(2002, 10, 31), 42.5m, "LW");
            Mannschaft p4 = new Mannschaft(3, "Antoine", "Griezmann", new DateTime(1991, 3, 21), 113.5m, "ST");
            Mannschaft p5 = new Mannschaft(4, "Luis", "Suarez", new DateTime(1987, 1, 24), 36.0m, "ST");
            Mannschaft p6 = new Mannschaft(5, "Ousmane", "Dembele", new DateTime(1997, 5, 15), 73.0m, "RW");
            Mannschaft p7 = new Mannschaft(6, "Frankie", "De Jong", new DateTime(1997, 5, 12), 83.5m, "CM");
            Mannschaft p8 = new Mannschaft(7, "Arthur", "Melo", new DateTime(1996, 8, 12), 73.0m, "CM");
            Mannschaft p9 = new Mannschaft(8, "Sergio", "Busquets", new DateTime(1988, 7, 16), 33.7m, "CDM");
            Mannschaft p10 = new Mannschaft(9, "Ivan", "Rakitic", new DateTime(1988, 3, 10), 27.0m, "CDM");
            Mannschaft p11 = new Mannschaft(10, "Arturo", "Vidal", new DateTime(1987, 5, 22), 13.5m, "COM");
            Mannschaft p12 = new Mannschaft(11, "Clement", "Lenglet", new DateTime(1995, 6, 17), 62.0m, "IV");
            Mannschaft p13 = new Mannschaft(12, "Jordi", "Alba", new DateTime(1989, 3, 21), 53.0m, "LV");
            Mannschaft p14 = new Mannschaft(13, "Sergi", "Roberto", new DateTime(1992, 2, 7), 48.5m, "RV");
            Mannschaft p15 = new Mannschaft(14, "Smauel", "Umtiti", new DateTime(1993, 11, 14), 41.0m, "IV");
            Mannschaft p16 = new Mannschaft(15, "Nelson", "Semedo", new DateTime(1993, 11, 16), 37.0m, "RV");
            Mannschaft p17 = new Mannschaft(16, "Gerard", "Pique", new DateTime(1987, 2, 2), 24.5m, "IV");
            Mannschaft p18 = new Mannschaft(17, "Junior", "Firpo", new DateTime(1996, 8, 22), 24.0m, "LV");
            Mannschaft p19 = new Mannschaft(18, "Marc-Andre", "Ter Stegen", new DateTime(1992, 4, 30), 94.0m, "GK");
            Mannschaft p20 = new Mannschaft(19, "Noberto", "Neto", new DateTime(1989, 7, 19), 16.9m, "GK");


            List<Mannschaft> p1 = new List<Mannschaft>();
            p1.Add(p2);
            p1.Add(p3);
            p1.Add(p4);
            p1.Add(p5);
            p1.Add(p6);
            p1.Add(p7);
            p1.Add(p8);
            p1.Add(p9);
            p1.Add(p10);
            p1.Add(p11);
            p1.Add(p12);
            p1.Add(p13);
            p1.Add(p14);
            p1.Add(p15);
            p1.Add(p16);
            p1.Add(p17);
            p1.Add(p18);
            p1.Add(p19);
            p1.Add(p20);


            return View(p1);
        }
    }
}