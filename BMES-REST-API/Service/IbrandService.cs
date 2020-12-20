using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Request.Brand;
using BMES_REST_API.Messages.Response.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Service
{
    interface IbrandService
    {
        public CreateBrandResponse SaveBrand(CreateBrandRequest createBrandRequest);

        public DeleteBrandResponse DeleteBrand(DeleteBandRequest deleteBandRequest);

        public FetchBrandResponse FetchBrand(FetchBrandsRequest fetchBrandsRequest);
       
        public GetBrandResponse GetBrand(GetBrandRequest getBrandRequest);
        
        public UpdateBrandResponse EditBrand(UpdateBrandsRequest updateBrandsRequest);
    }
}
