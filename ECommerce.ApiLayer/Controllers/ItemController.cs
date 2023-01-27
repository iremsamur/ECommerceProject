using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        //listeleme işlemi
        [HttpGet("{id}")]//metodun üstüne türünün ne olduğunu belirtiyorum
        //bu bir ekleme mi, silme mi ne ise yazıyorum.
        //listeleme için HttpGet verdim.
        public IActionResult GetSelectedItemDetail(int id)
        {
            var values = _itemService.TGetSelectedItemAllDetails(id);
            return Ok(values);

        }

    }
}
