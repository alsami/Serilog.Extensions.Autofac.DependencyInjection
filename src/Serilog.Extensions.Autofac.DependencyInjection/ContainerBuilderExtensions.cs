using Autofac;
using Serilog.Events;

namespace Serilog.Extensions.Autofac.DependencyInjection
{
    public static class ContainerBuilderExtensions
    {
        public static ContainerBuilder RegisterSerilog(this ContainerBuilder builder, string logPath,
            LogEventLevel logEventLevel = LogEventLevel.Debug, string outputTemplate = Constants.DefaultLogTemplate)
        {
            if (string.IsNullOrWhiteSpace(logPath))
                throw new ArgumentNullException(nameof(logPath));

            if (string.IsNullOrWhiteSpace(outputTemplate))
                throw new ArgumentNullException(nameof(outputTemplate));

            return RegisterSerilogInternal(builder,
                Constants.DefaultLoggerConfiguration(logPath, outputTemplate, logEventLevel));
        }

        public static ContainerBuilder RegisterSerilog(this ContainerBuilder builder,
            LoggerConfiguration loggerConfiguration) => RegisterSerilogInternal(builder, loggerConfiguration);

        private static ContainerBuilder RegisterSerilogInternal(this ContainerBuilder builder,
            LoggerConfiguration loggerConfiguration)
        {
            if (loggerConfiguration == null)
                throw new ArgumentNullException(nameof(loggerConfiguration));

            Log.Logger = loggerConfiguration
                .CreateLogger();

            builder.RegisterModule<SerilogModule>();

            return builder;
        }
    }
}