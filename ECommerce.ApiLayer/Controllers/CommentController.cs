using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.ApiLayer.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CommentController : ControllerBase
	{
        private readonly ICommentService _commentService;

		public CommentController(ICommentService commentService)
		{
			_commentService = commentService;
		}
        [HttpGet("{id}")]//metodun üstüne türünün ne olduğunu belirtiyorum
        //bu bir ekleme mi, silme mi ne ise yazıyorum.
        //listeleme için HttpGet verdim.
        public IActionResult GetSelectedItemDetail(int id)
        {
            var values = _commentService.TGetItemWithCommentByID(id);
            return Ok(values);

        }

    }

}
