using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Commands.Category;

namespace Application.Handlers.Category
{
    public class DeleteCategoryHandler : IRequestHandler<DeleteCategoryCommand, Domain.Entities.Category>
    {
        private readonly IProductDbContext _context;

        public DeleteCategoryHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Category> Handle(DeleteCategoryCommand request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories
                .FirstOrDefaultAsync(x => x.CategoryID == request.CategoryId && !x.IsDeleted, cancellationToken);

            if (category == null)
                return null;

            category.IsDeleted = true;
            category.UpdatedBy = request.UpdatedBy;
            category.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);

            return category;
        }
    }
} 