using ThuongMaiDienTuWebAPI.Models;
namespace ThuongMaiDienTuWebAPI.Dto
{
    public class CartIemDto
    {
        public Product Product { get; set; } = new Product();
        public int Quantity { get; set; }
    }
}
