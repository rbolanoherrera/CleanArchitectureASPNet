using InventarioApp.Entities;
using InventarioApp.Entities.Abstractions.Repositories;
using Microsoft.EntityFrameworkCore;

namespace InventarioApp.Repository.EFCore
{
    public class ProductosRepository : IProductosRepository
    {
        private readonly InventarioDBContext context;

        public ProductosRepository(InventarioDBContext context)
        {
            this.context = context;
        }

        public async Task<Productos> Add(Productos producto)
        {
            if (producto == null)
                throw new Exception("El producto no puede ser null");

            producto.Id = Guid.NewGuid();
            await context.Productos.AddAsync(producto);
            await context.SaveChangesAsync();

            return producto;
        }

        public async Task<Productos> Update(Productos producto)
        {
            if (producto == null)
                throw new Exception("El producto no puede ser null");

            if (producto.Id == Guid.Empty)
                throw new Exception("Por favor digite el Id del producto");
            else
                context.Productos.Update(producto);

            await context.SaveChangesAsync();

            return producto;
        }

        public async Task<Productos> Delete(Productos producto)
        {
            if (producto.Id != Guid.Empty)
            {
                context.Productos.Remove(producto);
                await context.SaveChangesAsync();

                return producto;
            }
            else
                throw new Exception("Debe especificar el Id del Producto a Eliminar");
        }

        public async Task<List<Productos>> GetAll()
        {
            return await context.Productos.ToListAsync();
        }

        public async Task<Productos> GetProductoById(Guid id)
        {
            var video = await context.Productos.Where(p => p.Id.Equals(id)).FirstOrDefaultAsync();

            return video;
        }
    }
}
