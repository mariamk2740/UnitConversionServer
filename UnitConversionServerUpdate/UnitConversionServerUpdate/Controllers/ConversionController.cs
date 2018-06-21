using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace UnitConversionServerUpdate.Controllers
{
    public class ConversionController : Controller
    {
        public ActionResult Index()
        {
            return View(viewName "Index", model : "");
        }

        public ActionResult pints()
        {
            return View(viewName "pints", model: "");
        }
    }
}