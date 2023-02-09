using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Concrete
{
	public class UserManager : IUserService
	{
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }
        public AppUser TgetLoggedUserID(string username)
		{
			return _userDal.getLoggedUserID(username);
			
		}

		public void TDelete(AppUser t)
		{
			throw new NotImplementedException();
		}

		public AppUser TGetByID(int id)
		{
			return _userDal.GetByID(id);
		}

		public List<AppUser> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TInsert(AppUser t)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(AppUser t)
		{
			throw new NotImplementedException();
		}

		public AppUser TGetLoggedUserCompanyInformations(int id)
		{
			return _userDal.GetLoggedUserCompanyInformations(id);
		}

		public AppUser TGetLoggedUserRoleInformations(int id)
		{
			return _userDal.GetLoggedUserRoleInformations(id);
		}
	}
}
