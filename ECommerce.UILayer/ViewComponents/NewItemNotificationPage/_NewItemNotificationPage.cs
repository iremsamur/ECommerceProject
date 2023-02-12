using AutoMapper;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.DTOLayer.NewItemNotificationDTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ECommerce.UILayer.ViewComponents.NewItemNotificationPage
{
    public class _NewItemNotificationPage : ViewComponent
    {
        private readonly INewItemNotificationService _newItemNotificationService;
        private readonly IMapper _mapper;

        public _NewItemNotificationPage(INewItemNotificationService newItemNotificationService, IMapper mapper)
        {
            _newItemNotificationService = newItemNotificationService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.notificationCount = _newItemNotificationService.TGetNewItemNotification().Count;
            var values = _newItemNotificationService.TGetNewItemNotification();
            var mappingValues = _mapper.Map<List<NewItemNotificationDTO>>(values);
            return View(mappingValues);
        }
    }
}
