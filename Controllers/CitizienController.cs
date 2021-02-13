using AspDotNetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspDotNetMVC.Controllers
{
    public class CitizienController : Controller
    {
        // GET: Citizien
        public ActionResult Index()
        {

            var citizien = new Citizien() 
            { 
                Id = 1,
                Name = "Jotun",
                rank = 7
            };

            return View(citizien);
        }
    }
}