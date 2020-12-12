using BMES_REST_API.Messages.DataTransferObjects.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Request
{
    public class CreateBrandRequest
    {
        public BrandDto Brand { get; set; }
    }
}
