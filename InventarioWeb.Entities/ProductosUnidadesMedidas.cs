using InventarioApp.Abstractions.Entities;

namespace InventarioApp.Entities
{
    public class ProductosUnidadesMedidas : IEntity
    {
        public Guid Id { get; set; }
        public Guid ProductoId { get; set; }
        public Guid UnidadMedidaId { get; set; }
        public int CantEquivalente { get; set; }
        public double Valor { get; set; }
        public Guid Estado { get; set; }
        //public List<Productos> Productos { get; set; }
        //public List<UnidadesMedidas> UnidadesMedidas { get; set; }
    }
}