using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BusinessLayer.Abstract
{
    public interface IMindListService : IGenericService<MindList>
    {
        public List<MindList> TGetMyMindList(int id);
        public Task<Unit> GetMyMindListWithAppUserAndItem(CreateMindListCommand mindListCommand);

        public List<MindList> TGetMyMindListWithAppUserAndItem(int userId, int itemId);

        public List<MindList> GetMyMindListByUser(int userId);
    }
}
