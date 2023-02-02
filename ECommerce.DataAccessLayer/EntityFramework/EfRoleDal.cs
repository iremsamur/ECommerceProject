using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
    public class EfRoleDal : GenericRepository<AppRole>, IRoleDal
    {
        public int GetLoggedUserRoleId(int UserId)
        {
            using (var context = new Context())
            {
                var loggedUserRoleId = context.UserRoles.Where(x=>x.UserId==UserId).Select(y => y.RoleId).FirstOrDefault();
                return loggedUserRoleId;
            }
        }

        public string GetLoggedUserRoleTitle(int RoleId)
        {
            using (var context = new Context())
            {
                var loggedUserRoleTitle = context.Roles.Where(x => x.Id == RoleId).Select(y => y.Name).FirstOrDefault();
                return loggedUserRoleTitle;
            }
        }
    }
}
