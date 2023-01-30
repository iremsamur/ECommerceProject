using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.DTOLayer.MindListDTOs;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MindListController : ControllerBase
    {
        private readonly IMindListService _mindListService;

        public MindListController(IMindListService mindListService)
        {
            _mindListService = mindListService;
        }
        [HttpPost]
        public IActionResult AddMindList(MindList mindList)
        {
            _mindListService.TInsert(mindList);
            return Ok();
        }
    }
}
