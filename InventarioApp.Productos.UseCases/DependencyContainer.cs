using InventarioApp.Interactors.Abstractions.Productos;
using Microsoft.Extensions.DependencyInjection;

namespace InventarioApp.Productos.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddProductosUseCases(this IServiceCollection services)
        {
            services.AddScoped<IAddProductosInputPort, AddProductos>();

            return services;
        }
    }
}