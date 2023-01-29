using ECommerce.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.Abstract
{
    public interface IMindListDal : IGenericDal<MindList>
    {
        List<MindList> GetMyMindList(int id);

    }
}
