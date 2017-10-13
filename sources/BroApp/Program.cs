using System;
using Nancy.Hosting.Self;

namespace BroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:555/bro/";
            using (var nancyHost = new NancyHost(new Uri(url)))
            {
                nancyHost.Start();
                Console.WriteLine($"bro started at {url}.  Press enter to stop.");
                Console.ReadLine();
            }
        }
    }
}
