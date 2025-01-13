using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.User;

namespace Application.Handlers.User
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, Domain.Entities.User>
    {
        private readonly ISecurityDbContext _context;

        public GetUserByIdQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            var user = await _context.Users
                .Select(u => new Domain.Entities.User
                {
                    UserId = u.UserId,
                    Username = u.Username,
                    RoleId = u.RoleId,
                    PersonId = u.PersonId,
                    IsDeleted = u.IsDeleted,
                    CreatedBy = u.CreatedBy,
                    CreatedAt = u.CreatedAt,
                    UpdatedBy = u.UpdatedBy,
                    UpdatedAt = u.UpdatedAt,
                    Role = new Domain.Entities.Role
                    {
                        RoleId = u.Role.RoleId,
                        Name = u.Role.Name,
                        Description = u.Role.Description,
                        IsDeleted = u.Role.IsDeleted,
                        CreatedBy = u.Role.CreatedBy,
                        CreatedAt = u.Role.CreatedAt,
                        UpdatedBy = u.Role.UpdatedBy,
                        UpdatedAt = u.Role.UpdatedAt
                    },
                    Person = new Domain.Entities.Person
                    {
                        PersonId = u.Person.PersonId,
                        Names = u.Person.Names,
                        FirstName = u.Person.FirstName,
                        LastName = u.Person.LastName,
                        Img = u.Person.Img,
                        Email = u.Person.Email,
                        IsDeleted = u.Person.IsDeleted,
                        CreatedBy = u.Person.CreatedBy,
                        CreatedAt = u.Person.CreatedAt,
                        UpdatedBy = u.Person.UpdatedBy,
                        UpdatedAt = u.Person.UpdatedAt
                    }
                })
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.UserId == request.UserId && !x.IsDeleted, cancellationToken);

            return user;
        }
    }
} 