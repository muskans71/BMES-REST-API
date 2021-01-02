using BMES_REST_API.Messages.DataTransferObjects.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Order
{
    public class FetchOrderResponse
    {
        public int OrdersPerPage { get; set; }
        public bool HasPreviousPages { get; set; }
        public bool HasNextPages { get; set; }
        public int CurrentPage { get; set; }
        public int[] Pages { get; set; }
        public IEnumerable<OrderDto> Orders { get; set; }
    }
}
