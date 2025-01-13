using MediatR;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Role;

namespace Application.Handlers.Role
{
    public class CreateRoleCommandHandler : IRequestHandler<CreateRoleCommand, int>
    {
        private readonly ISecurityDbContext _context;

        public CreateRoleCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = new Domain.Entities.Role
            {
                Name = request.Name,
                Description = request.Description,
                IsDeleted = false,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow
            };

            _context.Roles.Add(role);
            await _context.SaveChangesAsync(cancellationToken);

            return role.RoleId;
        }
    }
} 