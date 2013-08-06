namespace WebSignalR.Controllers
{
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using Microsoft.AspNet.SignalR;

    public class HomeController : Controller
    {
        private static int percent;

        public ActionResult Index()
        {
            return View();
        }

        public void StartLongProcess()
        {
            percent = 0;
            // здесь мы как будто запускаем большой процесс на бэкэнде
            Task.Factory.StartNew(() =>
                {
                    while (true)
                    {
                        Thread.Sleep(1000);
                        // это не переменная, а например ячейка в БД или сервис
                        percent++;
                        IHubContext context = GlobalHost.ConnectionManager.GetHubContext<SimpleHub>();
                        context.Clients.All.showPercent(percent);
                    }
                });
        }
    }
}