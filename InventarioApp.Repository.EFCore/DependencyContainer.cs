using InventarioApp.Entities.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InventarioApp.Repository.EFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddEFCoreRepositories(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<InventarioDBContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("ConexionDB"), op =>
                {
                    op.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(60), null);
                });
            });

            services.AddScoped<IProductosRepository, ProductosRepository>();

            return services;
        }
    }
}