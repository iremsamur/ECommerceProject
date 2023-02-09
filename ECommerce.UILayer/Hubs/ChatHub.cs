using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IUserService _userService;
        private readonly IItemOwnerService _itemOwnerService;
        private readonly IMessageNotificationService _messageNotificationService;

        public ChatHub(IUserService userService, IItemOwnerService itemOwnerService, IMessageNotificationService messageNotificationService)
        {
            _userService = userService;
            _itemOwnerService = itemOwnerService;
            _messageNotificationService = messageNotificationService;
        }

        public void addMessageNotification(int receiverId,int senderId,string message,string item,string sendDate)
        {
            MessageNotification messageNotification = new MessageNotification();
            messageNotification.SenderID = senderId;
            messageNotification.ReceiverID = receiverId;
            messageNotification.Subject = message;
            messageNotification.status = true;
            messageNotification.MessageStatus = true;
            messageNotification.MessageDate= DateTime.Parse(sendDate);
            messageNotification.CreatedDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            messageNotification.UpdatedDate= DateTime.Parse(DateTime.Now.ToShortDateString());
            messageNotification.MessageDetail = message;
            messageNotification.ItemAdId = Int32.Parse(item);
            _messageNotificationService.TInsert(messageNotification);
        }
        public async Task SendMessage(string user,string item, string message)
        {
           
            string id = user;
            var loggedUser = _userService.TGetByID(Int32.Parse(id));
            string userName = loggedUser.Name;
            string userSurname = loggedUser.Surname;
            string fullName = userName + " " + userSurname;
      
            user = fullName;
            string sendDate = DateTime.Now.ToString() ;
            int ownerUserId = _itemOwnerService.TGetOwnerByItemId(Int32.Parse(item));
            int senderUserId = loggedUser.Id;

            addMessageNotification(ownerUserId, senderUserId, message,item,sendDate);

            await Clients.All.SendAsync("ReceiveMessage", user,sendDate, message);
        }
    }
}
