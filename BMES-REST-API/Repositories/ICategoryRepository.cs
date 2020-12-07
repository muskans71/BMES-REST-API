using BMES_REST_API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories
{
    interface ICategoryRepository
    {
        public Category FindCategoryById(long id);
        public IEnumerable<Category> GetAllcategories();
        public void SaveCategory(Category n);
        public void EditCategory(Category n);

        public void Delete(Category category);
    }
}
