using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace InventarioApp.Repository.Dapper
{
    public class Connection
    {
        private readonly IConfiguration configuration;
        public SqlConnection sqlConnection { get; }

        public Connection(IConfiguration config)
        {
            this.configuration = config;
            sqlConnection = new SqlConnection(config["ConexionDB"]);
        }
    }
}
