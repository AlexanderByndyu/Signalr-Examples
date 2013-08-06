namespace Web.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    public class HomeController : Controller
    {
        private static int percent;

        public ActionResult Index()
        {
            return View();
        }

        public void StartLongProcess()
        {
            // здесь мы как будто запускаем большой процесс на бэкэнде
            Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        // это не переменная, а например ячейка в БД или сервис
                        percent++;
                    }
                });
        }

        public ActionResult GetProgress()
        {
            return Content(percent.ToString());
        }
    }
}