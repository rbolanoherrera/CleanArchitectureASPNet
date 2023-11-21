using InventarioApp.Interactors.Abstractions.DTO;
using InventarioApp.Interactors.Abstractions.Productos;

namespace InventarioApp.Presenters
{
    public class ProductosPresenter : IAddProductosOutputPort
    {
        public ProductosDTO Content { get; private set; }

        public Task Handle(ProductosDTO toAdd)
        {
            //Aquí se puede agregar más logica
            toAdd.Iva = "0.16";

            Content = toAdd;
            return Task.CompletedTask;
        }
    }
}