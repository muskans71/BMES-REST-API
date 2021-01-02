using BMES_REST_API.Messages.DataTransferObjects.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Order
{
    public class GetOrderResponse
    {
        public OrderDto Order { get; set; }
    }
}
