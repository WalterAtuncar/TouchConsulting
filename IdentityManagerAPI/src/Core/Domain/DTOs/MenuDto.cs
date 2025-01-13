namespace Domain.DTOs
{
    public class MenuResponseDto 
    {
        public MenuItemDto Menu { get; set; } = null!;
        public List<MenuItemDto> SubMenus { get; set; } = new List<MenuItemDto>();
    }

    public class MenuItemDto 
    {
        public int MenuId { get; set; }
        public string Title { get; set; } = null!;
        public string? Path { get; set; }
        public string? Icon { get; set; }
        public int? ParentMenuId { get; set; }
        public bool IsGroup { get; set; }
    }
} 