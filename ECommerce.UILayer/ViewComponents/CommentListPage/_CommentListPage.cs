using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.CommentDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.UILayer.ViewComponents.CommentListPage
{
	public class _CommentListPage : ViewComponent
    {
        private readonly ICommentService _commentService;
        private readonly IUserService _userService;

        public _CommentListPage(ICommentService commentService, IUserService userService)
        {
            _commentService = commentService;
            _userService = userService;
        }
        public IViewComponentResult Invoke(int id)
        {
           
           
            List<CommentListByItemIdDTO> commentListDTO = new List<CommentListByItemIdDTO>();
            CommentListByItemIdDTO commentDTO = new CommentListByItemIdDTO();
            var values = _commentService.TGetItemWithCommentByID(id);
            foreach (var comment in values)
            {
                commentDTO.CommentContent = comment.CommentContent;
                commentDTO.CommentDate = comment.CommentDate;
                commentDTO.Name = comment.AppUser.Name;
                commentDTO.Surname = comment.AppUser.Surname;
                commentDTO.ImageUrl = comment.AppUser.ImageUrl;
                commentDTO.Email = comment.AppUser.Email;
                commentListDTO.Add(commentDTO); 
            }

           
            return View(commentListDTO);
        }
    }
}
