using MediatR;
using Microsoft.EntityFrameworkCore;
using Application.Request.Queries.Role;
using Domain.Entities;
using Infrastructure.Persistence;

namespace Application.Handlers.Role
{
    public class GetRoleByIdQueryHandler : IRequestHandler<GetRoleByIdQuery, Domain.Entities.Role>
    {
        private readonly ISecurityDbContext _context;

        public GetRoleByIdQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Role> Handle(GetRoleByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Roles
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.RoleId == request.RoleId, cancellationToken);
        }
    }
} 