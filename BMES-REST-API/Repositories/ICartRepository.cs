using BMES_REST_API.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
    public interface ICartRepository
    {
        public Cart FindCartById(long id);
        public IEnumerable<Cart> GetAllCarts();
        public void SaveCart(Cart cart);
        public void DeleteCart(Cart cart);
        public void UpdateCart(Cart cart);
    }
}
