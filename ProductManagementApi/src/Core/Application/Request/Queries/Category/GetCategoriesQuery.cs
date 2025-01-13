using Application.Common.Models.Pagination;
using MediatR;

namespace Application.Request.Queries.Category
{
    public class GetCategoriesQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.Category>>
    {
    }
} 