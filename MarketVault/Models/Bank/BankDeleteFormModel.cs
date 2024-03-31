namespace MarketVault.Models.Bank
{
    using MarketVault.Core.Contracts;

    /// <summary>
    /// Bank delete form model
    /// </summary>
    public class BankDeleteFormModel : IUrlDetailModel
    {
        /// <summary>
        /// Bank id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Bank name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Bank address
        /// </summary>
        public string Address { get; set; } = string.Empty;

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
