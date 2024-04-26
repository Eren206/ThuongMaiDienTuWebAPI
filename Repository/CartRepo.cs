using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Helper;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ThuongMaiDienTuWebAPI.Repository
{
    public class CartRepo : ICartRepo
    {
        private readonly DataContext context;
        public CartRepo(DataContext context) {
            this.context = context;
        }
        public IActionResult AddToCart(int cartId, int quantity = 1)
        {
            var item = context.Carts.Where(c => c.CartId == cartId).FirstOrDefault();
            if (item == null)
            {
                Product product =  context.Products.Where(p => p.ProductId == productId).FirstOrDefault();
            }
        }


    }
}
