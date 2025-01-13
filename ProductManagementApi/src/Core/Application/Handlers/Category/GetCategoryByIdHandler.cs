using MediatR;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Application.Request.Queries.Category;

namespace Application.Handlers.Category
{
    public class GetCategoryByIdHandler : IRequestHandler<GetCategoryByIdQuery, Domain.Entities.Category>
    {
        private readonly IProductDbContext _context;

        public GetCategoryByIdHandler(IProductDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Category> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _context.Categories
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.CategoryID == request.CategoryId && !x.IsDeleted, cancellationToken);

            if (category == null)
                return null;

            return category;
        }
    }
} 