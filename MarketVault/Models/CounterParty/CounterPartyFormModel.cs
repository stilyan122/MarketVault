namespace MarketVault.Models.CounterParty
{
    using MarketVault.Infrastructure.ValidationAttributes;
    using MarketVault.Models.Bank;
    using MarketVault.Models.Firm;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.CounterPartyConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;

    /// <summary>
    /// Counter party form model
    /// </summary>
    public class CounterPartyFormModel
    {
        /// <summary>
        /// Counter party name
        /// </summary>
        [Required(ErrorMessage = CounterPartyNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = CounterPartyNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Counter party VAT Number
        /// </summary>
        [Required(ErrorMessage = CounterPartyVATNumberRequiredExceptionMessage)]
        [EuropeanVatNumber]
        [StringLength(VATNumberMaxLength,
            MinimumLength = VATNumberMinLength,
            ErrorMessage = CounterPartyVATNumberLengthExceptionMessage)]
        public string VATNumber { get; set; } = string.Empty;

        /// <summary>
        /// Counter party Query Added Tax Law Id
        /// </summary>
        [Required(ErrorMessage = CounterPartyValueAddedTaxLawIdRequiredExceptionMessage)]
        [StringLength(ValueAddedTaxLawIdMaxLength,
            MinimumLength = ValueAddedTaxLawIdMinLength,
            ErrorMessage = CounterPartyValueAddedTaxLawIdLengthExceptionMessage)]
        public string ValueAddedTaxLawId { get; set; } = string.Empty;
        
        /// <summary>
        /// Counter party bank id
        /// </summary>
        [Required(ErrorMessage = CounterPartyBankRequiredExceptionMessage)]
        public int BankId { get; set; }

        /// <summary>
        /// Counter party banks
        /// </summary>
        public IEnumerable<BankViewModel> Banks { get; set; }
             = new List<BankViewModel>();

        /// <summary>
        /// Counter party bank code
        /// </summary>
        [Required(ErrorMessage = CounterPartyBankCodeRequiredExceptionMessage)]
        [StringLength(BankCodeMaxLength,
            MinimumLength = BankCodeMinLength,
            ErrorMessage = CounterPartyBankCodeLengthExceptionMessage)]
        public string BankCode { get; set; } = string.Empty;

        /// <summary>
        /// Counter party bank IBAN
        /// </summary>
        [Required(ErrorMessage = CounterPartyBankIBANRequiredExceptionMessage)]
        [StringLength(BankIBANMaxLength,
            MinimumLength = BankIBANMinLength,
            ErrorMessage = CounterPartyBankIBANLengthExceptionMessage)]
        public string BankIBAN { get; set; } = string.Empty;

        [Required(ErrorMessage = CounterPartyFirmRequiredExceptionMessage)]
        public int FirmId { get; set; }

        /// <summary>
        /// Counter party firms
        /// </summary>
        public IEnumerable<FirmViewModel> Firms { get; set; }
             = new List<FirmViewModel>();
    }
}
