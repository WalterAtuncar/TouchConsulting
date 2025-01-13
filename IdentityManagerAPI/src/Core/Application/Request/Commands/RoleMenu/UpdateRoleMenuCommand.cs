using MediatR;

namespace Application.Request.Commands.RoleMenu
{
    public class UpdateRoleMenuCommand : IRequest<bool>
    {
        public int RoleMenuId { get; set; }
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public string UpdatedBy { get; set; } = null!;
    }
} 