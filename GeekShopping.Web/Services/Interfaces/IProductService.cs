using GeekShopping.Web.Models;

namespace GeekShopping.Web.Services.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> GetProducts();
        Task<ProductModel> GetProductById(long id);
        Task<ProductModel> CreateProduct(ProductModel productModel);
        Task<ProductModel> UpdateProduct(ProductModel productModel);
        Task<bool> DeleteProductById(long id);
    }
}
