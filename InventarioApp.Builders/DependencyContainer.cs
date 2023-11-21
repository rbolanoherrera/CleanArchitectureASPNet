using Microsoft.Extensions.DependencyInjection;

namespace InventarioApp.Builders
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddBuilders(this IServiceCollection services)
        {
            services.AddScoped<ProductosBuilder>();

            return services;
        }
    }
}