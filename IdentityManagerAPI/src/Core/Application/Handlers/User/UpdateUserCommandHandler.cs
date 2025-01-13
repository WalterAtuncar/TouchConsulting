using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Application.Request.Commands.User;

namespace Application.Handlers.User
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommand, bool>
    {
        private readonly ISecurityDbContext _context;
        private readonly ICryptoService _cryptoService;

        public UpdateUserCommandHandler(ISecurityDbContext context, ICryptoService cryptoService)
        {
            _context = context;
            _cryptoService = cryptoService;
        }

        public async Task<bool> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(x => x.UserId == request.UserId && !x.IsDeleted, cancellationToken);

            if (user == null)
                return false;

            user.Username = request.Username;
            if (!string.IsNullOrEmpty(request.Password))
                user.PasswordHash = _cryptoService.Encrypt(request.Password);
            user.RoleId = request.RoleId;
            user.UpdatedBy = request.UpdatedBy;
            user.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 