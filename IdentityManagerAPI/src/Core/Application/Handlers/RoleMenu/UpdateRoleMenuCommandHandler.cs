using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.RoleMenu;

namespace Application.Handlers.RoleMenu
{
    public class UpdateRoleMenuCommandHandler : IRequestHandler<UpdateRoleMenuCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public UpdateRoleMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateRoleMenuCommand request, CancellationToken cancellationToken)
        {
            var roleMenu = await _context.RoleMenus
                .FirstOrDefaultAsync(x => x.RoleMenuId == request.RoleMenuId && !x.IsDeleted, cancellationToken);

            if (roleMenu == null)
                return false;

            roleMenu.RoleId = request.RoleId;
            roleMenu.MenuId = request.MenuId;
            roleMenu.UpdatedBy = request.UpdatedBy;
            roleMenu.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 