using System;
namespace AllenEcommerceBlazorApp.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductAsync(int productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);
    }
}

