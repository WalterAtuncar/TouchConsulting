using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs;
using Domain.Interfaces;
using Infrastructure.Persistence;
using Application.Request.Queries.User;

namespace Application.Handlers.User
{
    public class GetUserByCredentialsQueryHandler : IRequestHandler<GetUserByCredentialsQuery, UserDto>
    {
        private readonly ISecurityDbContext _context;
        private readonly ICryptoService _cryptoService;

        public GetUserByCredentialsQueryHandler(ISecurityDbContext context, ICryptoService cryptoService)
        {
            _context = context;
            _cryptoService = cryptoService;
        }

        public async Task<UserDto> Handle(GetUserByCredentialsQuery request, CancellationToken cancellationToken)
        {
            var encryptedPassword = _cryptoService.Encrypt(request.Credentials.Password);

            return await _context.Users
                .Include(u => u.Person)
                .Where(u => u.Username == request.Credentials.Username 
                       && u.PasswordHash == encryptedPassword 
                       && !u.IsDeleted)
                .Select(u => new UserDto
                {
                    Id = u.UserId,
                    Username = u.Username,
                    FirstName = u.Person.FirstName,
                    LastName = u.Person.LastName,
                    Img = u.Person.Img,
                    RoleId = u.RoleId,
                    IsDeleted = u.IsDeleted,
                    PersonId = u.PersonId
                })
                .FirstOrDefaultAsync(cancellationToken);
        }
    }
} 