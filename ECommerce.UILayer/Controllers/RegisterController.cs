using AutoMapper.Internal;
using ECommerce.BusinessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UILayer.Controllers
{
	public class RegisterController : Controller
	{

        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;


        public RegisterController(UserManager<AppUser> userManager, RoleManager<AppRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult EMailConfirmedPage()
        {
            return View();
        }
      
        [HttpPost]
        public async Task<IActionResult> EMailConfirmedPage(AppUser appUser)
        {
            var user = await _userManager.FindByEmailAsync(appUser.Email);
            if (user.EmailConfirmedControlCode == appUser.EmailConfirmedControlCode)
            {
                user.EmailConfirmed = true;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn", "Login");
                }
               
            }
            return View();
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }
        public string GetCode(int size, bool characterStatus)
        {
            Random rnd = new Random();
            string harfler = "";
            int sayi, min = 65;
            char harf;

            if (characterStatus)
            {
                min = 97;
            }

            for (int i = 0;i < size;i++)
            {
                sayi = rnd.Next(min, min + 25); //sayi değişkenine rastgele bir sayı atar.
                harf = Convert.ToChar(sayi);//rastgele bir harf üretir
                harfler += harf;
            }
            return harfler;

        }
        public string GenerateEMailConfirmCode()
        {
            Random rnd = new Random();

            string numbers = rnd.Next(100, 999).ToString();

            StringBuilder builder = new StringBuilder();
            builder.Append(GetCode(3, true));
            builder.Append(numbers);
            builder.Append(GetCode(2, false));
            return builder.ToString();

        }
        public void SendEmail(AppUser appUser,string code)
        {

            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailBoxAddressFrom = new MailboxAddress("Admin", "mysoftwareproject40@gmail.com");//mailin kimden gittiğini gösterir. 1.parametre mail kim tarafından gönderildi. 2.parametre
            //gönderilen mail adresi yani şifrsini aktif hale getirdiğimiz mail adresi
            mimeMessage.From.Add(mailBoxAddressFrom);//mailin kimden gönderileceği
            //bilgisini ekledik

            MailboxAddress mailboxAddressTo = new MailboxAddress("User", appUser.Email);//mailin kime gönderileceği
            //bilgisi
            mimeMessage.To.Add(mailboxAddressTo);//mesajın kime gönderileceği bilgisini ekledik

            //mesajın içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = "Merhaba " + appUser.Name + " " + appUser.Surname + ",\n" + appUser.Email + " mail adresinizle oluşturulan hesabınız için mail doğrulamaması yapmanız gerekmektedir. \n Mail doğrulaması için" +
                "aşağıdaki doğrulama kodunu kayıt sayfasında karşınıza çıkan ekranda giriniz.\n Doğrulama Kodunuz : " + code;//mailin konusu 
            mimeMessage.Body = bodyBuilder.ToMessageBody();//mailin içeriği
            mimeMessage.Subject = "Mail Doğrulama İşlemi";
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587, false);
            client.Authenticate("mysoftwareproject50@gmail.com", "amquynplcohcrqro");
            //2.parametreye gmail hesabı izinden aldığımız key değerini veriyoruz
            client.Send(mimeMessage);//mimeMessage'ı gönder
            client.Disconnect(true);



            
        }
        [HttpPost]
        public async Task<IActionResult> SignUp(AppUser appUser)
        {
            var result = await _userManager.CreateAsync(appUser, appUser.PasswordHash);//bu metod yeni bir kullanıcı değeri oluşturacak. Bir kullanıcı ve şifre istiyor
            //await burada beklemeden çalışmasını sağlar.
          
            bool check = result.Succeeded;
            if (result.Succeeded)
            {
                ViewBag.registerIsSucceeded = true;
                ViewBag.email = appUser.Email;
            
                string emailConfirmedCode = GenerateEMailConfirmCode();
                SendEmail(appUser, emailConfirmedCode);
                var user = await _userManager.FindByEmailAsync(appUser.Email);
                user.EmailConfirmedControlCode = emailConfirmedCode;
                var assignedRoleUser= _userManager.Users.FirstOrDefault(x => x.Email ==appUser.Email);
                await _userManager.AddToRoleAsync(assignedRoleUser, "Customer");
                await _userManager.UpdateAsync(user);


                return RedirectToAction("EMailConfirmedPage", "Register");



            }


            return View();
        }


     


    }
}
