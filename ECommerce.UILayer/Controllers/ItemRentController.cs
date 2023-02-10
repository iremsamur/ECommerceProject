using ECommerce.BusinessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;

namespace ECommerce.UILayer.Controllers
{
	public class ItemRentController : Controller
	{
		private readonly IUserService _userService;
        private readonly IItemOwnerService _itemOwnerService;
        private readonly IItemService _itemService;


        public ItemRentController(IUserService userService, IItemOwnerService itemOwnerService, IItemService itemService)
        {
            _userService = userService;
            _itemOwnerService = itemOwnerService;
            _itemService = itemService;
        }
        [HttpGet]
        public IActionResult ChatWithItemOwnerForHiring(int id)
		{
			var username = User.Identity.Name;

            var loggedUserValues = _userService.TgetLoggedUserID(username);
         
            ViewBag.loggedUserImage = loggedUserValues.ImageUrl;
			ViewBag.loggedUserFullName = loggedUserValues.Name + " " + loggedUserValues.Surname;
            //ViewBag.SenderMessageUser = loggedUserValues.Name+" "+loggedUserValues.Surname;
            ViewBag.SenderMessageUser = loggedUserValues.Id;
			ViewBag.ItemId = id;
            if(loggedUserValues.CompanySellerId is null || loggedUserValues.IndividualSellerId is null)
            {
                SendEmailToCustomer(id, loggedUserValues.Id);

            }
          

            return View();
		}

        public void SendEmailToCustomer(int itemId,int customerId)
        {
            var ownerId = _itemOwnerService.TGetOwnerByItemId(itemId);
            var sellerInformations = _userService.TGetByID(ownerId);//satıcı bilgileri
            var customerInformations = _userService.TGetByID(customerId);//müşteri bilgileri
            var itemInformations = _itemService.TGetByID(itemId);
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailBoxAddressFrom = new MailboxAddress("KiralaVeyaSatınAl.com", "mysoftwareproject50@gmail.com");//mailin kimden gittiğini gösterir. 1.parametre mail kim tarafından gönderildi. 2.parametre
            //gönderilen mail adresi yani şifrsini aktif hale getirdiğimiz mail adresi
            mimeMessage.From.Add(mailBoxAddressFrom);//mailin kimden gönderileceği
            //bilgisini ekledik

            MailboxAddress mailboxAddressTo = new MailboxAddress("Değerli Müşterimiz", customerInformations.Email);//mailin kime gönderileceği
            //bilgisi
            mimeMessage.To.Add(mailboxAddressTo);//mesajın kime gönderileceği bilgisini ekledik

            //mesajın içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Merhaba " + customerInformations.Name + " " + customerInformations.Surname + "\n\n Kiralama talebinde bulunduğunuz "+itemInformations.ItemName+"" +
                "için iletişime geçeceğiniz ürün sahibi satıcı bilgilerini göndermek için bu mail size ulaştırılmıştır.\nBilgiler : \n\n Ad-Soyad : "+sellerInformations.Name+" "+sellerInformations.Surname+"\nMail Adresi : "+sellerInformations.Email+"\nTelefon Numarası : "+sellerInformations.PhoneNumber+"\nİyi alışverişler dileriz.";//mailin konusu 
            mimeMessage.Body = bodyBuilder.ToMessageBody();//mailin içeriği
            mimeMessage.Subject = "Satıcı İletişim Bilgileri";
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mysoftwareproject50@gmail.com", "amquynplcohcrqro");
            //2.parametreye gmail hesabı izinden aldığımız key değerini veriyoruz
            client.Send(mimeMessage);//mimeMessage'ı gönder
            client.Disconnect(true);

        }

        public IActionResult GetContactInformationItemOwner()
		{
			return View();
		}
        public IActionResult SendMessageToItemOwner()
        {
            return View();
        }
    }
}
