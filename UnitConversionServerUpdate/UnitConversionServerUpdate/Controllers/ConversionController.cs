﻿using System;
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
    }
}