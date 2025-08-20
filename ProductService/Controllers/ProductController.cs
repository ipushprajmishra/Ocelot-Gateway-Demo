using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProductService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "Laptop", Price = 800 },
                new { Id = 2, Name = "Phone", Price = 500 }
            });
        }
    }
}
