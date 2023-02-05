using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace ECommerce.ApiLayer.Controllers
{
    //[Route("api/[controller]/[action]")]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemOwnerController : ControllerBase
    {
        private readonly IItemOwnerService _itemOwnerService;

        public ItemOwnerController(IItemOwnerService itemOwnerService)
        {
            _itemOwnerService = itemOwnerService;
        }

      
        [HttpPost]
        [Route("AddItemOwner")]
        public IActionResult AddItemOwner(ItemOwner itemOwner)
        {

            _itemOwnerService.TInsert(itemOwner);
            return Ok();
        }

        [HttpGet("{UserId}")]
        public async Task<IActionResult> GetMyOpenItemAdsByUser(int UserId)
        {
            var values = await _itemOwnerService.GetMyOpenItemAds(UserId);
            
            return Ok(values);

        }


    }
}
