using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Person;

namespace Application.Handlers.Person
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, bool>
    {
        private readonly ISecurityDbContext _context;

        public DeletePersonCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var person = await _context.Person
                .FirstOrDefaultAsync(x => x.PersonId == request.PersonId, cancellationToken);

            if (person == null)
                return false;

            person.IsDeleted = true;
            person.UpdatedBy = request.DeletedBy;
            person.UpdatedAt = DateTime.UtcNow;

            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
} 