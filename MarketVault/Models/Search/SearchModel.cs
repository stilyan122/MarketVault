namespace MarketVault.Models.Search
{
    public class SearchModel
    {
        public string Query { get; set; } = string.Empty;

        public string SortingType { get; set; } = string.Empty;

        public string ViewName { get; set; } = string.Empty;
    }
}
