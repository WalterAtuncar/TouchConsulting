using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Menu;

namespace Application.Handlers.Menu
{
    public class DeleteMenuCommandHandler : IRequestHandler<DeleteMenuCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public DeleteMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await _context.Menus
                .FirstOrDefaultAsync(x => x.MenuId == request.MenuId && !x.IsDeleted, cancellationToken);

            if (menu == null)
                return false;

            menu.IsDeleted = true;
            menu.UpdatedBy = request.DeletedBy;
            menu.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 