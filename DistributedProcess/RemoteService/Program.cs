namespace RemoteService
{
    using System;
    using System.IO;
    using System.Threading;

    internal class Program
    {
        private static void Main()
        {
            int step = 0;

            while (true)
            {
                var message = string.Format("Step #{0}: done", step);

                File.WriteAllText("~/../../../../Web/DistibutedDatabase.txt", message);

                Console.WriteLine(message);

                step++;

                Thread.Sleep(new Random().Next(1000, 4000));
            }
        }
    }
}