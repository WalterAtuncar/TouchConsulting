using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.Menu;
using Application.Common.Models.Pagination;

namespace Application.Handlers.Menu
{
    public class GetMenusQueryHandler : IRequestHandler<GetMenusQuery, PaginatedResponse<Domain.Entities.Menu>>
    {
        private readonly ISecurityDbContext _context;

        public GetMenusQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.Menu>> Handle(GetMenusQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Menus
                .AsNoTracking()
                .Where(x => !x.IsDeleted);
            
            var totalRecords = await query.CountAsync(cancellationToken);
            
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.Menu>(
                items, 
                request.Page, 
                request.PageSize, 
                totalRecords);
        }
    }
} 