namespace InventarioApp.Interactors.Abstractions.DTO
{
    public class ProductosDTO
    {
        public Guid Id { get; set; }

        public string Codigo { get;  set; }

        public string Nombre { get;  set; }

        public Guid? IdTipoProducto { get;  set; }

        public string ValorCompra { get;  set; }

        public string ValorVenta { get;  set; }

        public string Iva { get; set; }

        //public byte[] Imagen { get; set; }

        public Guid IdUnidadMedidaBase { get; set; }

        public Guid IdUnidadMedidaCompra { get; set; }

        public Guid IdUnidadMedidaVenta { get; set; }

        public decimal? CantEquivalente { get; set; }

        //public string CodigoBarras { get; set; }

        public Guid? ProveedorId { get; set; }

        public DateTime CreatedAt { get; set; }

        //public DateTime? UpdatedAt { get; set; }

        //public string UserCreated { get;  set; }

        //public string UserUpdated { get; set; }

        public int? CantMinimaAlert { get; set; }

        public int CantidadStock { get; set; }

        //public string FechaVencimiento { get; set; }

        public Guid EstadoId { get; set; }
    }
}