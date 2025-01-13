using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Commands.Product;

namespace Application.Handlers.Product
{
    public class DeleteProductHandler : IRequestHandler<DeleteProductCommand, Domain.Entities.Product>
    {
        private readonly IProductDbContext _context;

        public DeleteProductHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Product> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.ProductID == request.ProductId && !x.IsDeleted, cancellationToken);

            if (product == null)
                return null;

            product.IsDeleted = true;
            product.UpdatedBy = request.UpdatedBy;
            product.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }
    }
} 