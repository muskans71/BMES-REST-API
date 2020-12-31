using BMES_REST_API.Models.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Models.Cart
{
    public class Cart: BaseObject
    {
        public Cart()
        {
            cartItems = new List<CartItem>();
        }
        public string UniqueCartId { get; set; }
        public cartStatus CartStatus { get; set; }
        public IEnumerable<CartItem> cartItems { get; set; }
    }
}
