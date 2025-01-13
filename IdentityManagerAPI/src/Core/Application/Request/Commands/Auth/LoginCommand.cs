using MediatR;
using Domain.DTOs;

namespace Application.Request.Commands.Auth
{
    public class LoginCommand : IRequest<LoginResponseDto>
    {
        public UserRequestDto Credentials { get; }

        public LoginCommand(UserRequestDto credentials)
        {
            Credentials = credentials;
        }
    }
} 