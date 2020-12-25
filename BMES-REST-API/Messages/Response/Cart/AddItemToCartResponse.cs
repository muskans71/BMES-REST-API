namespace BMES_REST_API.Messages.Response.Cart
{
    using DataTransferObjects.Cart;
    public class AddItemToCartResponse : ResponseBase
    {
        public CartItemDto CartItem { get; set; }
    }
}
