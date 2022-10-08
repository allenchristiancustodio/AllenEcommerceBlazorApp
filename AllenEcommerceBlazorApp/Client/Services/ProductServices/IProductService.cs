using System;
using AllenEcommerceBlazorApp.Shared;

namespace AllenEcommerceBlazorApp.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }

        Task GetProducts();
    }
}

