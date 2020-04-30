using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;

namespace _01_WebApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();

            //BuildWebHost(args).Run();//my method

            //using (var host = WebHost.Start("http://localhost:8080",
            //    c => c.Response.WriteAsync("Hajox Vahe")))
            //{
            //    Console.WriteLine("Application has been started");
            //    host.WaitForShutdown();
            //}


            //    var host = new WebHostBuilder()
            //        .UseKestrel()
            //        .UseContentRoot(Directory.GetCurrentDirectory())
            //        .UseIISIntegration()
            //        .UseStartup<Startup>()
            //        .Build();
            //host.Run();
        }
        //my method
        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .UseStartup<Startup>()
            .Build();
        //origin
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<_Startup>();
                });
    }
}
