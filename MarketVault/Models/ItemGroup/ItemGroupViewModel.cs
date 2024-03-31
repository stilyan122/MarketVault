namespace MarketVault.Models.ItemGroup
{
    using MarketVault.Core.Contracts;

    /// <summary>
    /// Item group view model
    /// </summary>
    public class ItemGroupViewModel : IUrlDetailModel
    {
        /// <summary>
        /// Item group id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Item group name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Item group products count
        /// </summary>
        public int ProductsCount { get; set; }

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
