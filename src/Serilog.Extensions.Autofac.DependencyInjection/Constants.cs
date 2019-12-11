using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;

namespace Serilog.Extensions.Autofac.DependencyInjection
{
    internal class Constants
    {
        public const string DefaultLogTemplate
            = "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}";

        public static LoggerConfiguration DefaultLoggerConfiguration(string logpath, string outputTemplate,
            LogEventLevel logLevel)
            => new LoggerConfiguration()
                .Enrich.FromLogContext()
                .MinimumLevel.Is(logLevel)
                .WriteTo.RollingFile(logpath)
                .WriteTo.Console(outputTemplate: outputTemplate, theme: AnsiConsoleTheme.Literate);
    }
}