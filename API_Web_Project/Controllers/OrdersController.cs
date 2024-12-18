using Microsoft.AspNetCore.Mvc;
using API_Web_Project.DTO;
using API_Web_Project.Services;

namespace API_Web_Project.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost]
        public IActionResult PlaceOrder([FromBody] OrderDto model)
        {
            try
            {
                var order = _orderService.PlaceOrder(model, userId: 1); // Hardcoded userId for simplicity
                return Ok(order);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
