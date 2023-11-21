using InventarioApp.Entities;
using InventarioApp.Interactors.Abstractions.DTO;

namespace InventarioApp.Builders
{
    public class ProductosBuilder : BuilderBase<Productos, ProductosDTO>
    {
        public override Productos Convert(ProductosDTO param)
        {
            return new Productos()
            {
                Id = param.Id,
                Codigo = param.Codigo,
                Nombre = param.Nombre,
                //IdTipoProducto = param.IdTipoProducto,
                ValorCompra = param.ValorCompra,
                ValorVenta = param.ValorVenta,
                Iva = param.Iva,
                //Imagen = param.Imagen,
                IdUnidadMedidaBase = param.IdUnidadMedidaBase,
                IdUnidadMedidaCompra = param.IdUnidadMedidaCompra,
                IdUnidadMedidaVenta = param.IdUnidadMedidaVenta,
                CantEquivalente = param.CantEquivalente,
                //CodigoBarras = param.CodigoBarras,
                ProveedorId = param.ProveedorId,
                CreatedAt = param.CreatedAt,
                //UpdatedAt = param.UpdatedAt,
                //UserCreated = param.UserCreated,
                //UserUpdated = param.UserUpdated,
                CantMinimaAlert = param.CantMinimaAlert,
                //CantidadStock = param.CantidadStock,
                //FechaVencimiento = param.FechaVencimiento,
                EstadoId = param.EstadoId
            };
        }

        public override ProductosDTO Convert(Productos param)
        {
            return new ProductosDTO()
            {
                Id = param.Id,
                Codigo = param.Codigo,
                Nombre = param.Nombre,
                ValorCompra = param.ValorCompra,
                ValorVenta = param.ValorVenta,
                Iva = param.Iva,
                //Imagen = param.Imagen,
                IdUnidadMedidaBase = param.IdUnidadMedidaBase,
                IdUnidadMedidaCompra = param.IdUnidadMedidaCompra,
                IdUnidadMedidaVenta = param.IdUnidadMedidaVenta,
                CantEquivalente = param.CantEquivalente,
                //CodigoBarras = param.CodigoBarras,
                ProveedorId = param.ProveedorId,
                CreatedAt = param.CreatedAt,
                //UpdatedAt = param.UpdatedAt,
                //UserUpdated = param.UserUpdated,
                CantMinimaAlert = param.CantMinimaAlert,
                //FechaVencimiento = param.FechaVencimiento,
                EstadoId = param.EstadoId
            };
        }
    }
}