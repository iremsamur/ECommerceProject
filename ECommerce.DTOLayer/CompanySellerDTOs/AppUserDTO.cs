using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DTOLayer.CompanySellerDTOs
{
    public class AppUserDTO
    {
        public string Name
        {
            get; set;
        }

        public string Surname
        {
            get; set;
        }
        public string ImageUrl
        {
            get; set;
        }
        public string Gender
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string PhoneNumber
        {
            get; set;
        }

        public CompanySellerDTO CompanySeller { get; set; }
        public int? CompanySellerId { get; set; }
    }
}
