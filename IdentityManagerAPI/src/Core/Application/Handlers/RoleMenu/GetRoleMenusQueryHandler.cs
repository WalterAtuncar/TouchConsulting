using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.RoleMenu;
using Application.Common.Models.Pagination;

namespace Application.Handlers.RoleMenu
{
    public class GetRoleMenusQueryHandler : IRequestHandler<GetRoleMenusQuery, PaginatedResponse<Domain.Entities.RoleMenu>>
    {
        private readonly ISecurityDbContext _context;

        public GetRoleMenusQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.RoleMenu>> Handle(GetRoleMenusQuery request, CancellationToken cancellationToken)
        {
            var query = _context.RoleMenus
                .Include(x => x.Role)
                .Include(x => x.Menu)
                .AsNoTracking()
                .Where(x => !x.IsDeleted);

            if (request.RoleId.HasValue)
                query = query.Where(x => x.RoleId == request.RoleId.Value);

            if (request.MenuId.HasValue)
                query = query.Where(x => x.MenuId == request.MenuId.Value);
            
            var totalRecords = await query.CountAsync(cancellationToken);
            
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.RoleMenu>(
                items, 
                request.Page, 
                request.PageSize, 
                totalRecords);
        }
    }
} 