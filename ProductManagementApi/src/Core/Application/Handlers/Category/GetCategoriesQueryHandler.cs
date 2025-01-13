using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Common.Models.Pagination;
using Application.Request.Queries.Category;
using Domain.Entities;
using Domain.Interfaces;

namespace Application.Handlers.Category
{
    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, PaginatedResponse<Domain.Entities.Category>>
    {
        private readonly IProductDbContext _context;

        public GetCategoriesQueryHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.Category>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Categories
                .Where(x => !x.IsDeleted)
                .OrderBy(x => x.Name)
                .AsNoTracking();

            var totalRecords = await query.CountAsync(cancellationToken);
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.Category>(
                items,
                request.Page,
                request.PageSize,
                totalRecords);
        }
    }
} 