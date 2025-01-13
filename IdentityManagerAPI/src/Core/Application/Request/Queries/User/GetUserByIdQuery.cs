using MediatR;
using Domain.Entities;

namespace Application.Request.Queries.User
{
    public class GetUserByIdQuery : IRequest<Domain.Entities.User>
    {
        public int UserId { get; set; }

        public GetUserByIdQuery(int userId)
        {
            UserId = userId;
        }
    }
} 