using System;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Microsoft.Extensions.Logging;

namespace Serilog.Extensions.Autofac.DependencyInjection.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logPath = Path.Combine(typeof(Program).Assembly.GetName().Name!, "Log.log");

            var container = new ContainerBuilder()
                .RegisterSerilog(logPath)
                .Build();

            var logger = container.Resolve<ILogger<Program>>();

            logger.LogInformation("LOGGER WORKS!");
            System.Console.WriteLine("PRESS ANY KEY TO EXIT");
            System.Console.ReadKey();
        }
    }
}