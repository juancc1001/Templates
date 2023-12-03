using Microsoft.AspNetCore.Builder;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProySuministros.Business.Layer;
using ProySuministros.Presentation.Layer.Middlewares;

[assembly: InternalsVisibleTo("ProySuministros.Bootstrapper")]
namespace ProySuministros.Presentation.Layer
{
    internal static class Module
    {
        public static IServiceCollection AddModule(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddBusiness(configuration);
            return services;
        }
        public static IApplicationBuilder UseModule(this IApplicationBuilder app)
        {
            app.UseMiddleware<ErrorMiddleware>();
            return app;
        }
    }
}