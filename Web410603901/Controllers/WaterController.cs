using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web410603901.Controllers
{
    public class WaterController : Controller
    {
        // GET: Water
        public ActionResult Index(string Name,float?Weight)
        {
            var result = "";
            if ( Weight.HasValue) {
                result = (Weight * 30) + "cc";
            }

            ViewBag.Name = Name;
            ViewBag.Result = result;
            return View();
        }
    }
}