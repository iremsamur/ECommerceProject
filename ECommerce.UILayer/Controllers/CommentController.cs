using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.EntityLayer.Concrete.Enum;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using ECommerce.DTOLayer.CommentDTOs;
using System;

namespace ECommerce.UILayer.Controllers
{
	public class CommentController : Controller
	{
		private readonly ICommentService _commentService;
        private readonly IUserService _userService;

        public CommentController(ICommentService commentService, IUserService userService)
        {
            _commentService = commentService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetCommentListByItemID(int id)
        {

            //bana güncellenecek kullanıcı verilerini getirir.
            var httpClient = new HttpClient();
            var responseMessage = await httpClient.GetAsync("https://localhost:44362/api/Comment/GetSelectedItemDetail/" + id);//id değerine göre veriyi alıyor
            CommentListByItemIdDTO commentListDTO = new CommentListByItemIdDTO();
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonItem = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<Comment>(jsonItem);
                //ilişkili tablodan gelen verilerileride dto'ya da gösterebilmek için bu böyle eklendi

                commentListDTO.CommentContent = values.CommentContent;
                commentListDTO.CommentDate = values.CommentDate;
                commentListDTO.Name = values.AppUser.Name;
                commentListDTO.Surname = values.AppUser.Surname;
                commentListDTO.ImageUrl = values.AppUser.ImageUrl;
                commentListDTO.Email = values.AppUser.Email;


           

                return View(commentListDTO);


            }
            else
            {
                return RedirectToAction("GetAllItemAds", "ItemAds");
            }
        }
       
        //Yorum ekleme
        [HttpGet]
        public PartialViewResult AddComment()
        {
      

            return PartialView();
        }
        [HttpPost]
        public IActionResult AddComment(AddCommentDTO commentDto)
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            _commentService.TInsert(new Comment()
            {
                AppUserID = loggedUserValues.Id,
                CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString()),
                CommentContent = commentDto.CommentContent,
                CommentState = true,
                ItemID=commentDto.ItemID


             

            }) ;


            return RedirectToAction("GetAllItemAds", "ItemAds");
        }
    }
}
