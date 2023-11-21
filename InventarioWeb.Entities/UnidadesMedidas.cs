using InventarioApp.Abstractions.Entities;

namespace InventarioApp.Entities
{
    public class UnidadesMedidas : IEntity
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
    }
}