using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Repository;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ThuongMaiDienTuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : Controller
    {
        private const int pageSize = 20;
        public IProductRepo productRepo { get; set; }
        
        public IMapper mapper { get; set; }
        public ProductController(IProductRepo productRepo , IMapper mapper)
        {
            this.productRepo = productRepo;
            
            this.mapper = mapper;
        }
        // GET: api/<ProductController>/detail/sp001
        [HttpGet()]
        public IActionResult GetDetailProduct([FromQuery]string productId)
        {
            var product= mapper.Map<ProductDto>(productRepo.GetProductById(productId));
            return Ok(product);
        }

        // GET api/<ProductController>/search/keyword=sp&....
        [HttpGet("search/")]
        public IActionResult GetProductByName([FromQuery] string keyword,
        [FromQuery] int? minPrice,
        [FromQuery] int? maxPrice,
        [FromQuery] int? page,
        [FromQuery] int? brandId
        )
        {
            var products = productRepo.SearchProducts(keyword,(int)page,(int)minPrice,(int)maxPrice,(int)brandId);
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(products);
        }

        // POST api/<ProductController>
        [HttpPost]
        public IActionResult CreateProducts([FromBody] ProductDto productDto)
        {
            var product = mapper.Map<ProductDto>(productDto);
            if (product == null)   
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(product);
        }
       

        // PUT api/<ProductController>/5
        [HttpPut()]
        public IActionResult Put([FromQuery] string productId, [FromBody] ProductDto product )
        {
            if(!productRepo.ProductExist(productId))
            {
                return NotFound();
            }
            return Ok();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete()]
        public IActionResult DeleteProduct([FromQuery] string productId)
        {
            try {
                productRepo.DeleteProduct(productId);
            }
            catch(Exception ex)
            {
                return Ok(ex);
            }
            return Ok("Đã xóa (ngưng bán) sản phẩm!");
            }
        
    }
}
