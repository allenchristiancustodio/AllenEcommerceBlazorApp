using System;
using AllenEcommerceBlazorApp.Shared;

namespace AllenEcommerceBlazorApp.Client.Services.ProductServices
{
    public interface IProductService
    {
        event Action ProductChanged;
        string Message { get; set; }

        List<Product> Products { get; set; }

        Task GetProducts(string? categoryUrl = null);

        Task<ServiceResponse<Product>> GetProduct(int productId);

        Task SearchProducts(string searchText);

        Task<List<string>> GetProductSearchSearchSuggestions(string searchText);
    }
}

