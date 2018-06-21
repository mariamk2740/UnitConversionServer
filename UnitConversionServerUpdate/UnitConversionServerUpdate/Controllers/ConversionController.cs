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
        public ActionResult Gallons()
        {
            return View(viewName: "gallons", model: "");
        }

        public IActionResult Teaspoons()
        {
            return View(viewName: "teaspoon", model: "");
        }
    }
}