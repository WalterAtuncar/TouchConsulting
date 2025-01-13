using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Menu;

namespace Application.Handlers.Menu
{
    public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public UpdateMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await _context.Menus
                .FirstOrDefaultAsync(x => x.MenuId == request.MenuId && !x.IsDeleted, cancellationToken);

            if (menu == null)
                return false;

            menu.Title = request.Title;
            menu.Path = request.Path;
            menu.Icon = request.Icon;
            menu.ParentMenuId = request.ParentMenuId;
            menu.IsGroup = request.IsGroup;
            menu.UpdatedBy = request.UpdatedBy;
            menu.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 