namespace MarketVault.Models.Bank
{
    using MarketVault.Core.Contracts;
    using MarketVault.Models.Address;
    using System.ComponentModel.DataAnnotations;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.BankConstants;
    using static MarketVault.Infrastructure.Constants
        .DataConstants.ExceptionMessagesConstants;

    /// <summary>
    /// Bank form model
    /// </summary>
    public class BankFormModel : IUrlDetailModel
    {
        /// <summary>
        /// Bank name
        /// </summary>
        [Required(ErrorMessage = BankNameRequiredExceptionMessage)]
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage = BankNameLengthExceptionMessage)]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Bank address id
        /// </summary>
        [Required(ErrorMessage = BankAddressRequiredExceptionMessage)]
        public int AddressId { get; set; }

        /// <summary>
        /// Bank addresses
        /// </summary>
        public IEnumerable<AddressViewModel> Addresses { get; set; } =
            new List<AddressViewModel>();

        /// <summary>
        /// Model Information - for URL
        /// </summary>
        public string Information { get; set; } = string.Empty;
    }
}
