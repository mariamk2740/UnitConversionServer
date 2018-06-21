using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionServerUpdate.Controllers
{
    public class ConversionController : Controller
    {
        public ActionResult Tablespoons()
        {
            return View(viewName: "Tablespoons", model: " ");
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Gallons()
        {
            return View(viewName: "gallons", model: "");
        }
    }
}