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
            return View(viewName: "gallons", model: "");
        }
    }
}