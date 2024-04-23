using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Repository;

namespace ThuongMaiDienTuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        public ICartRepo cartRepo { get; set; }
        public IMapper mapper { get; set; }
        public CartController(ICartRepo cartRepo, IMapper mapper) {
            this.cartRepo = cartRepo;
            this.mapper = mapper;
        }
        [HttpGet("{cartId}")]
        public IActionResult GetCartItem(int cartId) {
              var 
        }
    }
}
