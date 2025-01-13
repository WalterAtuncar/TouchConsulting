using MediatR;
using Domain.Entities;
using Application.Common.Models.Pagination;

namespace Application.Request.Queries.Menu
{
    public class GetMenusQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.Menu>>
    {
    }
} 