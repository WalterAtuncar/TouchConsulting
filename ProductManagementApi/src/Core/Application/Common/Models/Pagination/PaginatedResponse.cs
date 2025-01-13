using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
