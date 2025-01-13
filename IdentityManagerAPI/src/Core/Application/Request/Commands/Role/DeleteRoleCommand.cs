using MediatR;

namespace Application.Request.Commands.Role
{
    public class DeleteRoleCommand : IRequest<bool>
    {
        public int RoleId { get; set; }
        public string DeletedBy { get; set; } = null!;

        public DeleteRoleCommand(int roleId, string deletedBy)
        {
            RoleId = roleId;
            DeletedBy = deletedBy;
        }
    }
} 