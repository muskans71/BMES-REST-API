using BMES_REST_API.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
     public interface ICartItemRepository
    {
        public CartItem FindCartItemById(long id);
        public IEnumerable<CartItem> FindCartItemsByCartId(long cartId);
        public void SaveCartItem(CartItem cartItem);
        public void DeleteCartItem(CartItem cartItem);
        public void UpdateCartItem(CartItem cartItem);
    }
}
