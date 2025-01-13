using MediatR;

namespace Application.Request.Commands.Category
{
    public class DeleteCategoryCommand : IRequest<Domain.Entities.Category>
    {
        public int CategoryId { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 