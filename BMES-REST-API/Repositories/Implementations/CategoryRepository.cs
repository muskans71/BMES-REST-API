using BMES_REST_API.Database;
using BMES_REST_API.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Repositories.Implementations
{
    public class CategoryRepository:ICategoryRepository
    {
        private BmesDbContext _context;
        public CategoryRepository(BmesDbContext context)
        {
            _context = context;
        }

        public Category FindCategoryById(long id)
        {
            var category = _context.Categories.Find(id);

            return category;
        }
        public IEnumerable<Category> GetAllcategories()
        {
            var categories = _context.Categories;
            return categories;
        }
        public void SaveCategory(Category n)
        {
            _context.Categories.Add(n);
            _context.SaveChanges();
        }
        public void EditCategory(Category n)
        {
            _context.Categories.Update(n);
            _context.SaveChanges();
        }

        public void Delete(Category category)
        {
            _context.Categories.Remove(category);
            _context.SaveChanges();
        }
    }
}
