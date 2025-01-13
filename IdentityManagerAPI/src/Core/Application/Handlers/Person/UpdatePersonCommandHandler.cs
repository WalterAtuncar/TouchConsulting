using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Person;

namespace Application.Handlers.Person
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public UpdatePersonCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = await _context.Person
                .FirstOrDefaultAsync(x => x.PersonId == request.PersonId, cancellationToken);

            if (person == null)
                return false;

            person.Names = request.Names;
            person.FirstName = request.FirstName;
            person.LastName = request.LastName;
            person.Img = request.Img;
            person.Email = request.Email;
            person.UpdatedBy = request.UpdatedBy;
            person.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 