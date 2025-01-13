using MediatR;

namespace Application.Request.Commands.Product
{
    public class UpdateProductCommand : IRequest<Domain.Entities.Product>
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public int CategoryId { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 