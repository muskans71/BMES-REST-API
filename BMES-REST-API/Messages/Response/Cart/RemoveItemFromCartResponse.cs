using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Cart
{
    using DataTransferObjects.Cart;
    public class RemoveItemFromCartResponse : ResponseBase
    {
        public long CartItemId { get; set; }
    }
}
