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


    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void TDelete(Brand t)
        {
            throw new NotImplementedException();
        }

        public Brand TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Brand> TGetList()
        {
            return _brandDal.GetList();
        }

        public void TInsert(Brand t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Brand t)
        {
            throw new NotImplementedException();
        }
    }
}
