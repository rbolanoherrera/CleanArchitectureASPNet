namespace InventarioApp.Entities.Abstractions.Repositories.Queries
{
    public interface IQueryProductosRepository
    {
        Task<List<Productos>> GetProductoPorNombre(string nombre);
    }
}