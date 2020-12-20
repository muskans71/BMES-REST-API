using BMES_REST_API.Messages;
using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Request.Brand;
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
            var brand = messageMapper.MapToBrand(createBrandRequest.Brand);
            brandRepository.SaveBrand(brand);
            var createbrandresponse = new CreateBrandResponse { Brand = messageMapper.MapToBrandDto(brand) };
            return createbrandresponse;

        }

        public DeleteBrandResponse DeleteBrand(DeleteBandRequest deleteBandRequest)
        {
            var brand = brandRepository.FindBrandById(deleteBandRequest.Id);
            brandRepository.Delete(brand);
            var deletebrandresponse = new DeleteBrandResponse { Brand = messageMapper.MapToBrandDto(brand) };
            return deletebrandresponse;
        }

        public FetchBrandResponse FetchBrand(FetchBrandsRequest fetchBrandsRequest)
        {
            var brands = brandRepository.GetAllcategories();
            var brandDtos = messageMapper.MapToBrandDtos(brands);

            return new FetchBrandResponse
            {
                Brands = brandDtos
            };
        }
        public GetBrandResponse GetBrand(GetBrandRequest getBrandRequest)
        {
            var brand = brandRepository.FindBrandById(getBrandRequest.Id);
            var brandDTO = messageMapper.MapToBrandDto(brand);
            return new GetBrandResponse { Brand = brandDTO };
        }
        public UpdateBrandResponse EditBrand (UpdateBrandsRequest updateBrandsRequest)
        {
            UpdateBrandResponse updateBrandResponse = null;

            
                var brand = messageMapper.MapToBrand(updateBrandsRequest.Brand);
                brandRepository.EditBrands(brand);
                var brandDto = messageMapper.MapToBrandDto(brand);

                updateBrandResponse = new UpdateBrandResponse
                {

                };
            
            return updateBrandResponse;
        }

    }
}
