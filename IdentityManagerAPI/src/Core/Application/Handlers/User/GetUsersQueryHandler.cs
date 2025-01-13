using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Queries.User;
using Application.Common.Models.Pagination;

namespace Application.Handlers.User
{
    public class GetUsersQueryHandler : IRequestHandler<GetUsersQuery, PaginatedResponse<Domain.Entities.User>>
    {
        private readonly ISecurityDbContext _context;

        public GetUsersQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedResponse<Domain.Entities.User>> Handle(GetUsersQuery request, CancellationToken cancellationToken)
        {
            var query = _context.Users
                .Include(x => x.Role)
                .Include(x => x.Person)
                .AsNoTracking()
                .Where(x => !x.IsDeleted);

            if (request.RoleId.HasValue)
                query = query.Where(x => x.RoleId == request.RoleId.Value);

            if (request.PersonId.HasValue)
                query = query.Where(x => x.PersonId == request.PersonId.Value);

            if (!string.IsNullOrEmpty(request.Username))
                query = query.Where(x => x.Username.Contains(request.Username));
            
            var totalRecords = await query.CountAsync(cancellationToken);
            
            var items = await query
                .Skip((request.Page - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            return new PaginatedResponse<Domain.Entities.User>(
                items, 
                request.Page, 
                request.PageSize, 
                totalRecords);
        }
    }
} 