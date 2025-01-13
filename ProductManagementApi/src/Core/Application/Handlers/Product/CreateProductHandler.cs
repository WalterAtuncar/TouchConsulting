using MediatR;
using Domain.Interfaces;
using Application.Request.Commands.Product;

namespace Application.Handlers.Product
{
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, Domain.Entities.Product>
    {
        private readonly IProductDbContext _context;

        public CreateProductHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var product = new Domain.Entities.Product
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Stock = request.Stock,
                CategoryID = request.CategoryId,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = request.CreatedBy,
                IsDeleted = false
            };

            await _context.Products.AddAsync(product, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return product;
        }
    }
} 