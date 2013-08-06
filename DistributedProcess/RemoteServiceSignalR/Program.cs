namespace RemoteServiceSignalR
{
    using System;
    using System.IO;
    using System.Threading;
    using Microsoft.AspNet.SignalR.Client;
    using Microsoft.AspNet.SignalR.Client.Hubs;

    internal class Program
    {
        private static void Main(string[] args)
        {
            var hubConnection = new HubConnection("http://localhost:37255");
            var hubProxy = hubConnection.CreateHubProxy("simpleHub");
            hubConnection.Start().Wait();

            int step = 0;

            while (true)
            {
                string message = string.Format("Step #{0}: done", step);

                File.WriteAllText("~/../../../../Web/DistibutedDatabase.txt", message);
                
                hubProxy.Invoke("ShowProgress", message);

                Console.WriteLine(message);

                step++;

                Thread.Sleep(new Random().Next(1000, 4000));
            }
        }
    }
}