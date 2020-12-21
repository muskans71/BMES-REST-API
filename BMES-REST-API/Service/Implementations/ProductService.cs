using BMES_REST_API.Messages;
using BMES_REST_API.Messages.Request.Product;
using BMES_REST_API.Messages.Response.Product;
using BMES_REST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service.Implementations
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly ICatalogueService catalogueService;
        private MessageMapper messageMapper;

        public ProductService(IProductRepository product, ICatalogueService catalogue)
        {
            productRepository = product;
            catalogueService = catalogue;
            messageMapper = new MessageMapper();
        }

        public CreateProductResponse SaveProduct(CreateProductRequest createProductRequest)
        {
            var product = messageMapper.MapToProduct(createProductRequest.Product);
            productRepository.SaveProduct(product);
            var createbrandresponse = new CreateProductResponse { Product = messageMapper.MapToProductDto(product) };
            return createbrandresponse;

        }

        public DeleteProductResponse DeleteProduct(DeleteProductRequest deleteProductRequest)
        {
            var product = productRepository.FindProductById(deleteProductRequest.Id);
            productRepository.Delete(product);
            var deletebrandresponse = new DeleteProductResponse { Product = messageMapper.MapToProductDto(product) };
            return deletebrandresponse;
        }

        public FetchProductResponse FetchBrand(FetchProductRequest fetchproductRequest)
        {
            var product = catalogueService.FetchProducts(fetchproductRequest);
            return product;
        }
        public GetProductResponse GetBrand(GetProductRequest getproductRequest)
        {
            var product = productRepository.FindProductById(getproductRequest.Id);
            var productDTO = messageMapper.MapToProductDto(product);
            return new GetProductResponse { Product = productDTO };
        }
        public UpdateProductResponse EditBrand(UpdateProductRequest updateProductRequest)
        {
            UpdateProductResponse updateProductResponse = null;


            var product = messageMapper.MapToProduct(updateProductRequest.Product);
            productRepository.EditProduct(product);
            var brandDto = messageMapper.MapToProductDto(product);

            updateProductResponse = new UpdateProductResponse
            {

            };

            return updateProductResponse;
        }
    }
}
