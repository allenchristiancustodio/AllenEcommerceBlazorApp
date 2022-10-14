using System;
namespace AllenEcommerceBlazorApp.Shared
{
    public class OrderOverviewResponseDTO
    {

        public int Id { get; set; }

        public DateTime  OrderDate { get; set; }

        public decimal TotalPrice { get; set; }

        public string Product { get; set; }

        public string ProductImageUrl { get; set; }

    }
}

