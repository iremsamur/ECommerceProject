﻿using ECommerce.DataAccessLayer.Concrete;
using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IItemDetailOwnerDal : IGenericDal<ItemDetailOwner>
    {
        List<ItemDetailOwner> GetItemDetailOwnerByLoggedUser(int userId);
        public void ChangeItemDetailOwnerStatusToActive(int id);

        public void ChangeItemDetailOwnerStatusToPassive(int id);
    }

}
