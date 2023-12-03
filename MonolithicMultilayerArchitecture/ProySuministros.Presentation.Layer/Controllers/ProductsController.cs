using ProySuministros.Business.Layer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using ProySuministros.Business.Layer.DataContracts;

namespace ProySuministros.Presentation.Layer.Controllers
{
    public class ProductsController : _BaseController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDto>>> Get()
        {
            return Ok(await _productService.GetProducts());
        }
        [HttpPost]
        public async Task<ActionResult<ProductDto>> Post([FromBody] ProductDto productDto)
        {
            return Ok(await _productService.InsertProducts(productDto));
        }
    }
}