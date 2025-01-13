using MediatR;

namespace Application.Request.Commands.Product
{
    public class CreateProductCommand : IRequest<Domain.Entities.Product>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? CreatedBy { get; set; }
    }
} 