namespace MarketVault.Models.CounterParty
{
    /// <summary>
    /// Counter party view model
    /// </summary>
    public class CounterPartyViewModel
    {
        /// <summary>
        /// Counter party id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Counter party nam
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
        /// Counter party bank name
        /// </summary>
        public string BankName { get; set; } = string.Empty;

        /// <summary>
        /// Counter party bank code
        /// </summary>
        public string BankCode { get; set; } = null!;

        /// <summary>
        /// Counter party bank IBAN
        /// </summary>
        public string BankIBAN { get; set; } = null!;

        /// <summary>
        /// Counter party firm name
        /// </summary>
        public string FirmName { get; set; } = string.Empty;
    }
}
