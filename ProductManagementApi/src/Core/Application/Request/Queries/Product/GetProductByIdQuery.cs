using MediatR;

namespace Application.Request.Queries.Product
{
    public class GetProductByIdQuery : IRequest<Domain.Entities.Product>
    {
        public int ProductId { get; }

        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
} 