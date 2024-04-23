using ThuongMaiDienTuWebAPI.Controllers;
using ThuongMaiDienTuWebAPI.Dto;

namespace ThuongMaiDienTuWebAPI.Interface
{
    public interface ICartRepo
    {
        Cart GetCartItem(int cartId);
        bool AddCartItem();
        bool UpdateCart();
        bool DeleteCartItem();
    }
}
