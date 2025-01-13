using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Role;

namespace Application.Handlers.Role
{
    public class DeleteRoleCommandHandler : IRequestHandler<DeleteRoleCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public DeleteRoleCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeleteRoleCommand request, CancellationToken cancellationToken)
        {
            var role = await _context.Roles
                .FirstOrDefaultAsync(x => x.RoleId == request.RoleId, cancellationToken);

            if (role == null)
                return false;

            role.IsDeleted = true;
            role.UpdatedBy = request.DeletedBy;
            role.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 