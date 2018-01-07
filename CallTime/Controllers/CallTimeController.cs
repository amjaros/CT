using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CallTime.Controllers
{
    public class CallTimeController : Controller
    {
        // GET: CallTime
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult CallTime()
        {
            return View();
        }
    }
}