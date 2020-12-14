using BMES_REST_API.Messages;
using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Response.Brand;
using BMES_REST_API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service.Implementations
{
    public class BrandService:IbrandService
    {
        private IBrandRepository brandRepository;
        private MessageMapper messageMapper;

        public CreateBrandResponse SaveBrand(CreateBrandRequest createBrandRequest)
        {
            var brand = messageMapper.MapToBrand( createBrandRequest.Brand);
            brandRepository.SaveBrand(brand);
            var createbrandresponse=new CreateBrandResponse { Brand = messageMapper.MapToBrandDto(brand) };
            return createbrandresponse;

        }
    }
}
