namespace WebSignalR
{
    using Microsoft.AspNet.SignalR;

    public class SimpleHub : Hub
    {
        public void ShowProgress(string message)
        {
            Clients.All.showPercent(message);
        }
    }
}