using BMES_REST_API.Messages.Request.Product;
using BMES_REST_API.Messages.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service
{
    public interface IProductService
    {
        public CreateProductResponse SaveProduct(CreateProductRequest createProductRequest);
        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest);
        public FetchProductResponse FetchProduct(FetchProductRequest fetchproductRequest);
        public GetProductResponse GetProduct(GetProductRequest getproductRequest);
        public UpdateProductResponse EditProduct(UpdateProductRequest updateProductRequest);
        
    }
}
