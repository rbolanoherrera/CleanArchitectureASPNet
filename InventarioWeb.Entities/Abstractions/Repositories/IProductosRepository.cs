namespace InventarioApp.Entities.Abstractions.Repositories
{
    public interface IProductosRepository : IBaseRepository<Productos>
    {        
        Task<List<Productos>> GetAll();
        Task<Productos> GetProductoById(Guid id);
    }
}