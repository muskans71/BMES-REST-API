using BMES_REST_API.Messages.DataTransferObjects.Product;

namespace BMES_REST_API.Messages.Response.Brand
{
    public class GetBrandRequest:ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
