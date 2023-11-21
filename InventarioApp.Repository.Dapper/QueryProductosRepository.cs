using Dapper;
using InventarioApp.Entities;
using InventarioApp.Entities.Abstractions.Repositories.Queries;

namespace InventarioApp.Repository.Dapper
{
    public class QueryProductosRepository : IQueryProductosRepository
    {
        private readonly Connection connection;

        public QueryProductosRepository(Connection connection)
        {
            this.connection = connection;
        }

        public async Task<List<Productos>> GetProductoPorNombre(string nombre)
        {
            var dictionary = new Dictionary<string, string>()
            {
                { "@Nombre", nombre }
            };

            string query = "select * from Productos where nombre like '%' + @Nombre + '%'";

            var response = await connection.sqlConnection.QueryAsync<Productos>(query);

            return response.ToList();
        }
    }
}