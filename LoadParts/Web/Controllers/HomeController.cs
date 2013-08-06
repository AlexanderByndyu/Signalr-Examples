namespace Web.Controllers
{
    using System;
    using System.Threading;
    using System.Web.Mvc;
    using Models;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(new FastData { Date = DateTime.Now });
        }

        public ActionResult Block2()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то графики" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block3()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то индексы" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block4()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то графики" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block5()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то графики" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block6()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то индексы" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block7()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то индексы" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block8()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то графики" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block9()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то индексы" }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Block10()
        {
            Thread.Sleep(3000);
            return Json(new { Data = "Какие-то графики" }, JsonRequestBehavior.AllowGet);
        }
    }
}