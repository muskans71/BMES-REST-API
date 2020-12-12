using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Request.Brand
{
    public class FetchBrandsRequest
    {
        public int PageNumber { get; set; }
        public int BrandsPerPage { get; set; }
    }
}
