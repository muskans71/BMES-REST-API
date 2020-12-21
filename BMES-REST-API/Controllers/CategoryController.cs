using BMES_REST_API.Messages.Request.Categoy;
using BMES_REST_API.Messages.Response.Category;
using BMES_REST_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService icategoryService)
        {
            categoryService = icategoryService;
        }

        [HttpGet(template: "id")]
        public ActionResult<GetCategoryResponse> GetCategory(long id)
        {
            var getCategoryRequest = new GetCategoryRequest();
            getCategoryRequest.Id = id;
            return categoryService.GetCategory(getCategoryRequest);
        }

        [HttpGet]
        public ActionResult<FetchCategoryResponse> GetCategories()
        {
            var fetchCategoryRequest = new FetchCategoryRequest();
            return categoryService.FetchCategory(fetchCategoryRequest);
        }
        [HttpPost]
        public ActionResult<CreateCategoryResponse> PostCategory(CreateCategoryRequest createCategoryRequest)
        {
            return categoryService.SaveCategory(createCategoryRequest);
        }

        [HttpPut]
        public ActionResult<UpdateCategoryResponse> PutCategory(UpdateCategoryRequest updateCategoryRequest)
        {
            return categoryService.EditCategory(updateCategoryRequest);
        }

        [HttpDelete(template: "id")]
        public ActionResult<DeleteCategoryResponse> DeleteCategory(long id)
        {
            DeleteCategoryRequest deleteCategoryRequest = new DeleteCategoryRequest();
            deleteCategoryRequest.Id = id;
            return categoryService.DeleteCategory(deleteCategoryRequest);
        }
    }
}
