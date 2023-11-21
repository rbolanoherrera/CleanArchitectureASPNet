using InventarioApp.Builders;
using InventarioApp.Entities.Abstractions.Repositories;
using InventarioApp.Interactors.Abstractions.DTO;
using InventarioApp.Interactors.Abstractions.Productos;

namespace InventarioApp.Productos.UseCases
{
    /// <summary>
    /// Casos de Uso de Productos
    /// </summary>
    public class AddProductos : IAddProductosInputPort
    {
        private readonly IAddProductosOutputPort addProductosOutputPort;
        private readonly IProductosRepository productosRepository;
        private readonly ProductosBuilder productosBuilder;

        public AddProductos(IAddProductosOutputPort addProductosOutputPort,
            IProductosRepository productosRepository, ProductosBuilder productosBuilder)
        {
            this.addProductosOutputPort = addProductosOutputPort;
            this.productosRepository = productosRepository;
            this.productosBuilder = productosBuilder;
        }

        public async Task Handle(ProductosDTO toAdd)
        {
            //Aquí viene logica de los casos de uso
            if(string.IsNullOrEmpty(toAdd.ValorCompra))
            {
                throw new Exception("El Valor de compra no pueder estar vacio");
            }

            await productosRepository.Add(productosBuilder.Convert(toAdd));
            await addProductosOutputPort.Handle(toAdd);
        }
    }
}
