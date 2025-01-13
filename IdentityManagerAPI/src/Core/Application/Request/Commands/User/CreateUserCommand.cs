using MediatR;

namespace Application.Request.Commands.User
{
    public class CreateUserCommand : IRequest<int>
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public int RoleId { get; set; }
        public int PersonId { get; set; }
        public string? CreatedBy { get; set; }
    }
} 