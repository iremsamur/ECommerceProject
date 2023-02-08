using DocumentFormat.OpenXml.Spreadsheet;
using ECommerce.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Hubs
{
    public class ChatHub : Hub
    {
        private readonly IUserService _userService;

        public ChatHub(IUserService userService)
        {
            _userService = userService;
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


            
            await Clients.All.SendAsync("ReceiveMessage", user,sendDate, message);
        }
    }
}
