using MediatR;
using Microsoft.EntityFrameworkCore;
using Domain.DTOs;
using Infrastructure.Persistence;
using Application.Request.Queries.Menu;

namespace Application.Handlers.Menu
{
    public class GetMenusByRoleQueryHandler : IRequestHandler<GetMenusByRoleQuery, List<MenuResponseDto>>
    {
        private readonly ISecurityDbContext _context;

        public GetMenusByRoleQueryHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<List<MenuResponseDto>> Handle(GetMenusByRoleQuery request, CancellationToken cancellationToken)
        {
            var menus = await _context.Menus
                .Join(_context.RoleMenus,
                    m => m.MenuId,
                    rm => rm.MenuId,
                    (m, rm) => new { Menu = m, RoleMenu = rm })
                .Where(x => x.RoleMenu.RoleId == request.RoleId 
                       && !x.Menu.IsDeleted)
                .Select(x => new MenuItemDto
                {
                    MenuId = x.Menu.MenuId,
                    Title = x.Menu.Title,
                    Path = x.Menu.Path,
                    Icon = x.Menu.Icon,
                    ParentMenuId = x.Menu.ParentMenuId,
                    IsGroup = x.Menu.IsGroup
                })
                .ToListAsync(cancellationToken);

            var mainMenus = menus.Where(m => m.ParentMenuId == null).ToList();

            var response = new List<MenuResponseDto>();

            foreach (var mainMenu in mainMenus)
            {
                var menuResponse = new MenuResponseDto
                {
                    Menu = mainMenu,
                    SubMenus = menus
                        .Where(m => m.ParentMenuId == mainMenu.MenuId)
                        .ToList()
                };

                response.Add(menuResponse);
            }

            return response;
        }
    }
} 