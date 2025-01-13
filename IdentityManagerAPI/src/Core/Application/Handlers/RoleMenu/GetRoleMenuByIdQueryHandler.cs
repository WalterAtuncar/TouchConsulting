using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.RoleMenu;

namespace Application.Handlers.RoleMenu
{
    public class GetRoleMenuByIdQueryHandler : IRequestHandler<GetRoleMenuByIdQuery, Domain.Entities.RoleMenu>
    {
        private readonly ISecurityDbContext _context;

        public GetRoleMenuByIdQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.RoleMenu> Handle(GetRoleMenuByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.RoleMenus
                .Include(x => x.Role)
                .Include(x => x.Menu)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.RoleMenuId == request.RoleMenuId && !x.IsDeleted, cancellationToken);
        }
    }
} 