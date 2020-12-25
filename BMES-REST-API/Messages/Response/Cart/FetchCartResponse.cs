using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Messages.Response.Cart
{
    using DataTransferObjects.Cart;

    public class FetchCartResponse : ResponseBase
    {
        public CartDto Cart { get; set; }
    }
}
