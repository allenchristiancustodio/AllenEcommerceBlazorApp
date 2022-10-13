using System;
namespace AllenEcommerceBlazorApp.Server.Services.CartService
{
    public interface ICartService
    {

        Task<ServiceResponse<List<CartProductResponseDTO>>> GetCartProducts(List<CartItem> cartItems);

        Task<ServiceResponse<List<CartProductResponseDTO>>> StoreCartItems(List<CartItem> cartItems);

        Task<ServiceResponse<int>> GetCartItemsCount();

    }
}

