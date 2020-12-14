using BMES_REST_API.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Product
{
    public class GetProductResponse
    {
        public ProductDto Product { get; set; }
    }
}
