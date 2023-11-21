using InventarioApp.Interactors.Abstractions.DTO;
using InventarioApp.Interactors.Abstractions.Productos;
using Microsoft.AspNetCore.Mvc;

namespace InventarioApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductosController : Controller
    {
        private readonly IAddProductosInputPort addProductosInputPort;
        private readonly IAddProductosOutputPort addProductosOutputPort;

        public ProductosController(IAddProductosInputPort addProductosInputPort,
            IAddProductosOutputPort addProductosOutputPort)
        {
            this.addProductosInputPort = addProductosInputPort;
            this.addProductosOutputPort = addProductosOutputPort;
        }

        [HttpPost]
        public async Task<IActionResult> AddProducto(ProductosDTO toAdd)
        {
            await addProductosInputPort.Handle(toAdd);
            var response = addProductosOutputPort.Content;

            return Ok(response);
        }

        //[HttpPost]
        //public async Task<IActionResult> GetAll()
        //{
        //    await addProductosInputPort.Handle(toAdd);
        //    var response = addProductosOutputPort.Content;

        //    return Ok(response);
        //}
    }
}
