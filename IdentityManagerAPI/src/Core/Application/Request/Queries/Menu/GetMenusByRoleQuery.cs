using MediatR;
using Domain.DTOs;

namespace Application.Request.Queries.Menu
{
    public class GetMenusByRoleQuery : IRequest<List<MenuResponseDto>>
    {
        public int RoleId { get; }

        public GetMenusByRoleQuery(int roleId)
        {
            RoleId = roleId;
        }
    }
} 