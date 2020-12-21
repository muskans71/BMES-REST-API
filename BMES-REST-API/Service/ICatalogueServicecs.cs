using BMES_REST_API.Messages.Request.Product;
using BMES_REST_API.Messages.Response.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service
{
     public interface ICatalogueService
    {
        public FetchProductResponse FetchProducts(FetchProductRequest fetchProductsRequest);
    }
}
