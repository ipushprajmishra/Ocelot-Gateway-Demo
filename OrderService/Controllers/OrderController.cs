using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetOrders()
        {
            return Ok(new[]
            {
                new { Id = 101, ProductId = 1, Quantity = 2 },
                new { Id = 102, ProductId = 2, Quantity = 1 }
            });
        }
    }
}
