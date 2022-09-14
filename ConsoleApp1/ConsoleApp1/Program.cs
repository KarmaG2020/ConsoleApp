using ConsoleApp1;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace MyApp
{
    class Program
    {
        static void Main(String[] args)
        {
            CreatHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreatHostBuilder(String[] args) =>
        
            Host.CreateDefaultBuilder(args).ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            }); 
        
    }

}