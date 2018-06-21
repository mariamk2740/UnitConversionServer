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



