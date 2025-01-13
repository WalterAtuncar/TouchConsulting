using MediatR;
using Domain.Entities;

namespace Application.Request.Queries.RoleMenu
{
    public class GetRoleMenuByIdQuery : IRequest<Domain.Entities.RoleMenu>
    {
        public int RoleMenuId { get; set; }

        public GetRoleMenuByIdQuery(int roleMenuId)
        {
            RoleMenuId = roleMenuId;
        }
    }
} 