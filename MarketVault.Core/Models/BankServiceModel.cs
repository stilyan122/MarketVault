namespace MarketVault.Core.Models
{
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Service model used for bank entity
    /// </summary>
    public class BankServiceModel
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
        /// Service model address id
        /// </summary>
        public int AddressId { get; set; }

        /// <summary>
        /// Service model address
        /// </summary>
        public Address Address { get; set; } = null!;
    }
}
