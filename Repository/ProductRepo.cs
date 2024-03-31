using ThuongMaiDienTuWebAPI.Models;
using ThuongMaiDienTuWebAPI.Interface;
using ThuongMaiDienTuWebAPI.Data;
using ThuongMaiDienTuWebAPI.Dto;
using ThuongMaiDienTuWebAPI.Helper;
namespace ThuongMaiDienTuWebAPI.Repository
{
    public class ProductRepo : IProductRepo
    {
        private const int pageSize = 20;
        private readonly DataContext context;
        public ProductRepo(DataContext context)
        {
            this.context = context;
        }

        public bool AddProduct(Product product)
        {
            context.Products.Add(product);
            return Save();
        }

        public bool DeleteProduct(string id)
        {
            var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            
            if (product == null)
            {
                return false;
            }
            product.ProductStatus = "Ngưng kinh doanh";
            context.Products.Update(product);
            return Save();
        }

        public Product GetProductById(string id)
        {
            var product = context.Products.Where(p => p.ProductId == id).FirstOrDefault();
            
            return product;
        }
        public bool ProductExist(string id)
        {
            return context.Products.Any(p => p.ProductId == id);
        }

        public bool Save()
        {
            var saved = context.SaveChanges();
            return saved > 0 ? true : false;

        }

        public bool UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public ICollection<ProductInSearchDto> SearchProducts(string keyword, int page, int minPrice, int maxPrice, int brandId)
        {
            keyword = HandleUnicode.RemoveUnicode(keyword);
            keyword=(keyword).ToLower(); 
            

            var products = context.Products.Where(p => p.BrandId == brandId).ToList();
            products = products.Where(p => HandleUnicode.RemoveUnicode(p.Name).ToLower().Contains(keyword)).ToList();
            products = products.Skip((page - 1) * pageSize).ToList();

            // Join với bảng Price để lấy giá của sản phẩm nằm trong khoảng [minPrice,maxPrice]
            var productsInSearch=products
                .Join(context.Prices,product => product.ProductId,price => price.ProductId,
                (product, price) => new {Product = product, Price=price})
                .Join(context.ProductImages.Where(image => image.IsAvatar == true),
                combined => combined.Product.ProductId,
                image => image.ProductId,
                (combined,image) => new ProductInSearchDto
                {
                    ProductId= combined.Product.ProductId,
                    Name= combined.Product.Name,
                    Price=combined.Price.ImportPrice + combined.Price.Profit,
                    CoolingCapacity= combined.Product.CoolingCapacity,
                    AvatarPath=image.ImagePath,
                    
                })
                .Where(p => (p.Price) >= minPrice && (p.Price) <= maxPrice)
                .ToList();
            return productsInSearch;
        }
        
    }
}
