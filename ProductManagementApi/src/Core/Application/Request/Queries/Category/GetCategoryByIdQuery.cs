using MediatR;

namespace Application.Request.Queries.Category
{
    public class GetCategoryByIdQuery : IRequest<Domain.Entities.Category>
    {
        public int CategoryId { get; }

        public GetCategoryByIdQuery(int categoryId)
        {
            CategoryId = categoryId;
        }
    }
} 