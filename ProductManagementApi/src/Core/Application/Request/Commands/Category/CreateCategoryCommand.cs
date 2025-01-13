using MediatR;

namespace Application.Request.Commands.Category
{
    public class CreateCategoryCommand : IRequest<Domain.Entities.Category>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string? CreatedBy { get; set; }
    }
} 