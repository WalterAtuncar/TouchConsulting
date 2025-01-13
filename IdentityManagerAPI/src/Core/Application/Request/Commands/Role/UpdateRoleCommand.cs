using MediatR;
using System;

namespace Application.Request.Commands.Role
{
    public class UpdateRoleCommand : IRequest<bool>
    {
        public int RoleId { get; set; }
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string UpdatedBy { get; set; } = null!;
    }
} 