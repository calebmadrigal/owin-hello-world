using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Owin.Hosting;

namespace SelfHost
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://localhost:1337";
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Listening on " + url);
                Console.ReadLine();
            }
        }
    }
}
