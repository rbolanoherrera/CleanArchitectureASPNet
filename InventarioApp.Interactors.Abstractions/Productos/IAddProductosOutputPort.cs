using InventarioApp.Interactors.Abstractions.DTO;

namespace InventarioApp.Interactors.Abstractions.Productos
{
    public interface IAddProductosOutputPort
    {
        ProductosDTO Content { get; }
        Task Handle(ProductosDTO toAdd);
    }
}