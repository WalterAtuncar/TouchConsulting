using MediatR;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.RoleMenu;

namespace Application.Handlers.RoleMenu
{
    public class CreateRoleMenuCommandHandler : IRequestHandler<CreateRoleMenuCommand, int>
    {
        private readonly ISecurityDbContext _context;

        public CreateRoleMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRoleMenuCommand request, CancellationToken cancellationToken)
        {
            var roleMenu = new Domain.Entities.RoleMenu
            {
                RoleId = request.RoleId,
                MenuId = request.MenuId,
                IsDeleted = false,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow
            };

            _context.RoleMenus.Add(roleMenu);
            await _context.SaveChangesAsync(cancellationToken);

            return roleMenu.RoleMenuId;
        }
    }
} 