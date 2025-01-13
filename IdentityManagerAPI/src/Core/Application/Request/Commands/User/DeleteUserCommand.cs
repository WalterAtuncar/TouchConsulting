using MediatR;

namespace Application.Request.Commands.User
{
    public class DeleteUserCommand : IRequest<bool>
    {
        public int UserId { get; set; }
        public string? DeletedBy { get; set; }

        public DeleteUserCommand(int userId, string deletedBy)
        {
            UserId = userId;
            DeletedBy = deletedBy;
        }
    }
} 