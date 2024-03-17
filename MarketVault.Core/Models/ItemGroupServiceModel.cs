namespace MarketVault.Core.Models
{
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Service model used for item group entity
    /// </summary>
    public class ItemGroupServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Service model products
        /// </summary>
        public IEnumerable<ProductServiceModel> Products { get; set; }
            = new List<ProductServiceModel>();
    }
}
