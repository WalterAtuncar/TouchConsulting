using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Queries.Product;

namespace Application.Handlers.Product
{
    public class GetProductByIdHandler : IRequestHandler<GetProductByIdQuery, Domain.Entities.Product>
    {
        private readonly IProductDbContext _context;

        public GetProductByIdHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Product> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Products
                .Include(p => p.Category)
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.ProductID == request.ProductId && !x.IsDeleted, cancellationToken);
        }
    }
} 