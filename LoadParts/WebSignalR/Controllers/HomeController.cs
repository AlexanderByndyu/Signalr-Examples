namespace WebSignalR.Controllers
{
    using System;
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new FastData {Date = DateTime.Now});
        }
    }
}