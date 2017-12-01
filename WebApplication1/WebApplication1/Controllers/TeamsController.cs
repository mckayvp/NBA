using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult Index(int teamID)
        {
            //Put teamID in Viewbag to display in the View
            ViewBag.teamNumber = teamID;
            return View();
        }
    }
}