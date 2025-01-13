using MediatR;
using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Application.Request.Commands.User;

namespace Application.Handlers.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly ISecurityDbContext _context;
        private readonly ICryptoService _cryptoService;

        public CreateUserCommandHandler(ISecurityDbContext context, ICryptoService cryptoService)
        {
            _context = context;
            _cryptoService = cryptoService;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var user = new Domain.Entities.User
            {
                Username = request.Username,
                PasswordHash = _cryptoService.Encrypt(request.Password),
                RoleId = request.RoleId,
                PersonId = request.PersonId,
                IsDeleted = false,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync(cancellationToken);

            return user.UserId;
        }
    }
} 