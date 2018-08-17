using Nancy.Hosting.Self;
using System;

namespace Example
{
    public class Program : Nancy.NancyModule
    {
        static void Main(string[] args)
        {
            HostConfiguration hostConfigs = new HostConfiguration();
            hostConfigs.UrlReservations.CreateAutomatically = true;
            Uri uri = new Uri("http://localhost:12345");
            var host = new NancyHost(hostConfigs, uri);
            Console.Write("Starting server...");
            host.Start();
            Console.WriteLine("started!");
            Console.WriteLine("press key [ENTER] to exit");
            Console.ReadLine();
        }

        public Program()
        {
            Get["/"] = _ => { return "<h5>Nancy says fuck you!</h5>"; };
        }
    }
}