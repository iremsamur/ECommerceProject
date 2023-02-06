using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.Repository;
using ECommerce.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.EntityFramework
{
	public class EfUserDal : GenericRepository<AppUser>, IUserDal
	{
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
