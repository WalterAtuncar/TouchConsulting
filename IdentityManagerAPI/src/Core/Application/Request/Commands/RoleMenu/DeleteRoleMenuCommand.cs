using MediatR;

namespace Application.Request.Commands.RoleMenu
{
    public class DeleteRoleMenuCommand : IRequest<bool>
    {
        public int RoleMenuId { get; set; }
        public string? DeletedBy { get; set; }

        public DeleteRoleMenuCommand(int roleMenuId, string deletedBy)
        {
            RoleMenuId = roleMenuId;
            DeletedBy = deletedBy;
        }
    }
} 