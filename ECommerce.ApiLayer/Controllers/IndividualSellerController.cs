using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class IndividualSellerController : ControllerBase
    {
        private readonly IItemService _itemService;
        private readonly IItemDetailService _itemDetailService;

        public IndividualSellerController(IItemService itemService, IItemDetailService itemDetailService)
        {
            _itemService = itemService;
            _itemDetailService = itemDetailService;
        }

        [HttpPost]//ekleme işlemi için HttpPost attribute'u actionresult üzerinde kullanılır.
        public IActionResult CreateItemAds(Item item)
        {
            _itemService.TInsert(item);
            return Ok();
        }
        [HttpPost]//ekleme işlemi için HttpPost attribute'u actionresult üzerinde kullanılır.
        public IActionResult CreateItemDetailAds(ItemDetail itemDetail)
        {
            _itemDetailService.TInsert(itemDetail);
            return Ok();
        }
    
        [HttpGet("{id}")]
        public IActionResult ItemDetailGet(int id)
        {

            return Ok(_itemDetailService.TGetByID(id));
        }
    
        [HttpPut]
        public IActionResult ItemUpdateForItemDetail(Item item)
        {
            var updatedItem = _itemService.TGetByID(item.ItemID);
            if (updatedItem == null)
            {
                return NotFound();
            }
            else
            {
                updatedItem.ItemDetailID = item.ItemDetailID;
                _itemService.TUpdate(updatedItem);
                return Ok();
                
            }
         
        }
    }
}
