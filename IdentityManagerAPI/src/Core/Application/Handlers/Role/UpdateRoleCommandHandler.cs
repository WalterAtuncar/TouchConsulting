using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Role;

namespace Application.Handlers.Role
{
    public class UpdateRoleCommandHandler : IRequestHandler<UpdateRoleCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public UpdateRoleCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdateRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles
                .FirstOrDefaultAsync(x => x.RoleId == request.RoleId, cancellationToken);

            if (role == null)
                return false;

            role.Name = request.Name;
            role.Description = request.Description;
            role.UpdatedBy = request.UpdatedBy;
            role.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 