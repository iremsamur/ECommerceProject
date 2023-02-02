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
    public class AdItemsManager : IAdItemsService
    {
        IAdItemsDal _adItems;

        public AdItemsManager(IAdItemsDal adItems)
        {
            _adItems = adItems;
        }

        public void TDelete(AdItems t)
        {
            throw new NotImplementedException();
        }

        public AdItems TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<AdItems> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TInsert(AdItems t)
        {
            _adItems.Insert(t);
        }

        public void TUpdate(AdItems t)
        {
            throw new NotImplementedException();
        }
    }
}
