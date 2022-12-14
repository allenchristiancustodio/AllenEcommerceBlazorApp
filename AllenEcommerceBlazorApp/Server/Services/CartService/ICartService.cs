using System;
namespace AllenEcommerceBlazorApp.Server.Services.CartService
{
    public interface ICartService
    {

        Task<ServiceResponse<List<CartProductResponseDTO>>> GetCartProducts(List<CartItem> cartItems);

        Task<ServiceResponse<List<CartProductResponseDTO>>> StoreCartItems(List<CartItem> cartItems);

        Task<ServiceResponse<int>> GetCartItemsCount();

        Task<ServiceResponse<List<CartProductResponseDTO>>> GetDbCartProducts();

        Task<ServiceResponse<bool>> AddtoCart(CartItem cartItem);

        Task<ServiceResponse<bool>> UpdateQuantity(CartItem cartItem);

        Task<ServiceResponse<bool>> RemoveItemFromCart(int productId,int productTypeId);

    }
}

