using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
	public interface IUserDal : IGenericDal<AppUser>
    {

        AppUser getLoggedUserID(string username);
        AppUser GetLoggedUserCompanyInformations(int id);

        AppUser GetLoggedUserRoleInformations(int id);

   
     

    }
}
