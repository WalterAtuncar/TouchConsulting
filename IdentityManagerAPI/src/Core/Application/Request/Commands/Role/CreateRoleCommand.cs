using MediatR;
using System;

namespace Application.Request.Commands.Role
{
    public class CreateRoleCommand : IRequest<int>
    {
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
} 