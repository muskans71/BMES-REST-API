using BMES_REST_API.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Request.Brand
{
    public class UpdateBrandsRequest
    {
        public int Id { get; set; }
        public BrandDto Brand { get; set; }
    }
}
