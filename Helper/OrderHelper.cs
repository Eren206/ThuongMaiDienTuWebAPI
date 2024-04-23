namespace ThuongMaiDienTuWebAPI.Helper
{
    public class OrderHelper
    {
        public static List<string> OrderStattues { get; } = new()
        {
            "Đã tạo", "Chấp nhận", "Đã hủy", "Đã giao", "Đang vận chuyển"
        };
    }
}
