using BMES_REST_API.Messages;
using BMES_REST_API.Messages.Request.Product;
using BMES_REST_API.Messages.Response.Product;
using BMES_REST_API.Models.Product;
using BMES_REST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service.Implementations
{
    public class CatalogueService: ICatalogueService
    {
        private IProductRepository productRepository;
        private MessageMapper messageMapper;

        public CatalogueService(IProductRepository product)
        {
            productRepository = product;
            messageMapper = new MessageMapper();
        }
        public FetchProductResponse FetchProducts(FetchProductRequest fetchProductsRequest)
        {

            IEnumerable<Product> products = new List<Product>();

            int productCount = 0;

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                productCount = productRepository.GetAllProducts().Count();
                products = productRepository.GetAllProducts()
                   .Where(product => product.ProductStatus == ProductStatus.Active)
                   .Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                   .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category.Slug == fetchProductsRequest.CategorySlug &&
                                                                           product.Brand.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug != "all-categories" && fetchProductsRequest.BrandSlug == "all-brands")
            {
                var filteredProducts = productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Category.Slug == fetchProductsRequest.CategorySlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            if (fetchProductsRequest.CategorySlug == "all-categories" && fetchProductsRequest.BrandSlug != "all-brands")
            {
                var filteredProducts = productRepository.GetAllProducts()
                                                         .Where(product => product.ProductStatus == ProductStatus.Active &&
                                                                           product.Brand.Slug == fetchProductsRequest.BrandSlug);
                productCount = filteredProducts.Count();
                products = filteredProducts.Skip((fetchProductsRequest.PageNumber - 1) * fetchProductsRequest.ProductsPerPage)
                                           .Take(fetchProductsRequest.ProductsPerPage);
            }

            var totalPages = (int)Math.Ceiling((decimal)productCount / fetchProductsRequest.ProductsPerPage);

            int[] pages = Enumerable.Range(1, totalPages).ToArray();

            var productDtos = messageMapper.MapToProductDtos(products);

            var fetchProductsResponse = new FetchProductResponse()
            {
                ProductsPerPage = fetchProductsRequest.ProductsPerPage,
                Products = productDtos,
                HasPreviousPages = (fetchProductsRequest.PageNumber > 1),
                CurrentPage = fetchProductsRequest.PageNumber,
                HasNextPages = (fetchProductsRequest.PageNumber < totalPages),
                Pages = pages
            };

            return fetchProductsResponse;
        }
    }
}
