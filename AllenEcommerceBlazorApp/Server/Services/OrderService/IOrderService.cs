using System;
namespace AllenEcommerceBlazorApp.Server.Services.OrderService
{
    public interface IOrderService
    {

        Task<ServiceResponse<bool>> PlaceOrder();


    }
}

