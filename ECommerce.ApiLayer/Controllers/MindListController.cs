using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]/")]
    [ApiController]
    public class MindListController : ControllerBase
    {
        private readonly IMindListService _mindListService;

        public MindListController(IMindListService mindListService)
        {
            _mindListService = mindListService;
        }

        [HttpGet]
        [Route("GetMindList/{userId}/{itemId}")]
        public IActionResult GetMindisListByUserAndItem([FromRoute] int userId, [FromRoute] int itemId)
        {

            var values = _mindListService.TGetMyMindListWithAppUserAndItem(userId,itemId);
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMindList(MindList mindList)
        {

            _mindListService.TInsert(mindList);
            return Ok();
        }
       
        [HttpGet]
        [Route("GetMyMindListByUserId/{userId}")]
        public IActionResult GetMyMindListByUserId([FromRoute] int userId)
        {
            var values = _mindListService.GetMyMindListByUser(userId);
            return Ok(values);

        }

    }
}
