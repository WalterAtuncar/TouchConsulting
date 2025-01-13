using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Queries.Product;
using Application.Common.Models.Pagination;

namespace Application.Handlers.Product
{
    public class GetProductsHandler : IRequestHandler<GetProductsQuery, PaginatedResponse<Domain.Entities.Product>>
    {
        private readonly IProductDbContext _context;

        public GetProductsHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Products
                .Include(p => p.Category)
                .Where(x => !x.IsDeleted)
                .AsNoTracking();
            var totalRecords = await query.CountAsync(cancellationToken);
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.Product>(
                 items,
                request.Page,
                request.PageSize,
                totalRecords);
        }
    }
} 