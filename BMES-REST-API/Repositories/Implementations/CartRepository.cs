using BMES_REST_API.Database;
using BMES_REST_API.Models.Cart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
    public class CartRepository:ICartRepository
    {
        private BmesDbContext bmesDbContext;

        public CartRepository(BmesDbContext context)
        {
            bmesDbContext = context;
        }

        public Cart FindCartById(long id)
        {
            var cart = bmesDbContext.Carts.Find(id);
            return cart;
        }
        public IEnumerable<Cart> GetAllCarts()
        {
            var cart = bmesDbContext.Carts;
            return cart;
        }
        public void SaveCart(Cart cart)
        {
            bmesDbContext.Carts.Add(cart);
            bmesDbContext.SaveChanges();
        }
        public void DeleteCart(Cart cart)
        {
            bmesDbContext.Carts.Remove(cart);
            bmesDbContext.SaveChanges();
        }
        public void UpdateCart(Cart cart)
        {
            bmesDbContext.Carts.Update(cart);
            bmesDbContext.SaveChanges();
        }
    }
}
