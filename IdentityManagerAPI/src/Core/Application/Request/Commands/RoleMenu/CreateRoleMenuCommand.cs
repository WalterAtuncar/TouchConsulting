using MediatR;

namespace Application.Request.Commands.RoleMenu
{
    public class CreateRoleMenuCommand : IRequest<int>
    {
        public int RoleId { get; set; }
        public int MenuId { get; set; }
        public string? CreatedBy { get; set; }
    }
} 