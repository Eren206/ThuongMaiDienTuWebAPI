using ThuongMaiDienTuWebAPI.Models;
using Microsoft.EntityFrameworkCore;
namespace ThuongMaiDienTuWebAPI.Repository
{
    public class ProductRepo
    {
        private readonly DataContext context;
        public ProductRepo(DataContext context)
        {
            this.context = context;
        }
    }
}
