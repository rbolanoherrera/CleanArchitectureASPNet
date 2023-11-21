using InventarioApp.Interactors.Abstractions.DTO;

namespace InventarioApp.Interactors.Abstractions.Productos
{
    public interface IAddProductosInputPort
    {
        Task Handle(ProductosDTO toAdd);
    }
}
