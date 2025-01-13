using MediatR;
using Domain.Entities;

namespace Application.Request.Queries.Person
{
    public class GetPersonByIdQuery : IRequest<Domain.Entities.Person>
    {
        public int PersonId { get; set; }

        public GetPersonByIdQuery(int personId)
        {
            PersonId = personId;
        }
    }
} 