using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Request.Queries.Role;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Common.Models.Pagination;

namespace Application.Handlers.Role
{
    public class GetRolesQueryHandler : IRequestHandler<GetRolesQuery, PaginatedResponse<Domain.Entities.Role>>
    {
        private readonly ISecurityDbContext _context;

        public GetRolesQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.Role>> Handle(GetRolesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Roles.AsNoTracking();
            
            var totalRecords = await query.CountAsync(cancellationToken);
            
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.Role>(
                items, 
                request.Page, 
                request.PageSize, 
                totalRecords);
        }
    }
} 