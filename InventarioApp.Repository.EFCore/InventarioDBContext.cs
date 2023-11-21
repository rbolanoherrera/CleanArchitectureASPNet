using InventarioApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace InventarioApp.Repository.EFCore
{
    public class InventarioDBContext : DbContext
    {

        public DbSet<EstadosTablas> EstadosTablas { get; set; }
        public DbSet<UnidadesMedidas> UnidadesMedidas { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<ProductosUnidadesMedidas> ProductosUnidadesMedidas { get; set; }


        public InventarioDBContext(DbContextOptions<InventarioDBContext> options) : base(options)
        {
            
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //Colocar aquí la cadena de conexion no es necesario por que ya se la estoy padando en dependencyContainer
            //optionsBuilder.UseSqlServer("Data Source=PCRALFSL470\\SQLEXPRESS;Initial Catalog=CleanArchitecture;User=sa;Password=ralfs.8310;TrustServerCertificate=true");
            //optionsBuilder.UseSqlServer("ConexionDB");//no funciona
            //optionsBuilder.UseSqlServer(configuration.GetConnectionString("ConexionDB"));//no funciona
        }
    }
}
