using BMES_REST_API.Messages;
using BMES_REST_API.Messages.Request.Categoy;
using BMES_REST_API.Messages.Response.Category;
using BMES_REST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service.Implementations
{
    public class CategoryService:ICategoryService
    {
        private ICategoryRepository categoryRepository;
        private MessageMapper messageMapper;

        public CreateCategoryResponse SaveCategory(CreateCategoryRequest createCategoryRequest)
        {
            var category = messageMapper.MapToCategory(createCategoryRequest.Category);
            categoryRepository.SaveCategory(category);
            var createbrandresponse = new CreateCategoryResponse { Category = messageMapper.MapToCategoryDto(category) };
            return createbrandresponse;

        }

        public DeleteCategoryResponse DeleteCategory(DeleteCategoryRequest deletecategoryRequest)
        {
            var category = categoryRepository.FindCategoryById(deletecategoryRequest.Id);
            categoryRepository.Delete(category);
            var deletebrandresponse = new DeleteCategoryResponse { Category = messageMapper.MapToCategoryDto(category) };
            return deletebrandresponse;
        }

        public FetchCategoryResponse FetchCategory(FetchCategoryRequest fetchcategoryRequest)
        {
            var category = categoryRepository.GetAllcategories();
            var CategoryDtos = messageMapper.MapToCategoryDtos(category);

            return new FetchCategoryResponse
            {
                Categories = CategoryDtos
            };
        }
        public GetCategoryResponse GetCategory(GetCategoryRequest getCategoryRequest)
        {
            var category = categoryRepository.FindCategoryById(getCategoryRequest.Id);
            var categoryDTO = messageMapper.MapToCategoryDto(category);
            return new GetCategoryResponse { Category = categoryDTO };
        }
        public UpdateCategoryResponse EditCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            UpdateCategoryResponse updateCategoryResponse = null;


            var category = messageMapper.MapToCategory(updateCategoryRequest.Category);
            categoryRepository.EditCategory(category);
            var brandDto = messageMapper.MapToCategoryDto(category);

            updateCategoryResponse = new UpdateCategoryResponse
            {

            };

            return updateCategoryResponse;
        }

    }
}
