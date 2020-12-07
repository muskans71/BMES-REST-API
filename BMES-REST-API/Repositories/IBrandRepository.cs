using BMES_REST_API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
    interface IBrandRepository
    {
        public Brand FindBrandById(long id);
        public IEnumerable<Brand> GetAllcategories();
        public void SaveBrand(Brand n);
        public void EditBrands(Brand n);
        public void Delete(Brand brand);
    }
}
