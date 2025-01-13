using MediatR;
using Domain.Entities;
using Application.Common.Models.Pagination;

namespace Application.Request.Queries.Role
{
    public class GetRolesQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.Role>>
    {
    }
} 