
namespace ThuongMaiDienTuWebAPI.Dto
{
    public class CartDto
    {
        public List<CartIemDto> CartItems { get; set; }   = new List<CartIemDto>();
        public decimal TotalAmount { get; set; } 
    }
}
