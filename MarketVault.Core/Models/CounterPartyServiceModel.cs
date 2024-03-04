namespace MarketVault.Core.Models
{
    using MarketVault.Infrastructure.Data.Models;

    /// <summary>
    /// Service model used for counter party entity
    /// </summary>
    public class CounterPartyServiceModel
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
        /// Service model VAT number
        /// </summary>
        public string VATNumber { get; set; } = string.Empty;

        /// <summary>
        /// Service model value added tax law id
        /// </summary>
        public string ValueAddedTaxLawId { get; set; } = string.Empty;

        /// <summary>
        /// Service model bank
        /// </summary>
        public Bank Bank { get; set; } = null!;


        /// <summary>
        /// Service model bank code
        /// </summary>
        public string BankCode { get; set; } = null!;

        /// <summary>
        /// Service model bank IBAN
        /// </summary>
        public string BankIBAN { get; set; } = null!;

        /// <summary>
        /// Service model firm
        /// </summary>
        public Firm Firm { get; set; } = null!;
    }
}
