using InventarioApp.Entities.Abstractions.Repositories.Queries;
using Microsoft.Extensions.DependencyInjection;

namespace InventarioApp.Repository.Dapper
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddDapperRepository(this IServiceCollection services)
        {
            services.AddScoped<Connection>();
            services.AddScoped<IQueryProductosRepository, QueryProductosRepository>();

            return services;
        }
    }
}