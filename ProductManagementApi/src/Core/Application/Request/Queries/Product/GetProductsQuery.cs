using Application.Common.Models.Pagination;
using MediatR;

namespace Application.Request.Queries.Product
{
    public class GetProductsQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.Product>>
    {
    }
} 