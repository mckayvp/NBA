using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class WesternConferenceController : Controller
    {
        // GET: WesternConference
        public ActionResult MainPage()
        {
            return View();
        }
    }
}