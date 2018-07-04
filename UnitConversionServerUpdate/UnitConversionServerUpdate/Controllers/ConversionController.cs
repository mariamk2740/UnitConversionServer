using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionServerUpdate.Controllers
{
    public class ConversionController : Controller
    {
        public ActionResult oz()
        {
            return View(viewName:"oz", model: 0.0);
        }

        public ActionResult OzConvert(double cups)
        {
            double ounces = cups * 8;
            return View(viewName: "oz", model: ounces);
        }

        public ActionResult Tablespoons()
        {
            return View(viewName: "Tablespoons", model: 0.0);
        }

        public ActionResult CupstoTBSP(double cups)
        {
            double tbsp = cups * 16;
            return View(viewName: "Tablespoons", model: tbsp);
        }
       
        public ActionResult Gallons()
        {
            return View(viewName: "gallons", model: "0.0");
        }
        public ActionResult GallonsConvert(double cups)
        {
            double gallons = cups * 0.0625;
            return View(viewName: "gallons", model: gallons);
        }

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



