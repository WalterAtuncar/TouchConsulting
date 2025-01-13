using MediatR;

namespace Application.Request.Commands.Menu
{
    public class DeleteMenuCommand : IRequest<bool>
    {
        public int MenuId { get; set; }
        public string? DeletedBy { get; set; } 

        public DeleteMenuCommand(int menuId, string deletedBy)
        {
            MenuId = menuId;
            DeletedBy = deletedBy;
        }
    }
} 