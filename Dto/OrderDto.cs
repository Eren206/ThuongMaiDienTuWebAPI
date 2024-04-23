using System.Data.SqlTypes;

namespace ThuongMaiDienTuWebAPI.Dto
{
    public class OrderDto { 
    
        public int OrderId { get; set; }
        public int CusmtomerId { get; set; }
        public DateTime OderDate { get; set; }
        public Decimal TotalAmount { get; set; }
        public int AddressId { get; set; }
        public int OrderDetail { get; set; }
        public int OrderStatus { get; set; }
    }
}
