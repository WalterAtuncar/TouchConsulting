using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.Person;
using Application.Common.Models.Pagination;

namespace Application.Handlers.Person
{
    public class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, PaginatedResponse<Domain.Entities.Person>>
    {
        private readonly ISecurityDbContext _context;

        public GetPersonsQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.Person>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Person.AsNoTracking();
            
            var totalRecords = await query.CountAsync(cancellationToken);
            
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.Person>(
                items, 
                request.Page, 
                request.PageSize, 
                totalRecords);
        }
    }
} 