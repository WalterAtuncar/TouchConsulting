using MediatR;
using Domain.Entities;

namespace Application.Request.Queries.Menu
{
    public class GetMenuByIdQuery : IRequest<Domain.Entities.Menu>
    {
        public int MenuId { get; set; }

        public GetMenuByIdQuery(int menuId)
        {
            MenuId = menuId;
        }
    }
} 