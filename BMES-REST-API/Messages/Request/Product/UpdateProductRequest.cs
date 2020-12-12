using BMES_REST_API.Messages.DataTransferObjects.Product;

namespace BMES_REST_API.Messages.Request.Product
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public ProductDto Product { get; set; }
    }
}
