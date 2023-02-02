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
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void TDelete(AppRole t)
        {
            throw new NotImplementedException();
        }

        public AppRole TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AppRole> TGetList()
        {
            throw new NotImplementedException();
        }

        public int TGetLoggedUserRoleId(int UserId)
        {
            return _roleDal.GetLoggedUserRoleId(UserId);
        }

        public string TGetLoggedUserRoleTitle(int RoleId)
        {
            return _roleDal.GetLoggedUserRoleTitle(RoleId);
        }

        public void TInsert(AppRole t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(AppRole t)
        {
            throw new NotImplementedException();
        }
    }
}
