using ThuongMaiDienTuWebAPI.Models;

namespace ThuongMaiDienTuWebAPI.Interface
{
    public interface IOrderRepo
    {
        IEnumerable<Order> getAll();
        bool CreateOrder(Order order);
        bool CancelOrder(Order order);

    }
}
