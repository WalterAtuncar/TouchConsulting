using MediatR;
using Domain.Entities;
using Application.Common.Models;

namespace Application.Request.Queries.Role
{
    public class GetRoleByIdQuery : IRequest<Domain.Entities.Role>
    {
        public int RoleId { get; set; }

        public GetRoleByIdQuery(int roleId)
        {
            RoleId = roleId;
        }
    }
} 