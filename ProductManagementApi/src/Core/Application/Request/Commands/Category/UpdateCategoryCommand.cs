using MediatR;

namespace Application.Request.Commands.Category
{
    public class UpdateCategoryCommand : IRequest<Domain.Entities.Category>
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 