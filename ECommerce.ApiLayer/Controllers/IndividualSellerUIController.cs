using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndividualSellerUIController : ControllerBase
    {
        private readonly IItemService _itemService;

        public IndividualSellerUIController(IItemService itemService)
        {
            _itemService = itemService;
        }

        [HttpPost]//ekleme işlemi için HttpPost attribute'u actionresult üzerinde kullanılır.
        public IActionResult CreateItemAds(Item item)
        {
            _itemService.TInsert(item);
            return Ok();
        }
    }
}
