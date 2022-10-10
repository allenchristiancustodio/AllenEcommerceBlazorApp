using System;
namespace AllenEcommerceBlazorApp.Server.Services.ProductServices
{
    public interface IProductService
    {
        Task<ServiceResponse<List<Product>>> GetProductsAsync();

        Task<ServiceResponse<Product>> GetProductAsync(int productId);

        Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl);

        Task<ServiceResponse<ProductSearchResultDTO>> SearchProducts(string searchText , int page);

        Task<ServiceResponse<List<string>>> GetProductSearchSuggestions(string searchText);

        Task<ServiceResponse<List<Product>>> GetFeaturedProducts();
    }
}

