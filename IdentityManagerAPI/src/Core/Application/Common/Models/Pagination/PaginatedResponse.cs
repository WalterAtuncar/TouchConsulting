namespace Application.Common.Models.Pagination
{
    public class PaginatedResponse<T>
    {
        public IEnumerable<T> Items { get; }
        public PaginationMetadata Metadata { get; }

        public PaginatedResponse(IEnumerable<T> items, int currentPage, int pageSize, int totalRecords)
        {
            Items = items;
            Metadata = new PaginationMetadata(currentPage, pageSize, totalRecords);
        }
    }
} 