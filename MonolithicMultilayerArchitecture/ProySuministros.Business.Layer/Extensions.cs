using ProySuministros.Business.Layer.Services.Implementations;
using ProySuministros.Business.Layer.Services.Interfaces;
using ProySuministros.DataAccess.Layer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("ProySuministros.Presentation.Layer")]
namespace ProySuministros.Business.Layer
{
    internal static class Extensions
    {
        public static IServiceCollection AddBusiness(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDataAccess(configuration);
            return services;
        }
    }
}
