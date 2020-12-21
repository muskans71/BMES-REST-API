using BMES_REST_API.Messages.Request;
using BMES_REST_API.Messages.Request.Brand;
using BMES_REST_API.Messages.Response.Brand;
using BMES_REST_API.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMES_REST_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IbrandService brandService;

        public BrandController(IbrandService ibrandService)
        {
            brandService = ibrandService;
        }

        [HttpGet(template:"id")]
        public ActionResult<GetBrandResponse>  GetBrand(long id)
        {
            var getBrandRequest = new GetBrandRequest();
            getBrandRequest.Id = id;
            return brandService.GetBrand(getBrandRequest);
        }

        [HttpGet]
        public ActionResult<FetchBrandResponse> GetBrands()
        {
            var fetchBrandRequest = new FetchBrandsRequest();
            return brandService.FetchBrand(fetchBrandRequest);
        }
        [HttpPost]
        public ActionResult<CreateBrandResponse> PostBrand(CreateBrandRequest createBrandRequest)
        {
            return brandService.SaveBrand(createBrandRequest);
        }

        [HttpPut]
        public ActionResult<UpdateBrandResponse> PutBrand(UpdateBrandsRequest updateBrandsRequest)
        {
            return brandService.EditBrand(updateBrandsRequest);
        }

        [HttpDelete(template:"id")]
        public ActionResult<DeleteBrandResponse> DeleteBrand(long id)
        {
            DeleteBandRequest deleteBandRequest = new DeleteBandRequest();
            deleteBandRequest.Id = id;
            return brandService.DeleteBrand(deleteBandRequest);
        }
    }
}
