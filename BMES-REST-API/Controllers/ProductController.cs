using BMES_REST_API.Messages.Request.Product;
using BMES_REST_API.Messages.Response.Product;
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
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService iproductService)
        {
            productService = iproductService;
        }

        [HttpGet(template: "id")]
        public ActionResult<GetProductResponse> GetProduct(long id)
        {
            var getProductRequest = new GetProductRequest();
            getProductRequest.Id = id;
            return productService.GetProduct(getProductRequest);
        }

        [HttpGet]
        public ActionResult<FetchProductResponse> GetProducts()
        {
            var fetchProductRequest = new FetchProductRequest();
            return productService.FetchProduct(fetchProductRequest);
        }
        [HttpPost]
        public ActionResult<CreateProductResponse> PostProduct(CreateProductRequest createProductRequest)
        {
            return productService.SaveProduct(createProductRequest);
        }

        [HttpPut]
        public ActionResult<UpdateProductResponse> PutProduct(UpdateProductRequest updateProductRequest)
        {
            return productService.EditProduct(updateProductRequest);
        }

        [HttpDelete(template: "id")]
        public ActionResult<DeleteProductResponse> DeleteProduct(long id)
        {
            DeleteProductRequest deleteProductRequest = new DeleteProductRequest();
            deleteProductRequest.Id = id;
            return productService.DeleteProduct(deleteProductRequest);
        }
    }
}
