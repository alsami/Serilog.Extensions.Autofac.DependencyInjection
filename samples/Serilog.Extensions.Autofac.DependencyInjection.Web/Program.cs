using Autofac.Extensions.DependencyInjection;

namespace Serilog.Extensions.Autofac.DependencyInjection.Web;

public static class Program
{
    public static async Task Main(string[] args)
    {
        var host = CreateWebHostBuilder(args);

        await host.RunAsync();
    }

    private static IHost CreateWebHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .UseServiceProviderFactory(new AutofacServiceProviderFactory())
            .ConfigureWebHostDefaults(builder => builder.UseStartup<Startup>())
            .Build();
}