using BMES_REST_API.Database;
using BMES_REST_API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories.Implementations
{
    public class BrandRepository:IBrandRepository
    {
        private BmesDbContext _context;
        public BrandRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Brand FindBrandById(long id)
        {
            var brands = _context.Brands.Find(id);

            return brands;
        }
        public IEnumerable<Brand> GetAllcategories()
        {
            var brands = _context.Brands;
            return brands;
        }
        public void SaveBrand(Brand n)
        {
            _context.Brands.Add(n);
            _context.SaveChanges();
        }
        public void EditBrands(Brand n)
        {
            _context.Brands.Update(n);
            _context.SaveChanges();
        }

        public void Delete(Brand brand)
        {
            _context.Brands.Remove(brand);
            _context.SaveChanges();
        }
    }
}

