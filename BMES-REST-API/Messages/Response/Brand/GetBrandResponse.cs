using BMES_REST_API.Messages.DataTransferObjects.Product;

namespace BMES_REST_API.Messages.Response.Brand
{
    public class GetBrandResponse:ResponseBase
    {
        public BrandDto Brand { get; set; }
    }
}
