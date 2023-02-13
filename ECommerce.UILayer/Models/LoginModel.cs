using System.ComponentModel.DataAnnotations;

namespace ECommerce.UILayer.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz!")]
        public string UserName
        {
            get; set;
        }
       
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz!")]
        public string PasswordHash
        {
            get; set;
        }

    }
}
