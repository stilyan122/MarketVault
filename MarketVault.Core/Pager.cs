namespace MarketVault.Core
{
    /// <summary>
    /// Pager help class in case of pagination
    /// </summary>
    public class Pager
    {
        /// <summary>
        /// Total items in the paginator
        /// </summary>
        public int TotalItems { get; private set; }

        /// <summary>
        /// Current page in the paginator
        /// </summary>
        public int CurrentPage { get; private set; }

        /// <summary>
        /// Page size in the paginator
        /// </summary>
        public int PageSize { get; private set; }

        /// <summary>
        /// Total pages in the paginator
        /// </summary>
        public int TotalPages { get; private set; }

        /// <summary>
        /// Start page of the paginator
        /// </summary>
        public int StartPage { get; private set; }

        /// <summary>
        /// End page of the paginator
        /// </summary>
        public int EndPage { get; private set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Pager()
        {
            
        }

        /// <summary>
        /// Constructor with parameters for evaluation of pagination
        /// </summary>
        /// <param name="totalItems">Total items in the paginator</param>
        /// <param name="page">Current page of the paginator</param>
        /// <param name="pageSize">Size of a page in the paginator (default - 15)</param>
        public Pager(int totalItems, int page, int pageSize = 15)
        {
            int totalPages = (int)Math.Ceiling((decimal)totalItems / (decimal)pageSize);

            int currentPage = page;

            int startPage = currentPage - 5;
            int endPage = currentPage + 4;

            if (startPage <= 0)
            {
                endPage -= startPage - 1;
                startPage = 1;
            }

            if (endPage > totalPages)
            {
                endPage = totalPages;
                if (endPage > 10)
                {
                    startPage = endPage - 9;
                }
            }

            this.TotalItems = totalItems;
            this.CurrentPage = currentPage;
            this.PageSize = pageSize;
            this.TotalPages = totalPages;
            this.StartPage = startPage;
            this.EndPage = endPage;
        }
    }
}
