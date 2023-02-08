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
        public AppUser GetLoggedUserCompanyInformations(int id)
        {
            using (var context = new Context())
            {
                var userInformations = context.Users.Include(x=>x.CompanySeller).Where(x => x.Id==id).FirstOrDefault();
                return userInformations;
            }
        }

        public AppUser getLoggedUserID(string username)
        {
            using (var context = new Context())
            {
                var userInformations = context.Users.Where(x => x.UserName == username).FirstOrDefault();
                return userInformations;
            }
        }

      
    }
}
