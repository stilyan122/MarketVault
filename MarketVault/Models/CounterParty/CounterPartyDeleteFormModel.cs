namespace MarketVault.Models.CounterParty
{
    using MarketVault.Core.Contracts;

    /// <summary>
    /// Counter party delete form model
    /// </summary>
    public class CounterPartyDeleteFormModel : IUrlDetailModel
    {
        /// <summary>
        /// Counter party id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Counter party name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Counter party VAT number
        /// </summary>
        public string VATNumber { get; set; } = string.Empty;

        /// <summary>
        /// Counter party value added tax law id
        /// </summary>
        public string ValueAddedTaxLawId { get; set; } = string.Empty;

        /// <summary>
        /// Counter party bank code
        /// </summary>
        public string BankCode { get; set; } = null!;

        /// <summary>
        /// Counter party bank IBAN
        /// </summary>
        public string BankIBAN { get; set; } = null!;

        /// <summary>
        /// Couner party bank name
        /// </summary>
        public string BankName { get; set;} = string.Empty;

        /// <summary>
        /// Counter party bank address
        /// </summary>
        public string BankAddress { get; set; } = string.Empty;

        /// <summary>
        /// Counter party firm address
        /// </summary>
        public string FirmAddress { get; set; } = string.Empty;

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
