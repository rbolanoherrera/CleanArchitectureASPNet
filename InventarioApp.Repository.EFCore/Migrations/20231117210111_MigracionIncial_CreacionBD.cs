using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventarioApp.Repository.EFCore.Migrations
{
    /// <inheritdoc />
    public partial class MigracionIncial_CreacionBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EstadosTablas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadosTablas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Productos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdTipoProducto = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ValorCompra = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValorVenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iva = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imagen = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    IdUnidadMedidaBase = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadMedidaCompra = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUnidadMedidaVenta = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantEquivalente = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    CodigoBarras = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProveedorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserCreated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserUpdated = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CantMinimaAlert = table.Column<int>(type: "int", nullable: true),
                    CantidadStock = table.Column<int>(type: "int", nullable: false),
                    FechaVencimiento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Productos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductosUnidadesMedidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UnidadMedidaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CantEquivalente = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<double>(type: "float", nullable: false),
                    Estado = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductosUnidadesMedidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadesMedidas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadesMedidas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EstadosTablas");

            migrationBuilder.DropTable(
                name: "Productos");

            migrationBuilder.DropTable(
                name: "ProductosUnidadesMedidas");

            migrationBuilder.DropTable(
                name: "UnidadesMedidas");
        }
    }
}
