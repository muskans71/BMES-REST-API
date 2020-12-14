using BMES_REST_API.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;

namespace BMES_REST_API.Messages.Response.Product
{
    public class FetchProductResponse
    {
        public int ProductsPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
