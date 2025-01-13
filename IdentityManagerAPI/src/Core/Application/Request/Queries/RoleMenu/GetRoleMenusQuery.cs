using MediatR;
using Domain.Entities;
using Application.Common.Models.Pagination;

namespace Application.Request.Queries.RoleMenu
{
    public class GetRoleMenusQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.RoleMenu>>
    {
        public int? RoleId { get; set; }
        public int? MenuId { get; set; }
    }
} 