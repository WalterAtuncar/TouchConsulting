using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Menu
{
    public int MenuId { get; set; }

    public string Title { get; set; } = null!;

    public string? Path { get; set; }

    public string? Icon { get; set; }

    public int? ParentMenuId { get; set; }

    public bool IsGroup { get; set; }

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<RoleMenu> RoleMenus { get; set; } = new List<RoleMenu>();
}
