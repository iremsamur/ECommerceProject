using System.ComponentModel.DataAnnotations;

namespace ECommerce.UILayer.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="İsim alanı boş bırakılamaz!")]
        public string Name
        {
            get; set;
        }
        [Required(ErrorMessage = "Soyisim alanı boş bırakılamaz!")]
        public string Surname
        {
            get; set;
        }
        [Required(ErrorMessage = "Kullanıcı adı alanı boş bırakılamaz!")]
        public string UserName
        {
            get; set;
        }
        [Required(ErrorMessage = "Mail Adresi alanı boş bırakılamaz!")]
        public string Email
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
