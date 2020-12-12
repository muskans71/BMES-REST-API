using BMES_REST_API.Messages.DataTransferObjects.Product;

namespace BMES_REST_API.Messages.Request.Categoy
{
    public class UpdateCategoryRequest
    {
        public int Id { get; set; }
        public CategoryDto Category { get; set; }
    }
}
