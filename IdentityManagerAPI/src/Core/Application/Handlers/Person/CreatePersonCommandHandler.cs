using MediatR;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Person;

namespace Application.Handlers.Person
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
    {
        private readonly ISecurityDbContext _context;

        public CreatePersonCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = new Domain.Entities.Person
            {
                Names = request.Names,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Img = request.Img,
                Email = request.Email,
                IsDeleted = false,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow
            };

            _context.Person.Add(person);
            await _context.SaveChangesAsync(cancellationToken);

            return person.PersonId;
        }
    }
} 