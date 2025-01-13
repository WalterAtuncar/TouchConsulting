using MediatR;
using Domain.Entities;
using Infrastructure.Persistence;
using Application.Request.Commands.Menu;

namespace Application.Handlers.Menu
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, int>
    {
        private readonly ISecurityDbContext _context;

        public CreateMenuCommandHandler(ISecurityDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = new Domain.Entities.Menu
            {
                Title = request.Title,
                Path = request.Path,
                Icon = request.Icon,
                ParentMenuId = request.ParentMenuId,
                IsGroup = request.IsGroup,
                IsDeleted = false,
                CreatedBy = request.CreatedBy,
                CreatedAt = DateTime.UtcNow
            };

            _context.Menus.Add(menu);
            await _context.SaveChangesAsync(cancellationToken);

            return menu.MenuId;
        }
    }
} 