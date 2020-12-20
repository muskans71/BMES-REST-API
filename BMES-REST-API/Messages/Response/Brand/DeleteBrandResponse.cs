using BMES_REST_API.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Brand
{
    public class DeleteBrandResponse:ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
