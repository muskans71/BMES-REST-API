using BMES_REST_API.Database;
using BMES_REST_API.Models.Product;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories.Implementations
{
    public class ProductRepository: IProductRepository
    {
        private BmesDbContext _context;

        public ProductRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Product FindProductById(long id)
        {
            var note = _context.Products.Find(id);
            return note;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            var products = _context.Products.Include(p=>p.Category).Include(p=> p.Brand);
            return products;
        }
        public void SaveProduct(Product n)
        {
            _context.Products.Add(n);
            _context.SaveChanges();
        }
        public void EditProduct(Product n)
        {
            _context.Products.Update(n);
            _context.SaveChanges();
        }

        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
    }
}

