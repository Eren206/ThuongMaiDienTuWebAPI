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
        [HttpGet("Danh sách khách hàng")]
        public IActionResult GetCustomers() {
            var customers = mapper.Map<List<CustomerDto>>(customerRepo.GetAll());
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(customers);
        }

        [HttpGet("{phoneNumber}")]
        public IActionResult GetCustomerByPhoneNumber([FromQuery] string PhoneNumer)
        {
            var customer = mapper.Map<CustomerDto>(customerRepo.GetCustomerByPhoneNumber(PhoneNumer));
            return Ok(customer);
        }
        [HttpPost]
        public IActionResult AddCustomer([FromBody] CustomerDto customerDto)
        {
            var customer = mapper.Map<CustomerDto>(customerDto);
            if (customer == null)
            {
                return BadRequest(ModelState);
            }
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(customer);
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
