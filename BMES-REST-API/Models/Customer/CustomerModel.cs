namespace BmesRestApi.Models.Customer
{
    using System.Collections.Generic;
    using Shared;
    using Order;
    using BMES_REST_API.Models.Shared;
    using BMES_REST_API.Models.Address;

    public class Customer : BaseObject
    {
        public long PersonId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<Order> Orders { get; set; }
        public IEnumerable<Address> Addresses { get; set; }
    }
}