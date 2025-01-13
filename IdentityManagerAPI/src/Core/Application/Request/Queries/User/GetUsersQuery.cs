using MediatR;
using Domain.Entities;
using Application.Common.Models.Pagination;

namespace Application.Request.Queries.User
{
    public class GetUsersQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.User>>
    {
        public int? RoleId { get; set; }
        public int? PersonId { get; set; }
        public string? Username { get; set; }
    }
} 