using ConsumerRab.Model;
using ConsumerRab.Service;
using Microsoft.AspNetCore.Mvc;

namespace ConsumerRab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListProductController:ControllerBase
    {
        IListProductService _productService;

        public ListProductController(IListProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("GetAllProduct")]
        public async Task<ActionResult<List<ProductList>>> GetAll()
        {
            return Ok(await _productService.GetAll());
        }

    }
}
