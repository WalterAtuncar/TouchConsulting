using MediatR;
using Domain.DTOs;

namespace Application.Request.Queries.User
{
    public class GetUserByCredentialsQuery : IRequest<UserDto>
    {
        public UserRequestDto Credentials { get; }

        public GetUserByCredentialsQuery(UserRequestDto credentials)
        {
            Credentials = credentials;
        }
    }
} 