using System;

namespace AllenEcommerceBlazorApp.Server.Services.CartService
{
    public class CartService : ICartService
    {
        public CartService()
        {

        }

        public Task<ServiceResponse<List<CartProductResponseDTO>>> GetCartProducts(List<CartItem> cartItems)
        {
            throw new NotImplementedException();
        }
    }
}

