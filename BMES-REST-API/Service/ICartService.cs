using BMES_REST_API.Messages.Request.Cart;
using BMES_REST_API.Messages.Response.Cart;
using BMES_REST_API.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service
{
    interface ICartService
    {
        public string UniqueCartId();
        public Cart GetCart();
        public AddItemToCartResponse AddItemToCart(AddItemToCartRequest addItemToCartRequest);

        public RemoveItemFromCartResponse RemoveItemFromCart(RemoveItemFromCartRequest removeItemFromCartRequest);
       
        public FetchCartResponse FetchCart();

        public IEnumerable<CartItem> GetCartItems();

        public int CartItemsCount();


        public decimal GetCartTotal();
       
    }
}
