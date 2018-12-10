using Autofac;
using Microsoft.Extensions.Logging;
using Serilog.Extensions.Logging;

namespace Serilog.Extensions.Autofac.DependencyInjection
{
    internal class SerilogModule : Module
    {
        private readonly LoggerConfiguration loggerConfiguration;

        public SerilogModule(LoggerConfiguration loggerConfiguration)
        {
            this.loggerConfiguration = loggerConfiguration;
        }

        protected override void Load(ContainerBuilder builder)
        {
            Log.Logger = this.loggerConfiguration
                .CreateLogger();

            builder.Register(_ => new LoggerFactory(new ILoggerProvider[] {new SerilogLoggerProvider()}))
                .As<ILoggerFactory>()
                .SingleInstance();

            builder.RegisterGeneric(typeof(Logger<>))
                .As(typeof(ILogger<>))
                .SingleInstance();
        }
    }
}