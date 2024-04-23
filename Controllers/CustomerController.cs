using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Repository;

namespace ThuongMaiDienTuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : Controller
    {
        public ICustomerRepo customerRepo { get; set; }
        public IMapper mapper { get; set; }
        public CustomerController(ICustomerRepo customerRepo, IMapper mapper)
        {
            this.customerRepo = customerRepo;
            this.mapper = mapper;
        }

        [HttpGet("{phoneNumber}")]
        public IActionResult GetCustomerByPhoneNumber([FromQuery] string PhoneNumer)
        {
            var customer = mapper.Map<CustomerDto>(customerRepo.GetCustomerById(customerId));
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerDto customerDto)
        {
            var prodcuct = mapper.Map<CustomerDto>(customerDto);
            if (prodcuct == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(prodcuct);
        }
        [HttpPut()]
        public IActionResult UpdateCustomer([FromQuery] int customerId, [FromBody] CustomerDto customer)
        {
            if (!customerRepo.CustomerExist(customerId))
            {
                return NotFound();
            }
            return Ok();
        }
    }
}
