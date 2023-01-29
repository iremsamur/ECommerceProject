using ECommerce.BusinessLayer.Abstract;
using ECommerce.DataAccessLayer.Abstract;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace ECommerce.BusinessLayer.Concrete
{
    public class MindListManager : IMindListService
    {
        IMindListDal _mindListDal;
        private readonly IMediator _mediator;


        public MindListManager(IMindListDal mindListDal, IMediator mediator)
        {
            _mindListDal = mindListDal;
            _mediator = mediator;
        }

        public List<MindList> TGetMyMindList(int id)
        {
            return _mindListDal.GetMyMindList(id);
        }

        public void TDelete(MindList t)
        {
            _mindListDal.Delete(t);
        }

        public MindList TGetByID(int id)
        {
            return _mindListDal.GetByID(id);
        }

        public List<MindList> TGetList()
        {
            return _mindListDal.GetList();
        }

        public void TInsert(MindList t)
        {
            _mindListDal.Insert(t);
        }

        public void TUpdate(MindList t)
        {
            _mindListDal.Update(t);
        }

        public async Task<Unit> GetMyMindListWithAppUserAndItem(CreateMindListCommand mindListCommand)
        {
            return await _mediator.Send(mindListCommand);
        }
    }
}
