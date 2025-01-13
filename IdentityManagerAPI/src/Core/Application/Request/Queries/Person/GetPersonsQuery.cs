using MediatR;
using Domain.Entities;
using Application.Common.Models.Pagination;

namespace Application.Request.Queries.Person
{
    public class GetPersonsQuery : PaginatorRequest, IRequest<PaginatedResponse<Domain.Entities.Person>>
    {
    }
} 