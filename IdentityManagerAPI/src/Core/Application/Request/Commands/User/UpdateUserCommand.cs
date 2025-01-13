using MediatR;

namespace Application.Request.Commands.User
{
    public class UpdateUserCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public string Username { get; set; } = null!;
        public string? Password { get; set; }
        public int RoleId { get; set; }
        public int PersonId { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 