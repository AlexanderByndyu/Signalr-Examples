namespace WebSignalR.Controllers
{
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetProgress()
        {
            string databasePath = Server.MapPath("~/DistibutedDatabase.txt");

            string result = System.IO.File.ReadAllText(databasePath);

            return Content(result);
        }

        public void StartLongProcess()
        {
            // Отсылаем сообщение в очередь, например, через RabbitMQ, это стартует удаленный сервис
        }
    }
}