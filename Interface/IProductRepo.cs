using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Dto;
namespace ThuongMaiDienTuWebAPI.Interface
{
    public interface IProductRepo
    {
        Product GetProductById(string id);
        ICollection<ProductInSearchDto> SearchProducts(string keyword,int page,int minPrice, int maxPrice, int brandId);
        bool ProductExist(string id);
        bool AddProduct(Product product);
        bool UpdateProduct(Product product);
        bool DeleteProduct(string id);
        bool Save();
    }
}
