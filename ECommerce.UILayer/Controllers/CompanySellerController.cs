using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.CompanySellerDTOs;
using ECommerce.DTOLayer.ItemDTOs;
using ECommerce.DTOLayer.ItemOwnerDTOs;
using ECommerce.EntityLayer.Concrete;
using ECommerce.UILayer.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
    public class CompanySellerController : Controller
    {
        private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IBrandService _brandService;
        private readonly ISubCategoryService _subCategoryService;
        private readonly IItemService _itemService;
        private readonly IItemOwnerService _itemOwnerService;
        private readonly IItemDetailService _itemDetailService;
        private readonly IItemDetailOwnerService _itemDetailOwnerService;
        private readonly IMediator _mediator;
        private readonly IMessageNotificationService _messageNotificationService;

        public CompanySellerController(IUserService userService, IMapper mapper, IBrandService brandService, ISubCategoryService subCategoryService, IItemService itemService, IItemOwnerService itemOwnerService, IItemDetailService itemDetailService, IItemDetailOwnerService itemDetailOwnerService, IMediator mediator, IMessageNotificationService messageNotificationService)
        {
            _userService = userService;
            _mapper = mapper;
            _brandService = brandService;
            _subCategoryService = subCategoryService;
            _itemService = itemService;
            _itemOwnerService = itemOwnerService;
            _itemDetailService = itemDetailService;
            _itemDetailOwnerService = itemDetailOwnerService;
            _mediator = mediator;
            _messageNotificationService = messageNotificationService;
        }

        public IActionResult Index()
        {
            var username = User.Identity.Name;
            var loggedUserValues = _userService.TgetLoggedUserID(username);
            ViewBag.loggedUserPhoto = loggedUserValues.ImageUrl;
            ViewBag.loggedUserFullName = loggedUserValues.Name + " " + loggedUserValues.Surname;
            var companyInformations = _userService.TGetLoggedUserCompanyInformations(loggedUserValues.Id);
            var values = _mapper.Map<AppUserDTO>(companyInformations);
            var messages = _messageNotificationService.TGetMessageNotifications(loggedUserValues.Id);
            ViewBag.messageCount = _messageNotificationService.TGetMessageNotificationsCount(loggedUserValues.Id);
            return View(values);
        }
     
    }
}
