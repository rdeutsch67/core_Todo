using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
// using System.Data.OracleClient;

namespace TodoApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

            //Console.WriteLine("Starting.\r\n");
            //using (var _db = new OracleConnection("User Id=myUser;Password=myPassword;Data Source=MyOracleConnection"))
            //{
            //    Console.WriteLine("Open connection...");
            //    _db.Open();
            //    Console.WriteLine("Connected to:" + _db.ServerVersion);
            //    Console.WriteLine("\r\nDone. Press key for exit");
            //    Console.ReadKey();
            //}
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
