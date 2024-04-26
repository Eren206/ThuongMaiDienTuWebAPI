using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Helper;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
namespace ThuongMaiDienTuWebAPI.Repository
{
    public class EmployeeRepo: IEmployeeRepo
    {
        private readonly DataContext context;
        public EmployeeRepo(DataContext context)
        {
            this.context = context;
        }
    }
        public 
}
