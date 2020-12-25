
namespace BMES_REST_API.Models.Cart
{
    using BMES_REST_API.Models.Shared;
    using Product;
    public class CartItem : BaseObject
    {
        public long CardId { get; set; }
        public Cart Cart { get; set; }
        public long ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
