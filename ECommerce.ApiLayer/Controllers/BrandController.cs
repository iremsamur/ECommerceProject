using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        //listeleme işlemi
        [HttpGet]//metodun üstüne türünün ne olduğunu belirtiyorum
        //bu bir ekleme mi, silme mi ne ise yazıyorum.
        //listeleme için HttpGet verdim.
        public IActionResult GetSelectedItemDetail()
        {
            var values = _brandService.TGetList();
            return Ok(values);

        }
    }
}
