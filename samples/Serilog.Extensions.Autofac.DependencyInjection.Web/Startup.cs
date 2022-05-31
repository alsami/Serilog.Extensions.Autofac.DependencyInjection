using Autofac;

namespace Serilog.Extensions.Autofac.DependencyInjection.Web;

public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }

        app.Run(async context =>
        {
            var logger = context.RequestServices.GetRequiredService<ILogger<Startup>>();
            logger.LogInformation("LOGGER WORKS");
            await context.Response.WriteAsync("Hello World!");
        });
    }

    public void ConfigureContainer(ContainerBuilder builder)
    {
        var logPath = Path.Combine(typeof(Startup).Assembly.GetName().Name!, "Log.log");
        builder.RegisterSerilog(logPath);
    }
}