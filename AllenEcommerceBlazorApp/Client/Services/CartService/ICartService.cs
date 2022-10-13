using System;
namespace AllenEcommerceBlazorApp.Client.Services.CartService
{
    public interface ICartService
    {

        event Action OnChange;

        Task AddToCart(CartItem cartItem);

        Task<List<CartItem>> GetCartItems();

        Task<List<CartProductResponseDTO>> GetCartProducts();

        Task RemoveProductFromCart(int productId, int productTypeId);

        Task UpdateQuantity(CartProductResponseDTO product);

        Task StoreCartItems(bool emptyLocalCart);

        Task GetCartItemsCount();

    }
}

