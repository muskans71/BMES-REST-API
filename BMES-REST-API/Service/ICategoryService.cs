using BMES_REST_API.Messages.Request.Categoy;
using BMES_REST_API.Messages.Response.Category;

namespace BMES_REST_API.Service
{
    public interface ICategoryService
    {
        public CreateCategoryResponse SaveCategory(CreateCategoryRequest createCategoryRequest);
        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deletecategoryRequest);
        public FetchCategoryResponse FetchCategory(FetchCategoryRequest fetchcategoryRequest);
        public GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest);
        public UpdateCategoryResponse EditCategory(UpdateCategoryRequest updateCategoryRequest);
      
    }
}
