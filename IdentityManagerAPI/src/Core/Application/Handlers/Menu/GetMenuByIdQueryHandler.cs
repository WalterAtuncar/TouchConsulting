using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.Menu;

namespace Application.Handlers.Menu
{
    public class GetMenuByIdQueryHandler : IRequestHandler<GetMenuByIdQuery, Domain.Entities.Menu>
    {
        private readonly ISecurityDbContext _context;

        public GetMenuByIdQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Menu> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Menus
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.MenuId == request.MenuId && !x.IsDeleted, cancellationToken);
        }
    }
} 