using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands
{
    public class CreateMindListCommand : IRequest
    {
        public int UserId { get; set; }
        public int ItemId { get; set; }

    }
}
