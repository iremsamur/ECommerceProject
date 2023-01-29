using ECommerce.DataAccessLayer.Concrete;
using ECommerce.DataAccessLayer.CQRS.Commands.MindListCommands;
using ECommerce.EntityLayer.Concrete;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ECommerce.DataAccessLayer.CQRS.Handlers.MindListHandlers
{
    public class CreateMindListCommandHandler : IRequestHandler<CreateMindListCommand>
    {
        private readonly Context _context;

        public CreateMindListCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateMindListCommand request, CancellationToken cancellationToken)
        {
            _context.MindLists.Add(new MindList
            {
                UserId = request.UserId,
                ItemId = request.ItemId,
               
            });
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
