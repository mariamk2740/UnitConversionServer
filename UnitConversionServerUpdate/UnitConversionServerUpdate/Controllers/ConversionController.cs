using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionServerUpdate.Controllers
{
    public class ConversionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Teaspoons()
        {
            return View(viewName: "Teaspoons", model: "");
        }

        public ActionResult TspConvert(double cups)
        {
            double tsp = cups * 48;
            return View(viewName: "Teaspoons", model: tsp);
        }

        public ActionResult pints()
        {
            return View(viewName: "pints", model: 0.0);
        }

        public ActionResult ctop(double cups )
        {
            double pints = cups / 2;
            return View(viewName: "pints", model: pints);
        }
    }
}



