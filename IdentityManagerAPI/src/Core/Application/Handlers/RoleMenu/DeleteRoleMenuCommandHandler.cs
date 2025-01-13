using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.RoleMenu;

namespace Application.Handlers.RoleMenu
{
    public class DeleteRoleMenuCommandHandler : IRequestHandler<DeleteRoleMenuCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public DeleteRoleMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteRoleMenuCommand request, CancellationToken cancellationToken)
        {
            var roleMenu = await _context.RoleMenus
                .FirstOrDefaultAsync(x => x.RoleMenuId == request.RoleMenuId && !x.IsDeleted, cancellationToken);

            if (roleMenu == null)
                return false;

            roleMenu.IsDeleted = true;
            roleMenu.UpdatedBy = request.DeletedBy;
            roleMenu.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 