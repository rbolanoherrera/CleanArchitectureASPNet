using InventarioApp.Abstractions.Entities;
using System.ComponentModel.DataAnnotations;

namespace InventarioApp.Entities
{
    public class Productos : IEntity
    {
        public Productos()
        {
            CreatedAt = DateTime.UtcNow;
        }

        public Guid Id { get; set; }

        //[Required]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; }

        [Required]
        [Display(Name = "Nombre")]
        public string Nombre { get;  set; }

        [Display(Name = "Tipo de producto")]
        public Guid? IdTipoProducto { get;  set; }

        [Required]
        //[DataType(DataType.Text)]
        [Display(Name = "Valor compra")]
        [RegularExpression(@"^[0-9,.]+$", ErrorMessage = "Solo se permiten números 0-9 y el . decimal")]
        public string ValorCompra { get;  set; }

        [Required]
        //[DataType(DataType.Text)]
        [RegularExpression(@"^[0-9,.]+$", ErrorMessage = "Solo se permiten números 0-9 y el . decimal")]
        [Display(Name = "Valor venta")]
        public string ValorVenta { get;  set; }

        [Display(Name = "Iva")]
        //[DataType(DataType.Currency)]
        [RegularExpression(@"^[0-9.]+$", ErrorMessage = "Solo se permiten números 0-9 y el . decimal")]
        public string Iva { get; set; }

        [Display(Name = "Imagen del producto")]
        public byte[] Imagen { get; set; }

        //[Required]
        [Display(Name = "Unidad de Medida Base")]
        public Guid IdUnidadMedidaBase { get; set; }

        //[Required]
        [Display(Name = "Unidad de Medida Compra")]
        public Guid IdUnidadMedidaCompra { get; set; }

        //[Required]
        [Display(Name = "Unidad de Medida Venta")]
        public Guid IdUnidadMedidaVenta { get; set; }

        /// <summary>
        /// Relación que existe en la Unidad de Mediad de Compra y la Unidad de Mediad de Venta. 
        /// Sera el valor que se descontara del Inventario al realizar una venta
        /// </summary>
        //[Required]
        [Display(Name = "Cantidad equivalente")]
        public decimal? CantEquivalente { get; set; }

        public string CodigoBarras { get; set; }

        [Display(Name = "Proveedor")]
        public Guid? ProveedorId { get; set; }

        [Display(Name = "Fecha de creación")]
        public DateTime CreatedAt { get; set; }

        [Display(Name = "Fecha de actualización")]
        public DateTime? UpdatedAt { get; set; }

        [Display(Name = "Creado por")]
        public string UserCreated { get;  set; }

        [Display(Name = "Actualizado por")]
        public string UserUpdated { get; set; }
        //public List<int> UnidadesMedidasId { get; set; }

        /// <summary>
        /// Cantidad minima en el Inventario para generar una alerta de que se va a acabar las Existencias en el Inventario
        /// </summary>
        [Display(Name = "Stock minimo alerta")]
        public int? CantMinimaAlert { get; set; }

        /// <summary>
        /// Cantidad existente en el Inventario
        /// </summary>
        [Display(Name = "Cantidad en Stock")]
        public int CantidadStock { get;  set; }

        [Display(Name = "Fecha de vencimiento")]
        public string FechaVencimiento { get; set; }

        [Display(Name = "Estado")]
        public Guid EstadoId { get; set; }


        //public void SetNombre(string nombre)
        //{
        //    Nombre = nombre;
        //}

        //public void SetCodigo(string codigo)
        //{
        //    Codigo = codigo;
        //}

        //public void SetIdTipoProducto(Guid idtipoProducto)
        //{
        //    IdTipoProducto = idtipoProducto;
        //}

        //public void SetValorCompra(string valCompra)
        //{
        //    ValorCompra = valCompra;
        //}

        //public void SetValorVenta(string valVenta)
        //{
        //    ValorVenta = valVenta;
        //}

        public void SetCantidadStock(int cantidadStock)
        {
            if (cantidadStock < 0)
                throw new Exception("La cantidad en stock debe ser mayor a cero");

            CantidadStock = cantidadStock;
        }

    }
}