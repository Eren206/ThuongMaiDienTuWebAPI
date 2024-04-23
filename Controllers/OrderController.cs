using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Repository;

namespace ThuongMaiDienTuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        public IOrderRepo orderRepo { get; set; }
        public IMapper mapper { get; set; }
        public OrderController(IOrderRepo orderRepo, IMapper mapper)
        {
            this.orderRepo = orderRepo;
            this.mapper = mapper;
        }
      
        [HttpGet]
        public IActionResult GetOrdersList()
        {
            var ordersList = mapper.Map<List<OrderDto>>(orderRepo.getAll());
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(ordersList);
        }
        // POST api/<ProductController>
        [HttpPost]
        public IActionResult CreateOrder([FromBody] OrderDto orderDto)
        {
            var order = mapper.Map<OrderDto>(orderDto);
            if (order == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(order);

        }

        [HttpPut("{id}/cancel")]
        public IActionResult CancelOrder([FromQuery] int orderId, [FromBody] OrderDto orderDto)
        {
            var cancelledOrder = await orderRepo.CancelOrder(orderId);
            if (cancelledOrder == null)
            {
                return NotFound();
            }
            return Ok(cancelledOrder);
        }
    }
}
