using BMES_REST_API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
    public interface IProductRepository
    {

        public Product FindProductById(long id);
        public IEnumerable<Product> GetAllProducts();
        public void SaveProduct(Product n);
        public void EditProduct(Product n);
        public void Delete(Product product);
       
    }
}
