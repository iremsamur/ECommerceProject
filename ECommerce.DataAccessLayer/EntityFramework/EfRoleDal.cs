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
        private readonly Context _context;

        public EfRoleDal(Context context) : base(context)
        {
            _context = context;
        }
        public int GetLoggedUserRoleId(int UserId)
        {
            var loggedUserRoleId = _context.UserRoles.Where(x => x.UserId == UserId).Select(y => y.RoleId).FirstOrDefault();
            return loggedUserRoleId;
        }

        public string GetLoggedUserRoleTitle(int RoleId)
        {
            var loggedUserRoleTitle = _context.Roles.Where(x => x.Id == RoleId).Select(y => y.Name).FirstOrDefault();
            return loggedUserRoleTitle;
        }
    }
}
