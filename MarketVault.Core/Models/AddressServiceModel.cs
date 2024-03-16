namespace MarketVault.Core.Models
{
    /// <summary>
    /// Service model used for address entity
    /// </summary>
    public class AddressServiceModel
    {
        /// <summary>
        /// Service model id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Service model town name
        /// </summary>
        public string TownName { get; set; } = string.Empty;

        /// <summary>
        /// Service model street name
        /// </summary>
        public string StreetName { get; set; } = string.Empty;

        /// <summary>
        /// Service model street number
        /// </summary>
        public string StreetNumber { get; set; } = string.Empty;
    }
}
