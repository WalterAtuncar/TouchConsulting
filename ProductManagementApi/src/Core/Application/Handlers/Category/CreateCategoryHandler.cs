using MediatR;
using Domain.Interfaces;
using Application.Request.Commands.Category;

namespace Application.Handlers.Category
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategoryCommand, Domain.Entities.Category>
    {
        private readonly IProductDbContext _context;

        public CreateCategoryHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Category> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = new Domain.Entities.Category
            {
                Name = request.Name,
                Description = request.Description,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow,
                UpdatedBy = request.CreatedBy,
                IsDeleted = false
            };

            await _context.Categories.AddAsync(category, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return category;
        }
    }
} 