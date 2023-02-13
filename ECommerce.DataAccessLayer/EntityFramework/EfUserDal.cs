using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
	public class EfUserDal : GenericRepository<AppUser>, IUserDal
	{
        private readonly Context _context;

        public EfUserDal(Context context) : base(context)
        {
            _context = context;
        }
        public AppUser GetLoggedUserCompanyInformations(int id)
        {
            var userInformations = _context.Users.Include(x => x.CompanySeller).Where(x => x.Id == id).FirstOrDefault();
            return userInformations;
        }

        public AppUser getLoggedUserID(string username)
        {
            var userInformations = _context.Users.Where(x => x.UserName == username).FirstOrDefault();
            return userInformations;
        }

        public AppUser GetLoggedUserRoleInformations(int id)
        {
            var userInformations = _context.Users.Where(x => x.Id == id).FirstOrDefault();
            return userInformations;
        }
    }
}
