using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Request
{
    public class FetchOrderResponse
    {
        public int PageNumber { get; set; }
        public int OrdersPerPage { get; set; }
    }
}
