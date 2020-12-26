using BMES_REST_API.Database;
using BMES_REST_API.Models.Cart;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories.Implementations
{
    public class CartItemRepository:ICartItemRepository
    {
        private BmesDbContext bmesDbContext;

        public CartItemRepository(BmesDbContext context)
        {
            bmesDbContext = context;
        }

        public CartItem FindCartItemById(long id)
        {
            var cartItem = bmesDbContext.CartItems.Find(id);
            return cartItem;
        }
        public IEnumerable<CartItem> FindCartItemsByCartId(long cartId)
        {
            var cartItems = bmesDbContext.CartItems.Where(cartItem => cartItem.CartId == cartId).Include(c => c.Product);
            return cartItems;
        }
       
        public void SaveCartItem(CartItem cartItem)
        {
            bmesDbContext.CartItems.Add(cartItem);
            bmesDbContext.SaveChanges();
        }
        public void DeleteCartItem(CartItem cartItem)
        {
            bmesDbContext.CartItems.Remove(cartItem);
            bmesDbContext.SaveChanges();
        }
        public void UpdateCartItem(CartItem cartItem)
        {
            bmesDbContext.CartItems.Update(cartItem);
            bmesDbContext.SaveChanges();
        }
    }
}
