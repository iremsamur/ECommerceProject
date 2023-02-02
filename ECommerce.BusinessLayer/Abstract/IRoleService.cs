using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IRoleService : IGenericService<AppRole>
    {
        int TGetLoggedUserRoleId(int UserId);
        string TGetLoggedUserRoleTitle(int RoleId);
    }
}
