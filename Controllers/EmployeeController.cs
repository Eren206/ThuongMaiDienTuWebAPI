using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ThuongMaiDienTuWebAPI.Interface;

namespace ThuongMaiDienTuWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        public IEmployeeRepo employeeRepo { get; set; }
        public IMapper mapper { get; set; }
        public EmployeeController(IEmployeeRepo employeeRepo, IMapper mapper)
        {
            this.employeeRepo = employeeRepo;
            this.mapper = mapper;
        }

    }
}
