using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimeiraAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
#pragma warning disable CS0246 // O nome do tipo ou do namespace "Startup" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
#pragma warning disable CS0246 // O nome do tipo ou do namespace "Startup" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
                    webBuilder.UseStartup<Startup>();
#pragma warning restore CS0246 // O nome do tipo ou do namespace "Startup" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
#pragma warning restore CS0246 // O nome do tipo ou do namespace "Startup" não pode ser encontrado (está faltando uma diretiva using ou uma referência de assembly?)
                });
    }
}
