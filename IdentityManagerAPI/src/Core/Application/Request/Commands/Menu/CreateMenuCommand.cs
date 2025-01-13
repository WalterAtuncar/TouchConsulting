using MediatR;

namespace Application.Request.Commands.Menu
{
    public class CreateMenuCommand : IRequest<int>
    {
        public string Title { get; set; } = null!;
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentMenuId { get; set; }
        public bool IsGroup { get; set; }
        public string CreatedBy { get; set; } = null!;
    }
} 