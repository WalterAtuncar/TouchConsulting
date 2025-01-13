using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.Person;

namespace Application.Handlers.Person
{
    public class GetPersonByIdQueryHandler : IRequestHandler<GetPersonByIdQuery, Domain.Entities.Person>
    {
        private readonly ISecurityDbContext _context;

        public GetPersonByIdQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Person> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            return await _context.Person
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.PersonId == request.PersonId, cancellationToken);
        }
    }
} 