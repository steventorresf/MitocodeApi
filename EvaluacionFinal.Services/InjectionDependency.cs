using EvaluacionFinal.DataAccess;
using EvaluacionFinal.DataAccess.Implementations;
using EvaluacionFinal.DataAccess.Interfaces;
using EvaluacionFinal.Services.Implemenattions;
using EvaluacionFinal.Services.Implementations;
using EvaluacionFinal.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EvaluacionFinal.Services
{
    public static class InjectionDependency
    {
        public static IServiceCollection AddInterfacesInjection(this IServiceCollection services)
        {
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProductoRepository, ProductoRepository>();

            services.AddScoped<ICategoriaService, CategoriaService>();
            services.AddScoped<IProductoService, ProductoService>();

            return services;
        }

        public static IServiceCollection AddDbContextInjection(this IServiceCollection services, IConfiguration configuration)
        {
            try
            {
                services.AddDbContext<EvaluacionFinalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("EvaluacionFinalDbContext")));
                return services;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
