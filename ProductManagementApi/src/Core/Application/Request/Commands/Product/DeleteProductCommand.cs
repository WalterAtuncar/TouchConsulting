using MediatR;

namespace Application.Request.Commands.Product
{
    public class DeleteProductCommand : IRequest<Domain.Entities.Product>
    {
        public int ProductId { get; set; }
        public string? UpdatedBy { get; set; }
    }
} 