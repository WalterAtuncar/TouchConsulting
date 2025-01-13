using MediatR;
using Domain.DTOs;
using Domain.Interfaces;
using Application.Request.Commands.Auth;
using Application.Request.Queries.User;
using Application.Request.Queries.Menu;

namespace Application.Handlers.Auth
{
    public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginResponseDto>
    {
        private readonly IMediator _mediator;
        private readonly ICryptoService _cryptoService;
        private readonly ITokenService _tokenService;

        public LoginCommandHandler(
            IMediator mediator,
            ICryptoService cryptoService,
            ITokenService tokenService)
        {
            _mediator = mediator;
            _cryptoService = cryptoService;
            _tokenService = tokenService;
        }

        public async Task<LoginResponseDto> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
            var user = await _mediator.Send(
                new GetUserByCredentialsQuery(request.Credentials),
                cancellationToken);

            if (user == null)
            {
                return new LoginResponseDto { Success = false, Data = null };
            }

            var menus = await _mediator.Send(
                new GetMenusByRoleQuery(user.RoleId),
                cancellationToken);

            var token = _tokenService.GenerateToken(user);

            return new LoginResponseDto
            {
                Success = true,
                Data = new LoginDataDto
                {
                    User = user,
                    Menus = menus,
                    Token = token
                }
            };
        }
    }
} 