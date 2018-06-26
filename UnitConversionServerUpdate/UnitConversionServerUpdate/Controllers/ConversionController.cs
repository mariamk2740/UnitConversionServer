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



