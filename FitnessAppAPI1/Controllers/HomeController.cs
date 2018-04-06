using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FitnessAppAPI1.Controllers
{
    public class HomeController : Controller
    {

        UserFac uf = new UserFac();

        // GET: Home
        public ActionResult Index()
        {
            

            return View(uf.Get(1));
        }
    }
}