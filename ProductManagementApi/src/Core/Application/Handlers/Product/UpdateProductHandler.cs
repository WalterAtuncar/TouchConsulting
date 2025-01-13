using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Commands.Product;

namespace Application.Handlers.Product
{
    public class UpdateProductHandler : IRequestHandler<UpdateProductCommand, Domain.Entities.Product>
    {
        private readonly IProductDbContext _context;

        public UpdateProductHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _context.Products
                .FirstOrDefaultAsync(x => x.ProductID == request.ProductId && !x.IsDeleted, cancellationToken);

            if (product == null)
                return null;

            product.Name = request.Name;
            product.Description = request.Description;
            product.Price = request.Price;
            product.Stock = request.Stock;
            product.CategoryID = request.CategoryId;
            product.UpdatedBy = request.UpdatedBy;
            product.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }
    }
} 