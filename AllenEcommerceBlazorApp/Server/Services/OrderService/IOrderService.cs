using System;
namespace AllenEcommerceBlazorApp.Server.Services.OrderService
{
    public interface IOrderService
    {

        Task<ServiceResponse<bool>> PlaceOrder();

        Task<ServiceResponse<List<OrderOverviewResponseDTO>>> GetOrders();

        Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId);

    }
}

