
namespace ThuongMaiDienTuWebAPI.Dto
{
    public class CartDto
    {
        public List<CartIemDto> CartItems { get; set; }   = new List<CartIemDto>();
        public int CartId { get; set; }
        public int CustomerId { get; set; }
        public string ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
