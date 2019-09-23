using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace aplicacao_controle_de_tarefas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new webHostBuilder()
                .UseKestrel()
                .Configure(
                    app => {
                        app.Run(context =>context.Responsive.WriteAsync("Olá Mundo"));
                    }
                )
                .Build();
                Host.Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
