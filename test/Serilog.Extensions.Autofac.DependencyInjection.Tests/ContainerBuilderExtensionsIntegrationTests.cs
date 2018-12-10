using System;
using System.IO;
using System.Reflection;
using Autofac;
using Autofac.Core;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Serilog.Events;
using Serilog.Sinks.SystemConsole.Themes;
using Xunit;

namespace Serilog.Extensions.Autofac.DependencyInjection.Tests
{
    public class ContainerBuilderExtensionsIntegrationTests : IDisposable
    {
        private const string DefaultLogTemplate
            = "[{Timestamp:HH:mm:ss} {Level}] {SourceContext}{NewLine}{Message:lj}{NewLine}{Exception}{NewLine}";

        private static readonly string LogPath =
            Path.Combine(Assembly.GetExecutingAssembly().GetName().Name, "TestLogFile.log");

        private IContainer container;

        public void Dispose()
        {
            container?.Dispose();
        }

        [Fact]
        public void ContainerBuilderExtensions_RegisterSerilog_PathAndTemplate_ResolveComponents_ExpectInstances()
        {
            this.container = new ContainerBuilder()
                .RegisterSerilog(LogPath)
                .Build();

            CommonAssertations();
        }

        [Fact]
        public void ContainerBuilderExtensions_RegisterSerilog_LoggerConfiguration_ResolveComponents_ExpectInstances()
        {
            var configuration = new LoggerConfiguration()
                .MinimumLevel.Information()
                .Enrich.FromLogContext()
                .WriteTo.RollingFile(LogPath);

            this.container = new ContainerBuilder()
                .RegisterSerilog(configuration)
                .Build();

            CommonAssertations();
        }

        private void CommonAssertations()
        {
            Assert.True(this.container.IsRegistered<ILoggerFactory>());
            Assert.True(this.container.IsRegistered<ILogger<Program>>());

            ILoggerFactory factoryA;
            ILoggerFactory factoryB;

            ILogger<Program> loggerA;
            ILogger<Program> loggerB;

            using (var scope = this.container.BeginLifetimeScope())
            {
                factoryA = scope.Resolve<ILoggerFactory>();
                Assert.NotNull(factoryA);

                loggerA = scope.Resolve<ILogger<Program>>();
                Assert.NotNull(loggerA);
            }

            using (var scope = this.container.BeginLifetimeScope())
            {
                factoryB = scope.Resolve<ILoggerFactory>();
                Assert.NotNull(factoryB);

                loggerB = scope.Resolve<ILogger<Program>>();
                Assert.NotNull(loggerB);
            }

            Assert.Equal(factoryA, factoryB);
            Assert.Equal(loggerA, loggerB);
        }
    }
}