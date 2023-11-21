using InventarioApp.Interactors.Abstractions.Productos;
using Microsoft.Extensions.DependencyInjection;

namespace InventarioApp.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<IAddProductosOutputPort, ProductosPresenter>();

            return services;
        }
    }
}