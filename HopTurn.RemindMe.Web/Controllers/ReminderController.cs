using HopTurn.RemindMe.Web.App;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HopTurn.RemindMe.Web.Controllers
{
    public class ReminderController : Controller
    {
        [Dependency]
        public IReminderEngine Engine { get; set; }

        public ReminderController(IReminderEngine engine)
        {
            this.Engine = engine;
        }

        // GET: Reminder
        public ActionResult Index()
        {
            ViewBag.Engine = Engine.ToString();

            return View();
        }


    }
}