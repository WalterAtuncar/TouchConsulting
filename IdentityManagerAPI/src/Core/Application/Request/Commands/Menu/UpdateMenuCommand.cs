using MediatR;

namespace Application.Request.Commands.Menu
{
    public class UpdateMenuCommand : IRequest<bool>
    {
        public int MenuId { get; set; }
        public string Title { get; set; } = null!;
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentMenuId { get; set; }
        public bool IsGroup { get; set; }
        public string UpdatedBy { get; set; } = null!;
    }
} 