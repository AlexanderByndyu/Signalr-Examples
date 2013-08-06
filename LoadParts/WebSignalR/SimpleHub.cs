namespace WebSignalR
{
    using System.Threading;
    using Microsoft.AspNet.SignalR;

    public class SimpleHub : Hub
    {
        public string Block2()
        {
            Thread.Sleep(3000);
            return "Какие-то графики";
        }

        public string Block3()
        {
            Thread.Sleep(3000);
            return "Какие-то индексы";
        }

        public string Block4()
        {
            Thread.Sleep(3000);
            return "Какие-то графики";
        }

        public string Block5()
        {
            Thread.Sleep(3000);
            return "Какие-то графики";
        }

        public string Block6()
        {
            Thread.Sleep(3000);
            return "Какие-то индексы";
        }

        public string Block7()
        {
            Thread.Sleep(3000);
            return "Какие-то индексы";
        }

        public string Block8()
        {
            Thread.Sleep(3000);
            return "Какие-то графики";
        }

        public string Block9()
        {
            Thread.Sleep(3000);
            return "Какие-то индексы";
        }

        public string Block10()
        {
            Thread.Sleep(3000);
            return "Какие-то графики";
        }
    }
}