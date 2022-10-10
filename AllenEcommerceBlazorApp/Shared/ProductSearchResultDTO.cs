using System;
namespace AllenEcommerceBlazorApp.Shared
{
    public class ProductSearchResultDTO
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public int Pages { get; set; }

        public int CurrentPage { get; set; }
    }
}

