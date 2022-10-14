using System;
namespace AllenEcommerceBlazorApp.Client.Services.OrderService
{
    public interface IOrderService
    {
        Task PlaceOrder();

        Task<List<OrderOverviewResponseDTO>> GetOrders();

        Task<OrderDetailsResponse> GetOrderDetails(int orderId);

    }
}

