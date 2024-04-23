using Microsoft.EntityFrameworkCore;
using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Helper;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;

namespace ThuongMaiDienTuWebAPI.Repository
{
    public class OrderRepo: IOrderRepo
    {
        private readonly DataContext context;
        public OrderRepo(DataContext context) {
            this.context = context;
        }
        public IEnumerable<Order> getAll()
        {
            return context.Orders.OrderBy(o => o.OrderId).ToList();
        }
      
        public bool CreateOrder(Order order)
        {
            context.Orders.Add(order);
            return Save();
        }
        public bool CancelOrder(int orderId)
        {
            var order = context.Orders.Where(p => p.OrderId == orderId).FirstOrDefault();

            if (order == null)
            {
                return false;
            }
            order.OrderStatuses = "Đã hủy";
            context.Orders.Update(order);
            return Save();
        }
        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0 ? true : false;

        }
    }
}
